using Microsoft.VisualBasic.FileIO;
using System.Diagnostics;
using System.Text;
using Tools.Constants;
using Tools.Extensions;
using Tools.Models.VideoTrimming;

namespace Tools.Services.VideoTrimming;

internal class VideoTrimmingService : IVideoTrimmingService
{
    public async Task StartAsync(
        Request videoTrimmingRequestModel, 
        IProgress<string>? progress = null)
    {
        await TrimVideoByTimeSegments(videoTrimmingRequestModel, progress);
        await ApplySelectedOptions(videoTrimmingRequestModel, progress);
    }

    private static async Task TrimVideoByTimeSegments(Request videoTrimmingRequestModel, IProgress<string>? progress)
    {
        ValidateRequest(videoTrimmingRequestModel);

        for (var index = 0; index < videoTrimmingRequestModel.TimeSegments.Count; index++)
        {
            var timeSegmentText = videoTrimmingRequestModel.TimeSegments[index].Trim();

            // Empty lines are ignored
            if (string.IsNullOrEmpty(timeSegmentText))
            {
                continue;
            }

            progress?.Report($"Trimming time segment {timeSegmentText} -> ");

            var timeSegmentModel = CreateTimeSegmentModel(timeSegmentText);
            string ffmpegCommand = CreateFFmpegCommand(videoTrimmingRequestModel, index, timeSegmentModel);
            await RunFFmpegCommandAsync(ffmpegCommand);

            progress?.Report($"Done.{Environment.NewLine}");
        }

        progress?.Report($"All time segments have been trimmed.{Environment.NewLine}");
    }

    private static async Task ApplySelectedOptions(Request videoTrimmingRequestModel, IProgress<string>? progress)
    {
        if (videoTrimmingRequestModel.Options.ShouldDeleteSourceVideoAfterTrimming)
        {
            DeleteInputVideoFile(videoTrimmingRequestModel.InputVideoPath, progress);
        }
    }

    private static void ValidateRequest(Request request)
    {
        if (string.IsNullOrWhiteSpace(request.InputVideoPath) || !File.Exists(request.InputVideoPath))
        {
            throw new FileNotFoundException("Error! Invalid input video file path.");
        }

        if (string.IsNullOrWhiteSpace(request.OutputFolderPath) || !Directory.Exists(request.OutputFolderPath))
        {
            throw new DirectoryNotFoundException("Error! Invalid output folder path.");
        }
    }

    private static TimeSegment CreateTimeSegmentModel(string timeSegmentText)
    {
        var timeSegmentComponents = timeSegmentText.Split('/');

        var timeSegmentModel = new TimeSegment
        {
            FromSecond = CalculateTotalSeconds(timeSegmentComponents[0])
        };

        timeSegmentModel.TotalTrimSeconds = CalculateTotalSeconds(timeSegmentComponents[1]) - timeSegmentModel.FromSecond;
        timeSegmentModel.FileDescription = timeSegmentComponents.Length > 2
            ? timeSegmentComponents[2]
            : "";

        return timeSegmentModel;
    }

    private static int CalculateTotalSeconds(string timeText)
    {
        var hoursStringBuilder = new StringBuilder();
        var minutesStringBuilder = new StringBuilder();
        var secondsStringBuilder = new StringBuilder();
        var lastIndex = timeText.Length - 1;

        for (var index = lastIndex; index >= 0; index--)
        {
            if (index >= lastIndex - 1)
            {
                secondsStringBuilder.Insert(0, timeText[index]);
            }

            if (lastIndex - 3 <= index && index < lastIndex - 1)
            {
                minutesStringBuilder.Insert(0, timeText[index]);
            }

            if (index < lastIndex - 3)
            {
                hoursStringBuilder.Insert(0, timeText[index]);
            }
        }

        int hours = hoursStringBuilder.ToString().ToInt32();
        int minutes = minutesStringBuilder.ToString().ToInt32();
        int seconds = secondsStringBuilder.ToString().ToInt32();

        return minutes >= 60 || seconds >= 60
            ? throw new FormatException($"Error! Time value '{timeText}' has invalid minutes or seconds.")
            : Convert.ToInt32(new TimeSpan(hours, minutes, seconds).TotalSeconds);
    }

    private static string CreateFFmpegCommand(Request videoTrimmingRequestModel, int index, TimeSegment timeSegmentModel)
    {
        var outputFileName = $"{videoTrimmingRequestModel.OutputVideoName}_{index}";

        if (!string.IsNullOrEmpty(timeSegmentModel.FileDescription))
        {
            outputFileName += $"_{timeSegmentModel.FileDescription}";
        }

        var outputFileExtension = Path.GetExtension(videoTrimmingRequestModel.InputVideoPath);

        string outputVideoPath = videoTrimmingRequestModel.OutputFolderPath +
            $@"\{outputFileName}{outputFileExtension}";

        return $"ffmpeg" +
            $" -ss {timeSegmentModel.FromSecond}" +
            $" -i \"{videoTrimmingRequestModel.InputVideoPath}\"" +
            $" -to {timeSegmentModel.TotalTrimSeconds}" +
            $" -c copy" +
            $" \"{outputVideoPath}\"";
    }

    private static async Task RunFFmpegCommandAsync(string ffmpegCommand)
    {
        var processStartInfo = new ProcessStartInfo
        {
            FileName = ProcessFileNameConstants.CMD,
            RedirectStandardInput = true,
            RedirectStandardOutput = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };

        var process = new Process { StartInfo = processStartInfo };

        if (!process.Start())
        {
            throw new InvalidOperationException("Error! Failed to start the process. Make sure ffmpeg is installed and available on PATH.");
        }

        using (var streamWriter = process.StandardInput)
        {
            if (streamWriter.BaseStream.CanWrite)
            {
                streamWriter.WriteLine(ffmpegCommand);
            }
        }

        await process.WaitForExitAsync();

        if (process.ExitCode != 0)
        {
            throw new InvalidOperationException($"Error! Can't execute the ffmpeg command. Process exited with code {process.ExitCode}.");
        }

        process.Close();
    }

    private static void DeleteInputVideoFile(string inputFilePath, IProgress<string>? progress)
    {
        try
        {
            FileSystem.DeleteFile(
                inputFilePath,
                UIOption.OnlyErrorDialogs,
                RecycleOption.SendToRecycleBin);

            progress?.Report($"Deleted the source video {Path.GetFileName(inputFilePath)}.");
        }
        catch (Exception exception)
        {
            progress?.Report($"Error! Can't delete source video. {exception.Message}");
        }
    }
}
