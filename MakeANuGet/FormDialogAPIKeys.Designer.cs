﻿namespace MakeANuGet
{
    partial class FormDialogAPIKeys
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDialogAPIKeys));
            this.btCancel = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.lbNuGetAPIKey = new System.Windows.Forms.Label();
            this.tbNuGetAPIKey = new System.Windows.Forms.TextBox();
            this.llbNuGetAPIKey = new System.Windows.Forms.LinkLabel();
            this.llbTestNuGetAPIKey = new System.Windows.Forms.LinkLabel();
            this.tbTestNuGetAPIKey = new System.Windows.Forms.TextBox();
            this.lbTestNuGetAPIKey = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(486, 72);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 6;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btOK
            // 
            this.btOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOK.Enabled = false;
            this.btOK.Location = new System.Drawing.Point(12, 72);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 5;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            // 
            // lbNuGetAPIKey
            // 
            this.lbNuGetAPIKey.AutoSize = true;
            this.lbNuGetAPIKey.Location = new System.Drawing.Point(12, 15);
            this.lbNuGetAPIKey.Name = "lbNuGetAPIKey";
            this.lbNuGetAPIKey.Size = new System.Drawing.Size(52, 13);
            this.lbNuGetAPIKey.TabIndex = 7;
            this.lbNuGetAPIKey.Text = "nuget.org";
            // 
            // tbNuGetAPIKey
            // 
            this.tbNuGetAPIKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNuGetAPIKey.Location = new System.Drawing.Point(101, 12);
            this.tbNuGetAPIKey.Name = "tbNuGetAPIKey";
            this.tbNuGetAPIKey.Size = new System.Drawing.Size(322, 20);
            this.tbNuGetAPIKey.TabIndex = 8;
            this.tbNuGetAPIKey.TextChanged += new System.EventHandler(this.tbNuGetAPIKey_TextChanged);
            // 
            // llbNuGetAPIKey
            // 
            this.llbNuGetAPIKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llbNuGetAPIKey.AutoSize = true;
            this.llbNuGetAPIKey.Location = new System.Drawing.Point(429, 15);
            this.llbNuGetAPIKey.Name = "llbNuGetAPIKey";
            this.llbNuGetAPIKey.Size = new System.Drawing.Size(115, 13);
            this.llbNuGetAPIKey.TabIndex = 9;
            this.llbNuGetAPIKey.TabStop = true;
            this.llbNuGetAPIKey.Text = "https://www.nuget.org";
            this.llbNuGetAPIKey.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.common_LinkClicked);
            // 
            // llbTestNuGetAPIKey
            // 
            this.llbTestNuGetAPIKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llbTestNuGetAPIKey.AutoSize = true;
            this.llbTestNuGetAPIKey.Location = new System.Drawing.Point(429, 41);
            this.llbTestNuGetAPIKey.Name = "llbTestNuGetAPIKey";
            this.llbTestNuGetAPIKey.Size = new System.Drawing.Size(119, 13);
            this.llbTestNuGetAPIKey.TabIndex = 12;
            this.llbTestNuGetAPIKey.TabStop = true;
            this.llbTestNuGetAPIKey.Text = "https://int.nugettest.org";
            this.llbTestNuGetAPIKey.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.common_LinkClicked);
            // 
            // tbTestNuGetAPIKey
            // 
            this.tbTestNuGetAPIKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTestNuGetAPIKey.Location = new System.Drawing.Point(101, 38);
            this.tbTestNuGetAPIKey.Name = "tbTestNuGetAPIKey";
            this.tbTestNuGetAPIKey.Size = new System.Drawing.Size(322, 20);
            this.tbTestNuGetAPIKey.TabIndex = 11;
            // 
            // lbTestNuGetAPIKey
            // 
            this.lbTestNuGetAPIKey.AutoSize = true;
            this.lbTestNuGetAPIKey.Location = new System.Drawing.Point(12, 41);
            this.lbTestNuGetAPIKey.Name = "lbTestNuGetAPIKey";
            this.lbTestNuGetAPIKey.Size = new System.Drawing.Size(83, 13);
            this.lbTestNuGetAPIKey.TabIndex = 10;
            this.lbTestNuGetAPIKey.Text = "int.nugettest.org";
            // 
            // FormDialogAPIKeys
            // 
            this.AcceptButton = this.btOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(573, 107);
            this.Controls.Add(this.llbTestNuGetAPIKey);
            this.Controls.Add(this.tbTestNuGetAPIKey);
            this.Controls.Add(this.lbTestNuGetAPIKey);
            this.Controls.Add(this.llbNuGetAPIKey);
            this.Controls.Add(this.tbNuGetAPIKey);
            this.Controls.Add(this.lbNuGetAPIKey);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDialogAPIKeys";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage NuGet API key(s)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Label lbNuGetAPIKey;
        private System.Windows.Forms.TextBox tbNuGetAPIKey;
        private System.Windows.Forms.LinkLabel llbNuGetAPIKey;
        private System.Windows.Forms.LinkLabel llbTestNuGetAPIKey;
        private System.Windows.Forms.TextBox tbTestNuGetAPIKey;
        private System.Windows.Forms.Label lbTestNuGetAPIKey;
    }
}