namespace Tools;

partial class MainForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        appTableLayout1 = new Tools.ControlLibrary.Layouts.AppTableLayout();
        appPanel1 = new Tools.ControlLibrary.Containers.AppPanel();
        _telegramFilesUploaderMenuButton = new Tools.ControlLibrary.Buttons.AppSideBarMenuButton();
        _filesRenamingMenuButton = new Tools.ControlLibrary.Buttons.AppSideBarMenuButton();
        _videoTrimmingMenuButton = new Tools.ControlLibrary.Buttons.AppSideBarMenuButton();
        _panelFormDisplay = new Tools.ControlLibrary.Containers.AppPanel();
        appTableLayout1.SuspendLayout();
        appPanel1.SuspendLayout();
        SuspendLayout();
        // 
        // appTableLayout1
        // 
        appTableLayout1.ColumnCount = 2;
        appTableLayout1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
        appTableLayout1.ColumnStyles.Add(new ColumnStyle());
        appTableLayout1.Controls.Add(appPanel1, 0, 0);
        appTableLayout1.Controls.Add(_panelFormDisplay, 1, 0);
        appTableLayout1.Dock = DockStyle.Fill;
        appTableLayout1.Location = new Point(0, 0);
        appTableLayout1.Margin = new Padding(0);
        appTableLayout1.Name = "appTableLayout1";
        appTableLayout1.RowCount = 1;
        appTableLayout1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        appTableLayout1.Size = new Size(1612, 1041);
        appTableLayout1.TabIndex = 0;
        // 
        // appPanel1
        // 
        appPanel1.BackColor = Color.Black;
        appPanel1.Controls.Add(_telegramFilesUploaderMenuButton);
        appPanel1.Controls.Add(_filesRenamingMenuButton);
        appPanel1.Controls.Add(_videoTrimmingMenuButton);
        appPanel1.Dock = DockStyle.Fill;
        appPanel1.Location = new Point(0, 0);
        appPanel1.Margin = new Padding(0);
        appPanel1.Name = "appPanel1";
        appPanel1.Size = new Size(250, 1041);
        appPanel1.TabIndex = 0;
        // 
        // _telegramFilesUploaderMenuButton
        // 
        _telegramFilesUploaderMenuButton.BackColor = Color.Black;
        _telegramFilesUploaderMenuButton.Dock = DockStyle.Top;
        _telegramFilesUploaderMenuButton.FlatAppearance.BorderSize = 0;
        _telegramFilesUploaderMenuButton.FlatAppearance.MouseDownBackColor = Color.Black;
        _telegramFilesUploaderMenuButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
        _telegramFilesUploaderMenuButton.FlatStyle = FlatStyle.Flat;
        _telegramFilesUploaderMenuButton.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
        _telegramFilesUploaderMenuButton.ForeColor = Color.White;
        _telegramFilesUploaderMenuButton.Location = new Point(0, 120);
        _telegramFilesUploaderMenuButton.Margin = new Padding(0);
        _telegramFilesUploaderMenuButton.Name = "_telegramFilesUploaderMenuButton";
        _telegramFilesUploaderMenuButton.Size = new Size(250, 60);
        _telegramFilesUploaderMenuButton.TabIndex = 2;
        _telegramFilesUploaderMenuButton.Text = "Telegram files uploader";
        _telegramFilesUploaderMenuButton.UseVisualStyleBackColor = false;
        _telegramFilesUploaderMenuButton.Click += TelegramFilesUploaderMenuButton_Click;
        // 
        // _filesRenamingMenuButton
        // 
        _filesRenamingMenuButton.BackColor = Color.Black;
        _filesRenamingMenuButton.Dock = DockStyle.Top;
        _filesRenamingMenuButton.FlatAppearance.BorderSize = 0;
        _filesRenamingMenuButton.FlatAppearance.MouseDownBackColor = Color.Black;
        _filesRenamingMenuButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
        _filesRenamingMenuButton.FlatStyle = FlatStyle.Flat;
        _filesRenamingMenuButton.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
        _filesRenamingMenuButton.ForeColor = Color.White;
        _filesRenamingMenuButton.Location = new Point(0, 60);
        _filesRenamingMenuButton.Margin = new Padding(0);
        _filesRenamingMenuButton.Name = "_filesRenamingMenuButton";
        _filesRenamingMenuButton.Size = new Size(250, 60);
        _filesRenamingMenuButton.TabIndex = 1;
        _filesRenamingMenuButton.Text = "Files renaming";
        _filesRenamingMenuButton.UseVisualStyleBackColor = false;
        _filesRenamingMenuButton.Click += FileRenamingMenuButton_Click;
        // 
        // _videoTrimmingMenuButton
        // 
        _videoTrimmingMenuButton.BackColor = Color.Black;
        _videoTrimmingMenuButton.Dock = DockStyle.Top;
        _videoTrimmingMenuButton.FlatAppearance.BorderSize = 0;
        _videoTrimmingMenuButton.FlatAppearance.MouseDownBackColor = Color.Black;
        _videoTrimmingMenuButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
        _videoTrimmingMenuButton.FlatStyle = FlatStyle.Flat;
        _videoTrimmingMenuButton.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
        _videoTrimmingMenuButton.ForeColor = Color.White;
        _videoTrimmingMenuButton.Location = new Point(0, 0);
        _videoTrimmingMenuButton.Margin = new Padding(0);
        _videoTrimmingMenuButton.Name = "_videoTrimmingMenuButton";
        _videoTrimmingMenuButton.Size = new Size(250, 60);
        _videoTrimmingMenuButton.TabIndex = 0;
        _videoTrimmingMenuButton.Text = "Video trimming";
        _videoTrimmingMenuButton.UseVisualStyleBackColor = false;
        _videoTrimmingMenuButton.Click += VideoTrimmingMenuButton_Click;
        // 
        // _panelFormDisplay
        // 
        _panelFormDisplay.BackColor = Color.Transparent;
        _panelFormDisplay.Dock = DockStyle.Fill;
        _panelFormDisplay.Location = new Point(250, 0);
        _panelFormDisplay.Margin = new Padding(0);
        _panelFormDisplay.Name = "_panelFormDisplay";
        _panelFormDisplay.Size = new Size(1362, 1041);
        _panelFormDisplay.TabIndex = 1;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1612, 1041);
        Controls.Add(appTableLayout1);
        MinimumSize = new Size(1600, 1080);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Tools";
        Load += MainForm_Load;
        appTableLayout1.ResumeLayout(false);
        appPanel1.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private ControlLibrary.Layouts.AppTableLayout appTableLayout1;
    private ControlLibrary.Containers.AppPanel appPanel1;
    private ControlLibrary.Buttons.AppSideBarMenuButton _telegramFilesUploaderMenuButton;
    private ControlLibrary.Buttons.AppSideBarMenuButton _filesRenamingMenuButton;
    private ControlLibrary.Buttons.AppSideBarMenuButton _videoTrimmingMenuButton;
    private ControlLibrary.Containers.AppPanel _panelFormDisplay;
}