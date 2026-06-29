using TL;
using Tools.Models.TelegramUploader;

namespace Tools.Services.TelegramUploader;

internal interface ITelegramService
{
    Task<LoginStatus> Login(LoginRequest loginInfo, IProgress<string>? progress = null);
    Task Logout(LoginRequest loginRequest, IProgress<string>? progress = null);
    Task<Messages_Chats?> GetChats(IProgress<string>? progress = null);
    Task UploadFiles(UploadFilesRequest uploadFilesRequest, IProgress<string>? progress = null);
}
