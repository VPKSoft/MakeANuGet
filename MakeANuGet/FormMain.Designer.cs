namespace MakeANuGet
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenProject = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveChanges = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFillWithDefaults = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateNuGetEXE = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEnterAPIKeys = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCertificateSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTest = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odCSProj = new System.Windows.Forms.OpenFileDialog();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpIcon = new System.Windows.Forms.TableLayoutPanel();
            this.btIconFile = new System.Windows.Forms.Button();
            this.lbIcon = new System.Windows.Forms.Label();
            this.tbIcon = new System.Windows.Forms.TextBox();
            this.tbIconTarget = new System.Windows.Forms.TextBox();
            this.tlpUseCodeSigningCertificate = new System.Windows.Forms.TableLayoutPanel();
            this.lbUseCodeSigningCertificate = new System.Windows.Forms.Label();
            this.cbUseCodeSigningCertificate = new System.Windows.Forms.CheckBox();
            this.tlpLicenseFileOrType = new System.Windows.Forms.TableLayoutPanel();
            this.lbLicenseFileOrType = new System.Windows.Forms.Label();
            this.tbLicenseFile = new System.Windows.Forms.TextBox();
            this.btLicenseFile = new System.Windows.Forms.Button();
            this.btSelectLicenseByType = new System.Windows.Forms.Button();
            this.btAddLicenseByType = new System.Windows.Forms.Button();
            this.tbLicenseFileTarget = new System.Windows.Forms.TextBox();
            this.tlpRequireLicenseAcceptance = new System.Windows.Forms.TableLayoutPanel();
            this.lbRequireLicenseAcceptance = new System.Windows.Forms.Label();
            this.cbRequireLicenseAcceptance = new System.Windows.Forms.CheckBox();
            this.tlpDescription = new System.Windows.Forms.TableLayoutPanel();
            this.lbDescription = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tlpCopyright = new System.Windows.Forms.TableLayoutPanel();
            this.lbCopyright = new System.Windows.Forms.Label();
            this.tbCopyright = new System.Windows.Forms.TextBox();
            this.tlpReleaseNotes = new System.Windows.Forms.TableLayoutPanel();
            this.lbReleaseNotes = new System.Windows.Forms.Label();
            this.tbReleaseNotes = new System.Windows.Forms.TextBox();
            this.tlpProjectURL = new System.Windows.Forms.TableLayoutPanel();
            this.lbProjectURL = new System.Windows.Forms.Label();
            this.tbProjectURL = new System.Windows.Forms.TextBox();
            this.tlpTags = new System.Windows.Forms.TableLayoutPanel();
            this.lbTags = new System.Windows.Forms.Label();
            this.tbTags = new System.Windows.Forms.TextBox();
            this.tlpApiKey = new System.Windows.Forms.TableLayoutPanel();
            this.btApiKey = new System.Windows.Forms.Button();
            this.lbApiKey = new System.Windows.Forms.Label();
            this.pnToggleApiKeyVisible = new System.Windows.Forms.Panel();
            this.tlpNuGetSteps = new System.Windows.Forms.TableLayoutPanel();
            this.pnNO1 = new System.Windows.Forms.Panel();
            this.pnNO2 = new System.Windows.Forms.Panel();
            this.pnNO3 = new System.Windows.Forms.Panel();
            this.btGenerateNuget = new System.Windows.Forms.Button();
            this.btGenerateNugetPackage = new System.Windows.Forms.Button();
            this.btPushNugetPackage = new System.Windows.Forms.Button();
            this.cbForceNuspec = new System.Windows.Forms.CheckBox();
            this.cbTestNuGet = new System.Windows.Forms.CheckBox();
            this.tlpProcessOutput = new System.Windows.Forms.TableLayoutPanel();
            this.lbProcessOutput = new System.Windows.Forms.Label();
            this.tbProcessOutput = new System.Windows.Forms.TextBox();
            this.odAnyFile = new System.Windows.Forms.OpenFileDialog();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.tabDeprecated = new System.Windows.Forms.TabPage();
            this.tlpDeprecated = new System.Windows.Forms.TableLayoutPanel();
            this.tlpIconURL = new System.Windows.Forms.TableLayoutPanel();
            this.btClearIconUrl = new System.Windows.Forms.Button();
            this.lbIconURL = new System.Windows.Forms.Label();
            this.tbIconURL = new System.Windows.Forms.TextBox();
            this.tlpLicenseURL = new System.Windows.Forms.TableLayoutPanel();
            this.lbLicenseUrl = new System.Windows.Forms.Label();
            this.tbLicenseUrl = new System.Windows.Forms.TextBox();
            this.btClearLicenseUrl = new System.Windows.Forms.Button();
            this.tabContent = new System.Windows.Forms.TabPage();
            this.lbHelpLink2 = new System.Windows.Forms.Label();
            this.lbAnd = new System.Windows.Forms.Label();
            this.lbHelpLink1 = new System.Windows.Forms.Label();
            this.lbForHelp = new System.Windows.Forms.Label();
            this.btUndoFileChanges = new System.Windows.Forms.Button();
            this.btSaveFileChanges = new System.Windows.Forms.Button();
            this.lbFiles = new System.Windows.Forms.Label();
            this.dgvFiles = new System.Windows.Forms.DataGridView();
            this.colFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSelectFile = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colExcludePattern = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuildAction = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colCopyToOutput = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colFlatten = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colTarget = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUseContentElement = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabNuspec = new System.Windows.Forms.TabPage();
            this.btSaveXMLChanges = new System.Windows.Forms.Button();
            this.scintillaNuspecContents = new ScintillaNET.Scintilla();
            this.odIconFile = new System.Windows.Forms.OpenFileDialog();
            this.ttMain = new System.Windows.Forms.ToolTip(this.components);
            this.tlpMainContainer = new System.Windows.Forms.TableLayoutPanel();
            this.mnuMain.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.tlpIcon.SuspendLayout();
            this.tlpUseCodeSigningCertificate.SuspendLayout();
            this.tlpLicenseFileOrType.SuspendLayout();
            this.tlpRequireLicenseAcceptance.SuspendLayout();
            this.tlpDescription.SuspendLayout();
            this.tlpCopyright.SuspendLayout();
            this.tlpReleaseNotes.SuspendLayout();
            this.tlpProjectURL.SuspendLayout();
            this.tlpTags.SuspendLayout();
            this.tlpApiKey.SuspendLayout();
            this.tlpNuGetSteps.SuspendLayout();
            this.tlpProcessOutput.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabDeprecated.SuspendLayout();
            this.tlpDeprecated.SuspendLayout();
            this.tlpIconURL.SuspendLayout();
            this.tlpLicenseURL.SuspendLayout();
            this.tabContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).BeginInit();
            this.tabNuspec.SuspendLayout();
            this.tlpMainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.aboutToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(988, 24);
            this.mnuMain.TabIndex = 1;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpenProject,
            this.mnuSaveChanges,
            this.mnuFillWithDefaults,
            this.mnuUpdateNuGetEXE,
            this.mnuEnterAPIKeys,
            this.mnuCertificateSettings,
            this.mnuTest});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuOpenProject
            // 
            this.mnuOpenProject.Name = "mnuOpenProject";
            this.mnuOpenProject.Size = new System.Drawing.Size(172, 22);
            this.mnuOpenProject.Text = "Open Project";
            this.mnuOpenProject.Click += new System.EventHandler(this.mnuOpenProject_Click);
            // 
            // mnuSaveChanges
            // 
            this.mnuSaveChanges.Enabled = false;
            this.mnuSaveChanges.Name = "mnuSaveChanges";
            this.mnuSaveChanges.Size = new System.Drawing.Size(172, 22);
            this.mnuSaveChanges.Text = "Save changes";
            this.mnuSaveChanges.Click += new System.EventHandler(this.mnuSaveChanges_Click);
            // 
            // mnuFillWithDefaults
            // 
            this.mnuFillWithDefaults.Enabled = false;
            this.mnuFillWithDefaults.Name = "mnuFillWithDefaults";
            this.mnuFillWithDefaults.Size = new System.Drawing.Size(172, 22);
            this.mnuFillWithDefaults.Text = "Fill with defaults";
            this.mnuFillWithDefaults.Click += new System.EventHandler(this.mnuFillWithDefaults_Click);
            // 
            // mnuUpdateNuGetEXE
            // 
            this.mnuUpdateNuGetEXE.Name = "mnuUpdateNuGetEXE";
            this.mnuUpdateNuGetEXE.Size = new System.Drawing.Size(172, 22);
            this.mnuUpdateNuGetEXE.Text = "Update nuget.exe";
            this.mnuUpdateNuGetEXE.Click += new System.EventHandler(this.mnuUpdateNuGetEXE_Click);
            // 
            // mnuEnterAPIKeys
            // 
            this.mnuEnterAPIKeys.Name = "mnuEnterAPIKeys";
            this.mnuEnterAPIKeys.Size = new System.Drawing.Size(172, 22);
            this.mnuEnterAPIKeys.Text = "Enter API key(s)";
            this.mnuEnterAPIKeys.Click += new System.EventHandler(this.mnuEnterAPIKeys_Click);
            // 
            // mnuCertificateSettings
            // 
            this.mnuCertificateSettings.Name = "mnuCertificateSettings";
            this.mnuCertificateSettings.Size = new System.Drawing.Size(172, 22);
            this.mnuCertificateSettings.Text = "Certificate settings";
            this.mnuCertificateSettings.Click += new System.EventHandler(this.MnuCertificateSettings_Click);
            // 
            // mnuTest
            // 
            this.mnuTest.Name = "mnuTest";
            this.mnuTest.Size = new System.Drawing.Size(172, 22);
            this.mnuTest.Text = "Test";
            this.mnuTest.Click += new System.EventHandler(this.mnuTest_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // odCSProj
            // 
            this.odCSProj.DefaultExt = "*.csproj";
            this.odCSProj.Filter = "C# Project Files (*.csproj)|*.csproj";
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Controls.Add(this.tlpIcon, 0, 5);
            this.tlpMain.Controls.Add(this.tlpUseCodeSigningCertificate, 0, 10);
            this.tlpMain.Controls.Add(this.tlpLicenseFileOrType, 0, 3);
            this.tlpMain.Controls.Add(this.tlpRequireLicenseAcceptance, 0, 9);
            this.tlpMain.Controls.Add(this.tlpDescription, 0, 8);
            this.tlpMain.Controls.Add(this.tlpCopyright, 0, 7);
            this.tlpMain.Controls.Add(this.tlpReleaseNotes, 0, 6);
            this.tlpMain.Controls.Add(this.tlpProjectURL, 0, 4);
            this.tlpMain.Controls.Add(this.tlpTags, 0, 2);
            this.tlpMain.Controls.Add(this.tlpApiKey, 0, 0);
            this.tlpMain.Controls.Add(this.tlpNuGetSteps, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(3, 3);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 12;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(944, 363);
            this.tlpMain.TabIndex = 2;
            // 
            // tlpIcon
            // 
            this.tlpIcon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpIcon.AutoSize = true;
            this.tlpIcon.ColumnCount = 4;
            this.tlpMain.SetColumnSpan(this.tlpIcon, 2);
            this.tlpIcon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpIcon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlpIcon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tlpIcon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpIcon.Controls.Add(this.btIconFile, 3, 0);
            this.tlpIcon.Controls.Add(this.lbIcon, 0, 0);
            this.tlpIcon.Controls.Add(this.tbIcon, 1, 0);
            this.tlpIcon.Controls.Add(this.tbIconTarget, 2, 0);
            this.tlpIcon.Location = new System.Drawing.Point(3, 179);
            this.tlpIcon.Name = "tlpIcon";
            this.tlpIcon.RowCount = 1;
            this.tlpIcon.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpIcon.Size = new System.Drawing.Size(938, 26);
            this.tlpIcon.TabIndex = 13;
            // 
            // btIconFile
            // 
            this.btIconFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btIconFile.Location = new System.Drawing.Point(893, 3);
            this.btIconFile.Name = "btIconFile";
            this.btIconFile.Size = new System.Drawing.Size(42, 20);
            this.btIconFile.TabIndex = 3;
            this.btIconFile.Text = "...";
            this.btIconFile.UseVisualStyleBackColor = true;
            this.btIconFile.Click += new System.EventHandler(this.btLicenseFile_Click);
            // 
            // lbIcon
            // 
            this.lbIcon.AutoSize = true;
            this.lbIcon.Location = new System.Drawing.Point(3, 0);
            this.lbIcon.Name = "lbIcon";
            this.lbIcon.Size = new System.Drawing.Size(31, 13);
            this.lbIcon.TabIndex = 0;
            this.lbIcon.Text = "Icon:";
            this.lbIcon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbIcon
            // 
            this.tbIcon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIcon.Location = new System.Drawing.Point(284, 3);
            this.tbIcon.Name = "tbIcon";
            this.tbIcon.Size = new System.Drawing.Size(303, 20);
            this.tbIcon.TabIndex = 1;
            // 
            // tbIconTarget
            // 
            this.tbIconTarget.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIconTarget.Location = new System.Drawing.Point(593, 3);
            this.tbIconTarget.Name = "tbIconTarget";
            this.tbIconTarget.Size = new System.Drawing.Size(294, 20);
            this.tbIconTarget.TabIndex = 4;
            this.tbIconTarget.TextChanged += new System.EventHandler(this.btLicenseFile_Click);
            // 
            // tlpUseCodeSigningCertificate
            // 
            this.tlpUseCodeSigningCertificate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpUseCodeSigningCertificate.AutoSize = true;
            this.tlpUseCodeSigningCertificate.ColumnCount = 2;
            this.tlpMain.SetColumnSpan(this.tlpUseCodeSigningCertificate, 2);
            this.tlpUseCodeSigningCertificate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpUseCodeSigningCertificate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpUseCodeSigningCertificate.Controls.Add(this.lbUseCodeSigningCertificate, 0, 0);
            this.tlpUseCodeSigningCertificate.Controls.Add(this.cbUseCodeSigningCertificate, 1, 0);
            this.tlpUseCodeSigningCertificate.Location = new System.Drawing.Point(3, 333);
            this.tlpUseCodeSigningCertificate.Name = "tlpUseCodeSigningCertificate";
            this.tlpUseCodeSigningCertificate.RowCount = 1;
            this.tlpUseCodeSigningCertificate.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpUseCodeSigningCertificate.Size = new System.Drawing.Size(938, 20);
            this.tlpUseCodeSigningCertificate.TabIndex = 12;
            // 
            // lbUseCodeSigningCertificate
            // 
            this.lbUseCodeSigningCertificate.AutoSize = true;
            this.lbUseCodeSigningCertificate.Location = new System.Drawing.Point(3, 0);
            this.lbUseCodeSigningCertificate.Name = "lbUseCodeSigningCertificate";
            this.lbUseCodeSigningCertificate.Size = new System.Drawing.Size(141, 13);
            this.lbUseCodeSigningCertificate.TabIndex = 0;
            this.lbUseCodeSigningCertificate.Text = "Use code signing certificate:";
            this.lbUseCodeSigningCertificate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbUseCodeSigningCertificate
            // 
            this.cbUseCodeSigningCertificate.AutoSize = true;
            this.cbUseCodeSigningCertificate.Location = new System.Drawing.Point(284, 3);
            this.cbUseCodeSigningCertificate.Name = "cbUseCodeSigningCertificate";
            this.cbUseCodeSigningCertificate.Size = new System.Drawing.Size(15, 14);
            this.cbUseCodeSigningCertificate.TabIndex = 1;
            this.cbUseCodeSigningCertificate.UseVisualStyleBackColor = true;
            this.cbUseCodeSigningCertificate.CheckedChanged += new System.EventHandler(this.CbUseCodeSigningCertificate_CheckedChanged);
            // 
            // tlpLicenseFileOrType
            // 
            this.tlpLicenseFileOrType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpLicenseFileOrType.AutoSize = true;
            this.tlpLicenseFileOrType.ColumnCount = 6;
            this.tlpMain.SetColumnSpan(this.tlpLicenseFileOrType, 2);
            this.tlpLicenseFileOrType.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpLicenseFileOrType.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlpLicenseFileOrType.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tlpLicenseFileOrType.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpLicenseFileOrType.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpLicenseFileOrType.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpLicenseFileOrType.Controls.Add(this.lbLicenseFileOrType, 0, 0);
            this.tlpLicenseFileOrType.Controls.Add(this.tbLicenseFile, 1, 0);
            this.tlpLicenseFileOrType.Controls.Add(this.btLicenseFile, 3, 0);
            this.tlpLicenseFileOrType.Controls.Add(this.btSelectLicenseByType, 4, 0);
            this.tlpLicenseFileOrType.Controls.Add(this.btAddLicenseByType, 5, 0);
            this.tlpLicenseFileOrType.Controls.Add(this.tbLicenseFileTarget, 2, 0);
            this.tlpLicenseFileOrType.Location = new System.Drawing.Point(3, 112);
            this.tlpLicenseFileOrType.Name = "tlpLicenseFileOrType";
            this.tlpLicenseFileOrType.RowCount = 1;
            this.tlpLicenseFileOrType.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpLicenseFileOrType.Size = new System.Drawing.Size(938, 29);
            this.tlpLicenseFileOrType.TabIndex = 11;
            // 
            // lbLicenseFileOrType
            // 
            this.lbLicenseFileOrType.AutoSize = true;
            this.lbLicenseFileOrType.Location = new System.Drawing.Point(3, 0);
            this.lbLicenseFileOrType.Name = "lbLicenseFileOrType";
            this.lbLicenseFileOrType.Size = new System.Drawing.Size(98, 13);
            this.lbLicenseFileOrType.TabIndex = 0;
            this.lbLicenseFileOrType.Text = "License file or type:";
            this.lbLicenseFileOrType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbLicenseFile
            // 
            this.tbLicenseFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLicenseFile.Location = new System.Drawing.Point(284, 3);
            this.tbLicenseFile.Name = "tbLicenseFile";
            this.tbLicenseFile.Size = new System.Drawing.Size(303, 20);
            this.tbLicenseFile.TabIndex = 1;
            // 
            // btLicenseFile
            // 
            this.btLicenseFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btLicenseFile.Location = new System.Drawing.Point(799, 3);
            this.btLicenseFile.Name = "btLicenseFile";
            this.btLicenseFile.Size = new System.Drawing.Size(40, 23);
            this.btLicenseFile.TabIndex = 2;
            this.btLicenseFile.Text = "...";
            this.btLicenseFile.UseVisualStyleBackColor = true;
            this.btLicenseFile.Click += new System.EventHandler(this.btLicenseFile_Click);
            // 
            // btSelectLicenseByType
            // 
            this.btSelectLicenseByType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btSelectLicenseByType.Location = new System.Drawing.Point(845, 3);
            this.btSelectLicenseByType.Name = "btSelectLicenseByType";
            this.btSelectLicenseByType.Size = new System.Drawing.Size(40, 23);
            this.btSelectLicenseByType.TabIndex = 3;
            this.btSelectLicenseByType.Text = "§";
            this.btSelectLicenseByType.UseVisualStyleBackColor = true;
            this.btSelectLicenseByType.Click += new System.EventHandler(this.btSelectLicenseByType_Click);
            // 
            // btAddLicenseByType
            // 
            this.btAddLicenseByType.Location = new System.Drawing.Point(891, 3);
            this.btAddLicenseByType.Name = "btAddLicenseByType";
            this.btAddLicenseByType.Size = new System.Drawing.Size(43, 23);
            this.btAddLicenseByType.TabIndex = 4;
            this.btAddLicenseByType.Text = "+§";
            this.btAddLicenseByType.UseVisualStyleBackColor = true;
            this.btAddLicenseByType.Click += new System.EventHandler(this.btAddLicenseByType_Click);
            // 
            // tbLicenseFileTarget
            // 
            this.tbLicenseFileTarget.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLicenseFileTarget.Location = new System.Drawing.Point(593, 3);
            this.tbLicenseFileTarget.Name = "tbLicenseFileTarget";
            this.tbLicenseFileTarget.Size = new System.Drawing.Size(200, 20);
            this.tbLicenseFileTarget.TabIndex = 5;
            // 
            // tlpRequireLicenseAcceptance
            // 
            this.tlpRequireLicenseAcceptance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpRequireLicenseAcceptance.AutoSize = true;
            this.tlpRequireLicenseAcceptance.ColumnCount = 2;
            this.tlpMain.SetColumnSpan(this.tlpRequireLicenseAcceptance, 2);
            this.tlpRequireLicenseAcceptance.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpRequireLicenseAcceptance.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpRequireLicenseAcceptance.Controls.Add(this.lbRequireLicenseAcceptance, 0, 0);
            this.tlpRequireLicenseAcceptance.Controls.Add(this.cbRequireLicenseAcceptance, 1, 0);
            this.tlpRequireLicenseAcceptance.Location = new System.Drawing.Point(3, 307);
            this.tlpRequireLicenseAcceptance.Name = "tlpRequireLicenseAcceptance";
            this.tlpRequireLicenseAcceptance.RowCount = 1;
            this.tlpRequireLicenseAcceptance.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpRequireLicenseAcceptance.Size = new System.Drawing.Size(938, 20);
            this.tlpRequireLicenseAcceptance.TabIndex = 10;
            // 
            // lbRequireLicenseAcceptance
            // 
            this.lbRequireLicenseAcceptance.AutoSize = true;
            this.lbRequireLicenseAcceptance.Location = new System.Drawing.Point(3, 0);
            this.lbRequireLicenseAcceptance.Name = "lbRequireLicenseAcceptance";
            this.lbRequireLicenseAcceptance.Size = new System.Drawing.Size(143, 13);
            this.lbRequireLicenseAcceptance.TabIndex = 0;
            this.lbRequireLicenseAcceptance.Text = "Require license acceptance:";
            this.lbRequireLicenseAcceptance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbRequireLicenseAcceptance
            // 
            this.cbRequireLicenseAcceptance.AutoSize = true;
            this.cbRequireLicenseAcceptance.Location = new System.Drawing.Point(284, 3);
            this.cbRequireLicenseAcceptance.Name = "cbRequireLicenseAcceptance";
            this.cbRequireLicenseAcceptance.Size = new System.Drawing.Size(15, 14);
            this.cbRequireLicenseAcceptance.TabIndex = 1;
            this.cbRequireLicenseAcceptance.Tag = "requireLicenseAcceptance";
            this.cbRequireLicenseAcceptance.UseVisualStyleBackColor = true;
            this.cbRequireLicenseAcceptance.CheckedChanged += new System.EventHandler(this.cbRequireLicenseAcceptance_CheckedChanged);
            // 
            // tlpDescription
            // 
            this.tlpDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpDescription.AutoSize = true;
            this.tlpDescription.ColumnCount = 2;
            this.tlpMain.SetColumnSpan(this.tlpDescription, 2);
            this.tlpDescription.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpDescription.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpDescription.Controls.Add(this.lbDescription, 0, 0);
            this.tlpDescription.Controls.Add(this.tbDescription, 1, 0);
            this.tlpDescription.Location = new System.Drawing.Point(3, 275);
            this.tlpDescription.Name = "tlpDescription";
            this.tlpDescription.RowCount = 1;
            this.tlpDescription.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDescription.Size = new System.Drawing.Size(938, 26);
            this.tlpDescription.TabIndex = 9;
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(3, 0);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(63, 13);
            this.lbDescription.TabIndex = 0;
            this.lbDescription.Text = "Description:";
            this.lbDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbDescription
            // 
            this.tbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDescription.Location = new System.Drawing.Point(284, 3);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(651, 20);
            this.tbDescription.TabIndex = 1;
            this.tbDescription.Tag = "description";
            this.tbDescription.TextChanged += new System.EventHandler(this.tbSimpleElement_TextChanged);
            // 
            // tlpCopyright
            // 
            this.tlpCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpCopyright.AutoSize = true;
            this.tlpCopyright.ColumnCount = 2;
            this.tlpMain.SetColumnSpan(this.tlpCopyright, 2);
            this.tlpCopyright.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpCopyright.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpCopyright.Controls.Add(this.lbCopyright, 0, 0);
            this.tlpCopyright.Controls.Add(this.tbCopyright, 1, 0);
            this.tlpCopyright.Location = new System.Drawing.Point(3, 243);
            this.tlpCopyright.Name = "tlpCopyright";
            this.tlpCopyright.RowCount = 1;
            this.tlpCopyright.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCopyright.Size = new System.Drawing.Size(938, 26);
            this.tlpCopyright.TabIndex = 8;
            // 
            // lbCopyright
            // 
            this.lbCopyright.AutoSize = true;
            this.lbCopyright.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbCopyright.Location = new System.Drawing.Point(3, 0);
            this.lbCopyright.Name = "lbCopyright";
            this.lbCopyright.Size = new System.Drawing.Size(51, 13);
            this.lbCopyright.TabIndex = 0;
            this.lbCopyright.Text = "Copyright";
            this.lbCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ttMain.SetToolTip(this.lbCopyright, "Click to add the copyright sign");
            this.lbCopyright.Click += new System.EventHandler(this.lbCopyright_Click);
            // 
            // tbCopyright
            // 
            this.tbCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCopyright.Location = new System.Drawing.Point(284, 3);
            this.tbCopyright.Name = "tbCopyright";
            this.tbCopyright.Size = new System.Drawing.Size(651, 20);
            this.tbCopyright.TabIndex = 1;
            this.tbCopyright.Tag = "copyright";
            this.tbCopyright.TextChanged += new System.EventHandler(this.tbSimpleElement_TextChanged);
            // 
            // tlpReleaseNotes
            // 
            this.tlpReleaseNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpReleaseNotes.AutoSize = true;
            this.tlpReleaseNotes.ColumnCount = 2;
            this.tlpMain.SetColumnSpan(this.tlpReleaseNotes, 2);
            this.tlpReleaseNotes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpReleaseNotes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpReleaseNotes.Controls.Add(this.lbReleaseNotes, 0, 0);
            this.tlpReleaseNotes.Controls.Add(this.tbReleaseNotes, 1, 0);
            this.tlpReleaseNotes.Location = new System.Drawing.Point(3, 211);
            this.tlpReleaseNotes.Name = "tlpReleaseNotes";
            this.tlpReleaseNotes.RowCount = 1;
            this.tlpReleaseNotes.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpReleaseNotes.Size = new System.Drawing.Size(938, 26);
            this.tlpReleaseNotes.TabIndex = 7;
            // 
            // lbReleaseNotes
            // 
            this.lbReleaseNotes.AutoSize = true;
            this.lbReleaseNotes.Location = new System.Drawing.Point(3, 0);
            this.lbReleaseNotes.Name = "lbReleaseNotes";
            this.lbReleaseNotes.Size = new System.Drawing.Size(78, 13);
            this.lbReleaseNotes.TabIndex = 0;
            this.lbReleaseNotes.Text = "Release notes:";
            this.lbReleaseNotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbReleaseNotes
            // 
            this.tbReleaseNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbReleaseNotes.Location = new System.Drawing.Point(284, 3);
            this.tbReleaseNotes.Name = "tbReleaseNotes";
            this.tbReleaseNotes.Size = new System.Drawing.Size(651, 20);
            this.tbReleaseNotes.TabIndex = 1;
            this.tbReleaseNotes.Tag = "releaseNotes";
            this.tbReleaseNotes.TextChanged += new System.EventHandler(this.tbSimpleElement_TextChanged);
            // 
            // tlpProjectURL
            // 
            this.tlpProjectURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpProjectURL.AutoSize = true;
            this.tlpProjectURL.ColumnCount = 2;
            this.tlpMain.SetColumnSpan(this.tlpProjectURL, 2);
            this.tlpProjectURL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpProjectURL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpProjectURL.Controls.Add(this.lbProjectURL, 0, 0);
            this.tlpProjectURL.Controls.Add(this.tbProjectURL, 1, 0);
            this.tlpProjectURL.Location = new System.Drawing.Point(3, 147);
            this.tlpProjectURL.Name = "tlpProjectURL";
            this.tlpProjectURL.RowCount = 1;
            this.tlpProjectURL.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpProjectURL.Size = new System.Drawing.Size(938, 26);
            this.tlpProjectURL.TabIndex = 5;
            // 
            // lbProjectURL
            // 
            this.lbProjectURL.AutoSize = true;
            this.lbProjectURL.Location = new System.Drawing.Point(3, 0);
            this.lbProjectURL.Name = "lbProjectURL";
            this.lbProjectURL.Size = new System.Drawing.Size(65, 13);
            this.lbProjectURL.TabIndex = 0;
            this.lbProjectURL.Text = "ProjectURL:";
            this.lbProjectURL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbProjectURL
            // 
            this.tbProjectURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProjectURL.Location = new System.Drawing.Point(284, 3);
            this.tbProjectURL.Name = "tbProjectURL";
            this.tbProjectURL.Size = new System.Drawing.Size(651, 20);
            this.tbProjectURL.TabIndex = 1;
            this.tbProjectURL.Tag = "projectUrl";
            this.tbProjectURL.TextChanged += new System.EventHandler(this.tbSimpleElement_TextChanged);
            // 
            // tlpTags
            // 
            this.tlpTags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpTags.AutoSize = true;
            this.tlpTags.ColumnCount = 2;
            this.tlpMain.SetColumnSpan(this.tlpTags, 2);
            this.tlpTags.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpTags.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpTags.Controls.Add(this.lbTags, 0, 0);
            this.tlpTags.Controls.Add(this.tbTags, 1, 0);
            this.tlpTags.Location = new System.Drawing.Point(3, 80);
            this.tlpTags.Name = "tlpTags";
            this.tlpTags.RowCount = 1;
            this.tlpTags.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTags.Size = new System.Drawing.Size(938, 26);
            this.tlpTags.TabIndex = 1;
            // 
            // lbTags
            // 
            this.lbTags.AutoSize = true;
            this.lbTags.Location = new System.Drawing.Point(3, 0);
            this.lbTags.Name = "lbTags";
            this.lbTags.Size = new System.Drawing.Size(122, 13);
            this.lbTags.TabIndex = 0;
            this.lbTags.Text = "Tags (space separated):";
            this.lbTags.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbTags
            // 
            this.tbTags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTags.Location = new System.Drawing.Point(284, 3);
            this.tbTags.Name = "tbTags";
            this.tbTags.Size = new System.Drawing.Size(651, 20);
            this.tbTags.TabIndex = 1;
            this.tbTags.Tag = "tags";
            this.tbTags.TextChanged += new System.EventHandler(this.tbSimpleElement_TextChanged);
            // 
            // tlpApiKey
            // 
            this.tlpApiKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpApiKey.AutoSize = true;
            this.tlpApiKey.ColumnCount = 3;
            this.tlpMain.SetColumnSpan(this.tlpApiKey, 2);
            this.tlpApiKey.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpApiKey.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tlpApiKey.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpApiKey.Controls.Add(this.btApiKey, 0, 0);
            this.tlpApiKey.Controls.Add(this.lbApiKey, 0, 0);
            this.tlpApiKey.Controls.Add(this.pnToggleApiKeyVisible, 2, 0);
            this.tlpApiKey.Location = new System.Drawing.Point(3, 3);
            this.tlpApiKey.Name = "tlpApiKey";
            this.tlpApiKey.RowCount = 1;
            this.tlpApiKey.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpApiKey.Size = new System.Drawing.Size(938, 29);
            this.tlpApiKey.TabIndex = 0;
            // 
            // btApiKey
            // 
            this.btApiKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btApiKey.Location = new System.Drawing.Point(284, 3);
            this.btApiKey.Name = "btApiKey";
            this.btApiKey.Size = new System.Drawing.Size(603, 23);
            this.btApiKey.TabIndex = 3;
            this.btApiKey.Text = "...";
            this.btApiKey.UseVisualStyleBackColor = true;
            this.btApiKey.Click += new System.EventHandler(this.mnuEnterAPIKeys_Click);
            // 
            // lbApiKey
            // 
            this.lbApiKey.AutoSize = true;
            this.lbApiKey.Location = new System.Drawing.Point(3, 0);
            this.lbApiKey.Name = "lbApiKey";
            this.lbApiKey.Size = new System.Drawing.Size(47, 13);
            this.lbApiKey.TabIndex = 0;
            this.lbApiKey.Text = "API key:";
            this.lbApiKey.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnToggleApiKeyVisible
            // 
            this.pnToggleApiKeyVisible.BackgroundImage = global::MakeANuGet.Properties.Resources.eye_password_hidden;
            this.pnToggleApiKeyVisible.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnToggleApiKeyVisible.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnToggleApiKeyVisible.Location = new System.Drawing.Point(890, 0);
            this.pnToggleApiKeyVisible.Margin = new System.Windows.Forms.Padding(0);
            this.pnToggleApiKeyVisible.Name = "pnToggleApiKeyVisible";
            this.pnToggleApiKeyVisible.Size = new System.Drawing.Size(48, 29);
            this.pnToggleApiKeyVisible.TabIndex = 4;
            this.pnToggleApiKeyVisible.Tag = "false";
            this.pnToggleApiKeyVisible.Click += new System.EventHandler(this.pnToggleApiKeyVisible_Click);
            // 
            // tlpNuGetSteps
            // 
            this.tlpNuGetSteps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpNuGetSteps.AutoSize = true;
            this.tlpNuGetSteps.ColumnCount = 8;
            this.tlpMain.SetColumnSpan(this.tlpNuGetSteps, 2);
            this.tlpNuGetSteps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpNuGetSteps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpNuGetSteps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpNuGetSteps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpNuGetSteps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpNuGetSteps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpNuGetSteps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpNuGetSteps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpNuGetSteps.Controls.Add(this.pnNO1, 0, 0);
            this.tlpNuGetSteps.Controls.Add(this.pnNO2, 2, 0);
            this.tlpNuGetSteps.Controls.Add(this.pnNO3, 4, 0);
            this.tlpNuGetSteps.Controls.Add(this.btGenerateNuget, 1, 0);
            this.tlpNuGetSteps.Controls.Add(this.btGenerateNugetPackage, 3, 0);
            this.tlpNuGetSteps.Controls.Add(this.btPushNugetPackage, 5, 0);
            this.tlpNuGetSteps.Controls.Add(this.cbForceNuspec, 6, 0);
            this.tlpNuGetSteps.Controls.Add(this.cbTestNuGet, 7, 0);
            this.tlpNuGetSteps.Location = new System.Drawing.Point(3, 38);
            this.tlpNuGetSteps.Name = "tlpNuGetSteps";
            this.tlpNuGetSteps.RowCount = 1;
            this.tlpNuGetSteps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNuGetSteps.Size = new System.Drawing.Size(938, 36);
            this.tlpNuGetSteps.TabIndex = 2;
            // 
            // pnNO1
            // 
            this.pnNO1.BackgroundImage = global::MakeANuGet.Properties.Resources.no_1;
            this.pnNO1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnNO1.Location = new System.Drawing.Point(3, 3);
            this.pnNO1.Name = "pnNO1";
            this.pnNO1.Size = new System.Drawing.Size(30, 30);
            this.pnNO1.TabIndex = 0;
            // 
            // pnNO2
            // 
            this.pnNO2.BackgroundImage = global::MakeANuGet.Properties.Resources.no_2;
            this.pnNO2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnNO2.Location = new System.Drawing.Point(172, 3);
            this.pnNO2.Name = "pnNO2";
            this.pnNO2.Size = new System.Drawing.Size(30, 30);
            this.pnNO2.TabIndex = 1;
            // 
            // pnNO3
            // 
            this.pnNO3.BackgroundImage = global::MakeANuGet.Properties.Resources.no_3;
            this.pnNO3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnNO3.Location = new System.Drawing.Point(405, 3);
            this.pnNO3.Name = "pnNO3";
            this.pnNO3.Size = new System.Drawing.Size(30, 30);
            this.pnNO3.TabIndex = 2;
            // 
            // btGenerateNuget
            // 
            this.btGenerateNuget.AutoSize = true;
            this.btGenerateNuget.Enabled = false;
            this.btGenerateNuget.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGenerateNuget.Location = new System.Drawing.Point(39, 3);
            this.btGenerateNuget.Name = "btGenerateNuget";
            this.btGenerateNuget.Size = new System.Drawing.Size(127, 23);
            this.btGenerateNuget.TabIndex = 3;
            this.btGenerateNuget.Text = "Generate a .nuspec file";
            this.btGenerateNuget.UseVisualStyleBackColor = true;
            this.btGenerateNuget.Click += new System.EventHandler(this.btGenerateNuget_Click);
            // 
            // btGenerateNugetPackage
            // 
            this.btGenerateNugetPackage.AutoSize = true;
            this.btGenerateNugetPackage.Enabled = false;
            this.btGenerateNugetPackage.Location = new System.Drawing.Point(208, 3);
            this.btGenerateNugetPackage.Name = "btGenerateNugetPackage";
            this.btGenerateNugetPackage.Size = new System.Drawing.Size(191, 23);
            this.btGenerateNugetPackage.TabIndex = 4;
            this.btGenerateNugetPackage.Text = "Generate a NuGet package (.nupkg)";
            this.btGenerateNugetPackage.UseVisualStyleBackColor = true;
            this.btGenerateNugetPackage.Click += new System.EventHandler(this.btGenerateNugetPackage_Click);
            // 
            // btPushNugetPackage
            // 
            this.btPushNugetPackage.AutoSize = true;
            this.btPushNugetPackage.Enabled = false;
            this.btPushNugetPackage.Location = new System.Drawing.Point(441, 3);
            this.btPushNugetPackage.Name = "btPushNugetPackage";
            this.btPushNugetPackage.Size = new System.Drawing.Size(198, 23);
            this.btPushNugetPackage.TabIndex = 5;
            this.btPushNugetPackage.Text = "Push NuGet package to the nuget.org";
            this.btPushNugetPackage.UseVisualStyleBackColor = true;
            this.btPushNugetPackage.Click += new System.EventHandler(this.btPushNugetPackage_Click);
            // 
            // cbForceNuspec
            // 
            this.cbForceNuspec.AutoSize = true;
            this.cbForceNuspec.Location = new System.Drawing.Point(645, 3);
            this.cbForceNuspec.Name = "cbForceNuspec";
            this.cbForceNuspec.Size = new System.Drawing.Size(142, 17);
            this.cbForceNuspec.TabIndex = 6;
            this.cbForceNuspec.Text = "Force nuspec regenration";
            this.cbForceNuspec.UseVisualStyleBackColor = true;
            // 
            // cbTestNuGet
            // 
            this.cbTestNuGet.AutoSize = true;
            this.cbTestNuGet.Location = new System.Drawing.Point(793, 3);
            this.cbTestNuGet.Name = "cbTestNuGet";
            this.cbTestNuGet.Size = new System.Drawing.Size(99, 17);
            this.cbTestNuGet.TabIndex = 7;
            this.cbTestNuGet.Text = "Test the NuGet";
            this.cbTestNuGet.UseVisualStyleBackColor = true;
            this.cbTestNuGet.CheckedChanged += new System.EventHandler(this.cbTestNuGet_CheckedChanged);
            // 
            // tlpProcessOutput
            // 
            this.tlpProcessOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpProcessOutput.ColumnCount = 1;
            this.tlpProcessOutput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProcessOutput.Controls.Add(this.lbProcessOutput, 0, 0);
            this.tlpProcessOutput.Controls.Add(this.tbProcessOutput, 0, 1);
            this.tlpProcessOutput.Location = new System.Drawing.Point(3, 404);
            this.tlpProcessOutput.Name = "tlpProcessOutput";
            this.tlpProcessOutput.RowCount = 2;
            this.tlpProcessOutput.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpProcessOutput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProcessOutput.Size = new System.Drawing.Size(958, 166);
            this.tlpProcessOutput.TabIndex = 3;
            // 
            // lbProcessOutput
            // 
            this.lbProcessOutput.AutoSize = true;
            this.lbProcessOutput.Location = new System.Drawing.Point(3, 0);
            this.lbProcessOutput.Name = "lbProcessOutput";
            this.lbProcessOutput.Size = new System.Drawing.Size(90, 13);
            this.lbProcessOutput.TabIndex = 0;
            this.lbProcessOutput.Text = "Command output:";
            // 
            // tbProcessOutput
            // 
            this.tbProcessOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProcessOutput.BackColor = System.Drawing.Color.Black;
            this.tbProcessOutput.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProcessOutput.ForeColor = System.Drawing.Color.White;
            this.tbProcessOutput.Location = new System.Drawing.Point(3, 16);
            this.tbProcessOutput.Multiline = true;
            this.tbProcessOutput.Name = "tbProcessOutput";
            this.tbProcessOutput.ReadOnly = true;
            this.tbProcessOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbProcessOutput.Size = new System.Drawing.Size(952, 147);
            this.tbProcessOutput.TabIndex = 1;
            // 
            // odAnyFile
            // 
            this.odAnyFile.Filter = "All files|*.*";
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tabMain);
            this.tcMain.Controls.Add(this.tabDeprecated);
            this.tcMain.Controls.Add(this.tabContent);
            this.tcMain.Controls.Add(this.tabNuspec);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(3, 3);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(958, 395);
            this.tcMain.TabIndex = 3;
            this.tcMain.Selected += new System.Windows.Forms.TabControlEventHandler(this.tcMain_Selected);
            this.tcMain.Click += new System.EventHandler(this.tcMain_Click);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tlpMain);
            this.tabMain.Location = new System.Drawing.Point(4, 22);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(950, 369);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "Main";
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // tabDeprecated
            // 
            this.tabDeprecated.Controls.Add(this.tlpDeprecated);
            this.tabDeprecated.Location = new System.Drawing.Point(4, 22);
            this.tabDeprecated.Name = "tabDeprecated";
            this.tabDeprecated.Padding = new System.Windows.Forms.Padding(3);
            this.tabDeprecated.Size = new System.Drawing.Size(950, 369);
            this.tabDeprecated.TabIndex = 1;
            this.tabDeprecated.Text = "Deprecated";
            this.tabDeprecated.UseVisualStyleBackColor = true;
            // 
            // tlpDeprecated
            // 
            this.tlpDeprecated.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpDeprecated.ColumnCount = 2;
            this.tlpDeprecated.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDeprecated.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDeprecated.Controls.Add(this.tlpIconURL, 0, 0);
            this.tlpDeprecated.Controls.Add(this.tlpLicenseURL, 0, 1);
            this.tlpDeprecated.Location = new System.Drawing.Point(6, 6);
            this.tlpDeprecated.Name = "tlpDeprecated";
            this.tlpDeprecated.RowCount = 3;
            this.tlpDeprecated.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDeprecated.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDeprecated.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpDeprecated.Size = new System.Drawing.Size(938, 357);
            this.tlpDeprecated.TabIndex = 9;
            // 
            // tlpIconURL
            // 
            this.tlpIconURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpIconURL.AutoSize = true;
            this.tlpIconURL.ColumnCount = 3;
            this.tlpDeprecated.SetColumnSpan(this.tlpIconURL, 2);
            this.tlpIconURL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpIconURL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tlpIconURL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpIconURL.Controls.Add(this.btClearIconUrl, 2, 0);
            this.tlpIconURL.Controls.Add(this.lbIconURL, 0, 0);
            this.tlpIconURL.Controls.Add(this.tbIconURL, 1, 0);
            this.tlpIconURL.Location = new System.Drawing.Point(3, 3);
            this.tlpIconURL.Name = "tlpIconURL";
            this.tlpIconURL.RowCount = 1;
            this.tlpIconURL.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpIconURL.Size = new System.Drawing.Size(932, 29);
            this.tlpIconURL.TabIndex = 7;
            // 
            // btClearIconUrl
            // 
            this.btClearIconUrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btClearIconUrl.Location = new System.Drawing.Point(887, 3);
            this.btClearIconUrl.Name = "btClearIconUrl";
            this.btClearIconUrl.Size = new System.Drawing.Size(42, 23);
            this.btClearIconUrl.TabIndex = 3;
            this.btClearIconUrl.Text = "X";
            this.btClearIconUrl.UseVisualStyleBackColor = true;
            this.btClearIconUrl.Click += new System.EventHandler(this.btClearDeprecatedText_Click);
            // 
            // lbIconURL
            // 
            this.lbIconURL.AutoSize = true;
            this.lbIconURL.Location = new System.Drawing.Point(3, 0);
            this.lbIconURL.Name = "lbIconURL";
            this.lbIconURL.Size = new System.Drawing.Size(138, 13);
            this.lbIconURL.TabIndex = 0;
            this.lbIconURL.Text = "Icon URL (DEPRECATED):";
            this.lbIconURL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbIconURL
            // 
            this.tbIconURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIconURL.BackColor = System.Drawing.Color.DarkGray;
            this.tbIconURL.Location = new System.Drawing.Point(282, 3);
            this.tbIconURL.Name = "tbIconURL";
            this.tbIconURL.Size = new System.Drawing.Size(599, 20);
            this.tbIconURL.TabIndex = 1;
            this.tbIconURL.Tag = "iconUrl;1";
            this.tbIconURL.TextChanged += new System.EventHandler(this.tbSimpleElement_TextChanged);
            // 
            // tlpLicenseURL
            // 
            this.tlpLicenseURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpLicenseURL.AutoSize = true;
            this.tlpLicenseURL.ColumnCount = 3;
            this.tlpDeprecated.SetColumnSpan(this.tlpLicenseURL, 2);
            this.tlpLicenseURL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpLicenseURL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tlpLicenseURL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpLicenseURL.Controls.Add(this.lbLicenseUrl, 0, 0);
            this.tlpLicenseURL.Controls.Add(this.tbLicenseUrl, 1, 0);
            this.tlpLicenseURL.Controls.Add(this.btClearLicenseUrl, 2, 0);
            this.tlpLicenseURL.Location = new System.Drawing.Point(3, 38);
            this.tlpLicenseURL.Name = "tlpLicenseURL";
            this.tlpLicenseURL.RowCount = 1;
            this.tlpLicenseURL.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpLicenseURL.Size = new System.Drawing.Size(932, 29);
            this.tlpLicenseURL.TabIndex = 8;
            // 
            // lbLicenseUrl
            // 
            this.lbLicenseUrl.AutoSize = true;
            this.lbLicenseUrl.Location = new System.Drawing.Point(3, 0);
            this.lbLicenseUrl.Name = "lbLicenseUrl";
            this.lbLicenseUrl.Size = new System.Drawing.Size(154, 13);
            this.lbLicenseUrl.TabIndex = 0;
            this.lbLicenseUrl.Text = "License URL (DEPRECATED):";
            this.lbLicenseUrl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbLicenseUrl
            // 
            this.tbLicenseUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLicenseUrl.BackColor = System.Drawing.Color.DarkGray;
            this.tbLicenseUrl.Location = new System.Drawing.Point(282, 3);
            this.tbLicenseUrl.Name = "tbLicenseUrl";
            this.tbLicenseUrl.Size = new System.Drawing.Size(599, 20);
            this.tbLicenseUrl.TabIndex = 1;
            this.tbLicenseUrl.Tag = "licenseUrl;1";
            this.tbLicenseUrl.TextChanged += new System.EventHandler(this.tbSimpleElement_TextChanged);
            // 
            // btClearLicenseUrl
            // 
            this.btClearLicenseUrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btClearLicenseUrl.Location = new System.Drawing.Point(887, 3);
            this.btClearLicenseUrl.Name = "btClearLicenseUrl";
            this.btClearLicenseUrl.Size = new System.Drawing.Size(42, 23);
            this.btClearLicenseUrl.TabIndex = 2;
            this.btClearLicenseUrl.Text = "X";
            this.btClearLicenseUrl.UseVisualStyleBackColor = true;
            this.btClearLicenseUrl.Click += new System.EventHandler(this.btClearDeprecatedText_Click);
            // 
            // tabContent
            // 
            this.tabContent.Controls.Add(this.lbHelpLink2);
            this.tabContent.Controls.Add(this.lbAnd);
            this.tabContent.Controls.Add(this.lbHelpLink1);
            this.tabContent.Controls.Add(this.lbForHelp);
            this.tabContent.Controls.Add(this.btUndoFileChanges);
            this.tabContent.Controls.Add(this.btSaveFileChanges);
            this.tabContent.Controls.Add(this.lbFiles);
            this.tabContent.Controls.Add(this.dgvFiles);
            this.tabContent.Location = new System.Drawing.Point(4, 22);
            this.tabContent.Name = "tabContent";
            this.tabContent.Padding = new System.Windows.Forms.Padding(3);
            this.tabContent.Size = new System.Drawing.Size(950, 369);
            this.tabContent.TabIndex = 2;
            this.tabContent.Text = "Content / Files";
            this.tabContent.UseVisualStyleBackColor = true;
            // 
            // lbHelpLink2
            // 
            this.lbHelpLink2.AutoSize = true;
            this.lbHelpLink2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbHelpLink2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHelpLink2.ForeColor = System.Drawing.Color.Blue;
            this.lbHelpLink2.Location = new System.Drawing.Point(642, 345);
            this.lbHelpLink2.Name = "lbHelpLink2";
            this.lbHelpLink2.Size = new System.Drawing.Size(110, 13);
            this.lbHelpLink2.TabIndex = 7;
            this.lbHelpLink2.Tag = "https://docs.microsoft.com/en-us/nuget/reference/nuspec#including-content-files";
            this.lbHelpLink2.Text = "Including content files";
            this.ttMain.SetToolTip(this.lbHelpLink2, "https://docs.microsoft.com/en-us/nuget/reference/nuspec#including-content-files");
            this.lbHelpLink2.Click += new System.EventHandler(this.HelpLink_Click);
            // 
            // lbAnd
            // 
            this.lbAnd.AutoSize = true;
            this.lbAnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnd.Location = new System.Drawing.Point(582, 345);
            this.lbAnd.Name = "lbAnd";
            this.lbAnd.Size = new System.Drawing.Size(28, 13);
            this.lbAnd.TabIndex = 6;
            this.lbAnd.Text = "and";
            // 
            // lbHelpLink1
            // 
            this.lbHelpLink1.AutoSize = true;
            this.lbHelpLink1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbHelpLink1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHelpLink1.ForeColor = System.Drawing.Color.Blue;
            this.lbHelpLink1.Location = new System.Drawing.Point(436, 345);
            this.lbHelpLink1.Name = "lbHelpLink1";
            this.lbHelpLink1.Size = new System.Drawing.Size(117, 13);
            this.lbHelpLink1.TabIndex = 5;
            this.lbHelpLink1.Tag = "https://docs.microsoft.com/en-us/nuget/reference/nuspec#including-assembly-files";
            this.lbHelpLink1.Text = "Including assembly files";
            this.ttMain.SetToolTip(this.lbHelpLink1, "https://docs.microsoft.com/en-us/nuget/reference/nuspec#including-assembly-files");
            this.lbHelpLink1.Click += new System.EventHandler(this.HelpLink_Click);
            // 
            // lbForHelp
            // 
            this.lbForHelp.AutoSize = true;
            this.lbForHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbForHelp.Location = new System.Drawing.Point(338, 345);
            this.lbForHelp.Name = "lbForHelp";
            this.lbForHelp.Size = new System.Drawing.Size(81, 13);
            this.lbForHelp.TabIndex = 4;
            this.lbForHelp.Text = "For help see:";
            // 
            // btUndoFileChanges
            // 
            this.btUndoFileChanges.Location = new System.Drawing.Point(172, 340);
            this.btUndoFileChanges.Name = "btUndoFileChanges";
            this.btUndoFileChanges.Size = new System.Drawing.Size(160, 23);
            this.btUndoFileChanges.TabIndex = 3;
            this.btUndoFileChanges.Text = "Undo file(s) changes";
            this.btUndoFileChanges.UseVisualStyleBackColor = true;
            this.btUndoFileChanges.Click += new System.EventHandler(this.btUndoFileChanges_Click);
            // 
            // btSaveFileChanges
            // 
            this.btSaveFileChanges.Location = new System.Drawing.Point(6, 340);
            this.btSaveFileChanges.Name = "btSaveFileChanges";
            this.btSaveFileChanges.Size = new System.Drawing.Size(160, 23);
            this.btSaveFileChanges.TabIndex = 2;
            this.btSaveFileChanges.Text = "Save changes";
            this.btSaveFileChanges.UseVisualStyleBackColor = true;
            this.btSaveFileChanges.Click += new System.EventHandler(this.btSaveFileChanges_Click);
            // 
            // lbFiles
            // 
            this.lbFiles.AutoSize = true;
            this.lbFiles.Location = new System.Drawing.Point(6, 3);
            this.lbFiles.Name = "lbFiles";
            this.lbFiles.Size = new System.Drawing.Size(68, 13);
            this.lbFiles.TabIndex = 1;
            this.lbFiles.Text = "Files section:";
            // 
            // dgvFiles
            // 
            this.dgvFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFile,
            this.colSelectFile,
            this.colExcludePattern,
            this.colBuildAction,
            this.colCopyToOutput,
            this.colFlatten,
            this.colTarget,
            this.colUseContentElement});
            this.dgvFiles.Location = new System.Drawing.Point(6, 19);
            this.dgvFiles.Name = "dgvFiles";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFiles.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFiles.Size = new System.Drawing.Size(938, 315);
            this.dgvFiles.TabIndex = 0;
            this.dgvFiles.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvFiles_CellBeginEdit);
            this.dgvFiles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFiles_CellContentClick);
            // 
            // colFile
            // 
            this.colFile.HeaderText = "File(s)";
            this.colFile.Name = "colFile";
            this.colFile.Width = 250;
            // 
            // colSelectFile
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "...";
            this.colSelectFile.DefaultCellStyle = dataGridViewCellStyle1;
            this.colSelectFile.HeaderText = "...";
            this.colSelectFile.Name = "colSelectFile";
            this.colSelectFile.Width = 30;
            // 
            // colExcludePattern
            // 
            this.colExcludePattern.HeaderText = "Exclude files";
            this.colExcludePattern.Name = "colExcludePattern";
            // 
            // colBuildAction
            // 
            dataGridViewCellStyle2.NullValue = "None";
            this.colBuildAction.DefaultCellStyle = dataGridViewCellStyle2;
            this.colBuildAction.HeaderText = "Build action";
            this.colBuildAction.Items.AddRange(new object[] {
            "None",
            "Compile",
            "Content",
            "Embedded Resource",
            "AdditionalFiles",
            "CodeAnalysisDictionary",
            "ApplicationDefinition",
            "Page",
            "Resource",
            "SplashScreen",
            "DesignData",
            "DesignDataWithDesignTimeCreatableTypes",
            "EntityDeploy",
            "XamlAppDef"});
            this.colBuildAction.Name = "colBuildAction";
            this.colBuildAction.Width = 150;
            // 
            // colCopyToOutput
            // 
            this.colCopyToOutput.HeaderText = "Copy to output";
            this.colCopyToOutput.Name = "colCopyToOutput";
            this.colCopyToOutput.Width = 50;
            // 
            // colFlatten
            // 
            this.colFlatten.HeaderText = "Flatten";
            this.colFlatten.Name = "colFlatten";
            this.colFlatten.Width = 50;
            // 
            // colTarget
            // 
            this.colTarget.HeaderText = "Target";
            this.colTarget.Name = "colTarget";
            this.colTarget.Width = 150;
            // 
            // colUseContentElement
            // 
            this.colUseContentElement.HeaderText = "To content element";
            this.colUseContentElement.Name = "colUseContentElement";
            this.colUseContentElement.Width = 70;
            // 
            // tabNuspec
            // 
            this.tabNuspec.Controls.Add(this.btSaveXMLChanges);
            this.tabNuspec.Controls.Add(this.scintillaNuspecContents);
            this.tabNuspec.Location = new System.Drawing.Point(4, 22);
            this.tabNuspec.Name = "tabNuspec";
            this.tabNuspec.Padding = new System.Windows.Forms.Padding(3);
            this.tabNuspec.Size = new System.Drawing.Size(950, 369);
            this.tabNuspec.TabIndex = 3;
            this.tabNuspec.Text = ".nuspec contents";
            this.tabNuspec.UseVisualStyleBackColor = true;
            // 
            // btSaveXMLChanges
            // 
            this.btSaveXMLChanges.Location = new System.Drawing.Point(6, 340);
            this.btSaveXMLChanges.Name = "btSaveXMLChanges";
            this.btSaveXMLChanges.Size = new System.Drawing.Size(160, 23);
            this.btSaveXMLChanges.TabIndex = 1;
            this.btSaveXMLChanges.Text = "Save changes";
            this.btSaveXMLChanges.UseVisualStyleBackColor = true;
            this.btSaveXMLChanges.Click += new System.EventHandler(this.btSaveXMLChanges_Click);
            // 
            // scintillaNuspecContents
            // 
            this.scintillaNuspecContents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scintillaNuspecContents.Location = new System.Drawing.Point(6, 6);
            this.scintillaNuspecContents.Name = "scintillaNuspecContents";
            this.scintillaNuspecContents.Size = new System.Drawing.Size(938, 328);
            this.scintillaNuspecContents.TabIndex = 0;
            // 
            // odIconFile
            // 
            this.odIconFile.Filter = "Image files|*.png;*.jpg;*.jpeg";
            this.odIconFile.Title = "Select an image file for the icon";
            // 
            // tlpMainContainer
            // 
            this.tlpMainContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpMainContainer.ColumnCount = 1;
            this.tlpMainContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMainContainer.Controls.Add(this.tlpProcessOutput, 0, 1);
            this.tlpMainContainer.Controls.Add(this.tcMain, 0, 0);
            this.tlpMainContainer.Location = new System.Drawing.Point(12, 27);
            this.tlpMainContainer.Name = "tlpMainContainer";
            this.tlpMainContainer.RowCount = 2;
            this.tlpMainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpMainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpMainContainer.Size = new System.Drawing.Size(964, 573);
            this.tlpMainContainer.TabIndex = 4;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 612);
            this.Controls.Add(this.tlpMainContainer);
            this.Controls.Add(this.mnuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMain;
            this.Name = "FormMain";
            this.Text = "Make a NuGet";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.tlpIcon.ResumeLayout(false);
            this.tlpIcon.PerformLayout();
            this.tlpUseCodeSigningCertificate.ResumeLayout(false);
            this.tlpUseCodeSigningCertificate.PerformLayout();
            this.tlpLicenseFileOrType.ResumeLayout(false);
            this.tlpLicenseFileOrType.PerformLayout();
            this.tlpRequireLicenseAcceptance.ResumeLayout(false);
            this.tlpRequireLicenseAcceptance.PerformLayout();
            this.tlpDescription.ResumeLayout(false);
            this.tlpDescription.PerformLayout();
            this.tlpCopyright.ResumeLayout(false);
            this.tlpCopyright.PerformLayout();
            this.tlpReleaseNotes.ResumeLayout(false);
            this.tlpReleaseNotes.PerformLayout();
            this.tlpProjectURL.ResumeLayout(false);
            this.tlpProjectURL.PerformLayout();
            this.tlpTags.ResumeLayout(false);
            this.tlpTags.PerformLayout();
            this.tlpApiKey.ResumeLayout(false);
            this.tlpApiKey.PerformLayout();
            this.tlpNuGetSteps.ResumeLayout(false);
            this.tlpNuGetSteps.PerformLayout();
            this.tlpProcessOutput.ResumeLayout(false);
            this.tlpProcessOutput.PerformLayout();
            this.tcMain.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabDeprecated.ResumeLayout(false);
            this.tlpDeprecated.ResumeLayout(false);
            this.tlpDeprecated.PerformLayout();
            this.tlpIconURL.ResumeLayout(false);
            this.tlpIconURL.PerformLayout();
            this.tlpLicenseURL.ResumeLayout(false);
            this.tlpLicenseURL.PerformLayout();
            this.tabContent.ResumeLayout(false);
            this.tabContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).EndInit();
            this.tabNuspec.ResumeLayout(false);
            this.tlpMainContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenProject;
        private System.Windows.Forms.OpenFileDialog odCSProj;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpTags;
        private System.Windows.Forms.Label lbTags;
        private System.Windows.Forms.TextBox tbTags;
        private System.Windows.Forms.TableLayoutPanel tlpNuGetSteps;
        private System.Windows.Forms.Panel pnNO1;
        private System.Windows.Forms.Panel pnNO2;
        private System.Windows.Forms.Panel pnNO3;
        private System.Windows.Forms.Button btGenerateNuget;
        private System.Windows.Forms.Button btGenerateNugetPackage;
        private System.Windows.Forms.Button btPushNugetPackage;
        private System.Windows.Forms.TableLayoutPanel tlpProcessOutput;
        private System.Windows.Forms.Label lbProcessOutput;
        private System.Windows.Forms.TextBox tbProcessOutput;
        private System.Windows.Forms.CheckBox cbForceNuspec;
        private System.Windows.Forms.TableLayoutPanel tlpProjectURL;
        private System.Windows.Forms.Label lbProjectURL;
        private System.Windows.Forms.TextBox tbProjectURL;
        private System.Windows.Forms.TableLayoutPanel tlpReleaseNotes;
        private System.Windows.Forms.Label lbReleaseNotes;
        private System.Windows.Forms.TextBox tbReleaseNotes;
        private System.Windows.Forms.TableLayoutPanel tlpRequireLicenseAcceptance;
        private System.Windows.Forms.Label lbRequireLicenseAcceptance;
        private System.Windows.Forms.CheckBox cbRequireLicenseAcceptance;
        private System.Windows.Forms.TableLayoutPanel tlpDescription;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TableLayoutPanel tlpCopyright;
        private System.Windows.Forms.Label lbCopyright;
        private System.Windows.Forms.TextBox tbCopyright;
        private System.Windows.Forms.ToolStripMenuItem mnuFillWithDefaults;
        private System.Windows.Forms.TableLayoutPanel tlpLicenseFileOrType;
        private System.Windows.Forms.Label lbLicenseFileOrType;
        private System.Windows.Forms.TextBox tbLicenseFile;
        private System.Windows.Forms.Button btLicenseFile;
        private System.Windows.Forms.OpenFileDialog odAnyFile;
        private System.Windows.Forms.Button btSelectLicenseByType;
        private System.Windows.Forms.Button btAddLicenseByType;
        private System.Windows.Forms.CheckBox cbTestNuGet;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateNuGetEXE;
        private System.Windows.Forms.ToolStripMenuItem mnuEnterAPIKeys;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCertificateSettings;
        private System.Windows.Forms.TableLayoutPanel tlpUseCodeSigningCertificate;
        private System.Windows.Forms.Label lbUseCodeSigningCertificate;
        private System.Windows.Forms.CheckBox cbUseCodeSigningCertificate;
        private System.Windows.Forms.TableLayoutPanel tlpIcon;
        private System.Windows.Forms.Label lbIcon;
        private System.Windows.Forms.TextBox tbIcon;
        private System.Windows.Forms.TableLayoutPanel tlpApiKey;
        private System.Windows.Forms.Label lbApiKey;
        private System.Windows.Forms.Button btIconFile;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.TabPage tabDeprecated;
        private System.Windows.Forms.TableLayoutPanel tlpLicenseURL;
        private System.Windows.Forms.Label lbLicenseUrl;
        private System.Windows.Forms.TextBox tbLicenseUrl;
        private System.Windows.Forms.Button btClearLicenseUrl;
        private System.Windows.Forms.TableLayoutPanel tlpIconURL;
        private System.Windows.Forms.Button btClearIconUrl;
        private System.Windows.Forms.Label lbIconURL;
        private System.Windows.Forms.TextBox tbIconURL;
        private System.Windows.Forms.TableLayoutPanel tlpDeprecated;
        private System.Windows.Forms.TabPage tabContent;
        private System.Windows.Forms.TextBox tbIconTarget;
        private System.Windows.Forms.TextBox tbLicenseFileTarget;
        private System.Windows.Forms.OpenFileDialog odIconFile;
        private System.Windows.Forms.ToolStripMenuItem mnuTest;
        private System.Windows.Forms.TabPage tabNuspec;
        private ScintillaNET.Scintilla scintillaNuspecContents;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveChanges;
        private System.Windows.Forms.ToolTip ttMain;
        private System.Windows.Forms.Button btApiKey;
        private System.Windows.Forms.Panel pnToggleApiKeyVisible;
        private System.Windows.Forms.Button btSaveXMLChanges;
        private System.Windows.Forms.Label lbFiles;
        private System.Windows.Forms.DataGridView dgvFiles;
        private System.Windows.Forms.TableLayoutPanel tlpMainContainer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFile;
        private System.Windows.Forms.DataGridViewButtonColumn colSelectFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExcludePattern;
        private System.Windows.Forms.DataGridViewComboBoxColumn colBuildAction;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCopyToOutput;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colFlatten;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTarget;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colUseContentElement;
        private System.Windows.Forms.Button btSaveFileChanges;
        private System.Windows.Forms.Button btUndoFileChanges;
        private System.Windows.Forms.Label lbHelpLink2;
        private System.Windows.Forms.Label lbAnd;
        private System.Windows.Forms.Label lbHelpLink1;
        private System.Windows.Forms.Label lbForHelp;
    }
}

