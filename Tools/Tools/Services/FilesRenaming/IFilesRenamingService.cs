using Tools.Models.FilesRenaming;

namespace Tools.Services.FilesRenaming;

internal interface IFilesRenamingService
{
    Task StartAsync(Request request, IProgress<string>? progress = null);
}
