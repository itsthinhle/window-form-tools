namespace Tools.Models.FilesRenaming;

internal class Request
{
    public required string InputFolderPath { get; init; }
    public string OutputFileName { get; init; } = string.Empty;
    public string OutputFileDescription { get; init; } = string.Empty;
    public required Options Options { get; init; }
}
