using Tools.Models.FilesRenaming;

namespace Tools.Models.AppSettings;

internal class FilesRenamingFormData
{
    public string InputFolderPath { get; set; } = string.Empty;

    public string OutputFileName { get; set; } = string.Empty;

    public string OutputFileDescription { get; set; } = string.Empty;

    public Options Options { get; set; } = new();
}
