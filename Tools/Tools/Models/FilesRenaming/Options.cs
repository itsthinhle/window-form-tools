namespace Tools.Models.FilesRenaming;

internal class Options
{
    public bool ShouldKeepOriginalFileNameAndOnlyAppendFileDescription { get; set; } = false;
    public bool ShouldIncludeTimeStampInTheFileName { get; set; } = true;
    public string TimeStampStringFormat { get; set; } = string.Empty;
    public bool ShouldOrderFilesByName { get; set; } = false;
    public bool ShouldOrderFilesByLastModifiedDate { get; set; } = false;
    public bool ShouldOrderFilesByCreationDate { get; set; } = false;
    public bool ShouldNotOrderFiles { get; set; } = true;
}
