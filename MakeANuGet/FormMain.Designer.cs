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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenProject = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFillWithDefaults = new System.Windows.Forms.ToolStripMenuItem();
            this.odCSProj = new System.Windows.Forms.OpenFileDialog();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbLicenseFileOrType = new System.Windows.Forms.Label();
            this.tbLicenseFile = new System.Windows.Forms.TextBox();
            this.btLicenseFile = new System.Windows.Forms.Button();
            this.btSelectLicenseByType = new System.Windows.Forms.Button();
            this.btAddLicenseByType = new System.Windows.Forms.Button();
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
            this.tlpIconURL = new System.Windows.Forms.TableLayoutPanel();
            this.lbIconURL = new System.Windows.Forms.Label();
            this.tbIconURL = new System.Windows.Forms.TextBox();
            this.tlpProjectURL = new System.Windows.Forms.TableLayoutPanel();
            this.lbProjectURL = new System.Windows.Forms.Label();
            this.tbProjectURL = new System.Windows.Forms.TextBox();
            this.tlpLicenseURL = new System.Windows.Forms.TableLayoutPanel();
            this.lbLicenseUrl = new System.Windows.Forms.Label();
            this.tbLicenseUrl = new System.Windows.Forms.TextBox();
            this.btClearLicenseUrl = new System.Windows.Forms.Button();
            this.tlpTags = new System.Windows.Forms.TableLayoutPanel();
            this.lbTags = new System.Windows.Forms.Label();
            this.tbTags = new System.Windows.Forms.TextBox();
            this.tlpApiKey = new System.Windows.Forms.TableLayoutPanel();
            this.lbApiKey = new System.Windows.Forms.Label();
            this.tbApiKey = new System.Windows.Forms.TextBox();
            this.tlpNuGetSteps = new System.Windows.Forms.TableLayoutPanel();
            this.btGenerateNuget = new System.Windows.Forms.Button();
            this.btGenerateNugetPackage = new System.Windows.Forms.Button();
            this.btPushNugetPackage = new System.Windows.Forms.Button();
            this.cbForceNuspec = new System.Windows.Forms.CheckBox();
            this.tlpProcessOutput = new System.Windows.Forms.TableLayoutPanel();
            this.lbProcessOutput = new System.Windows.Forms.Label();
            this.tbProcessOutput = new System.Windows.Forms.TextBox();
            this.odAnyFile = new System.Windows.Forms.OpenFileDialog();
            this.cbTestNuGet = new System.Windows.Forms.CheckBox();
            this.mnuUpdateNuGetEXE = new System.Windows.Forms.ToolStripMenuItem();
            this.pnNO1 = new System.Windows.Forms.Panel();
            this.pnNO2 = new System.Windows.Forms.Panel();
            this.pnNO3 = new System.Windows.Forms.Panel();
            this.mnuEnterAPIKeys = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlpRequireLicenseAcceptance.SuspendLayout();
            this.tlpDescription.SuspendLayout();
            this.tlpCopyright.SuspendLayout();
            this.tlpReleaseNotes.SuspendLayout();
            this.tlpIconURL.SuspendLayout();
            this.tlpProjectURL.SuspendLayout();
            this.tlpLicenseURL.SuspendLayout();
            this.tlpTags.SuspendLayout();
            this.tlpApiKey.SuspendLayout();
            this.tlpNuGetSteps.SuspendLayout();
            this.tlpProcessOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.aboutToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(973, 24);
            this.mnuMain.TabIndex = 1;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpenProject,
            this.mnuFillWithDefaults,
            this.mnuUpdateNuGetEXE,
            this.mnuEnterAPIKeys});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuOpenProject
            // 
            this.mnuOpenProject.Name = "mnuOpenProject";
            this.mnuOpenProject.Size = new System.Drawing.Size(180, 22);
            this.mnuOpenProject.Text = "Open Project";
            this.mnuOpenProject.Click += new System.EventHandler(this.mnuOpenProject_Click);
            // 
            // mnuFillWithDefaults
            // 
            this.mnuFillWithDefaults.Enabled = false;
            this.mnuFillWithDefaults.Name = "mnuFillWithDefaults";
            this.mnuFillWithDefaults.Size = new System.Drawing.Size(180, 22);
            this.mnuFillWithDefaults.Text = "Fill with defaults";
            this.mnuFillWithDefaults.Click += new System.EventHandler(this.mnuFillWithDefaults_Click);
            // 
            // odCSProj
            // 
            this.odCSProj.DefaultExt = "*.csproj";
            this.odCSProj.Filter = "C# Project Files (*.csproj)|*.csproj";
            // 
            // tlpMain
            // 
            this.tlpMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Controls.Add(this.tableLayoutPanel1, 0, 3);
            this.tlpMain.Controls.Add(this.tlpRequireLicenseAcceptance, 0, 10);
            this.tlpMain.Controls.Add(this.tlpDescription, 0, 9);
            this.tlpMain.Controls.Add(this.tlpCopyright, 0, 8);
            this.tlpMain.Controls.Add(this.tlpReleaseNotes, 0, 7);
            this.tlpMain.Controls.Add(this.tlpIconURL, 0, 6);
            this.tlpMain.Controls.Add(this.tlpProjectURL, 0, 5);
            this.tlpMain.Controls.Add(this.tlpLicenseURL, 0, 4);
            this.tlpMain.Controls.Add(this.tlpTags, 0, 2);
            this.tlpMain.Controls.Add(this.tlpApiKey, 0, 0);
            this.tlpMain.Controls.Add(this.tlpNuGetSteps, 0, 1);
            this.tlpMain.Controls.Add(this.tlpProcessOutput, 0, 13);
            this.tlpMain.Location = new System.Drawing.Point(12, 27);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 14;
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
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(949, 697);
            this.tlpMain.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tlpMain.SetColumnSpan(this.tableLayoutPanel1, 2);
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.lbLicenseFileOrType, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbLicenseFile, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btLicenseFile, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btSelectLicenseByType, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btAddLicenseByType, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 109);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(943, 29);
            this.tableLayoutPanel1.TabIndex = 11;
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
            this.tbLicenseFile.Location = new System.Drawing.Point(285, 3);
            this.tbLicenseFile.Name = "tbLicenseFile";
            this.tbLicenseFile.Size = new System.Drawing.Size(512, 20);
            this.tbLicenseFile.TabIndex = 1;
            // 
            // btLicenseFile
            // 
            this.btLicenseFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btLicenseFile.Location = new System.Drawing.Point(803, 3);
            this.btLicenseFile.Name = "btLicenseFile";
            this.btLicenseFile.Size = new System.Drawing.Size(41, 23);
            this.btLicenseFile.TabIndex = 2;
            this.btLicenseFile.Text = "...";
            this.btLicenseFile.UseVisualStyleBackColor = true;
            this.btLicenseFile.Click += new System.EventHandler(this.btLicenseFile_Click);
            // 
            // btSelectLicenseByType
            // 
            this.btSelectLicenseByType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btSelectLicenseByType.Location = new System.Drawing.Point(850, 3);
            this.btSelectLicenseByType.Name = "btSelectLicenseByType";
            this.btSelectLicenseByType.Size = new System.Drawing.Size(41, 23);
            this.btSelectLicenseByType.TabIndex = 3;
            this.btSelectLicenseByType.Text = "§";
            this.btSelectLicenseByType.UseVisualStyleBackColor = true;
            this.btSelectLicenseByType.Click += new System.EventHandler(this.btSelectLicenseByType_Click);
            // 
            // btAddLicenseByType
            // 
            this.btAddLicenseByType.Location = new System.Drawing.Point(897, 3);
            this.btAddLicenseByType.Name = "btAddLicenseByType";
            this.btAddLicenseByType.Size = new System.Drawing.Size(43, 23);
            this.btAddLicenseByType.TabIndex = 4;
            this.btAddLicenseByType.Text = "+§";
            this.btAddLicenseByType.UseVisualStyleBackColor = true;
            this.btAddLicenseByType.Click += new System.EventHandler(this.btAddLicenseByType_Click);
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
            this.tlpRequireLicenseAcceptance.Location = new System.Drawing.Point(3, 339);
            this.tlpRequireLicenseAcceptance.Name = "tlpRequireLicenseAcceptance";
            this.tlpRequireLicenseAcceptance.RowCount = 1;
            this.tlpRequireLicenseAcceptance.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpRequireLicenseAcceptance.Size = new System.Drawing.Size(943, 20);
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
            this.cbRequireLicenseAcceptance.Location = new System.Drawing.Point(285, 3);
            this.cbRequireLicenseAcceptance.Name = "cbRequireLicenseAcceptance";
            this.cbRequireLicenseAcceptance.Size = new System.Drawing.Size(15, 14);
            this.cbRequireLicenseAcceptance.TabIndex = 1;
            this.cbRequireLicenseAcceptance.UseVisualStyleBackColor = true;
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
            this.tlpDescription.Location = new System.Drawing.Point(3, 307);
            this.tlpDescription.Name = "tlpDescription";
            this.tlpDescription.RowCount = 1;
            this.tlpDescription.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDescription.Size = new System.Drawing.Size(943, 26);
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
            this.tbDescription.Location = new System.Drawing.Point(285, 3);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(655, 20);
            this.tbDescription.TabIndex = 1;
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
            this.tlpCopyright.Location = new System.Drawing.Point(3, 275);
            this.tlpCopyright.Name = "tlpCopyright";
            this.tlpCopyright.RowCount = 1;
            this.tlpCopyright.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCopyright.Size = new System.Drawing.Size(943, 26);
            this.tlpCopyright.TabIndex = 8;
            // 
            // lbCopyright
            // 
            this.lbCopyright.AutoSize = true;
            this.lbCopyright.Location = new System.Drawing.Point(3, 0);
            this.lbCopyright.Name = "lbCopyright";
            this.lbCopyright.Size = new System.Drawing.Size(51, 13);
            this.lbCopyright.TabIndex = 0;
            this.lbCopyright.Text = "Copyright";
            this.lbCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbCopyright
            // 
            this.tbCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCopyright.Location = new System.Drawing.Point(285, 3);
            this.tbCopyright.Name = "tbCopyright";
            this.tbCopyright.Size = new System.Drawing.Size(655, 20);
            this.tbCopyright.TabIndex = 1;
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
            this.tlpReleaseNotes.Location = new System.Drawing.Point(3, 243);
            this.tlpReleaseNotes.Name = "tlpReleaseNotes";
            this.tlpReleaseNotes.RowCount = 1;
            this.tlpReleaseNotes.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpReleaseNotes.Size = new System.Drawing.Size(943, 26);
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
            this.tbReleaseNotes.Location = new System.Drawing.Point(285, 3);
            this.tbReleaseNotes.Name = "tbReleaseNotes";
            this.tbReleaseNotes.Size = new System.Drawing.Size(655, 20);
            this.tbReleaseNotes.TabIndex = 1;
            // 
            // tlpIconURL
            // 
            this.tlpIconURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpIconURL.AutoSize = true;
            this.tlpIconURL.ColumnCount = 2;
            this.tlpMain.SetColumnSpan(this.tlpIconURL, 2);
            this.tlpIconURL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpIconURL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpIconURL.Controls.Add(this.lbIconURL, 0, 0);
            this.tlpIconURL.Controls.Add(this.tbIconURL, 1, 0);
            this.tlpIconURL.Location = new System.Drawing.Point(3, 211);
            this.tlpIconURL.Name = "tlpIconURL";
            this.tlpIconURL.RowCount = 1;
            this.tlpIconURL.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpIconURL.Size = new System.Drawing.Size(943, 26);
            this.tlpIconURL.TabIndex = 6;
            // 
            // lbIconURL
            // 
            this.lbIconURL.AutoSize = true;
            this.lbIconURL.Location = new System.Drawing.Point(3, 0);
            this.lbIconURL.Name = "lbIconURL";
            this.lbIconURL.Size = new System.Drawing.Size(56, 13);
            this.lbIconURL.TabIndex = 0;
            this.lbIconURL.Text = "Icon URL:";
            this.lbIconURL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbIconURL
            // 
            this.tbIconURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIconURL.Location = new System.Drawing.Point(285, 3);
            this.tbIconURL.Name = "tbIconURL";
            this.tbIconURL.Size = new System.Drawing.Size(655, 20);
            this.tbIconURL.TabIndex = 1;
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
            this.tlpProjectURL.Location = new System.Drawing.Point(3, 179);
            this.tlpProjectURL.Name = "tlpProjectURL";
            this.tlpProjectURL.RowCount = 1;
            this.tlpProjectURL.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpProjectURL.Size = new System.Drawing.Size(943, 26);
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
            this.tbProjectURL.Location = new System.Drawing.Point(285, 3);
            this.tbProjectURL.Name = "tbProjectURL";
            this.tbProjectURL.Size = new System.Drawing.Size(655, 20);
            this.tbProjectURL.TabIndex = 1;
            // 
            // tlpLicenseURL
            // 
            this.tlpLicenseURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpLicenseURL.AutoSize = true;
            this.tlpLicenseURL.ColumnCount = 3;
            this.tlpMain.SetColumnSpan(this.tlpLicenseURL, 2);
            this.tlpLicenseURL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpLicenseURL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tlpLicenseURL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpLicenseURL.Controls.Add(this.lbLicenseUrl, 0, 0);
            this.tlpLicenseURL.Controls.Add(this.tbLicenseUrl, 1, 0);
            this.tlpLicenseURL.Controls.Add(this.btClearLicenseUrl, 2, 0);
            this.tlpLicenseURL.Location = new System.Drawing.Point(3, 144);
            this.tlpLicenseURL.Name = "tlpLicenseURL";
            this.tlpLicenseURL.RowCount = 1;
            this.tlpLicenseURL.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpLicenseURL.Size = new System.Drawing.Size(943, 29);
            this.tlpLicenseURL.TabIndex = 4;
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
            this.tbLicenseUrl.Location = new System.Drawing.Point(285, 3);
            this.tbLicenseUrl.Name = "tbLicenseUrl";
            this.tbLicenseUrl.Size = new System.Drawing.Size(606, 20);
            this.tbLicenseUrl.TabIndex = 1;
            // 
            // btClearLicenseUrl
            // 
            this.btClearLicenseUrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btClearLicenseUrl.Location = new System.Drawing.Point(897, 3);
            this.btClearLicenseUrl.Name = "btClearLicenseUrl";
            this.btClearLicenseUrl.Size = new System.Drawing.Size(43, 23);
            this.btClearLicenseUrl.TabIndex = 2;
            this.btClearLicenseUrl.Text = "X";
            this.btClearLicenseUrl.UseVisualStyleBackColor = true;
            this.btClearLicenseUrl.Click += new System.EventHandler(this.btClearLicenseUrl_Click);
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
            this.tlpTags.Location = new System.Drawing.Point(3, 77);
            this.tlpTags.Name = "tlpTags";
            this.tlpTags.RowCount = 1;
            this.tlpTags.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTags.Size = new System.Drawing.Size(943, 26);
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
            this.tbTags.Location = new System.Drawing.Point(285, 3);
            this.tbTags.Name = "tbTags";
            this.tbTags.Size = new System.Drawing.Size(655, 20);
            this.tbTags.TabIndex = 1;
            // 
            // tlpApiKey
            // 
            this.tlpApiKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpApiKey.AutoSize = true;
            this.tlpApiKey.ColumnCount = 2;
            this.tlpMain.SetColumnSpan(this.tlpApiKey, 2);
            this.tlpApiKey.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpApiKey.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpApiKey.Controls.Add(this.lbApiKey, 0, 0);
            this.tlpApiKey.Controls.Add(this.tbApiKey, 1, 0);
            this.tlpApiKey.Location = new System.Drawing.Point(3, 3);
            this.tlpApiKey.Name = "tlpApiKey";
            this.tlpApiKey.RowCount = 1;
            this.tlpApiKey.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpApiKey.Size = new System.Drawing.Size(943, 26);
            this.tlpApiKey.TabIndex = 0;
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
            // tbApiKey
            // 
            this.tbApiKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbApiKey.Location = new System.Drawing.Point(285, 3);
            this.tbApiKey.Name = "tbApiKey";
            this.tbApiKey.Size = new System.Drawing.Size(655, 20);
            this.tbApiKey.TabIndex = 1;
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
            this.tlpNuGetSteps.Location = new System.Drawing.Point(3, 35);
            this.tlpNuGetSteps.Name = "tlpNuGetSteps";
            this.tlpNuGetSteps.RowCount = 1;
            this.tlpNuGetSteps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNuGetSteps.Size = new System.Drawing.Size(943, 36);
            this.tlpNuGetSteps.TabIndex = 2;
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
            this.cbForceNuspec.Size = new System.Drawing.Size(144, 17);
            this.cbForceNuspec.TabIndex = 6;
            this.cbForceNuspec.Text = "Force nuspec regenration";
            this.cbForceNuspec.UseVisualStyleBackColor = true;
            // 
            // tlpProcessOutput
            // 
            this.tlpProcessOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpProcessOutput.ColumnCount = 1;
            this.tlpMain.SetColumnSpan(this.tlpProcessOutput, 2);
            this.tlpProcessOutput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProcessOutput.Controls.Add(this.lbProcessOutput, 0, 0);
            this.tlpProcessOutput.Controls.Add(this.tbProcessOutput, 0, 1);
            this.tlpProcessOutput.Location = new System.Drawing.Point(3, 365);
            this.tlpProcessOutput.Name = "tlpProcessOutput";
            this.tlpProcessOutput.RowCount = 2;
            this.tlpProcessOutput.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpProcessOutput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProcessOutput.Size = new System.Drawing.Size(943, 329);
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
            this.tbProcessOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbProcessOutput.Size = new System.Drawing.Size(937, 310);
            this.tbProcessOutput.TabIndex = 1;
            // 
            // odAnyFile
            // 
            this.odAnyFile.Filter = "All files|*.*";
            // 
            // cbTestNuGet
            // 
            this.cbTestNuGet.AutoSize = true;
            this.cbTestNuGet.Location = new System.Drawing.Point(795, 3);
            this.cbTestNuGet.Name = "cbTestNuGet";
            this.cbTestNuGet.Size = new System.Drawing.Size(99, 17);
            this.cbTestNuGet.TabIndex = 7;
            this.cbTestNuGet.Text = "Test the NuGet";
            this.cbTestNuGet.UseVisualStyleBackColor = true;
            this.cbTestNuGet.CheckedChanged += new System.EventHandler(this.cbTestNuGet_CheckedChanged);
            // 
            // mnuUpdateNuGetEXE
            // 
            this.mnuUpdateNuGetEXE.Name = "mnuUpdateNuGetEXE";
            this.mnuUpdateNuGetEXE.Size = new System.Drawing.Size(180, 22);
            this.mnuUpdateNuGetEXE.Text = "Update nuget.exe";
            this.mnuUpdateNuGetEXE.Click += new System.EventHandler(this.mnuUpdateNuGetEXE_Click);
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
            // mnuEnterAPIKeys
            // 
            this.mnuEnterAPIKeys.Name = "mnuEnterAPIKeys";
            this.mnuEnterAPIKeys.Size = new System.Drawing.Size(180, 22);
            this.mnuEnterAPIKeys.Text = "Enter API key(s)";
            this.mnuEnterAPIKeys.Click += new System.EventHandler(this.mnuEnterAPIKeys_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 736);
            this.Controls.Add(this.tlpMain);
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
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tlpRequireLicenseAcceptance.ResumeLayout(false);
            this.tlpRequireLicenseAcceptance.PerformLayout();
            this.tlpDescription.ResumeLayout(false);
            this.tlpDescription.PerformLayout();
            this.tlpCopyright.ResumeLayout(false);
            this.tlpCopyright.PerformLayout();
            this.tlpReleaseNotes.ResumeLayout(false);
            this.tlpReleaseNotes.PerformLayout();
            this.tlpIconURL.ResumeLayout(false);
            this.tlpIconURL.PerformLayout();
            this.tlpProjectURL.ResumeLayout(false);
            this.tlpProjectURL.PerformLayout();
            this.tlpLicenseURL.ResumeLayout(false);
            this.tlpLicenseURL.PerformLayout();
            this.tlpTags.ResumeLayout(false);
            this.tlpTags.PerformLayout();
            this.tlpApiKey.ResumeLayout(false);
            this.tlpApiKey.PerformLayout();
            this.tlpNuGetSteps.ResumeLayout(false);
            this.tlpNuGetSteps.PerformLayout();
            this.tlpProcessOutput.ResumeLayout(false);
            this.tlpProcessOutput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenProject;
        private System.Windows.Forms.OpenFileDialog odCSProj;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpApiKey;
        private System.Windows.Forms.Label lbApiKey;
        private System.Windows.Forms.TextBox tbApiKey;
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
        private System.Windows.Forms.TableLayoutPanel tlpLicenseURL;
        private System.Windows.Forms.Label lbLicenseUrl;
        private System.Windows.Forms.TextBox tbLicenseUrl;
        private System.Windows.Forms.TableLayoutPanel tlpProjectURL;
        private System.Windows.Forms.Label lbProjectURL;
        private System.Windows.Forms.TextBox tbProjectURL;
        private System.Windows.Forms.TableLayoutPanel tlpIconURL;
        private System.Windows.Forms.Label lbIconURL;
        private System.Windows.Forms.TextBox tbIconURL;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbLicenseFileOrType;
        private System.Windows.Forms.TextBox tbLicenseFile;
        private System.Windows.Forms.Button btLicenseFile;
        private System.Windows.Forms.OpenFileDialog odAnyFile;
        private System.Windows.Forms.Button btSelectLicenseByType;
        private System.Windows.Forms.Button btAddLicenseByType;
        private System.Windows.Forms.Button btClearLicenseUrl;
        private System.Windows.Forms.CheckBox cbTestNuGet;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateNuGetEXE;
        private System.Windows.Forms.ToolStripMenuItem mnuEnterAPIKeys;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

