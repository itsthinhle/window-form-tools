using Tools.Models.TelegramUploader;
using Tools.Services;
using Tools.Services.TelegramUploader;
using Tools.Utilities;

namespace Tools;

internal partial class TelegramUploaderForm : Form
{
    private readonly ITelegramService _telegramUploaderService;
    private readonly IAppSettingsService _appSettingsService;
    private readonly IProgress<string> _loggingProgress;

    public TelegramUploaderForm(ITelegramService telegramUploaderService, IAppSettingsService appSettingsService)
    {
        InitializeComponent();
        _telegramUploaderService = telegramUploaderService;
        _appSettingsService = appSettingsService;
        _loggingProgress = new Progress<string>(AppendLog);
    }

    private async void TelegramUploaderForm_Load(object sender, EventArgs e)
    {
        LoadFormSettings();
        await LoginAndLoadChats();
    }

    private async void ButtonLoginOrVerify_Click(object sender, EventArgs e)
    {
        await LoginAndLoadChats();
    }

    private void ButtonLogOut_Click(object sender, EventArgs e)
    {
        var loginRequest = CreateLoginRequest();

        _telegramUploaderService.Logout(loginRequest, _loggingProgress);

        _textBoxAppId.Enabled = true;
        _textBoxAppHashCode.Enabled = true;
        _textBoxPhoneNumber.Enabled = true;
        _textBoxVerificationCode.Enabled = true;
        _buttonLogOut.Enabled = true;

        _groupBoxInput.Enabled = false;
        _groupBoxOptions.Enabled = false;
    }

    private void ButtonBrowseFolder_Click(object sender, EventArgs e)
    {
        _textBoxInputFolderPath.Text = FolderUtility.Browse();
    }

    private void ButtonReloadChats_Click(object sender, EventArgs e)
    {
        LoadChats();
    }

    private void CheckBoxHasUserSpecifiedExtensions_CheckedChanged(object sender, EventArgs e)
    {
        _textBoxUserSpecifiedExtensions.Enabled = _checkBoxHasUserSpecifiedExtensions.Checked;

        if (!_checkBoxHasUserSpecifiedExtensions.Checked)
        {
            _textBoxUserSpecifiedExtensions.Text = "";
        }
    }

    private async void ButtonStart_Click(object sender, EventArgs e)
    {
        _buttonStart.Enabled = false;
        _groupBoxInput.Enabled = false;
        _groupBoxOptions.Enabled = false;

        var uploadFilesRequest = new UploadFilesRequest
        {
            InputFolderPath = _textBoxInputFolderPath.Text.Trim(),
            Chat = (TL.ChatBase)_comboBoxChats.SelectedItem!,
            Options = new Options
            {
                HasUserSpecifiedExtensions = _checkBoxHasUserSpecifiedExtensions.Checked,
                UserSpecifiedExtensions = _textBoxUserSpecifiedExtensions.Text.Trim(),
                ShouldIncludeNestedFiles = _checkBoxShouldIncludeNestedFiles.Checked,
                ShouldDeleteSourceFileAfterUploaded = _checkBoxShouldDeleteSourceFileAfterUploading.Checked
            }
        };

        try
        {
            await _telegramUploaderService.UploadFiles(uploadFilesRequest, _loggingProgress);
        }
        catch (Exception exception)
        {
            AppendLog($"{exception.Message}{Environment.NewLine}");
        }
        finally
        {
            _buttonStart.Enabled = true;
            _groupBoxInput.Enabled = true;
            _groupBoxOptions.Enabled = true;
        }
    }

    private void ButtonSaveFormData_Click(object sender, EventArgs e)
    {
        _appSettingsService.AppSettings.TelegramUploaderFormData.AppId = _textBoxAppId.Text;
        _appSettingsService.AppSettings.TelegramUploaderFormData.AppHashCode = _textBoxAppHashCode.Text;
        _appSettingsService.AppSettings.TelegramUploaderFormData.PhoneNumber = _textBoxPhoneNumber.Text;

        _appSettingsService.AppSettings.TelegramUploaderFormData.InputFolderPath = _textBoxInputFolderPath.Text;

        _appSettingsService.AppSettings.TelegramUploaderFormData.HasUserSpecifiedExtensions = _checkBoxHasUserSpecifiedExtensions.Checked;
        _appSettingsService.AppSettings.TelegramUploaderFormData.UserSpecifiedExtensions = _textBoxUserSpecifiedExtensions.Text;
        _appSettingsService.AppSettings.TelegramUploaderFormData.ShouldIncludeNestedFiles = _checkBoxShouldIncludeNestedFiles.Checked;
        _appSettingsService.AppSettings.TelegramUploaderFormData.ShouldDeleteSourceFileAfterUploaded = _checkBoxShouldDeleteSourceFileAfterUploading.Checked;

        _appSettingsService.Save();
    }

    private void LoadFormSettings()
    {
        _textBoxAppId.Text = _appSettingsService.AppSettings.TelegramUploaderFormData.AppId;
        _textBoxAppHashCode.Text = _appSettingsService.AppSettings.TelegramUploaderFormData.AppHashCode;
        _textBoxPhoneNumber.Text = _appSettingsService.AppSettings.TelegramUploaderFormData.PhoneNumber;

        _textBoxInputFolderPath.Text = _appSettingsService.AppSettings.TelegramUploaderFormData.InputFolderPath;

        _checkBoxHasUserSpecifiedExtensions.Checked = _appSettingsService.AppSettings.TelegramUploaderFormData.HasUserSpecifiedExtensions;
        _textBoxUserSpecifiedExtensions.Text = _appSettingsService.AppSettings.TelegramUploaderFormData.UserSpecifiedExtensions;
        _checkBoxShouldIncludeNestedFiles.Checked = _appSettingsService.AppSettings.TelegramUploaderFormData.ShouldIncludeNestedFiles;
        _checkBoxShouldDeleteSourceFileAfterUploading.Checked = _appSettingsService.AppSettings.TelegramUploaderFormData.ShouldDeleteSourceFileAfterUploaded;
    }

    // Try to connect to the Telegram client during the form loading state
    // with the app ID and app hash code are provided.
    private async Task LoginAndLoadChats()
    {
        var loginRequest = CreateLoginRequest();

        try
        {
            var loginStatus = await _telegramUploaderService.Login(loginRequest, _loggingProgress);

            _textBoxAppId.Enabled = false;
            _textBoxAppHashCode.Enabled = false;
            _textBoxPhoneNumber.Enabled = false;

            if (loginStatus == LoginStatus.VerificationCodeRequired)
            {
                _textBoxVerificationCode.Enabled = true;
                _textBoxVerificationCode.Focus();
                _buttonLoginOrVerify.Text = "Verify";
            }
            else if (loginStatus == LoginStatus.LoggedIn)
            {
                _textBoxVerificationCode.Enabled = false;
                _buttonLoginOrVerify.Enabled = false;
                _buttonLoginOrVerify.Text = "LoginAndLoadChats";
                _buttonLogOut.Enabled = true;

                _groupBoxInput.Enabled = true;
                _groupBoxOptions.Enabled = true;

                LoadChats();
            }
        }
        catch (Exception exception)
        {
            _loggingProgress.Report($"{exception.Message}{Environment.NewLine}");
        }
    }

    private LoginRequest CreateLoginRequest()
    {
        return new LoginRequest
        {
            AppId = _textBoxAppId.Text.Trim(),
            AppHashCode = _textBoxAppHashCode.Text.Trim(),
            PhoneNumber = _textBoxPhoneNumber.Text.Trim(),
            VerificationCode = _textBoxVerificationCode.Text.Trim()
        };
    }

    private async void LoadChats()
    {
        var chats = await _telegramUploaderService.GetChats(_loggingProgress);

        if (chats != null)
        {
            _comboBoxChats.Items.Clear();

            foreach (var chat in chats.chats.Values)
                if (chat.IsActive)
                    _comboBoxChats.Items.Add(chat);

            _comboBoxChats.Sorted = true;
            _comboBoxChats.DisplayMember = "Title";
            _loggingProgress?.Report($"All chats have been loaded.{Environment.NewLine}");
        }
    }

    private void AppendLog(string message)
    {
        _richTextBoxLogs.AppendText($"{message}");
        _richTextBoxLogs.ScrollToCaret();
    }
}
