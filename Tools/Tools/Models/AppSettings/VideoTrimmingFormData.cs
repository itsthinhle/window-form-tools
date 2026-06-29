namespace Tools.Models.AppSettings;

internal class VideoTrimmingFormData
{
    // Input fields
    public string InputVideoPath { get; set; } = string.Empty;
    public string OutputVideoName { get; set; } = string.Empty;
    public string OutputFolderPath { get; set; } = string.Empty;
    public IReadOnlyList<string> TimeSegments { get; set; } = [];

    // Options
    public bool ShouldDeleteSourceVideoAfterTrimming { get; set; } = false;

}
