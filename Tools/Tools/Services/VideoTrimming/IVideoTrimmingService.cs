using Tools.Models.VideoTrimming;

namespace Tools.Services.VideoTrimming;

internal interface IVideoTrimmingService
{
    Task StartAsync(Request request, IProgress<string>? progress = null);
}
