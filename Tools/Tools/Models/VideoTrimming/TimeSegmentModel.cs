namespace Tools.Models.VideoTrimming;

internal class TimeSegmentModel
{
    public int FromSecond { get; set; }
    public int TotalTrimSeconds { get; set; }
    public string FileDescription { get; set; } = string.Empty;
}
