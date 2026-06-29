using Tools.Services;

namespace Tools;

internal partial class MainForm : Form
{
    private readonly IFormSwitchingService _formSwitchingService;

    public MainForm(IFormSwitchingService formSwitchingService)
    {
        InitializeComponent();
        _formSwitchingService = formSwitchingService;
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        _formSwitchingService.ShowForm<VideoTrimmingForm>(panel: _panelFormDisplay);
    }

    private void VideoTrimmingMenuButton_Click(object sender, EventArgs e)
    {
        _formSwitchingService.ShowForm<VideoTrimmingForm>(panel: _panelFormDisplay);
    }

    private void FileRenamingMenuButton_Click(object sender, EventArgs e)
    {
        _formSwitchingService.ShowForm<FilesRenamingForm>(panel: _panelFormDisplay);        
    }

    private void TelegramFilesUploaderMenuButton_Click(object sender, EventArgs e)
    {
        _formSwitchingService.ShowForm<TelegramUploaderForm>(panel: _panelFormDisplay);
    }
}
