namespace Tools.Models.AppSettings;

internal class AppSettings
{
    public VideoTrimmingFormData VideoTrimmingFormData { get; set; } = new();
    public FilesRenamingFormData FilesRenamingFormData { get; set; } = new();
}
