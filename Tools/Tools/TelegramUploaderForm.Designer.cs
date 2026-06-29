using Tools.ControlLibrary.Layouts;

namespace Tools;

partial class TelegramUploaderForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelegramUploaderForm));
        appTableLayout1 = new AppTableLayout();
        _buttonStart = new Tools.ControlLibrary.Buttons.AppPrimaryButton();
        _buttonSaveFormData = new Tools.ControlLibrary.Buttons.AppSecondaryButton();
        appTableLayout5 = new AppTableLayout();
        _groupBoxLogin = new Tools.ControlLibrary.Containers.AppGroupBox();
        appTableLayout2 = new AppTableLayout();
        appLabel1 = new Tools.ControlLibrary.Texts.AppLabel();
        appLabel2 = new Tools.ControlLibrary.Texts.AppLabel();
        _buttonLoginOrVerify = new Tools.ControlLibrary.Buttons.AppPrimaryButton();
        _textBoxAppId = new Tools.ControlLibrary.Controls.AppTextBox();
        _textBoxAppHashCode = new Tools.ControlLibrary.Controls.AppTextBox();
        _textBoxPhoneNumber = new Tools.ControlLibrary.Controls.AppTextBox();
        _textBoxVerificationCode = new Tools.ControlLibrary.Controls.AppTextBox();
        appLabel3 = new Tools.ControlLibrary.Texts.AppLabel();
        _labelVerificationCode = new Tools.ControlLibrary.Texts.AppLabel();
        _buttonLogOut = new Tools.ControlLibrary.Buttons.AppPrimaryButton();
        _groupBoxInput = new Tools.ControlLibrary.Containers.AppGroupBox();
        appTableLayout3 = new AppTableLayout();
        appTableLayout6 = new AppTableLayout();
        appLabel6 = new Tools.ControlLibrary.Texts.AppLabel();
        _comboBoxChats = new ComboBox();
        _buttonReloadChats = new Tools.ControlLibrary.Buttons.AppIconButton();
        appTableLayout4 = new AppTableLayout();
        _buttonBrowseFolder = new Tools.ControlLibrary.Buttons.AppIconButton();
        appLabel5 = new Tools.ControlLibrary.Texts.AppLabel();
        _textBoxInputFolderPath = new Tools.ControlLibrary.Controls.AppTextBox();
        appNormalText1 = new Tools.ControlLibrary.Texts.AppNormalText();
        _groupBoxOptions = new Tools.ControlLibrary.Containers.AppGroupBox();
        _textBoxUserSpecifiedExtensions = new Tools.ControlLibrary.Controls.AppTextBox();
        _checkBoxHasUserSpecifiedExtensions = new Tools.ControlLibrary.Controls.AppCheckBox();
        _checkBoxShouldDeleteSourceFileAfterUploading = new Tools.ControlLibrary.Controls.AppCheckBox();
        _checkBoxShouldIncludeNestedFiles = new Tools.ControlLibrary.Controls.AppCheckBox();
        appGroupBox4 = new Tools.ControlLibrary.Containers.AppGroupBox();
        _richTextBoxLogs = new Tools.ControlLibrary.Texts.AppRichTextBox();
        appTableLayout1.SuspendLayout();
        appTableLayout5.SuspendLayout();
        _groupBoxLogin.SuspendLayout();
        appTableLayout2.SuspendLayout();
        _groupBoxInput.SuspendLayout();
        appTableLayout3.SuspendLayout();
        appTableLayout6.SuspendLayout();
        appTableLayout4.SuspendLayout();
        _groupBoxOptions.SuspendLayout();
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
        appTableLayout1.TabIndex = 1;
        // 
        // _buttonStart
        // 
        _buttonStart.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        _buttonStart.BackColor = Color.SteelBlue;
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
        appTableLayout5.Controls.Add(_groupBoxLogin, 0, 0);
        appTableLayout5.Controls.Add(_groupBoxInput, 0, 1);
        appTableLayout5.Controls.Add(_groupBoxOptions, 0, 2);
        appTableLayout5.Location = new Point(0, 0);
        appTableLayout5.Margin = new Padding(0);
        appTableLayout5.Name = "appTableLayout5";
        appTableLayout5.RowCount = 3;
        appTableLayout5.RowStyles.Add(new RowStyle());
        appTableLayout5.RowStyles.Add(new RowStyle());
        appTableLayout5.RowStyles.Add(new RowStyle());
        appTableLayout5.Size = new Size(757, 698);
        appTableLayout5.TabIndex = 6;
        // 
        // _groupBoxLogin
        // 
        _groupBoxLogin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _groupBoxLogin.Controls.Add(appTableLayout2);
        _groupBoxLogin.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
        _groupBoxLogin.Location = new Point(0, 0);
        _groupBoxLogin.Margin = new Padding(0, 0, 9, 9);
        _groupBoxLogin.Name = "_groupBoxLogin";
        _groupBoxLogin.Padding = new Padding(9);
        _groupBoxLogin.Size = new Size(748, 253);
        _groupBoxLogin.TabIndex = 0;
        _groupBoxLogin.TabStop = false;
        _groupBoxLogin.Text = "LoginAndLoadChats";
        // 
        // appTableLayout2
        // 
        appTableLayout2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        appTableLayout2.ColumnCount = 2;
        appTableLayout2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        appTableLayout2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        appTableLayout2.Controls.Add(appLabel1, 0, 0);
        appTableLayout2.Controls.Add(appLabel2, 1, 0);
        appTableLayout2.Controls.Add(_buttonLoginOrVerify, 0, 4);
        appTableLayout2.Controls.Add(_textBoxAppId, 0, 1);
        appTableLayout2.Controls.Add(_textBoxAppHashCode, 1, 1);
        appTableLayout2.Controls.Add(_textBoxPhoneNumber, 0, 3);
        appTableLayout2.Controls.Add(_textBoxVerificationCode, 1, 3);
        appTableLayout2.Controls.Add(appLabel3, 0, 2);
        appTableLayout2.Controls.Add(_labelVerificationCode, 1, 2);
        appTableLayout2.Controls.Add(_buttonLogOut, 1, 4);
        appTableLayout2.Location = new Point(9, 33);
        appTableLayout2.Margin = new Padding(0);
        appTableLayout2.Name = "appTableLayout2";
        appTableLayout2.RowCount = 5;
        appTableLayout2.RowStyles.Add(new RowStyle());
        appTableLayout2.RowStyles.Add(new RowStyle());
        appTableLayout2.RowStyles.Add(new RowStyle());
        appTableLayout2.RowStyles.Add(new RowStyle());
        appTableLayout2.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
        appTableLayout2.Size = new Size(730, 211);
        appTableLayout2.TabIndex = 0;
        // 
        // appLabel1
        // 
        appLabel1.AutoSize = true;
        appLabel1.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
        appLabel1.Location = new Point(0, 0);
        appLabel1.Margin = new Padding(0, 0, 9, 9);
        appLabel1.Name = "appLabel1";
        appLabel1.Size = new Size(137, 25);
        appLabel1.TabIndex = 0;
        appLabel1.Text = "AppRequest ID";
        // 
        // appLabel2
        // 
        appLabel2.AutoSize = true;
        appLabel2.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
        appLabel2.Location = new Point(374, 0);
        appLabel2.Margin = new Padding(9, 0, 9, 9);
        appLabel2.Name = "appLabel2";
        appLabel2.Size = new Size(201, 25);
        appLabel2.TabIndex = 1;
        appLabel2.Text = "AppRequest hash code";
        // 
        // _buttonLoginOrVerify
        // 
        _buttonLoginOrVerify.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _buttonLoginOrVerify.BackColor = Color.SteelBlue;
        _buttonLoginOrVerify.FlatAppearance.MouseDownBackColor = Color.Black;
        _buttonLoginOrVerify.FlatAppearance.MouseOverBackColor = Color.Black;
        _buttonLoginOrVerify.FlatStyle = FlatStyle.Flat;
        _buttonLoginOrVerify.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
        _buttonLoginOrVerify.ForeColor = Color.White;
        _buttonLoginOrVerify.Location = new Point(0, 166);
        _buttonLoginOrVerify.Margin = new Padding(0, 0, 9, 0);
        _buttonLoginOrVerify.Name = "_buttonLoginOrVerify";
        _buttonLoginOrVerify.Size = new Size(356, 45);
        _buttonLoginOrVerify.TabIndex = 2;
        _buttonLoginOrVerify.Text = "Log in";
        _buttonLoginOrVerify.UseVisualStyleBackColor = false;
        _buttonLoginOrVerify.Click += ButtonLoginOrVerify_Click;
        // 
        // _textBoxAppId
        // 
        _textBoxAppId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _textBoxAppId.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
        _textBoxAppId.Location = new Point(0, 34);
        _textBoxAppId.Margin = new Padding(0, 0, 9, 18);
        _textBoxAppId.Name = "_textBoxAppId";
        _textBoxAppId.Size = new Size(356, 31);
        _textBoxAppId.TabIndex = 3;
        // 
        // _textBoxAppHashCode
        // 
        _textBoxAppHashCode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _textBoxAppHashCode.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
        _textBoxAppHashCode.Location = new Point(374, 34);
        _textBoxAppHashCode.Margin = new Padding(9, 0, 0, 0);
        _textBoxAppHashCode.Name = "_textBoxAppHashCode";
        _textBoxAppHashCode.Size = new Size(356, 31);
        _textBoxAppHashCode.TabIndex = 4;
        // 
        // _textBoxPhoneNumber
        // 
        _textBoxPhoneNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _textBoxPhoneNumber.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
        _textBoxPhoneNumber.Location = new Point(0, 117);
        _textBoxPhoneNumber.Margin = new Padding(0, 0, 9, 18);
        _textBoxPhoneNumber.Name = "_textBoxPhoneNumber";
        _textBoxPhoneNumber.Size = new Size(356, 31);
        _textBoxPhoneNumber.TabIndex = 5;
        // 
        // _textBoxVerificationCode
        // 
        _textBoxVerificationCode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _textBoxVerificationCode.Enabled = false;
        _textBoxVerificationCode.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
        _textBoxVerificationCode.Location = new Point(374, 117);
        _textBoxVerificationCode.Margin = new Padding(9, 0, 0, 0);
        _textBoxVerificationCode.Name = "_textBoxVerificationCode";
        _textBoxVerificationCode.Size = new Size(356, 31);
        _textBoxVerificationCode.TabIndex = 6;
        // 
        // appLabel3
        // 
        appLabel3.AutoSize = true;
        appLabel3.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
        appLabel3.Location = new Point(0, 83);
        appLabel3.Margin = new Padding(0, 0, 9, 9);
        appLabel3.Name = "appLabel3";
        appLabel3.Size = new Size(136, 25);
        appLabel3.TabIndex = 7;
        appLabel3.Text = "Phone number";
        // 
        // _labelVerificationCode
        // 
        _labelVerificationCode.AutoSize = true;
        _labelVerificationCode.Enabled = false;
        _labelVerificationCode.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
        _labelVerificationCode.Location = new Point(374, 83);
        _labelVerificationCode.Margin = new Padding(9, 0, 9, 9);
        _labelVerificationCode.Name = "_labelVerificationCode";
        _labelVerificationCode.Size = new Size(152, 25);
        _labelVerificationCode.TabIndex = 8;
        _labelVerificationCode.Text = "Verification code";
        // 
        // _buttonLogOut
        // 
        _buttonLogOut.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _buttonLogOut.BackColor = Color.SteelBlue;
        _buttonLogOut.Enabled = false;
        _buttonLogOut.FlatAppearance.MouseDownBackColor = Color.Black;
        _buttonLogOut.FlatAppearance.MouseOverBackColor = Color.Black;
        _buttonLogOut.FlatStyle = FlatStyle.Flat;
        _buttonLogOut.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
        _buttonLogOut.ForeColor = Color.White;
        _buttonLogOut.Location = new Point(374, 166);
        _buttonLogOut.Margin = new Padding(9, 0, 0, 0);
        _buttonLogOut.Name = "_buttonLogOut";
        _buttonLogOut.Size = new Size(356, 45);
        _buttonLogOut.TabIndex = 9;
        _buttonLogOut.Text = "Log out";
        _buttonLogOut.UseVisualStyleBackColor = false;
        _buttonLogOut.Click += ButtonLogOut_Click;
        // 
        // _groupBoxInput
        // 
        _groupBoxInput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        _groupBoxInput.Controls.Add(appTableLayout3);
        _groupBoxInput.Enabled = false;
        _groupBoxInput.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
        _groupBoxInput.Location = new Point(0, 262);
        _groupBoxInput.Margin = new Padding(0, 0, 9, 9);
        _groupBoxInput.Name = "_groupBoxInput";
        _groupBoxInput.Padding = new Padding(9);
        _groupBoxInput.Size = new Size(748, 156);
        _groupBoxInput.TabIndex = 1;
        _groupBoxInput.TabStop = false;
        _groupBoxInput.Text = "Input";
        // 
        // appTableLayout3
        // 
        appTableLayout3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        appTableLayout3.ColumnCount = 1;
        appTableLayout3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        appTableLayout3.Controls.Add(appTableLayout6, 0, 2);
        appTableLayout3.Controls.Add(appTableLayout4, 0, 0);
        appTableLayout3.Controls.Add(appNormalText1, 0, 1);
        appTableLayout3.Location = new Point(9, 33);
        appTableLayout3.Margin = new Padding(0);
        appTableLayout3.Name = "appTableLayout3";
        appTableLayout3.RowCount = 3;
        appTableLayout3.RowStyles.Add(new RowStyle());
        appTableLayout3.RowStyles.Add(new RowStyle());
        appTableLayout3.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
        appTableLayout3.Size = new Size(730, 114);
        appTableLayout3.TabIndex = 0;
        // 
        // appTableLayout6
        // 
        appTableLayout6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        appTableLayout6.ColumnCount = 3;
        appTableLayout6.ColumnStyles.Add(new ColumnStyle());
        appTableLayout6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        appTableLayout6.ColumnStyles.Add(new ColumnStyle());
        appTableLayout6.Controls.Add(appLabel6, 0, 0);
        appTableLayout6.Controls.Add(_comboBoxChats, 1, 0);
        appTableLayout6.Controls.Add(_buttonReloadChats, 2, 0);
        appTableLayout6.Location = new Point(0, 83);
        appTableLayout6.Margin = new Padding(0);
        appTableLayout6.Name = "appTableLayout6";
        appTableLayout6.RowCount = 1;
        appTableLayout6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        appTableLayout6.Size = new Size(730, 31);
        appTableLayout6.TabIndex = 2;
        // 
        // appLabel6
        // 
        appLabel6.AutoSize = true;
        appLabel6.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
        appLabel6.Location = new Point(0, 0);
        appLabel6.Margin = new Padding(0, 0, 9, 9);
        appLabel6.Name = "appLabel6";
        appLabel6.Size = new Size(101, 22);
        appLabel6.TabIndex = 0;
        appLabel6.Text = "Select chat";
        // 
        // _comboBoxChats
        // 
        _comboBoxChats.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _comboBoxChats.FormattingEnabled = true;
        _comboBoxChats.Location = new Point(110, 0);
        _comboBoxChats.Margin = new Padding(0);
        _comboBoxChats.Name = "_comboBoxChats";
        _comboBoxChats.Size = new Size(571, 31);
        _comboBoxChats.TabIndex = 1;
        // 
        // _buttonReloadChats
        // 
        _buttonReloadChats.BackColor = Color.Transparent;
        _buttonReloadChats.BackgroundImage = (Image)resources.GetObject("_buttonReloadChats.BackgroundImage");
        _buttonReloadChats.BackgroundImageLayout = ImageLayout.Stretch;
        _buttonReloadChats.FlatAppearance.BorderSize = 0;
        _buttonReloadChats.FlatAppearance.MouseDownBackColor = Color.Transparent;
        _buttonReloadChats.FlatAppearance.MouseOverBackColor = Color.Transparent;
        _buttonReloadChats.FlatStyle = FlatStyle.Flat;
        _buttonReloadChats.Location = new Point(699, 0);
        _buttonReloadChats.Margin = new Padding(18, 0, 0, 0);
        _buttonReloadChats.Name = "_buttonReloadChats";
        _buttonReloadChats.Size = new Size(31, 31);
        _buttonReloadChats.TabIndex = 3;
        _buttonReloadChats.UseVisualStyleBackColor = false;
        _buttonReloadChats.Click += ButtonReloadChats_Click;
        // 
        // appTableLayout4
        // 
        appTableLayout4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        appTableLayout4.ColumnCount = 3;
        appTableLayout4.ColumnStyles.Add(new ColumnStyle());
        appTableLayout4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        appTableLayout4.ColumnStyles.Add(new ColumnStyle());
        appTableLayout4.Controls.Add(_buttonBrowseFolder, 2, 0);
        appTableLayout4.Controls.Add(appLabel5, 0, 0);
        appTableLayout4.Controls.Add(_textBoxInputFolderPath, 1, 0);
        appTableLayout4.Location = new Point(0, 0);
        appTableLayout4.Margin = new Padding(0, 0, 0, 9);
        appTableLayout4.Name = "appTableLayout4";
        appTableLayout4.RowCount = 1;
        appTableLayout4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        appTableLayout4.Size = new Size(730, 31);
        appTableLayout4.TabIndex = 0;
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
        _buttonBrowseFolder.TabIndex = 2;
        _buttonBrowseFolder.UseVisualStyleBackColor = false;
        _buttonBrowseFolder.Click += ButtonBrowseFolder_Click;
        // 
        // appLabel5
        // 
        appLabel5.AutoSize = true;
        appLabel5.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
        appLabel5.Location = new Point(0, 0);
        appLabel5.Margin = new Padding(0, 0, 9, 9);
        appLabel5.Name = "appLabel5";
        appLabel5.Size = new Size(107, 22);
        appLabel5.TabIndex = 0;
        appLabel5.Text = "Folder path";
        // 
        // _textBoxInputFolderPath
        // 
        _textBoxInputFolderPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _textBoxInputFolderPath.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
        _textBoxInputFolderPath.Location = new Point(116, 0);
        _textBoxInputFolderPath.Margin = new Padding(0);
        _textBoxInputFolderPath.Name = "_textBoxInputFolderPath";
        _textBoxInputFolderPath.Size = new Size(565, 31);
        _textBoxInputFolderPath.TabIndex = 1;
        // 
        // appNormalText1
        // 
        appNormalText1.AutoSize = true;
        appNormalText1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
        appNormalText1.Location = new Point(0, 40);
        appNormalText1.Margin = new Padding(0, 0, 0, 18);
        appNormalText1.Name = "appNormalText1";
        appNormalText1.Size = new Size(442, 25);
        appNormalText1.TabIndex = 1;
        appNormalText1.Text = "Note: all files in this folder will be uploaded by default.";
        // 
        // _groupBoxOptions
        // 
        _groupBoxOptions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        _groupBoxOptions.Controls.Add(_textBoxUserSpecifiedExtensions);
        _groupBoxOptions.Controls.Add(_checkBoxHasUserSpecifiedExtensions);
        _groupBoxOptions.Controls.Add(_checkBoxShouldDeleteSourceFileAfterUploading);
        _groupBoxOptions.Controls.Add(_checkBoxShouldIncludeNestedFiles);
        _groupBoxOptions.Enabled = false;
        _groupBoxOptions.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
        _groupBoxOptions.Location = new Point(0, 427);
        _groupBoxOptions.Margin = new Padding(0, 0, 9, 0);
        _groupBoxOptions.Name = "_groupBoxOptions";
        _groupBoxOptions.Padding = new Padding(9);
        _groupBoxOptions.Size = new Size(748, 279);
        _groupBoxOptions.TabIndex = 2;
        _groupBoxOptions.TabStop = false;
        _groupBoxOptions.Text = "Options";
        // 
        // _textBoxUserSpecifiedExtensions
        // 
        _textBoxUserSpecifiedExtensions.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _textBoxUserSpecifiedExtensions.Enabled = false;
        _textBoxUserSpecifiedExtensions.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
        _textBoxUserSpecifiedExtensions.Location = new Point(9, 71);
        _textBoxUserSpecifiedExtensions.Margin = new Padding(0, 0, 0, 9);
        _textBoxUserSpecifiedExtensions.Name = "_textBoxUserSpecifiedExtensions";
        _textBoxUserSpecifiedExtensions.PlaceholderText = ".txt, .mp4";
        _textBoxUserSpecifiedExtensions.Size = new Size(730, 31);
        _textBoxUserSpecifiedExtensions.TabIndex = 3;
        // 
        // _checkBoxHasUserSpecifiedExtensions
        // 
        _checkBoxHasUserSpecifiedExtensions.AutoSize = true;
        _checkBoxHasUserSpecifiedExtensions.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
        _checkBoxHasUserSpecifiedExtensions.Location = new Point(9, 33);
        _checkBoxHasUserSpecifiedExtensions.Margin = new Padding(0, 0, 0, 9);
        _checkBoxHasUserSpecifiedExtensions.Name = "_checkBoxHasUserSpecifiedExtensions";
        _checkBoxHasUserSpecifiedExtensions.Size = new Size(513, 29);
        _checkBoxHasUserSpecifiedExtensions.TabIndex = 2;
        _checkBoxHasUserSpecifiedExtensions.Text = "Only files matching these extensions (separated by commas):";
        _checkBoxHasUserSpecifiedExtensions.UseVisualStyleBackColor = true;
        _checkBoxHasUserSpecifiedExtensions.CheckedChanged += CheckBoxHasUserSpecifiedExtensions_CheckedChanged;
        // 
        // _checkBoxShouldDeleteSourceFileAfterUploading
        // 
        _checkBoxShouldDeleteSourceFileAfterUploading.AutoSize = true;
        _checkBoxShouldDeleteSourceFileAfterUploading.Checked = true;
        _checkBoxShouldDeleteSourceFileAfterUploading.CheckState = CheckState.Checked;
        _checkBoxShouldDeleteSourceFileAfterUploading.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
        _checkBoxShouldDeleteSourceFileAfterUploading.Location = new Point(9, 149);
        _checkBoxShouldDeleteSourceFileAfterUploading.Margin = new Padding(0);
        _checkBoxShouldDeleteSourceFileAfterUploading.Name = "_checkBoxShouldDeleteSourceFileAfterUploading";
        _checkBoxShouldDeleteSourceFileAfterUploading.Size = new Size(323, 29);
        _checkBoxShouldDeleteSourceFileAfterUploading.TabIndex = 1;
        _checkBoxShouldDeleteSourceFileAfterUploading.Text = "Delete the source file after uploading";
        _checkBoxShouldDeleteSourceFileAfterUploading.UseVisualStyleBackColor = true;
        // 
        // _checkBoxShouldIncludeNestedFiles
        // 
        _checkBoxShouldIncludeNestedFiles.AutoSize = true;
        _checkBoxShouldIncludeNestedFiles.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
        _checkBoxShouldIncludeNestedFiles.Location = new Point(9, 111);
        _checkBoxShouldIncludeNestedFiles.Margin = new Padding(0, 0, 0, 9);
        _checkBoxShouldIncludeNestedFiles.Name = "_checkBoxShouldIncludeNestedFiles";
        _checkBoxShouldIncludeNestedFiles.Size = new Size(291, 29);
        _checkBoxShouldIncludeNestedFiles.TabIndex = 0;
        _checkBoxShouldIncludeNestedFiles.Text = "Include files in the nested folders";
        _checkBoxShouldIncludeNestedFiles.UseVisualStyleBackColor = true;
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
        // TelegramUploaderForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1551, 850);
        Controls.Add(appTableLayout1);
        Name = "TelegramUploaderForm";
        Padding = new Padding(18);
        Text = "TelegramUploader";
        Load += TelegramUploaderForm_Load;
        appTableLayout1.ResumeLayout(false);
        appTableLayout5.ResumeLayout(false);
        _groupBoxLogin.ResumeLayout(false);
        appTableLayout2.ResumeLayout(false);
        appTableLayout2.PerformLayout();
        _groupBoxInput.ResumeLayout(false);
        appTableLayout3.ResumeLayout(false);
        appTableLayout3.PerformLayout();
        appTableLayout6.ResumeLayout(false);
        appTableLayout6.PerformLayout();
        appTableLayout4.ResumeLayout(false);
        appTableLayout4.PerformLayout();
        _groupBoxOptions.ResumeLayout(false);
        _groupBoxOptions.PerformLayout();
        appGroupBox4.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private AppTableLayout appTableLayout1;
    private ControlLibrary.Buttons.AppPrimaryButton _buttonStart;
    private ControlLibrary.Buttons.AppSecondaryButton _buttonSaveFormData;
    private AppTableLayout appTableLayout5;
    private ControlLibrary.Containers.AppGroupBox _groupBoxLogin;
    private ControlLibrary.Containers.AppGroupBox appGroupBox4;
    private AppTableLayout appTableLayout2;
    private ControlLibrary.Texts.AppLabel appLabel1;
    private ControlLibrary.Texts.AppLabel appLabel2;
    private ControlLibrary.Buttons.AppPrimaryButton _buttonLoginOrVerify;
    private ControlLibrary.Controls.AppTextBox _textBoxAppId;
    private ControlLibrary.Controls.AppTextBox _textBoxAppHashCode;
    private ControlLibrary.Controls.AppTextBox _textBoxPhoneNumber;
    private ControlLibrary.Controls.AppTextBox _textBoxVerificationCode;
    private ControlLibrary.Texts.AppLabel appLabel3;
    private ControlLibrary.Texts.AppLabel _labelVerificationCode;
    private ControlLibrary.Containers.AppGroupBox _groupBoxInput;
    private ControlLibrary.Containers.AppGroupBox _groupBoxOptions;
    private AppTableLayout appTableLayout3;
    private AppTableLayout appTableLayout4;
    private ControlLibrary.Texts.AppLabel appLabel5;
    private ControlLibrary.Controls.AppTextBox _textBoxInputFolderPath;
    private ControlLibrary.Buttons.AppIconButton _buttonBrowseFolder;
    private ControlLibrary.Texts.AppNormalText appNormalText1;
    private AppTableLayout appTableLayout6;
    private ControlLibrary.Texts.AppLabel appLabel6;
    private ComboBox _comboBoxChats;
    private ControlLibrary.Controls.AppCheckBox _checkBoxShouldDeleteSourceFileAfterUploading;
    private ControlLibrary.Controls.AppCheckBox _checkBoxShouldIncludeNestedFiles;
    private ControlLibrary.Texts.AppRichTextBox _richTextBoxLogs;
    private ControlLibrary.Buttons.AppPrimaryButton _buttonLogOut;
    private ControlLibrary.Buttons.AppIconButton _buttonReloadChats;
    private ControlLibrary.Controls.AppCheckBox _checkBoxHasUserSpecifiedExtensions;
    private ControlLibrary.Controls.AppTextBox _textBoxUserSpecifiedExtensions;
}