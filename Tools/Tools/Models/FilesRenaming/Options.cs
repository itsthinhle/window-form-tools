namespace Tools.Models.FilesRenaming;

internal class Options
{
    public bool ShouldKeepOriginalFileNameAndOnlyAppendFileDescription { get; init; } = false;
    public bool ShouldIncludeTimeStampInTheFileName { get; init; } = true;
    public string TimeStampStringFormat { get; init; } = string.Empty;
    public bool ShouldOrderFilesByName { get; init; } = false;
    public bool ShouldOrderFilesByLastModifiedDate { get; init; } = false;
    public bool ShouldOrderFilesByCreationDate { get; init; } = false;
    public bool ShouldNotOrderFiles { get; init; } = true;
}
