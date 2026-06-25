namespace Tools.Models.Settings;

internal class VideoTrimmingFormSettings
{
    public string InputVideoPath { get; set; } = string.Empty;

    public string OutputVideoName { get; set; } = string.Empty;

    public string OutputFolderPath { get; set; } = string.Empty;

    public IReadOnlyList<string> TimeSegments { get; set; } = [];

    public VideoTrimming.Settings Settings { get; set; } = new();

}
