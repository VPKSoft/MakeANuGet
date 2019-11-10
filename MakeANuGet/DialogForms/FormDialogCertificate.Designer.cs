namespace MakeANuGet.DialogForms
{
    partial class FormDialogCertificate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDialogCertificate));
            this.lbCertificatePassword = new System.Windows.Forms.Label();
            this.tbCertificatePassword = new System.Windows.Forms.TextBox();
            this.lbCertificateTimeStampServer = new System.Windows.Forms.Label();
            this.tbCertificateTimeStampServer = new System.Windows.Forms.TextBox();
            this.tbCertificateFile = new System.Windows.Forms.TextBox();
            this.lbCertificateFile = new System.Windows.Forms.Label();
            this.btOK = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btCertificateFile = new System.Windows.Forms.Button();
            this.odCertificate = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lbCertificatePassword
            // 
            this.lbCertificatePassword.AutoSize = true;
            this.lbCertificatePassword.Location = new System.Drawing.Point(12, 15);
            this.lbCertificatePassword.Name = "lbCertificatePassword";
            this.lbCertificatePassword.Size = new System.Drawing.Size(105, 13);
            this.lbCertificatePassword.TabIndex = 0;
            this.lbCertificatePassword.Text = "Certificate password:";
            // 
            // tbCertificatePassword
            // 
            this.tbCertificatePassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCertificatePassword.Location = new System.Drawing.Point(197, 12);
            this.tbCertificatePassword.Name = "tbCertificatePassword";
            this.tbCertificatePassword.Size = new System.Drawing.Size(394, 20);
            this.tbCertificatePassword.TabIndex = 1;
            this.tbCertificatePassword.UseSystemPasswordChar = true;
            // 
            // lbCertificateTimeStampServer
            // 
            this.lbCertificateTimeStampServer.AutoSize = true;
            this.lbCertificateTimeStampServer.Location = new System.Drawing.Point(12, 41);
            this.lbCertificateTimeStampServer.Name = "lbCertificateTimeStampServer";
            this.lbCertificateTimeStampServer.Size = new System.Drawing.Size(142, 13);
            this.lbCertificateTimeStampServer.TabIndex = 2;
            this.lbCertificateTimeStampServer.Text = "Certificate time stamp server:";
            // 
            // tbCertificateTimeStampServer
            // 
            this.tbCertificateTimeStampServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCertificateTimeStampServer.Location = new System.Drawing.Point(197, 38);
            this.tbCertificateTimeStampServer.Name = "tbCertificateTimeStampServer";
            this.tbCertificateTimeStampServer.Size = new System.Drawing.Size(394, 20);
            this.tbCertificateTimeStampServer.TabIndex = 3;
            // 
            // tbCertificateFile
            // 
            this.tbCertificateFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCertificateFile.Location = new System.Drawing.Point(197, 64);
            this.tbCertificateFile.Name = "tbCertificateFile";
            this.tbCertificateFile.Size = new System.Drawing.Size(362, 20);
            this.tbCertificateFile.TabIndex = 5;
            // 
            // lbCertificateFile
            // 
            this.lbCertificateFile.AutoSize = true;
            this.lbCertificateFile.Location = new System.Drawing.Point(12, 67);
            this.lbCertificateFile.Name = "lbCertificateFile";
            this.lbCertificateFile.Size = new System.Drawing.Size(73, 13);
            this.lbCertificateFile.TabIndex = 4;
            this.lbCertificateFile.Text = "Certificate file:";
            // 
            // btOK
            // 
            this.btOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOK.Location = new System.Drawing.Point(12, 90);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 6;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(516, 90);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 7;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btCertificateFile
            // 
            this.btCertificateFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCertificateFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btCertificateFile.Image = global::MakeANuGet.Properties.Resources.cert;
            this.btCertificateFile.Location = new System.Drawing.Point(562, 64);
            this.btCertificateFile.Margin = new System.Windows.Forms.Padding(0);
            this.btCertificateFile.Name = "btCertificateFile";
            this.btCertificateFile.Size = new System.Drawing.Size(29, 20);
            this.btCertificateFile.TabIndex = 9;
            this.btCertificateFile.UseVisualStyleBackColor = true;
            this.btCertificateFile.Click += new System.EventHandler(this.BtCertificateFile_Click);
            // 
            // odCertificate
            // 
            this.odCertificate.Filter = "Certificate files|*.pfx;*.cer|All files|*.*";
            this.odCertificate.Title = "Select certificate file";
            // 
            // FormDialogCertificate
            // 
            this.AcceptButton = this.btOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(603, 125);
            this.Controls.Add(this.btCertificateFile);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.tbCertificateFile);
            this.Controls.Add(this.lbCertificateFile);
            this.Controls.Add(this.tbCertificateTimeStampServer);
            this.Controls.Add(this.lbCertificateTimeStampServer);
            this.Controls.Add(this.tbCertificatePassword);
            this.Controls.Add(this.lbCertificatePassword);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDialogCertificate";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Code signing certificate settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCertificatePassword;
        private System.Windows.Forms.TextBox tbCertificatePassword;
        private System.Windows.Forms.Label lbCertificateTimeStampServer;
        private System.Windows.Forms.TextBox tbCertificateTimeStampServer;
        private System.Windows.Forms.TextBox tbCertificateFile;
        private System.Windows.Forms.Label lbCertificateFile;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btCertificateFile;
        private System.Windows.Forms.OpenFileDialog odCertificate;
    }
}