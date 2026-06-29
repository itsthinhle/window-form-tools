namespace Tools.Models.VideoTrimming;

internal class Request
{
    public required string InputVideoPath { get; init; }
    public string OutputVideoName { get; init; } = string.Empty;
    public required string OutputFolderPath { get; init; }
    public required IReadOnlyList<string> TimeSegments { get; init; }
    public required Options Options { get; init; }
}
