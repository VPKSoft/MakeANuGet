namespace MakeANuGet.DialogForms
{
    partial class FormDialogCommandShell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDialogCommandShell));
            this.tbProcessOutput = new System.Windows.Forms.TextBox();
            this.btClose = new System.Windows.Forms.Button();
            this.ttMain = new System.Windows.Forms.ToolTip(this.components);
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.btKillProcess = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbProcessOutput
            // 
            this.tbProcessOutput.BackColor = System.Drawing.Color.Black;
            this.tlpMain.SetColumnSpan(this.tbProcessOutput, 2);
            this.tbProcessOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbProcessOutput.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProcessOutput.ForeColor = System.Drawing.Color.White;
            this.tbProcessOutput.Location = new System.Drawing.Point(3, 3);
            this.tbProcessOutput.Multiline = true;
            this.tbProcessOutput.Name = "tbProcessOutput";
            this.tbProcessOutput.ReadOnly = true;
            this.tbProcessOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbProcessOutput.Size = new System.Drawing.Size(684, 302);
            this.tbProcessOutput.TabIndex = 2;
            // 
            // btClose
            // 
            this.btClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btClose.Enabled = false;
            this.btClose.Location = new System.Drawing.Point(3, 311);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(615, 23);
            this.btClose.TabIndex = 3;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpMain.Controls.Add(this.btClose, 0, 1);
            this.tlpMain.Controls.Add(this.tbProcessOutput, 0, 0);
            this.tlpMain.Controls.Add(this.btKillProcess, 1, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(690, 337);
            this.tlpMain.TabIndex = 4;
            // 
            // btKillProcess
            // 
            this.btKillProcess.BackgroundImage = global::MakeANuGet.Properties.Resources.Abort;
            this.btKillProcess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btKillProcess.Location = new System.Drawing.Point(624, 311);
            this.btKillProcess.Name = "btKillProcess";
            this.btKillProcess.Size = new System.Drawing.Size(63, 23);
            this.btKillProcess.TabIndex = 4;
            this.ttMain.SetToolTip(this.btKillProcess, "Kill current process");
            this.btKillProcess.UseVisualStyleBackColor = true;
            this.btKillProcess.Click += new System.EventHandler(this.btKillProcess_Click);
            // 
            // FormDialogCommandShell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 337);
            this.ControlBox = false;
            this.Controls.Add(this.tlpMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDialogCommandShell";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Command output []";
            this.Shown += new System.EventHandler(this.FormDialogCommandShell_Shown);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbProcessOutput;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Button btKillProcess;
        private System.Windows.Forms.ToolTip ttMain;
    }
}