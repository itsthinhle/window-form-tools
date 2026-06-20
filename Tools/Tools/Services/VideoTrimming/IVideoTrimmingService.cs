using Tools.Models.VideoTrimming;

namespace Tools.Services.VideoTrimming;

internal interface IVideoTrimmingService
{
    Task StartAsync(VideoTrimmingRequestModel request, IProgress<string>? progress = null);
}
