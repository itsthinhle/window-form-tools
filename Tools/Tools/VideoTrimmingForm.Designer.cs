using Tools.ControlLibrary.Buttons;
using Tools.ControlLibrary.Containers;
using Tools.ControlLibrary.Controls;
using Tools.ControlLibrary.Layouts;
using Tools.ControlLibrary.Texts;

namespace Tools;

partial class VideoTrimmingForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoTrimmingForm));
        tableLayoutPanel1 = new TableLayoutPanel();
        appGroupBox1 = new AppGroupBox();
        appTableLayout1 = new AppTableLayout();
        appPanel1 = new AppPanel();
        _buttonBrowseVideo = new AppIconButton();
        _textBoxVideoPath = new AppTextBox();
        appLabel1 = new AppLabel();
        appNormalText2 = new AppNormalText();
        appLabel2 = new AppLabel();
        appNormalText1 = new AppNormalText();
        appPanel2 = new AppPanel();
        _buttonClearTimeRanges = new AppIconButton();
        _richTextBoxTimeSegments = new AppRichTextBox();
        _buttonStart = new AppPrimaryButton();
        appTableLayout2 = new AppTableLayout();
        appGroupBox2 = new AppGroupBox();
        appTableLayout3 = new AppTableLayout();
        appPanel4 = new AppPanel();
        appPanel5 = new AppPanel();
        _buttonBrowseOutputFolder = new AppIconButton();
        _buttonOpenOutputFolder = new AppIconButton();
        _textBoxOutputFolderPath = new AppTextBox();
        appLabel3 = new AppLabel();
        appPanel3 = new AppPanel();
        _textBoxOutputVideoName = new AppTextBox();
        appLabel4 = new AppLabel();
        appGroupBox3 = new AppGroupBox();
        _checkBoxShouldDeleteSourceVideoAfterTrimming = new AppCheckBox();
        appGroupBox4 = new AppGroupBox();
        _richTextBoxLogs = new AppRichTextBox();
        tableLayoutPanel1.SuspendLayout();
        appGroupBox1.SuspendLayout();
        appTableLayout1.SuspendLayout();
        appPanel1.SuspendLayout();
        appPanel2.SuspendLayout();
        appTableLayout2.SuspendLayout();
        appGroupBox2.SuspendLayout();
        appTableLayout3.SuspendLayout();
        appPanel4.SuspendLayout();
        appPanel5.SuspendLayout();
        appPanel3.SuspendLayout();
        appGroupBox3.SuspendLayout();
        appGroupBox4.SuspendLayout();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 2;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.Controls.Add(appGroupBox1, 0, 0);
        tableLayoutPanel1.Controls.Add(appTableLayout2, 1, 0);
        tableLayoutPanel1.Controls.Add(appGroupBox4, 0, 1);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(18, 18);
        tableLayoutPanel1.Margin = new Padding(0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 2;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
        tableLayoutPanel1.Size = new Size(1515, 761);
        tableLayoutPanel1.TabIndex = 1;
        // 
        // appGroupBox1
        // 
        appGroupBox1.Controls.Add(appTableLayout1);
        appGroupBox1.Dock = DockStyle.Fill;
        appGroupBox1.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        appGroupBox1.Location = new Point(0, 0);
        appGroupBox1.Margin = new Padding(0, 0, 9, 9);
        appGroupBox1.Name = "appGroupBox1";
        appGroupBox1.Padding = new Padding(9);
        appGroupBox1.Size = new Size(748, 485);
        appGroupBox1.TabIndex = 0;
        appGroupBox1.TabStop = false;
        appGroupBox1.Text = "Input";
        // 
        // appTableLayout1
        // 
        appTableLayout1.ColumnCount = 1;
        appTableLayout1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        appTableLayout1.Controls.Add(appPanel1, 0, 0);
        appTableLayout1.Controls.Add(appNormalText2, 0, 3);
        appTableLayout1.Controls.Add(appLabel2, 0, 1);
        appTableLayout1.Controls.Add(appNormalText1, 0, 2);
        appTableLayout1.Controls.Add(appPanel2, 0, 4);
        appTableLayout1.Dock = DockStyle.Fill;
        appTableLayout1.Location = new Point(9, 32);
        appTableLayout1.Margin = new Padding(0);
        appTableLayout1.Name = "appTableLayout1";
        appTableLayout1.RowCount = 5;
        appTableLayout1.RowStyles.Add(new RowStyle());
        appTableLayout1.RowStyles.Add(new RowStyle());
        appTableLayout1.RowStyles.Add(new RowStyle());
        appTableLayout1.RowStyles.Add(new RowStyle());
        appTableLayout1.RowStyles.Add(new RowStyle());
        appTableLayout1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        appTableLayout1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        appTableLayout1.Size = new Size(730, 444);
        appTableLayout1.TabIndex = 0;
        // 
        // appPanel1
        // 
        appPanel1.Controls.Add(_buttonBrowseVideo);
        appPanel1.Controls.Add(_textBoxVideoPath);
        appPanel1.Controls.Add(appLabel1);
        appPanel1.Dock = DockStyle.Top;
        appPanel1.Location = new Point(0, 0);
        appPanel1.Margin = new Padding(0, 0, 0, 18);
        appPanel1.Name = "appPanel1";
        appPanel1.Size = new Size(730, 31);
        appPanel1.TabIndex = 0;
        // 
        // _buttonBrowseVideo
        // 
        _buttonBrowseVideo.Anchor = AnchorStyles.Right;
        _buttonBrowseVideo.BackColor = Color.Transparent;
        _buttonBrowseVideo.BackgroundImage = (Image)resources.GetObject("_buttonBrowseVideo.BackgroundImage");
        _buttonBrowseVideo.BackgroundImageLayout = ImageLayout.Stretch;
        _buttonBrowseVideo.FlatAppearance.BorderSize = 0;
        _buttonBrowseVideo.FlatAppearance.MouseDownBackColor = Color.Transparent;
        _buttonBrowseVideo.FlatAppearance.MouseOverBackColor = Color.Transparent;
        _buttonBrowseVideo.FlatStyle = FlatStyle.Flat;
        _buttonBrowseVideo.Location = new Point(699, 0);
        _buttonBrowseVideo.Margin = new Padding(18, 0, 0, 0);
        _buttonBrowseVideo.Name = "_buttonBrowseVideo";
        _buttonBrowseVideo.Size = new Size(31, 31);
        _buttonBrowseVideo.TabIndex = 2;
        _buttonBrowseVideo.UseVisualStyleBackColor = false;
        _buttonBrowseVideo.Click += ButtonBrowseVideo_Click;
        // 
        // _textBoxVideoPath
        // 
        _textBoxVideoPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _textBoxVideoPath.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
        _textBoxVideoPath.Location = new Point(125, 0);
        _textBoxVideoPath.Margin = new Padding(0);
        _textBoxVideoPath.Name = "_textBoxVideoPath";
        _textBoxVideoPath.Size = new Size(556, 31);
        _textBoxVideoPath.TabIndex = 1;
        _textBoxVideoPath.TextChanged += TextBoxVideoPath_TextChanged;
        // 
        // appLabel1
        // 
        appLabel1.AutoSize = true;
        appLabel1.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
        appLabel1.Location = new Point(0, 3);
        appLabel1.Margin = new Padding(0, 0, 9, 0);
        appLabel1.Name = "appLabel1";
        appLabel1.Size = new Size(116, 25);
        appLabel1.TabIndex = 0;
        appLabel1.Text = "Video path *";
        // 
        // appNormalText2
        // 
        appNormalText2.AutoSize = true;
        appNormalText2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
        appNormalText2.Location = new Point(0, 117);
        appNormalText2.Margin = new Padding(0, 0, 0, 9);
        appNormalText2.Name = "appNormalText2";
        appNormalText2.Size = new Size(637, 50);
        appNormalText2.TabIndex = 3;
        appNormalText2.Text = "Time are separated by '/' and file description is placed at the end. For example, '1000/1245/sing' indicates the time from 10:00 to 12:45 with description 'sing'.";
        // 
        // appLabel2
        // 
        appLabel2.AutoSize = true;
        appLabel2.BackColor = Color.Transparent;
        appLabel2.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
        appLabel2.Location = new Point(0, 49);
        appLabel2.Margin = new Padding(0, 0, 0, 9);
        appLabel2.Name = "appLabel2";
        appLabel2.Size = new Size(139, 25);
        appLabel2.TabIndex = 1;
        appLabel2.Text = "Time segments";
        // 
        // appNormalText1
        // 
        appNormalText1.AutoSize = true;
        appNormalText1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
        appNormalText1.Location = new Point(0, 83);
        appNormalText1.Margin = new Padding(0, 0, 0, 9);
        appNormalText1.Name = "appNormalText1";
        appNormalText1.Size = new Size(582, 25);
        appNormalText1.TabIndex = 2;
        appNormalText1.Text = "Time will be in auto format. Examples: 1245 is 12:45, 11245 is 1:12:45, ...";
        // 
        // appPanel2
        // 
        appPanel2.Controls.Add(_buttonClearTimeRanges);
        appPanel2.Controls.Add(_richTextBoxTimeSegments);
        appPanel2.Controls.Add(_buttonStart);
        appPanel2.Dock = DockStyle.Fill;
        appPanel2.Location = new Point(0, 176);
        appPanel2.Margin = new Padding(0);
        appPanel2.Name = "appPanel2";
        appPanel2.Size = new Size(730, 268);
        appPanel2.TabIndex = 4;
        // 
        // _buttonClearTimeRanges
        // 
        _buttonClearTimeRanges.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        _buttonClearTimeRanges.BackColor = Color.Transparent;
        _buttonClearTimeRanges.BackgroundImage = (Image)resources.GetObject("_buttonClearTimeRanges.BackgroundImage");
        _buttonClearTimeRanges.BackgroundImageLayout = ImageLayout.Stretch;
        _buttonClearTimeRanges.FlatAppearance.BorderSize = 0;
        _buttonClearTimeRanges.FlatAppearance.MouseDownBackColor = Color.Transparent;
        _buttonClearTimeRanges.FlatAppearance.MouseOverBackColor = Color.Transparent;
        _buttonClearTimeRanges.FlatStyle = FlatStyle.Flat;
        _buttonClearTimeRanges.Location = new Point(690, 9);
        _buttonClearTimeRanges.Margin = new Padding(0, 9, 9, 0);
        _buttonClearTimeRanges.Name = "_buttonClearTimeRanges";
        _buttonClearTimeRanges.Size = new Size(31, 31);
        _buttonClearTimeRanges.TabIndex = 2;
        _buttonClearTimeRanges.UseVisualStyleBackColor = false;
        _buttonClearTimeRanges.Click += ButtonClearTimeRanges_Click;
        // 
        // _richTextBoxTimeSegments
        // 
        _richTextBoxTimeSegments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        _richTextBoxTimeSegments.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        _richTextBoxTimeSegments.Location = new Point(0, 0);
        _richTextBoxTimeSegments.Margin = new Padding(0, 0, 0, 18);
        _richTextBoxTimeSegments.Name = "_richTextBoxTimeSegments";
        _richTextBoxTimeSegments.Size = new Size(730, 205);
        _richTextBoxTimeSegments.TabIndex = 1;
        _richTextBoxTimeSegments.Text = "0/50/test";
        // 
        // _buttonStart
        // 
        _buttonStart.BackColor = Color.Black;
        _buttonStart.Dock = DockStyle.Bottom;
        _buttonStart.FlatAppearance.MouseDownBackColor = Color.Black;
        _buttonStart.FlatAppearance.MouseOverBackColor = Color.Black;
        _buttonStart.FlatStyle = FlatStyle.Flat;
        _buttonStart.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
        _buttonStart.ForeColor = Color.White;
        _buttonStart.Location = new Point(0, 223);
        _buttonStart.Margin = new Padding(0);
        _buttonStart.Name = "_buttonStart";
        _buttonStart.Size = new Size(730, 45);
        _buttonStart.TabIndex = 0;
        _buttonStart.Text = "Start";
        _buttonStart.UseVisualStyleBackColor = false;
        _buttonStart.Click += ButtonStart_Click;
        // 
        // appTableLayout2
        // 
        appTableLayout2.ColumnCount = 1;
        appTableLayout2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        appTableLayout2.Controls.Add(appGroupBox2, 0, 0);
        appTableLayout2.Controls.Add(appGroupBox3, 0, 1);
        appTableLayout2.Dock = DockStyle.Fill;
        appTableLayout2.Location = new Point(757, 0);
        appTableLayout2.Margin = new Padding(0);
        appTableLayout2.Name = "appTableLayout2";
        appTableLayout2.RowCount = 2;
        appTableLayout2.RowStyles.Add(new RowStyle(SizeType.Absolute, 131F));
        appTableLayout2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        appTableLayout2.Size = new Size(758, 494);
        appTableLayout2.TabIndex = 1;
        // 
        // appGroupBox2
        // 
        appGroupBox2.Controls.Add(appTableLayout3);
        appGroupBox2.Dock = DockStyle.Fill;
        appGroupBox2.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
        appGroupBox2.Location = new Point(9, 0);
        appGroupBox2.Margin = new Padding(9, 0, 0, 9);
        appGroupBox2.Name = "appGroupBox2";
        appGroupBox2.Padding = new Padding(9);
        appGroupBox2.Size = new Size(749, 122);
        appGroupBox2.TabIndex = 0;
        appGroupBox2.TabStop = false;
        appGroupBox2.Text = "Output";
        // 
        // appTableLayout3
        // 
        appTableLayout3.ColumnCount = 1;
        appTableLayout3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        appTableLayout3.Controls.Add(appPanel4, 0, 1);
        appTableLayout3.Controls.Add(appPanel3, 0, 0);
        appTableLayout3.Dock = DockStyle.Fill;
        appTableLayout3.Location = new Point(9, 33);
        appTableLayout3.Margin = new Padding(0, 0, 0, 9);
        appTableLayout3.Name = "appTableLayout3";
        appTableLayout3.RowCount = 2;
        appTableLayout3.RowStyles.Add(new RowStyle());
        appTableLayout3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        appTableLayout3.Size = new Size(731, 80);
        appTableLayout3.TabIndex = 0;
        // 
        // appPanel4
        // 
        appPanel4.Controls.Add(appPanel5);
        appPanel4.Controls.Add(_textBoxOutputFolderPath);
        appPanel4.Controls.Add(appLabel3);
        appPanel4.Dock = DockStyle.Top;
        appPanel4.Location = new Point(0, 49);
        appPanel4.Margin = new Padding(0);
        appPanel4.Name = "appPanel4";
        appPanel4.Size = new Size(731, 31);
        appPanel4.TabIndex = 1;
        // 
        // appPanel5
        // 
        appPanel5.Anchor = AnchorStyles.Right;
        appPanel5.Controls.Add(_buttonBrowseOutputFolder);
        appPanel5.Controls.Add(_buttonOpenOutputFolder);
        appPanel5.Location = new Point(660, 0);
        appPanel5.Margin = new Padding(0);
        appPanel5.Name = "appPanel5";
        appPanel5.Size = new Size(71, 31);
        appPanel5.TabIndex = 4;
        // 
        // _buttonBrowseOutputFolder
        // 
        _buttonBrowseOutputFolder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        _buttonBrowseOutputFolder.BackColor = Color.Transparent;
        _buttonBrowseOutputFolder.BackgroundImage = (Image)resources.GetObject("_buttonBrowseOutputFolder.BackgroundImage");
        _buttonBrowseOutputFolder.BackgroundImageLayout = ImageLayout.Stretch;
        _buttonBrowseOutputFolder.FlatAppearance.BorderSize = 0;
        _buttonBrowseOutputFolder.FlatAppearance.MouseDownBackColor = Color.Transparent;
        _buttonBrowseOutputFolder.FlatAppearance.MouseOverBackColor = Color.Transparent;
        _buttonBrowseOutputFolder.FlatStyle = FlatStyle.Flat;
        _buttonBrowseOutputFolder.Location = new Point(0, 0);
        _buttonBrowseOutputFolder.Margin = new Padding(0, 0, 9, 0);
        _buttonBrowseOutputFolder.Name = "_buttonBrowseOutputFolder";
        _buttonBrowseOutputFolder.Size = new Size(31, 31);
        _buttonBrowseOutputFolder.TabIndex = 2;
        _buttonBrowseOutputFolder.UseVisualStyleBackColor = false;
        _buttonBrowseOutputFolder.Click += ButtonBrowseOutputFolder_Click;
        // 
        // _buttonOpenOutputFolder
        // 
        _buttonOpenOutputFolder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        _buttonOpenOutputFolder.BackColor = Color.Transparent;
        _buttonOpenOutputFolder.BackgroundImage = (Image)resources.GetObject("_buttonOpenOutputFolder.BackgroundImage");
        _buttonOpenOutputFolder.BackgroundImageLayout = ImageLayout.Stretch;
        _buttonOpenOutputFolder.FlatAppearance.BorderSize = 0;
        _buttonOpenOutputFolder.FlatAppearance.MouseDownBackColor = Color.Transparent;
        _buttonOpenOutputFolder.FlatAppearance.MouseOverBackColor = Color.Transparent;
        _buttonOpenOutputFolder.FlatStyle = FlatStyle.Flat;
        _buttonOpenOutputFolder.Location = new Point(40, 0);
        _buttonOpenOutputFolder.Margin = new Padding(0);
        _buttonOpenOutputFolder.Name = "_buttonOpenOutputFolder";
        _buttonOpenOutputFolder.Size = new Size(31, 31);
        _buttonOpenOutputFolder.TabIndex = 3;
        _buttonOpenOutputFolder.UseVisualStyleBackColor = false;
        _buttonOpenOutputFolder.Click += ButtonOpenOutputFolder_Click;
        // 
        // _textBoxOutputFolderPath
        // 
        _textBoxOutputFolderPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _textBoxOutputFolderPath.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
        _textBoxOutputFolderPath.Location = new Point(192, 0);
        _textBoxOutputFolderPath.Margin = new Padding(0, 0, 18, 0);
        _textBoxOutputFolderPath.Name = "_textBoxOutputFolderPath";
        _textBoxOutputFolderPath.Size = new Size(450, 31);
        _textBoxOutputFolderPath.TabIndex = 1;
        // 
        // appLabel3
        // 
        appLabel3.AutoSize = true;
        appLabel3.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
        appLabel3.Location = new Point(0, 3);
        appLabel3.Margin = new Padding(0, 0, 9, 0);
        appLabel3.Name = "appLabel3";
        appLabel3.Size = new Size(183, 25);
        appLabel3.TabIndex = 0;
        appLabel3.Text = "Output folder path *";
        // 
        // appPanel3
        // 
        appPanel3.Controls.Add(_textBoxOutputVideoName);
        appPanel3.Controls.Add(appLabel4);
        appPanel3.Dock = DockStyle.Top;
        appPanel3.Location = new Point(0, 0);
        appPanel3.Margin = new Padding(0, 0, 0, 18);
        appPanel3.Name = "appPanel3";
        appPanel3.Size = new Size(731, 31);
        appPanel3.TabIndex = 0;
        // 
        // _textBoxOutputVideoName
        // 
        _textBoxOutputVideoName.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
        _textBoxOutputVideoName.Location = new Point(192, 0);
        _textBoxOutputVideoName.Margin = new Padding(0);
        _textBoxOutputVideoName.Name = "_textBoxOutputVideoName";
        _textBoxOutputVideoName.Size = new Size(250, 31);
        _textBoxOutputVideoName.TabIndex = 3;
        // 
        // appLabel4
        // 
        appLabel4.AutoSize = true;
        appLabel4.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
        appLabel4.Location = new Point(0, 3);
        appLabel4.Margin = new Padding(0, 0, 9, 0);
        appLabel4.Name = "appLabel4";
        appLabel4.Size = new Size(175, 25);
        appLabel4.TabIndex = 2;
        appLabel4.Text = "Output video name";
        // 
        // appGroupBox3
        // 
        appGroupBox3.Controls.Add(_checkBoxShouldDeleteSourceVideoAfterTrimming);
        appGroupBox3.Dock = DockStyle.Fill;
        appGroupBox3.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
        appGroupBox3.Location = new Point(9, 131);
        appGroupBox3.Margin = new Padding(9, 0, 0, 9);
        appGroupBox3.Name = "appGroupBox3";
        appGroupBox3.Padding = new Padding(9);
        appGroupBox3.Size = new Size(749, 354);
        appGroupBox3.TabIndex = 1;
        appGroupBox3.TabStop = false;
        appGroupBox3.Text = "Settings";
        // 
        // _checkBoxShouldDeleteSourceVideoAfterTrimming
        // 
        _checkBoxShouldDeleteSourceVideoAfterTrimming.AutoSize = true;
        _checkBoxShouldDeleteSourceVideoAfterTrimming.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
        _checkBoxShouldDeleteSourceVideoAfterTrimming.Location = new Point(9, 33);
        _checkBoxShouldDeleteSourceVideoAfterTrimming.Margin = new Padding(0);
        _checkBoxShouldDeleteSourceVideoAfterTrimming.Name = "_checkBoxShouldDeleteSourceVideoAfterTrimming";
        _checkBoxShouldDeleteSourceVideoAfterTrimming.Size = new Size(403, 29);
        _checkBoxShouldDeleteSourceVideoAfterTrimming.TabIndex = 0;
        _checkBoxShouldDeleteSourceVideoAfterTrimming.Text = "Should delete the source video after trimming?";
        _checkBoxShouldDeleteSourceVideoAfterTrimming.UseVisualStyleBackColor = true;
        // 
        // appGroupBox4
        // 
        tableLayoutPanel1.SetColumnSpan(appGroupBox4, 2);
        appGroupBox4.Controls.Add(_richTextBoxLogs);
        appGroupBox4.Dock = DockStyle.Fill;
        appGroupBox4.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
        appGroupBox4.Location = new Point(0, 494);
        appGroupBox4.Margin = new Padding(0);
        appGroupBox4.Name = "appGroupBox4";
        appGroupBox4.Padding = new Padding(9);
        appGroupBox4.Size = new Size(1515, 267);
        appGroupBox4.TabIndex = 2;
        appGroupBox4.TabStop = false;
        appGroupBox4.Text = "Logs";
        // 
        // _richTextBoxLogs
        // 
        _richTextBoxLogs.Dock = DockStyle.Fill;
        _richTextBoxLogs.Font = new Font("Segoe UI", 13F);
        _richTextBoxLogs.Location = new Point(9, 33);
        _richTextBoxLogs.Margin = new Padding(0);
        _richTextBoxLogs.Name = "_richTextBoxLogs";
        _richTextBoxLogs.Size = new Size(1497, 225);
        _richTextBoxLogs.TabIndex = 0;
        _richTextBoxLogs.Text = "";
        // 
        // VideoTrimmingForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1551, 797);
        Controls.Add(tableLayoutPanel1);
        MinimumSize = new Size(1280, 720);
        Name = "VideoTrimmingForm";
        Padding = new Padding(18);
        Text = "Form1";
        tableLayoutPanel1.ResumeLayout(false);
        appGroupBox1.ResumeLayout(false);
        appTableLayout1.ResumeLayout(false);
        appTableLayout1.PerformLayout();
        appPanel1.ResumeLayout(false);
        appPanel1.PerformLayout();
        appPanel2.ResumeLayout(false);
        appTableLayout2.ResumeLayout(false);
        appGroupBox2.ResumeLayout(false);
        appTableLayout3.ResumeLayout(false);
        appPanel4.ResumeLayout(false);
        appPanel4.PerformLayout();
        appPanel5.ResumeLayout(false);
        appPanel3.ResumeLayout(false);
        appPanel3.PerformLayout();
        appGroupBox3.ResumeLayout(false);
        appGroupBox3.PerformLayout();
        appGroupBox4.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private AppGroupBox appGroupBox1;
    private AppTableLayout appTableLayout1;
    private AppLabel appLabel2;
    private AppPanel appPanel1;
    private AppNormalText appNormalText2;
    private AppNormalText appNormalText1;
    private AppIconButton _buttonBrowseVideo;
    private AppTextBox _textBoxVideoPath;
    private AppLabel appLabel1;
    private AppPanel appPanel2;
    private AppPrimaryButton _buttonStart;
    private AppRichTextBox _richTextBoxTimeSegments;
    private AppTableLayout appTableLayout2;
    private AppGroupBox appGroupBox2;
    private AppTableLayout appTableLayout3;
    private AppPanel appPanel4;
    private AppIconButton _buttonBrowseOutputFolder;
    private AppTextBox _textBoxOutputFolderPath;
    private AppLabel appLabel3;
    private AppPanel appPanel3;
    private AppTextBox _textBoxOutputVideoName;
    private AppLabel appLabel4;
    private AppGroupBox appGroupBox3;
    private AppIconButton _buttonOpenOutputFolder;
    private AppGroupBox appGroupBox4;
    private AppRichTextBox _richTextBoxLogs;
    private AppPanel appPanel5;
    private AppIconButton _buttonClearTimeRanges;
    private AppCheckBox _checkBoxShouldDeleteSourceVideoAfterTrimming;
}
