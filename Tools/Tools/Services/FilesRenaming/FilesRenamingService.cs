using System.Text;
using Tools.Models.FilesRenaming;

namespace Tools.Services.FilesRenaming;

internal class FilesRenamingService : IFilesRenamingService
{
    public async Task StartAsync(FilesRenamingRequestModel filesRenamingRequestModel, IProgress<string>? progress = null)
    {
        ValidateRequest(filesRenamingRequestModel);

        FileInfo[] files = GetFiles(filesRenamingRequestModel.InputFolderPath, filesRenamingRequestModel.Options);

        for (int index = 0; index < files.Length; index++)
        {
            progress?.Report($"Renaming file {files[index].Name} -> ");

            StringBuilder newFileName = new($"");

            // If the user wants to keep the source file name, that means all the file names are already unique
            if (filesRenamingRequestModel.Options.ShouldKeepOriginalFileNameAndOnlyAppendFileDescription)
            {
                string sourceFileName = Path.GetFileNameWithoutExtension(files[index].Name);
                newFileName.Append($"{sourceFileName}");
            }
            else
            {
                // Else, we must include the timestamp (optional) and index before adding the file description
                newFileName.Append($"{filesRenamingRequestModel.OutputFileName}");

                // Timestamp & index
                if (filesRenamingRequestModel.Options.ShouldIncludeTimeStampInTheFileName)
                {
                    newFileName.Append($"_{DateTime.Now.ToString(filesRenamingRequestModel.Options.TimeStampStringFormat)}_{index}");
                }
            }

            // File description
            if (!string.IsNullOrWhiteSpace(filesRenamingRequestModel.OutputFileDescription))
            {
                newFileName.Append($"_{filesRenamingRequestModel.OutputFileDescription}");
            }

            // File extension
            newFileName.Append($"{files[index].Extension}");

            string newFilePath = Path.Combine(filesRenamingRequestModel.InputFolderPath, newFileName.ToString());

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

    private static void ValidateRequest(FilesRenamingRequestModel filesRenamingRequestModel)
    {
        if (string.IsNullOrWhiteSpace(filesRenamingRequestModel.InputFolderPath) 
            || !Directory.Exists(filesRenamingRequestModel.InputFolderPath))
        {
            throw new DirectoryNotFoundException("Error! Invalid input folder path.");
        }

        if (string.IsNullOrWhiteSpace(filesRenamingRequestModel.OutputFileName)
            && filesRenamingRequestModel.Options.ShouldKeepOriginalFileNameAndOnlyAppendFileDescription == false)
        {
            throw new FileNotFoundException("Error! File name can't be empty.");
        }

        if (filesRenamingRequestModel.Options.ShouldIncludeTimeStampInTheFileName
            && string.IsNullOrWhiteSpace(filesRenamingRequestModel.Options.TimeStampStringFormat))
        {
            throw new FileNotFoundException("Error! Timestamp string format can't be empty");
        }
    }
}
