using Tools.Models.FilesRenaming;
using Tools.Services;
using Tools.Services.FilesRenaming;
using Tools.Utilities;

namespace Tools;

internal partial class FilesRenamingForm : Form, IForm
{
    private readonly IFilesRenamingService _filesRenamingService;
    private readonly IAppSettingsService _appSettingsService;
    private readonly IProgress<string> _loggingProgress;

    public FilesRenamingForm(IFilesRenamingService filesRenamingService, IAppSettingsService appSettingsService)
    {
        InitializeComponent();
        _filesRenamingService = filesRenamingService;
        _appSettingsService = appSettingsService;
        _loggingProgress = new Progress<string>(AppendLog);
    }

    private void FilesRenamingForm_Load(object sender, EventArgs e)
    {
        LoadFormSettings();
    }

    private void ButtonBrowseFolder_Click(object sender, EventArgs e)
    {
        _textBoxFolderPath.Text = FolderUtility.Browse();
    }

    private async void ButtonStart_Click(object sender, EventArgs e)
    {
        var request = new Request
        {
            InputFolderPath = _textBoxFolderPath.Text.Trim(),
            OutputFileName = _textBoxOutputFileName.Text.Trim(),
            OutputFileDescription = _textBoxOutputFileDescription.Text.Trim(),
            Options = new()
            {
                ShouldKeepOriginalFileNameAndOnlyAppendFileDescription = _checkBoxShouldKeepOriginalFileNameAndOnlyAppendFileDescription.Checked,
                ShouldIncludeTimeStampInTheFileName = _checkBoxShouldIncludeTimeStampInTheFileName.Checked,
                TimeStampStringFormat = _textBoxTimeStampStringFormat.Text,
                ShouldOrderFilesByName = _radioButtonShouldOrderFilesByName.Checked,
                ShouldOrderFilesByLastModifiedDate = _radioButtonShouldOrderFilesByLastModifiedDate.Checked,
                ShouldOrderFilesByCreationDate = _radioButtonShouldOrderFilesByCreationDate.Checked,
                ShouldNotOrderFiles = _radioButtonShouldNotOrderFiles.Checked
            }
        };

        try
        {
            await _filesRenamingService.StartAsync(request, _loggingProgress);
        }
        catch (Exception exception)
        {
            _loggingProgress.Report($"{exception.Message}{Environment.NewLine}");
        }
    }

    private void CheckBoxShouldKeepOriginalFileNameAndAppendFileDescription_CheckedChanged(object sender, EventArgs e)
    {
        if (_checkBoxShouldKeepOriginalFileNameAndOnlyAppendFileDescription.Checked)
        {
            _textBoxOutputFileName.Text = "";
            _textBoxOutputFileName.Enabled = false;
            _labelOutputFileName.Text = _labelOutputFileName.Text[..^2];
        }
        else
        {
            _textBoxOutputFileName.Enabled = true;
            _labelOutputFileName.Text += " *";
        }
    }

    private void CheckBoxShouldIncludeTimeStampInTheFileName_CheckedChanged(object sender, EventArgs e)
    {
        if (_checkBoxShouldIncludeTimeStampInTheFileName.Checked)
        {
            _labelTimeStampStringFormat.Enabled = true;
            _textBoxTimeStampStringFormat.Enabled = true;
        }
        else
        {
            _labelTimeStampStringFormat.Enabled = false;
            _textBoxTimeStampStringFormat.Enabled = false;
        }
    }

    public void LoadFormSettings()
    {
        _textBoxFolderPath.Text = _appSettingsService.AppSettings.FilesRenamingFormData.InputFolderPath;
        _textBoxOutputFileName.Text = _appSettingsService.AppSettings.FilesRenamingFormData.OutputFileName;
        _textBoxOutputFileDescription.Text = _appSettingsService.AppSettings.FilesRenamingFormData.OutputFileDescription;

        _checkBoxShouldKeepOriginalFileNameAndOnlyAppendFileDescription.Checked =
            _appSettingsService.AppSettings.FilesRenamingFormData.ShouldKeepOriginalFileNameAndOnlyAppendFileDescription;

        _checkBoxShouldIncludeTimeStampInTheFileName.Checked =
            _appSettingsService.AppSettings.FilesRenamingFormData.ShouldIncludeTimeStampInTheFileName;

        if (!string.IsNullOrWhiteSpace(_appSettingsService.AppSettings.FilesRenamingFormData.TimeStampStringFormat))
        {
            _textBoxTimeStampStringFormat.Text = _appSettingsService.AppSettings.FilesRenamingFormData.TimeStampStringFormat;
        }

        _radioButtonShouldOrderFilesByName.Checked =
            _appSettingsService.AppSettings.FilesRenamingFormData.ShouldOrderFilesByName;
        _radioButtonShouldOrderFilesByLastModifiedDate.Checked =
            _appSettingsService.AppSettings.FilesRenamingFormData.ShouldOrderFilesByLastModifiedDate;
        _radioButtonShouldOrderFilesByCreationDate.Checked =
            _appSettingsService.AppSettings.FilesRenamingFormData.ShouldOrderFilesByCreationDate;
        _radioButtonShouldNotOrderFiles.Checked =
            _appSettingsService.AppSettings.FilesRenamingFormData.ShouldNotOrderFiles;
    }

    private void ButtonSaveFormData_Click(object sender, EventArgs e)
    {
        _appSettingsService.AppSettings.FilesRenamingFormData.InputFolderPath = _textBoxFolderPath.Text;
        _appSettingsService.AppSettings.FilesRenamingFormData.OutputFileName = _textBoxOutputFileName.Text;
        _appSettingsService.AppSettings.FilesRenamingFormData.OutputFileDescription = _textBoxOutputFileDescription.Text;

        _appSettingsService.AppSettings.FilesRenamingFormData.ShouldKeepOriginalFileNameAndOnlyAppendFileDescription = _checkBoxShouldKeepOriginalFileNameAndOnlyAppendFileDescription.Checked;

        _appSettingsService.AppSettings.FilesRenamingFormData.ShouldIncludeTimeStampInTheFileName = _checkBoxShouldIncludeTimeStampInTheFileName.Checked;
        _appSettingsService.AppSettings.FilesRenamingFormData.TimeStampStringFormat = _textBoxTimeStampStringFormat.Text;

        _appSettingsService.AppSettings.FilesRenamingFormData.ShouldOrderFilesByName =
            _radioButtonShouldOrderFilesByName.Checked;
        _appSettingsService.AppSettings.FilesRenamingFormData.ShouldOrderFilesByLastModifiedDate =
            _radioButtonShouldOrderFilesByLastModifiedDate.Checked;
        _appSettingsService.AppSettings.FilesRenamingFormData.ShouldOrderFilesByCreationDate =
            _radioButtonShouldOrderFilesByCreationDate.Checked;
        _appSettingsService.AppSettings.FilesRenamingFormData.ShouldNotOrderFiles =
            _radioButtonShouldNotOrderFiles.Checked;

        _appSettingsService.Save();
    }

    private void AppendLog(string message)
    {
        _richTextBoxLogs.AppendText($"{message}");
        _richTextBoxLogs.ScrollToCaret();
    }
}
