namespace MakeANuGet.DialogForms
{
    partial class FormDialogRoamSolution
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDialogRoamSolution));
            this.dgvPackages = new System.Windows.Forms.DataGridView();
            this.colFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSignPackage = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colPushNugetOrg = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colPusNuGetTestOrg = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colGitHubPackages = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colSelectAll = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colFileNameFull = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btRunBatch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackages)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPackages
            // 
            this.dgvPackages.AllowUserToAddRows = false;
            this.dgvPackages.AllowUserToDeleteRows = false;
            this.dgvPackages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPackages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPackages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFileName,
            this.colSignPackage,
            this.colPushNugetOrg,
            this.colPusNuGetTestOrg,
            this.colGitHubPackages,
            this.colSelectAll,
            this.colDelete,
            this.colFileNameFull});
            this.dgvPackages.Location = new System.Drawing.Point(12, 12);
            this.dgvPackages.Name = "dgvPackages";
            this.dgvPackages.RowHeadersVisible = false;
            this.dgvPackages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPackages.ShowEditingIcon = false;
            this.dgvPackages.Size = new System.Drawing.Size(804, 397);
            this.dgvPackages.TabIndex = 0;
            this.dgvPackages.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPackages_CellClick);
            this.dgvPackages.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPackages_CellContentClick);
            this.dgvPackages.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPackages_CellContentClick);
            this.dgvPackages.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPackages_CellValueChanged);
            this.dgvPackages.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPackages_ColumnHeaderMouseClick);
            this.dgvPackages.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPackages_ColumnHeaderMouseClick);
            // 
            // colFileName
            // 
            this.colFileName.HeaderText = "NuGet file";
            this.colFileName.Name = "colFileName";
            this.colFileName.ReadOnly = true;
            this.colFileName.Width = 200;
            // 
            // colSignPackage
            // 
            this.colSignPackage.HeaderText = "Sign NuGet";
            this.colSignPackage.Name = "colSignPackage";
            // 
            // colPushNugetOrg
            // 
            this.colPushNugetOrg.HeaderText = "nuget.org";
            this.colPushNugetOrg.Name = "colPushNugetOrg";
            // 
            // colPusNuGetTestOrg
            // 
            this.colPusNuGetTestOrg.HeaderText = "int.nugettest.org";
            this.colPusNuGetTestOrg.Name = "colPusNuGetTestOrg";
            // 
            // colGitHubPackages
            // 
            this.colGitHubPackages.HeaderText = "GitHub packages";
            this.colGitHubPackages.Name = "colGitHubPackages";
            // 
            // colSelectAll
            // 
            this.colSelectAll.HeaderText = "All";
            this.colSelectAll.Name = "colSelectAll";
            this.colSelectAll.Width = 50;
            // 
            // colDelete
            // 
            this.colDelete.HeaderText = "Delete?";
            this.colDelete.Name = "colDelete";
            this.colDelete.Width = 50;
            // 
            // colFileNameFull
            // 
            this.colFileNameFull.HeaderText = "Full path";
            this.colFileNameFull.Name = "colFileNameFull";
            this.colFileNameFull.ReadOnly = true;
            this.colFileNameFull.Width = 200;
            // 
            // btRunBatch
            // 
            this.btRunBatch.Location = new System.Drawing.Point(12, 415);
            this.btRunBatch.Name = "btRunBatch";
            this.btRunBatch.Size = new System.Drawing.Size(197, 23);
            this.btRunBatch.TabIndex = 1;
            this.btRunBatch.Text = "Run batch >>";
            this.btRunBatch.UseVisualStyleBackColor = true;
            this.btRunBatch.Click += new System.EventHandler(this.btRunBatch_Click);
            // 
            // FormDialogRoamSolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 450);
            this.Controls.Add(this.btRunBatch);
            this.Controls.Add(this.dgvPackages);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDialogRoamSolution";
            this.ShowInTaskbar = false;
            this.Text = "Batch handle packages...";
            this.Shown += new System.EventHandler(this.FormDialogRoamSolution_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPackages;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFileName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSignPackage;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colPushNugetOrg;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colPusNuGetTestOrg;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colGitHubPackages;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSelectAll;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFileNameFull;
        private System.Windows.Forms.Button btRunBatch;
    }
}