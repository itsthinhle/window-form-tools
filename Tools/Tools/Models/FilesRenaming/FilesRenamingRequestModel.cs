namespace Tools.Models.FilesRenaming;

internal class FilesRenamingRequestModel
{
    public required string InputFolderPath { get; set; }

    public string OutputFileName { get; set; } = string.Empty;

    public string OutputFileDescription { get; set; } = string.Empty;

    public required Options Options { get; set; }
}
