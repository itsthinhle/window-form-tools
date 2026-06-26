using Tools.Models.VideoTrimming;

namespace Tools.Models.AppSettings;

internal class VideoTrimmingFormData
{
    public string InputVideoPath { get; set; } = string.Empty;

    public string OutputVideoName { get; set; } = string.Empty;

    public string OutputFolderPath { get; set; } = string.Empty;

    public IReadOnlyList<string> TimeSegments { get; set; } = [];

    public Options Options { get; set; } = new();

}
