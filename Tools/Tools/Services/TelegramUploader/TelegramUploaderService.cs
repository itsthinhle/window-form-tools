using Microsoft.VisualBasic.FileIO;
using System.Text.RegularExpressions;
using TL;
using Tools.Models.TelegramUploader;

namespace Tools.Services.TelegramUploader;

internal class TelegramUploaderService : ITelegramService
{
    // Ref: https://github.com/wiz0u/WTelegramClient
    private WTelegram.Client? _wTelegramClient;

    private void ConnectToClient(LoginRequest loginRequest, IProgress<string>? progress = null)
    {
        if (_wTelegramClient == null)
        {
            progress?.Report($"Connecting to Telegram client...{Environment.NewLine}");

            try
            {
                _wTelegramClient = new WTelegram.Client(int.Parse(loginRequest.AppId), loginRequest.AppHashCode);
                progress?.Report($"Connected to Telegram client.{Environment.NewLine}");
            }
            catch
            {
                throw new InvalidDataException($"Failed to connect to Telegram client! Invalid app ID or app hash code.");
            }
        }
    }

    public async Task<LoginStatus> Login(LoginRequest loginRequest, IProgress<string>? progress = null)
    {
        ValidateLoginRequest(loginRequest);
        ConnectToClient(loginRequest, progress);

        progress?.Report(string.IsNullOrEmpty(loginRequest.VerificationCode)
            ? $"Logging in...{Environment.NewLine}"
            : $"Verifying...{Environment.NewLine}");

        if (_wTelegramClient!.User != null)
        {
            progress?.Report($"You are logged in as {_wTelegramClient!.User.first_name}.{Environment.NewLine}");
            return LoginStatus.LoggedIn;
        }
        else
        {
            // Possible return values from the Login function:
            // verification_code, name (signup), password (2FA), email; email_verification_code (email registration)

            string? additionalInfoRequired = string.IsNullOrWhiteSpace(loginRequest.VerificationCode)
                ? await _wTelegramClient!.Login(loginRequest.PhoneNumber)
                : await _wTelegramClient!.Login(loginRequest.VerificationCode);

            if (additionalInfoRequired != null)
            {
                if (additionalInfoRequired == "verification_code")
                {
                    progress?.Report($"Verification code is required to continue.{Environment.NewLine}");
                    return LoginStatus.VerificationCodeRequired;
                }
            }
            else
            {
                progress?.Report($"You are logged in as {_wTelegramClient!.User!.first_name}.{Environment.NewLine}");
                return LoginStatus.LoggedIn;
            }
        }

        return LoginStatus.LoggedIn;
    }

    public async Task Logout(LoginRequest loginRequest, IProgress<string>? progress = null)
    {
        ConnectToClient(loginRequest, progress);
        await _wTelegramClient.Auth_LogOut();
        progress?.Report($"You have been logged out.{Environment.NewLine}");
    }

    public async Task<Messages_Chats?> GetChats(IProgress<string>? progress)
    {
        if (_wTelegramClient == null)
        {
            progress?.Report("Please log in first.\n");
            return null;
        }

        progress?.Report($"Getting all chats...");
        var chats = await _wTelegramClient.Messages_GetAllChats();
        progress?.Report($"Done.{Environment.NewLine}");

        return chats;
    }

    public async Task UploadFiles(UploadFilesRequest uploadFilesRequest, IProgress<string>? progress = null)
    {
        if (_wTelegramClient == null)
        {
            progress?.Report($"Please log in first.{Environment.NewLine}");
            return;
        }

        ValidateUploadRequest(uploadFilesRequest);

        var filePaths = GetFilesForUpload(uploadFilesRequest);

        foreach (string filePath in filePaths)
        {
            progress?.Report($"Uploading file: {Path.GetFileName(filePath)} -> ");

            // Two steps: first upload the file to Telegram servers, then send it to the chat
            var inputFile = await _wTelegramClient.UploadFileAsync(filePath);

            await _wTelegramClient.SendMediaAsync(
                uploadFilesRequest.Chat,
                caption: Path.GetFileNameWithoutExtension(filePath),
                inputFile
            );

            progress?.Report($"Done.{Environment.NewLine}");

            // Delete the source file after successful upload
            if (uploadFilesRequest.Options.ShouldDeleteSourceFileAfterUploaded)
            {
                DeleteSourceFileAfterUploaded(filePath, progress);
            }
        }

        progress?.Report($"All files have been uploaded.{Environment.NewLine}");
    }

    private static string[] GetFilesForUpload(UploadFilesRequest uploadFilesRequest)
    {
        // If the user wants to include the nested files in the subfolders
        string[] filePaths = [];

        var searchFilesOption = uploadFilesRequest.Options.ShouldIncludeNestedFiles 
            ? System.IO.SearchOption.AllDirectories 
            : System.IO.SearchOption.TopDirectoryOnly;

        filePaths = Directory.GetFiles(uploadFilesRequest.InputFolderPath, "*.*", searchFilesOption);

        // If having user specified file extensions, filter the files according to the user specified extensions
        if (uploadFilesRequest.Options.HasUserSpecifiedExtensions)
        {
            var userSpecifiedExtensions = uploadFilesRequest.Options.UserSpecifiedExtensions!
                .Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

            filePaths = [.. filePaths
                .Where(filePath => userSpecifiedExtensions
                    .Contains(Path.GetExtension(filePath), StringComparer.OrdinalIgnoreCase))];
        }

        return filePaths;
    }

    private static void DeleteSourceFileAfterUploaded(string inputFilePath, IProgress<string>? progress)
    {
        try
        {
            FileSystem.DeleteFile(
                inputFilePath,
                UIOption.OnlyErrorDialogs,
                RecycleOption.SendToRecycleBin);

            progress?.Report($"The source file {Path.GetFileName(inputFilePath)} has been deleted.{Environment.NewLine}");
        }
        catch (Exception exception)
        {
            progress?.Report($"Error! Can't delete the source file {Path.GetFileName(inputFilePath)}. {exception.Message}{Environment.NewLine}");
        }
    }

    private static void ValidateLoginRequest(LoginRequest loginRequest)
    {
        if (string.IsNullOrWhiteSpace(loginRequest.AppId))
        {
            throw new InvalidOperationException("Error! App ID can't be empty.");
        }

        if (string.IsNullOrWhiteSpace(loginRequest.AppHashCode))
        {
            throw new InvalidOperationException("Error! App hash code can't be empty.");
        }

        if (string.IsNullOrWhiteSpace(loginRequest.PhoneNumber))
        {
            throw new InvalidOperationException("Error! Phone number can't be empty.");
        }
    }

    private static void ValidateUploadRequest(UploadFilesRequest uploadFilesRequest)
    {
        if (string.IsNullOrWhiteSpace(uploadFilesRequest.InputFolderPath)
            || !Directory.Exists(uploadFilesRequest.InputFolderPath))
        {
            throw new DirectoryNotFoundException("Error! Invalid input folder path.");
        }

        if (uploadFilesRequest.Chat == null)
        {
            throw new KeyNotFoundException("Error! Invalid chat selected.");
        }

        if (uploadFilesRequest.Options.HasUserSpecifiedExtensions)
        {
            if (string.IsNullOrWhiteSpace(uploadFilesRequest.Options.UserSpecifiedExtensions))
            {
                throw new InvalidOperationException("Error! Please provide your specified file extensions.");
            }
            else
            {
                // Regex:
                //  - Matches a string that starts with a dot followed by one or more alphanumeric characters,
                //  - Can be followed by zero or more occurrences of a comma, optional whitespace,
                //    and another dot followed by one or more alphanumeric characters.
                if (!Regex.IsMatch(uploadFilesRequest.Options.UserSpecifiedExtensions.Trim(), @"^\.[A-Za-z0-9]+(?:,\s*\.[A-Za-z0-9]+)*$"))
                {
                    throw new FormatException("Error! Your specified file extensions are not in a valid format.");
                }
            }
        }
    }
}
