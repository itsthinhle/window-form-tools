namespace Tools;

partial class FilesRenamingForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilesRenamingForm));
        appTableLayout1 = new Tools.ControlLibrary.Layouts.AppTableLayout();
        _buttonStart = new Tools.ControlLibrary.Buttons.AppPrimaryButton();
        _buttonSaveFormData = new Tools.ControlLibrary.Buttons.AppSecondaryButton();
        appTableLayout5 = new Tools.ControlLibrary.Layouts.AppTableLayout();
        appGroupBox1 = new Tools.ControlLibrary.Containers.AppGroupBox();
        appTableLayout3 = new Tools.ControlLibrary.Layouts.AppTableLayout();
        appLabel1 = new Tools.ControlLibrary.Texts.AppLabel();
        _textBoxFolderPath = new Tools.ControlLibrary.Controls.AppTextBox();
        _buttonBrowseFolder = new Tools.ControlLibrary.Buttons.AppIconButton();
        appGroupBox2 = new Tools.ControlLibrary.Containers.AppGroupBox();
        appTableLayout4 = new Tools.ControlLibrary.Layouts.AppTableLayout();
        _labelOutputFileName = new Tools.ControlLibrary.Texts.AppLabel();
        appLabel3 = new Tools.ControlLibrary.Texts.AppLabel();
        _textBoxOutputFileName = new Tools.ControlLibrary.Controls.AppTextBox();
        _textBoxOutputFileDescription = new Tools.ControlLibrary.Controls.AppTextBox();
        appNormalText1 = new Tools.ControlLibrary.Texts.AppNormalText();
        appGroupBox3 = new Tools.ControlLibrary.Containers.AppGroupBox();
        _labelTimeStampStringFormat = new Tools.ControlLibrary.Texts.AppNormalText();
        _textBoxTimeStampStringFormat = new Tools.ControlLibrary.Controls.AppTextBox();
        _checkBoxShouldIncludeTimeStampInTheFileName = new CheckBox();
        appPanel1 = new Tools.ControlLibrary.Containers.AppPanel();
        _radioButtonShouldOrderFilesByCreationDate = new Tools.ControlLibrary.Controls.AppRadioButton();
        _radioButtonShouldOrderFilesByName = new Tools.ControlLibrary.Controls.AppRadioButton();
        _radioButtonShouldNotOrderFiles = new Tools.ControlLibrary.Controls.AppRadioButton();
        _radioButtonShouldOrderFilesByLastModifiedDate = new Tools.ControlLibrary.Controls.AppRadioButton();
        appNormalText3 = new Tools.ControlLibrary.Texts.AppNormalText();
        appNormalText2 = new Tools.ControlLibrary.Texts.AppNormalText();
        _checkBoxShouldKeepOriginalFileNameAndOnlyAppendFileDescription = new CheckBox();
        appGroupBox4 = new Tools.ControlLibrary.Containers.AppGroupBox();
        _richTextBoxLogs = new Tools.ControlLibrary.Texts.AppRichTextBox();
        appTableLayout1.SuspendLayout();
        appTableLayout5.SuspendLayout();
        appGroupBox1.SuspendLayout();
        appTableLayout3.SuspendLayout();
        appGroupBox2.SuspendLayout();
        appTableLayout4.SuspendLayout();
        appGroupBox3.SuspendLayout();
        appPanel1.SuspendLayout();
        appGroupBox4.SuspendLayout();
        SuspendLayout();
        // 
        // appTableLayout1
        // 
        appTableLayout1.ColumnCount = 2;
        appTableLayout1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        appTableLayout1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        appTableLayout1.Controls.Add(_buttonStart, 0, 1);
        appTableLayout1.Controls.Add(_buttonSaveFormData, 1, 2);
        appTableLayout1.Controls.Add(appTableLayout5, 0, 0);
        appTableLayout1.Controls.Add(appGroupBox4, 1, 0);
        appTableLayout1.Dock = DockStyle.Fill;
        appTableLayout1.Location = new Point(18, 18);
        appTableLayout1.Margin = new Padding(0);
        appTableLayout1.Name = "appTableLayout1";
        appTableLayout1.RowCount = 3;
        appTableLayout1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        appTableLayout1.RowStyles.Add(new RowStyle(SizeType.Absolute, 63F));
        appTableLayout1.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
        appTableLayout1.Size = new Size(1515, 814);
        appTableLayout1.TabIndex = 0;
        // 
        // _buttonStart
        // 
        _buttonStart.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        _buttonStart.BackColor = Color.Black;
        appTableLayout1.SetColumnSpan(_buttonStart, 2);
        _buttonStart.FlatAppearance.MouseDownBackColor = Color.Black;
        _buttonStart.FlatAppearance.MouseOverBackColor = Color.Black;
        _buttonStart.FlatStyle = FlatStyle.Flat;
        _buttonStart.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
        _buttonStart.ForeColor = Color.White;
        _buttonStart.Location = new Point(0, 716);
        _buttonStart.Margin = new Padding(0, 18, 0, 0);
        _buttonStart.Name = "_buttonStart";
        _buttonStart.Size = new Size(1515, 45);
        _buttonStart.TabIndex = 3;
        _buttonStart.Text = "Start";
        _buttonStart.UseVisualStyleBackColor = false;
        _buttonStart.Click += ButtonStart_Click;
        // 
        // _buttonSaveFormData
        // 
        _buttonSaveFormData.BackColor = Color.White;
        _buttonSaveFormData.Dock = DockStyle.Right;
        _buttonSaveFormData.FlatAppearance.BorderColor = Color.LightGray;
        _buttonSaveFormData.FlatAppearance.MouseDownBackColor = Color.White;
        _buttonSaveFormData.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
        _buttonSaveFormData.FlatStyle = FlatStyle.Flat;
        _buttonSaveFormData.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
        _buttonSaveFormData.ForeColor = Color.Black;
        _buttonSaveFormData.Location = new Point(1370, 779);
        _buttonSaveFormData.Margin = new Padding(0, 18, 0, 0);
        _buttonSaveFormData.Name = "_buttonSaveFormData";
        _buttonSaveFormData.Size = new Size(145, 35);
        _buttonSaveFormData.TabIndex = 8;
        _buttonSaveFormData.Text = "Save form data";
        _buttonSaveFormData.UseVisualStyleBackColor = false;
        _buttonSaveFormData.Click += ButtonSaveFormData_Click;
        // 
        // appTableLayout5
        // 
        appTableLayout5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        appTableLayout5.ColumnCount = 1;
        appTableLayout5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        appTableLayout5.Controls.Add(appGroupBox1, 0, 0);
        appTableLayout5.Controls.Add(appGroupBox2, 0, 1);
        appTableLayout5.Controls.Add(appGroupBox3, 0, 2);
        appTableLayout5.Location = new Point(0, 0);
        appTableLayout5.Margin = new Padding(0);
        appTableLayout5.Name = "appTableLayout5";
        appTableLayout5.RowCount = 3;
        appTableLayout5.RowStyles.Add(new RowStyle());
        appTableLayout5.RowStyles.Add(new RowStyle());
        appTableLayout5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        appTableLayout5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        appTableLayout5.Size = new Size(757, 698);
        appTableLayout5.TabIndex = 6;
        // 
        // appGroupBox1
        // 
        appGroupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        appGroupBox1.Controls.Add(appTableLayout3);
        appGroupBox1.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
        appGroupBox1.Location = new Point(0, 0);
        appGroupBox1.Margin = new Padding(0, 0, 9, 9);
        appGroupBox1.Name = "appGroupBox1";
        appGroupBox1.Padding = new Padding(9);
        appGroupBox1.Size = new Size(748, 73);
        appGroupBox1.TabIndex = 0;
        appGroupBox1.TabStop = false;
        appGroupBox1.Text = "Input";
        // 
        // appTableLayout3
        // 
        appTableLayout3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        appTableLayout3.ColumnCount = 3;
        appTableLayout3.ColumnStyles.Add(new ColumnStyle());
        appTableLayout3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100.000008F));
        appTableLayout3.ColumnStyles.Add(new ColumnStyle());
        appTableLayout3.Controls.Add(appLabel1, 0, 0);
        appTableLayout3.Controls.Add(_textBoxFolderPath, 1, 0);
        appTableLayout3.Controls.Add(_buttonBrowseFolder, 2, 0);
        appTableLayout3.Location = new Point(9, 33);
        appTableLayout3.Margin = new Padding(0, 0, 0, 18);
        appTableLayout3.Name = "appTableLayout3";
        appTableLayout3.RowCount = 1;
        appTableLayout3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        appTableLayout3.Size = new Size(730, 31);
        appTableLayout3.TabIndex = 0;
        // 
        // appLabel1
        // 
        appLabel1.AutoSize = true;
        appLabel1.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
        appLabel1.Location = new Point(0, 0);
        appLabel1.Margin = new Padding(0, 0, 9, 0);
        appLabel1.Name = "appLabel1";
        appLabel1.Size = new Size(120, 25);
        appLabel1.TabIndex = 2;
        appLabel1.Text = "Folder path *";
        // 
        // _textBoxFolderPath
        // 
        _textBoxFolderPath.Dock = DockStyle.Fill;
        _textBoxFolderPath.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
        _textBoxFolderPath.Location = new Point(129, 0);
        _textBoxFolderPath.Margin = new Padding(0);
        _textBoxFolderPath.Name = "_textBoxFolderPath";
        _textBoxFolderPath.Size = new Size(552, 31);
        _textBoxFolderPath.TabIndex = 1;
        // 
        // _buttonBrowseFolder
        // 
        _buttonBrowseFolder.BackColor = Color.Transparent;
        _buttonBrowseFolder.BackgroundImage = (Image)resources.GetObject("_buttonBrowseFolder.BackgroundImage");
        _buttonBrowseFolder.BackgroundImageLayout = ImageLayout.Stretch;
        _buttonBrowseFolder.FlatAppearance.BorderSize = 0;
        _buttonBrowseFolder.FlatAppearance.MouseDownBackColor = Color.Transparent;
        _buttonBrowseFolder.FlatAppearance.MouseOverBackColor = Color.Transparent;
        _buttonBrowseFolder.FlatStyle = FlatStyle.Flat;
        _buttonBrowseFolder.Location = new Point(699, 0);
        _buttonBrowseFolder.Margin = new Padding(18, 0, 0, 0);
        _buttonBrowseFolder.Name = "_buttonBrowseFolder";
        _buttonBrowseFolder.Size = new Size(31, 31);
        _buttonBrowseFolder.TabIndex = 0;
        _buttonBrowseFolder.UseVisualStyleBackColor = false;
        _buttonBrowseFolder.Click += ButtonBrowseFolder_Click;
        // 
        // appGroupBox2
        // 
        appGroupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        appGroupBox2.Controls.Add(appTableLayout4);
        appGroupBox2.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
        appGroupBox2.Location = new Point(0, 82);
        appGroupBox2.Margin = new Padding(0, 0, 9, 9);
        appGroupBox2.Name = "appGroupBox2";
        appGroupBox2.Padding = new Padding(9);
        appGroupBox2.Size = new Size(748, 175);
        appGroupBox2.TabIndex = 1;
        appGroupBox2.TabStop = false;
        appGroupBox2.Text = "Output";
        // 
        // appTableLayout4
        // 
        appTableLayout4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        appTableLayout4.ColumnCount = 2;
        appTableLayout4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        appTableLayout4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        appTableLayout4.Controls.Add(_labelOutputFileName, 0, 0);
        appTableLayout4.Controls.Add(appLabel3, 1, 0);
        appTableLayout4.Controls.Add(_textBoxOutputFileName, 0, 1);
        appTableLayout4.Controls.Add(_textBoxOutputFileDescription, 1, 1);
        appTableLayout4.Controls.Add(appNormalText1, 0, 2);
        appTableLayout4.Location = new Point(9, 33);
        appTableLayout4.Margin = new Padding(0, 0, 0, 18);
        appTableLayout4.Name = "appTableLayout4";
        appTableLayout4.RowCount = 3;
        appTableLayout4.RowStyles.Add(new RowStyle());
        appTableLayout4.RowStyles.Add(new RowStyle());
        appTableLayout4.RowStyles.Add(new RowStyle());
        appTableLayout4.Size = new Size(730, 133);
        appTableLayout4.TabIndex = 1;
        // 
        // _labelOutputFileName
        // 
        _labelOutputFileName.AutoSize = true;
        _labelOutputFileName.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
        _labelOutputFileName.Location = new Point(0, 0);
        _labelOutputFileName.Margin = new Padding(0, 0, 9, 9);
        _labelOutputFileName.Name = "_labelOutputFileName";
        _labelOutputFileName.Size = new Size(105, 25);
        _labelOutputFileName.TabIndex = 0;
        _labelOutputFileName.Text = "File name *";
        // 
        // appLabel3
        // 
        appLabel3.AutoSize = true;
        appLabel3.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
        appLabel3.Location = new Point(374, 0);
        appLabel3.Margin = new Padding(9, 0, 9, 9);
        appLabel3.Name = "appLabel3";
        appLabel3.Size = new Size(140, 25);
        appLabel3.TabIndex = 1;
        appLabel3.Text = "File description";
        // 
        // _textBoxOutputFileName
        // 
        _textBoxOutputFileName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _textBoxOutputFileName.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
        _textBoxOutputFileName.Location = new Point(0, 34);
        _textBoxOutputFileName.Margin = new Padding(0, 0, 9, 18);
        _textBoxOutputFileName.Name = "_textBoxOutputFileName";
        _textBoxOutputFileName.Size = new Size(356, 31);
        _textBoxOutputFileName.TabIndex = 2;
        // 
        // _textBoxOutputFileDescription
        // 
        _textBoxOutputFileDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _textBoxOutputFileDescription.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
        _textBoxOutputFileDescription.Location = new Point(374, 34);
        _textBoxOutputFileDescription.Margin = new Padding(9, 0, 0, 0);
        _textBoxOutputFileDescription.Name = "_textBoxOutputFileDescription";
        _textBoxOutputFileDescription.Size = new Size(356, 31);
        _textBoxOutputFileDescription.TabIndex = 3;
        // 
        // appNormalText1
        // 
        appNormalText1.AutoSize = true;
        appTableLayout4.SetColumnSpan(appNormalText1, 2);
        appNormalText1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
        appNormalText1.Location = new Point(0, 83);
        appNormalText1.Margin = new Padding(0, 0, 0, 9);
        appNormalText1.Name = "appNormalText1";
        appNormalText1.Size = new Size(519, 50);
        appNormalText1.TabIndex = 5;
        appNormalText1.Text = "Batch renaming files by the following format: \r\n<file name>[_timestamp]_<index>[_<file description>].extension";
        // 
        // appGroupBox3
        // 
        appGroupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        appGroupBox3.Controls.Add(_labelTimeStampStringFormat);
        appGroupBox3.Controls.Add(_textBoxTimeStampStringFormat);
        appGroupBox3.Controls.Add(_checkBoxShouldIncludeTimeStampInTheFileName);
        appGroupBox3.Controls.Add(appPanel1);
        appGroupBox3.Controls.Add(appNormalText3);
        appGroupBox3.Controls.Add(appNormalText2);
        appGroupBox3.Controls.Add(_checkBoxShouldKeepOriginalFileNameAndOnlyAppendFileDescription);
        appGroupBox3.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
        appGroupBox3.Location = new Point(0, 266);
        appGroupBox3.Margin = new Padding(0, 0, 9, 0);
        appGroupBox3.Name = "appGroupBox3";
        appGroupBox3.Padding = new Padding(9);
        appGroupBox3.Size = new Size(748, 432);
        appGroupBox3.TabIndex = 2;
        appGroupBox3.TabStop = false;
        appGroupBox3.Text = "Options";
        // 
        // _labelTimeStampStringFormat
        // 
        _labelTimeStampStringFormat.AutoSize = true;
        _labelTimeStampStringFormat.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
        _labelTimeStampStringFormat.Location = new Point(52, 146);
        _labelTimeStampStringFormat.Margin = new Padding(18, 0, 0, 9);
        _labelTimeStampStringFormat.Name = "_labelTimeStampStringFormat";
        _labelTimeStampStringFormat.Size = new Size(213, 25);
        _labelTimeStampStringFormat.TabIndex = 13;
        _labelTimeStampStringFormat.Text = "Timestamp string format:";
        // 
        // _textBoxTimeStampStringFormat
        // 
        _textBoxTimeStampStringFormat.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
        _textBoxTimeStampStringFormat.Location = new Point(274, 143);
        _textBoxTimeStampStringFormat.Margin = new Padding(9, 0, 0, 0);
        _textBoxTimeStampStringFormat.Name = "_textBoxTimeStampStringFormat";
        _textBoxTimeStampStringFormat.Size = new Size(222, 31);
        _textBoxTimeStampStringFormat.TabIndex = 12;
        _textBoxTimeStampStringFormat.Text = "yyyy-MM-dd-HH.mm.ss";
        // 
        // _checkBoxShouldIncludeTimeStampInTheFileName
        // 
        _checkBoxShouldIncludeTimeStampInTheFileName.AutoSize = true;
        _checkBoxShouldIncludeTimeStampInTheFileName.Checked = true;
        _checkBoxShouldIncludeTimeStampInTheFileName.CheckState = CheckState.Checked;
        _checkBoxShouldIncludeTimeStampInTheFileName.Font = new Font("Segoe UI", 13F);
        _checkBoxShouldIncludeTimeStampInTheFileName.Location = new Point(36, 105);
        _checkBoxShouldIncludeTimeStampInTheFileName.Margin = new Padding(27, 0, 0, 9);
        _checkBoxShouldIncludeTimeStampInTheFileName.Name = "_checkBoxShouldIncludeTimeStampInTheFileName";
        _checkBoxShouldIncludeTimeStampInTheFileName.Size = new Size(470, 29);
        _checkBoxShouldIncludeTimeStampInTheFileName.TabIndex = 11;
        _checkBoxShouldIncludeTimeStampInTheFileName.Text = "Include a timestamp (before the index) in the file name?";
        _checkBoxShouldIncludeTimeStampInTheFileName.UseVisualStyleBackColor = true;
        _checkBoxShouldIncludeTimeStampInTheFileName.CheckedChanged += CheckBoxShouldIncludeTimeStampInTheFileName_CheckedChanged;
        // 
        // appPanel1
        // 
        appPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        appPanel1.BackColor = Color.Transparent;
        appPanel1.Controls.Add(_radioButtonShouldOrderFilesByCreationDate);
        appPanel1.Controls.Add(_radioButtonShouldOrderFilesByName);
        appPanel1.Controls.Add(_radioButtonShouldNotOrderFiles);
        appPanel1.Controls.Add(_radioButtonShouldOrderFilesByLastModifiedDate);
        appPanel1.Location = new Point(36, 214);
        appPanel1.Margin = new Padding(27, 0, 0, 0);
        appPanel1.Name = "appPanel1";
        appPanel1.Size = new Size(703, 147);
        appPanel1.TabIndex = 10;
        // 
        // _radioButtonShouldOrderFilesByCreationDate
        // 
        _radioButtonShouldOrderFilesByCreationDate.AutoSize = true;
        _radioButtonShouldOrderFilesByCreationDate.Font = new Font("Segoe UI", 13F);
        _radioButtonShouldOrderFilesByCreationDate.Location = new Point(0, 76);
        _radioButtonShouldOrderFilesByCreationDate.Margin = new Padding(0, 0, 0, 9);
        _radioButtonShouldOrderFilesByCreationDate.Name = "_radioButtonShouldOrderFilesByCreationDate";
        _radioButtonShouldOrderFilesByCreationDate.Size = new Size(157, 29);
        _radioButtonShouldOrderFilesByCreationDate.TabIndex = 10;
        _radioButtonShouldOrderFilesByCreationDate.Text = "By creation date";
        _radioButtonShouldOrderFilesByCreationDate.UseVisualStyleBackColor = true;
        // 
        // _radioButtonShouldOrderFilesByName
        // 
        _radioButtonShouldOrderFilesByName.AutoSize = true;
        _radioButtonShouldOrderFilesByName.Font = new Font("Segoe UI", 13F);
        _radioButtonShouldOrderFilesByName.Location = new Point(0, 0);
        _radioButtonShouldOrderFilesByName.Margin = new Padding(0, 0, 0, 9);
        _radioButtonShouldOrderFilesByName.Name = "_radioButtonShouldOrderFilesByName";
        _radioButtonShouldOrderFilesByName.Size = new Size(98, 29);
        _radioButtonShouldOrderFilesByName.TabIndex = 6;
        _radioButtonShouldOrderFilesByName.Text = "By name";
        _radioButtonShouldOrderFilesByName.UseVisualStyleBackColor = true;
        // 
        // _radioButtonShouldNotOrderFiles
        // 
        _radioButtonShouldNotOrderFiles.AutoSize = true;
        _radioButtonShouldNotOrderFiles.Checked = true;
        _radioButtonShouldNotOrderFiles.Font = new Font("Segoe UI", 13F);
        _radioButtonShouldNotOrderFiles.Location = new Point(0, 114);
        _radioButtonShouldNotOrderFiles.Margin = new Padding(0);
        _radioButtonShouldNotOrderFiles.Name = "_radioButtonShouldNotOrderFiles";
        _radioButtonShouldNotOrderFiles.Size = new Size(73, 29);
        _radioButtonShouldNotOrderFiles.TabIndex = 9;
        _radioButtonShouldNotOrderFiles.TabStop = true;
        _radioButtonShouldNotOrderFiles.Text = "None";
        _radioButtonShouldNotOrderFiles.UseVisualStyleBackColor = true;
        // 
        // _radioButtonShouldOrderFilesByLastModifiedDate
        // 
        _radioButtonShouldOrderFilesByLastModifiedDate.AutoSize = true;
        _radioButtonShouldOrderFilesByLastModifiedDate.Font = new Font("Segoe UI", 13F);
        _radioButtonShouldOrderFilesByLastModifiedDate.Location = new Point(0, 38);
        _radioButtonShouldOrderFilesByLastModifiedDate.Margin = new Padding(0, 0, 0, 9);
        _radioButtonShouldOrderFilesByLastModifiedDate.Name = "_radioButtonShouldOrderFilesByLastModifiedDate";
        _radioButtonShouldOrderFilesByLastModifiedDate.Size = new Size(198, 29);
        _radioButtonShouldOrderFilesByLastModifiedDate.TabIndex = 8;
        _radioButtonShouldOrderFilesByLastModifiedDate.Text = "By last modified date";
        _radioButtonShouldOrderFilesByLastModifiedDate.UseVisualStyleBackColor = true;
        // 
        // appNormalText3
        // 
        appNormalText3.AutoSize = true;
        appNormalText3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
        appNormalText3.Location = new Point(9, 33);
        appNormalText3.Margin = new Padding(0, 0, 0, 9);
        appNormalText3.Name = "appNormalText3";
        appNormalText3.Size = new Size(75, 25);
        appNormalText3.TabIndex = 7;
        appNormalText3.Text = "General:";
        // 
        // appNormalText2
        // 
        appNormalText2.AutoSize = true;
        appNormalText2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
        appNormalText2.Location = new Point(9, 180);
        appNormalText2.Margin = new Padding(0, 0, 0, 9);
        appNormalText2.Name = "appNormalText2";
        appNormalText2.Size = new Size(258, 25);
        appNormalText2.TabIndex = 5;
        appNormalText2.Text = "Ordering rule before renaming:";
        // 
        // _checkBoxShouldKeepOriginalFileNameAndOnlyAppendFileDescription
        // 
        _checkBoxShouldKeepOriginalFileNameAndOnlyAppendFileDescription.AutoSize = true;
        _checkBoxShouldKeepOriginalFileNameAndOnlyAppendFileDescription.Font = new Font("Segoe UI", 13F);
        _checkBoxShouldKeepOriginalFileNameAndOnlyAppendFileDescription.Location = new Point(36, 67);
        _checkBoxShouldKeepOriginalFileNameAndOnlyAppendFileDescription.Margin = new Padding(27, 0, 0, 9);
        _checkBoxShouldKeepOriginalFileNameAndOnlyAppendFileDescription.Name = "_checkBoxShouldKeepOriginalFileNameAndOnlyAppendFileDescription";
        _checkBoxShouldKeepOriginalFileNameAndOnlyAppendFileDescription.Size = new Size(525, 29);
        _checkBoxShouldKeepOriginalFileNameAndOnlyAppendFileDescription.TabIndex = 4;
        _checkBoxShouldKeepOriginalFileNameAndOnlyAppendFileDescription.Text = "Keep the source file name and only append the file description";
        _checkBoxShouldKeepOriginalFileNameAndOnlyAppendFileDescription.UseVisualStyleBackColor = true;
        _checkBoxShouldKeepOriginalFileNameAndOnlyAppendFileDescription.CheckedChanged += CheckBoxShouldKeepOriginalFileNameAndAppendFileDescription_CheckedChanged;
        // 
        // appGroupBox4
        // 
        appGroupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        appGroupBox4.Controls.Add(_richTextBoxLogs);
        appGroupBox4.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
        appGroupBox4.Location = new Point(766, 0);
        appGroupBox4.Margin = new Padding(9, 0, 0, 0);
        appGroupBox4.Name = "appGroupBox4";
        appGroupBox4.Padding = new Padding(9);
        appGroupBox4.Size = new Size(749, 698);
        appGroupBox4.TabIndex = 9;
        appGroupBox4.TabStop = false;
        appGroupBox4.Text = "Logs";
        // 
        // _richTextBoxLogs
        // 
        _richTextBoxLogs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        _richTextBoxLogs.Font = new Font("Segoe UI", 13F);
        _richTextBoxLogs.Location = new Point(9, 33);
        _richTextBoxLogs.Margin = new Padding(0);
        _richTextBoxLogs.Name = "_richTextBoxLogs";
        _richTextBoxLogs.Size = new Size(731, 656);
        _richTextBoxLogs.TabIndex = 0;
        _richTextBoxLogs.Text = "";
        // 
        // FilesRenamingForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1551, 850);
        Controls.Add(appTableLayout1);
        Name = "FilesRenamingForm";
        Padding = new Padding(18);
        Text = "FilesRenaming";
        Load += FilesRenamingForm_Load;
        appTableLayout1.ResumeLayout(false);
        appTableLayout5.ResumeLayout(false);
        appGroupBox1.ResumeLayout(false);
        appTableLayout3.ResumeLayout(false);
        appTableLayout3.PerformLayout();
        appGroupBox2.ResumeLayout(false);
        appTableLayout4.ResumeLayout(false);
        appTableLayout4.PerformLayout();
        appGroupBox3.ResumeLayout(false);
        appGroupBox3.PerformLayout();
        appPanel1.ResumeLayout(false);
        appPanel1.PerformLayout();
        appGroupBox4.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private ControlLibrary.Layouts.AppTableLayout appTableLayout1;
    private ControlLibrary.Containers.AppGroupBox appGroupBox1;
    private ControlLibrary.Layouts.AppTableLayout appTableLayout3;
    private ControlLibrary.Buttons.AppIconButton _buttonBrowseFolder;
    private ControlLibrary.Controls.AppTextBox _textBoxFolderPath;
    private ControlLibrary.Texts.AppLabel appLabel1;
    private ControlLibrary.Layouts.AppTableLayout appTableLayout4;
    private ControlLibrary.Texts.AppLabel _labelOutputFileName;
    private ControlLibrary.Texts.AppLabel appLabel3;
    private ControlLibrary.Controls.AppTextBox _textBoxOutputFileName;
    private ControlLibrary.Controls.AppTextBox _textBoxOutputFileDescription;
    private ControlLibrary.Layouts.AppTableLayout appTableLayout5;
    private ControlLibrary.Containers.AppGroupBox appGroupBox2;
    private ControlLibrary.Texts.AppNormalText appNormalText1;
    private ControlLibrary.Containers.AppGroupBox appGroupBox3;
    private ControlLibrary.Buttons.AppPrimaryButton _buttonStart;
    private ControlLibrary.Buttons.AppSecondaryButton _buttonSaveFormData;
    private ControlLibrary.Containers.AppGroupBox appGroupBox4;
    private ControlLibrary.Texts.AppRichTextBox _richTextBoxLogs;
    private CheckBox _checkBoxShouldKeepOriginalFileNameAndOnlyAppendFileDescription;
    private ControlLibrary.Texts.AppNormalText appNormalText3;
    private ControlLibrary.Containers.AppPanel appPanel1;
    private ControlLibrary.Controls.AppRadioButton _radioButtonShouldOrderFilesByName;
    private ControlLibrary.Controls.AppRadioButton _radioButtonShouldNotOrderFiles;
    private ControlLibrary.Controls.AppRadioButton _radioButtonShouldOrderFilesByLastModifiedDate;
    private ControlLibrary.Texts.AppNormalText appNormalText2;
    private ControlLibrary.Controls.AppRadioButton _radioButtonShouldOrderFilesByCreationDate;
    private CheckBox _checkBoxShouldIncludeTimeStampInTheFileName;
    private ControlLibrary.Texts.AppNormalText _labelTimeStampStringFormat;
    private ControlLibrary.Controls.AppTextBox _textBoxTimeStampStringFormat;
}