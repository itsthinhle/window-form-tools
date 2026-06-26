using Tools.Models.FilesRenaming;

namespace Tools.Services.FilesRenaming;

internal interface IFilesRenamingService
{
    Task StartAsync(FilesRenamingRequestModel request, IProgress<string>? progress = null);
}
