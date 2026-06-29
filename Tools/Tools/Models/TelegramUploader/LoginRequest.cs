namespace Tools.Models.TelegramUploader;

internal class LoginRequest
{
    public required string AppId { get; init; } = string.Empty;
    public required string AppHashCode { get; init; } = string.Empty;
    public required string PhoneNumber { get; init; } = string.Empty;
    public string VerificationCode { get; init; } = string.Empty;
}
