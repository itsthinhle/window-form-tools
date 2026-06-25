namespace Tools.Models.VideoTrimming;

internal class VideoTrimmingRequestModel
{
    public required string InputVideoPath { get; set; }

    public string OutputVideoName { get; set; } = string.Empty;

    public required string OutputFolderPath { get; set; }

    public required IReadOnlyList<string> TimeSegments { get; set; }

    public required Settings Settings { get; set; }
}
