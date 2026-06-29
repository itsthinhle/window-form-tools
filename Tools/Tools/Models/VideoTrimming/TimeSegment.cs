namespace Tools.Models.VideoTrimming;

internal class TimeSegment
{
    public int FromSecond { get; set; }
    public int TotalTrimSeconds { get; set; }
    public string FileDescription { get; set; } = string.Empty;
}
