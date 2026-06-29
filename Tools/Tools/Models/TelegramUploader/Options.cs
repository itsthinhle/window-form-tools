namespace Tools.Models.TelegramUploader;

internal class Options
{
    public bool HasUserSpecifiedExtensions { get; init; } = false;
    public string? UserSpecifiedExtensions { get; init; } = string.Empty;
    public bool ShouldIncludeNestedFiles { get; init; } = false;
    public bool ShouldDeleteSourceFileAfterUploaded { get; init; } = true;
}
