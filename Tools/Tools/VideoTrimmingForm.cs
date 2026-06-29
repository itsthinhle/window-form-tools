using System.Diagnostics;
using Tools.Constants;
using Tools.Extensions;
using Tools.Models.VideoTrimming;
using Tools.Services;
using Tools.Services.VideoTrimming;
using Tools.Utilities;

namespace Tools;

internal partial class VideoTrimmingForm : Form, IForm
{
    private readonly IVideoTrimmingService _videoTrimmingService;
    private readonly IAppSettingsService _appSettingsService;
    private readonly IProgress<string> _loggingProgress;

    public VideoTrimmingForm(IVideoTrimmingService videoTrimmingService, IAppSettingsService appSettingsService)
    {
        InitializeComponent();
        _videoTrimmingService = videoTrimmingService;
        _appSettingsService = appSettingsService;
        _loggingProgress = new Progress<string>(AppendLog);
    }

    private void VideoTrimmingForm_Load(object sender, EventArgs e)
    {
        LoadFormSettings();
    }

    private void TextBoxVideoPath_TextChanged(object sender, EventArgs e)
    {
        string trimmedPath = _textBoxVideoPath.Text.Trim();

        // Check if the path is a folder.
        if (Directory.Exists(trimmedPath))
        {
            // Set Output folder path the same as the folder path
            _textBoxOutputFolderPath.SetTextIfEmpty(trimmedPath);

            // Find the first video in the folder has its name contains the parent folder name,
            // set it as the video path, and set the parent folder name as the output video name.
            string folderName = new DirectoryInfo(trimmedPath).Name;

            var pathOfMatchingVideoName = Directory.GetFiles(trimmedPath)
                .FirstOrDefault(filePath => Path.GetFileName(filePath)
                    .Contains(folderName, StringComparison.OrdinalIgnoreCase));

            if (pathOfMatchingVideoName != null)
            {
                _textBoxVideoPath.Text = pathOfMatchingVideoName;
                _textBoxOutputVideoName.SetTextIfEmpty(folderName);
            }

            // If no video name matching with the folder name, try to get the first video in the folder
            // and let the user decide the output video name.
            else
            {
                var firstVideoPath = Directory.GetFiles(trimmedPath)
                    .FirstOrDefault(filePath => FileExtensionConstants.VIDEO_FILE_EXTENSIONS
                        .Any(fileExtension => string.Equals(
                            fileExtension,
                            Path.GetExtension(filePath),
                            StringComparison.OrdinalIgnoreCase)));

                if (firstVideoPath != null)
                {
                    _textBoxVideoPath.Text = firstVideoPath;
                }
            }
        }
        // If not, the video path is inputted and we will need to set its parent folder name
        // as the output video name.
        else if (File.Exists(trimmedPath))
        {
            // Get the parent folder name and set as the output folder path
            _textBoxOutputFolderPath.SetTextIfEmpty(Path.GetDirectoryName(trimmedPath));

            string parentFolderName = new FileInfo(trimmedPath).Directory?.Name ?? "";
            _textBoxOutputVideoName.SetTextIfEmpty(parentFolderName);
        }
    }

    private void ButtonBrowseVideo_Click(object sender, EventArgs e)
    {
        _textBoxVideoPath.Text = FileUtility.Browse(
            OpenFileDialogUtility.BuildFilterForOpenFileDialog(
                "Videos", FileExtensionConstants.VIDEO_FILE_EXTENSIONS));
    }

    private void ButtonClearTimeRanges_Click(object sender, EventArgs e)
    {
        _richTextBoxTimeSegments.Text = string.Empty;
    }

    private async void ButtonStart_Click(object sender, EventArgs e)
    {
        var request = new Request
        {
            InputVideoPath = _textBoxVideoPath.Text.Trim(),
            OutputVideoName = _textBoxOutputVideoName.Text.Trim(),
            OutputFolderPath = _textBoxOutputFolderPath.Text.Trim(),
            TimeSegments = _richTextBoxTimeSegments.Lines,
            Options = new()
            {
                ShouldDeleteSourceVideoAfterTrimming = _checkBoxShouldDeleteSourceVideoAfterTrimming.Checked
            }
        };

        try
        {
            await _videoTrimmingService.StartAsync(request, _loggingProgress);
        }
        catch (Exception exception)
        {
            _loggingProgress.Report($"{exception.Message}{Environment.NewLine}");
        }
    }

    private void ButtonBrowseOutputFolder_Click(object sender, EventArgs e)
    {
        _textBoxOutputFolderPath.Text = FolderUtility.Browse();
    }

    private void ButtonGoToOutputFolder_Click(object sender, EventArgs e)
    {
        var outputFolderPath = _textBoxOutputFolderPath.Text.Trim();

        if (string.IsNullOrWhiteSpace(outputFolderPath) || !Directory.Exists(outputFolderPath))
        {
            MessageBox.Show(
                "Please enter a valid output folder.",
                "Field required",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            return;
        }

        Process.Start(new ProcessStartInfo
        {
            FileName = outputFolderPath,
            UseShellExecute = true
        });
    }

    public void LoadFormSettings()
    {
        _textBoxVideoPath.Text = _appSettingsService.AppSettings.VideoTrimmingFormData.InputVideoPath;
        _textBoxOutputVideoName.Text = _appSettingsService.AppSettings.VideoTrimmingFormData.OutputVideoName;
        _textBoxOutputFolderPath.Text = _appSettingsService.AppSettings.VideoTrimmingFormData.OutputFolderPath;
        _richTextBoxTimeSegments.Lines = [.. _appSettingsService.AppSettings.VideoTrimmingFormData.TimeSegments];
        _checkBoxShouldDeleteSourceVideoAfterTrimming.Checked = _appSettingsService.AppSettings.VideoTrimmingFormData
            .ShouldDeleteSourceVideoAfterTrimming;
    }

    private void ButtonSaveFormData_Click(object sender, EventArgs e)
    {
        _appSettingsService.AppSettings.VideoTrimmingFormData.InputVideoPath = _textBoxVideoPath.Text;
        _appSettingsService.AppSettings.VideoTrimmingFormData.OutputVideoName = _textBoxOutputVideoName.Text;
        _appSettingsService.AppSettings.VideoTrimmingFormData.OutputFolderPath = _textBoxOutputFolderPath.Text;
        _appSettingsService.AppSettings.VideoTrimmingFormData.TimeSegments = _richTextBoxTimeSegments.Lines;
        _appSettingsService.AppSettings.VideoTrimmingFormData.ShouldDeleteSourceVideoAfterTrimming = _checkBoxShouldDeleteSourceVideoAfterTrimming.Checked;

        _appSettingsService.Save();
    }

    private void AppendLog(string message)
    {
        _richTextBoxLogs.AppendText($"{message}");
        _richTextBoxLogs.ScrollToCaret();
    }
}
