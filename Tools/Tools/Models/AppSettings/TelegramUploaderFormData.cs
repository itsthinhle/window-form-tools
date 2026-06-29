namespace Tools.Models.AppSettings;

internal class TelegramUploaderFormData
{
    // Login fields
    public string AppId { get; set; } = string.Empty;
    public string AppHashCode { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;

    // Input fields
    public string InputFolderPath { get; set; } = string.Empty;

    // Options
    public bool HasUserSpecifiedExtensions { get; set; } = false;
    public string? UserSpecifiedExtensions { get; set; } = string.Empty;
    public bool ShouldIncludeNestedFiles { get; set; } = false;
    public bool ShouldDeleteSourceFileAfterUploaded { get; set; } = true;

}
