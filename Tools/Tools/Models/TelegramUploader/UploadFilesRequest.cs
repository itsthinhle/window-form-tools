namespace Tools.Models.TelegramUploader;

internal class UploadFilesRequest
{
    public required string InputFolderPath { get; init; } = string.Empty;
    public required TL.ChatBase Chat { get; init; }
    public required Options Options { get; init; }
}
