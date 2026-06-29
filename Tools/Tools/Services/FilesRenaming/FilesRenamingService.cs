using System.Text;
using Tools.Models.FilesRenaming;

namespace Tools.Services.FilesRenaming;

internal class FilesRenamingService : IFilesRenamingService
{
    public async Task StartAsync(Request request, IProgress<string>? progress = null)
    {
        ValidateRequest(request);

        FileInfo[] files = GetFiles(request.InputFolderPath, request.Options);

        for (int index = 0; index < files.Length; index++)
        {
            progress?.Report($"Renaming file {files[index].Name} -> ");

            StringBuilder newFileName = new($"");

            // If the user wants to keep the source file name, that means all the file names are already unique
            if (request.Options.ShouldKeepOriginalFileNameAndOnlyAppendFileDescription)
            {
                string sourceFileName = Path.GetFileNameWithoutExtension(files[index].Name);
                newFileName.Append($"{sourceFileName}");
            }
            else
            {
                // Else, we must include the timestamp (optional) and index before adding the file description
                newFileName.Append($"{request.OutputFileName}");

                // Timestamp & index
                if (request.Options.ShouldIncludeTimeStampInTheFileName)
                {
                    newFileName.Append($"_{DateTime.Now.ToString(request.Options.TimeStampStringFormat)}_{index}");
                }
            }

            // File description
            if (!string.IsNullOrWhiteSpace(request.OutputFileDescription))
            {
                newFileName.Append($"_{request.OutputFileDescription}");
            }

            // File extension
            newFileName.Append($"{files[index].Extension}");

            string newFilePath = Path.Combine(request.InputFolderPath, newFileName.ToString());

            // Rename the file
            File.Move(files[index].FullName, newFilePath);
            progress?.Report($"Done.{Environment.NewLine}");
        }

        progress?.Report($"All files have been renamed.{Environment.NewLine}");
    }

    private static FileInfo[] GetFiles(string inputFolderPath, Options options)
    {
        var files = new DirectoryInfo(inputFolderPath).GetFiles();

        return options.ShouldOrderFilesByName
            ? [.. files.OrderBy(f => f.Name)]
            : options.ShouldOrderFilesByLastModifiedDate
            ? [.. files.OrderBy(f => f.LastWriteTime)]
            : options.ShouldOrderFilesByCreationDate 
            ? [.. files.OrderBy(f => f.CreationTime)] 
            : files ?? [];
    }

    private static void ValidateRequest(Request request)
    {
        if (string.IsNullOrWhiteSpace(request.InputFolderPath) 
            || !Directory.Exists(request.InputFolderPath))
        {
            throw new DirectoryNotFoundException("Error! Invalid input folder path.");
        }

        if (string.IsNullOrWhiteSpace(request.OutputFileName)
            && request.Options.ShouldKeepOriginalFileNameAndOnlyAppendFileDescription == false)
        {
            throw new FileNotFoundException("Error! File name can't be empty.");
        }

        if (request.Options.ShouldIncludeTimeStampInTheFileName
            && string.IsNullOrWhiteSpace(request.Options.TimeStampStringFormat))
        {
            throw new InvalidDataException("Error! Timestamp string format can't be empty");
        }
    }
}
