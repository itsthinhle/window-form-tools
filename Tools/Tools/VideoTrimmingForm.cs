using System.Diagnostics;
using Tools.Constants;
using Tools.Extensions;
using Tools.Models.VideoTrimming;
using Tools.Services.VideoTrimming;
using Tools.Utilities;

namespace Tools;

internal partial class VideoTrimmingForm : Form
{
    private readonly IVideoTrimmingService _videoTrimmingService;

    public VideoTrimmingForm(IVideoTrimmingService videoTrimmingService)
    {
        InitializeComponent();
        _videoTrimmingService = videoTrimmingService;
    }

    private void TextBoxVideoPath_TextChanged(object sender, EventArgs e)
    {
        string trimmedPath = _textBoxVideoPath.Text.Trim();

        // Check if the path is a folder.
        if (Directory.Exists(trimmedPath))
        {
            // Set Output folder path the same as the folder path
            _textBoxOutputFolderPath.SetTextWhenEmpty(trimmedPath);

            // Find the first video in the folder has its name contains the parent folder name,
            // set it as the video path, and set the parent folder name as the output video name.
            string folderName = new DirectoryInfo(trimmedPath).Name;

            var pathOfMatchingVideoName = Directory.GetFiles(trimmedPath)
                .FirstOrDefault(filePath => Path.GetFileName(filePath)
                    .Contains(folderName, StringComparison.OrdinalIgnoreCase));

            if (pathOfMatchingVideoName != null)
            {
                _textBoxVideoPath.Text = pathOfMatchingVideoName;
                _textBoxOutputVideoName.SetTextWhenEmpty(folderName);
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
            _textBoxOutputFolderPath.SetTextWhenEmpty(Path.GetDirectoryName(trimmedPath));

            string parentFolderName = new FileInfo(trimmedPath).Directory?.Name ?? "";
            _textBoxOutputVideoName.SetTextWhenEmpty(parentFolderName);
        }
    }

    private void ButtonBrowseVideo_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new()
        {
            Title = "Browse video",
            Filter = OpenFileDialogUtility.BuildFilterForOpenFileDialog(
                "Videos",
                FileExtensionConstants.VIDEO_FILE_EXTENSIONS)
        };

        DialogResult dialogResult = openFileDialog.ShowDialog();

        if (dialogResult == DialogResult.OK)
        {
            _textBoxVideoPath.Text = openFileDialog.FileName;
        }
    }

    private void ButtonClearTimeRanges_Click(object sender, EventArgs e)
    {
        _richTextBoxTimeSegments.Text = string.Empty;
    }

    private async void ButtonStart_Click(object sender, EventArgs e)
    {
        var request = new VideoTrimmingRequestModel
        {
            InputVideoPath = _textBoxVideoPath.Text.Trim(),
            OutputVideoName = _textBoxOutputVideoName.Text.Trim(),
            OutputFolderPath = _textBoxOutputFolderPath.Text.Trim(),
            TimeSegments = _richTextBoxTimeSegments.Lines,
            Settings = new()
            {
                ShouldDeleteSourceVideoAfterTrimming = _checkBoxShouldDeleteSourceVideoAfterTrimming.Checked
            }
        };

        var progress = new Progress<string>(AppendLog);

        await _videoTrimmingService.StartAsync(request, progress);

        try
        {
        }
        catch (Exception exception)
        {
            AppendLog($"{exception.Message}{Environment.NewLine}");
        }
    }

    private void ButtonBrowseOutputFolder_Click(object sender, EventArgs e)
    {
        FolderBrowserDialog folderBrowserDialog = new();
        DialogResult dialogResult = new FolderBrowserDialog().ShowDialog();

        if (dialogResult == DialogResult.OK)
        {
            _textBoxOutputFolderPath.Text = folderBrowserDialog.SelectedPath;
        }
    }

    private void ButtonOpenOutputFolder_Click(object sender, EventArgs e)
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

    private void AppendLog(string message)
    {
        _richTextBoxLogs.AppendText($"{message}");
        _richTextBoxLogs.ScrollToCaret();
    }
}
