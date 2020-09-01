using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using VPKSoft.Utils;

namespace MakeANuGet.DialogForms
{
    /// <summary>
    /// A dialog to handle multiple NuGet packages at the same time.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class FormDialogRoamSolution : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormDialogRoamSolution"/> class.
        /// </summary>
        public FormDialogRoamSolution()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Shows the dialog.
        /// </summary>
        /// <param name="owner">The owner.</param>
        /// <param name="files">The files.</param>
        public static void ShowDialog(IWin32Window owner, IEnumerable<FileEnumeratorFileEntry> files)
        {
            if (files != null)
            {
                var fileList = files.ToList();
                if (fileList.Any())
                {
                    var form = new FormDialogRoamSolution();
                    form.ListFiles(fileList);
                    form.ShowDialog(owner);
                }
            }
        }

        private void ListFiles(List<FileEnumeratorFileEntry> files)
        {
            SuspendCellChanged = true;
            foreach (var file in files)
            {
                if (file.PathFull.IndexOf("debug", StringComparison.InvariantCultureIgnoreCase) > 0)
                {
                    continue;
                }

                dgvPackages.Rows.Add(file.FileName, true, true, true, true, true, false, file.FileNameWithPath);
            }
            SuspendCellChanged = false;
        }

        private void FormDialogRoamSolution_Shown(object sender, EventArgs e)
        {
        }

        private bool SuspendCellChanged { get; set; }

        private void dgvPackages_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView) sender;
            if (SuspendCellChanged || e.RowIndex < 0 || e.RowIndex >= grid.RowCount)
            {
                return;
            }

            if (e.ColumnIndex == colSelectAll.Index)
            {
                grid.Rows[e.RowIndex].Cells[colGitHubPackages.Index].Value = grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                grid.Rows[e.RowIndex].Cells[colPusNuGetTestOrg.Index].Value = grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                grid.Rows[e.RowIndex].Cells[colPushNugetOrg.Index].Value = grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                grid.Rows[e.RowIndex].Cells[colSignPackage.Index].Value = grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            }
        }

        private void dgvPackages_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView) sender;
            grid.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dgvPackages_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var grid = (DataGridView) sender;
            bool newValue = false;
            if (grid.Columns[e.ColumnIndex].CellType == typeof(DataGridViewCheckBoxCell))
            {
                for (int i = 0; i < grid.RowCount; i++)
                {
                    if (i == 0)
                    {
                        newValue = !(bool) grid.Rows[i].Cells[e.ColumnIndex].Value;
                    }

                    grid.Rows[i].Cells[e.ColumnIndex].Value = newValue;
                }

                grid.RefreshEdit();
            }
        }

        private int CommandIndex { get; set; }

        // ReSharper disable once RedundantAssignment
        private void RequestNewCommand(ref string workingDirectory, ref string path, ref string command,
            ref CommandArgument[] commandArguments)
        {
            if (CommandIndex < 0 || CommandIndex >= CommandData.Count)
            {
                workingDirectory = null;
                return;
            }

            workingDirectory = CommandData[CommandIndex].workingDirectory;
            path = CommandData[CommandIndex].path;
            command = CommandData[CommandIndex].command;
            commandArguments = CommandData[CommandIndex].commandArguments;
            CommandIndex++;
        }

        private List<(string workingDirectory, string path, string command,
                CommandArgument[] commandArguments)>
            CommandData { get; } =
                new List<(string workingDirectory, string path, string command,
                    CommandArgument[] commandArguments)>();

        /// <summary>
        /// Bts the run batch click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        private void btRunBatch_Click(object sender, EventArgs e)
        {
            var grid = dgvPackages;
            for (int i = grid.RowCount - 1; i >= 0; i--)
            {
                if ((bool)grid.Rows[i].Cells[colDelete.Index].Value)
                {
                    var result =
                        MessageBox.Show($@"Really delete file {grid.Rows[i].Cells[colFileNameFull.Index].Value}?",
                            @"Delete file?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2);

                    if (result == DialogResult.Cancel)
                    {
                        break;
                    }

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            File.Delete(grid.Rows[i].Cells[colFileNameFull.Index].Value.ToString());
                            grid.Rows.RemoveAt(i);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(
                                $@"File deletion failed: '{grid.Rows[i].Cells[colFileNameFull.Index].Value}' with an exception of '{ex.Message}'.",
                                @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        }
                    }
                    continue; // a deleted file doesn't need to be handled any further..
                }

                var workingDirectory = Path.GetDirectoryName(grid.Rows[i].Cells[colFileNameFull.Index].Value.ToString());

                if ((bool)grid.Rows[i].Cells[colSignPackage.Index].Value)
                {
                    CommandData.Add((workingDirectory, Paths.AppInstallDir, "nuget.exe",
                        new[]
                        {
                            new CommandArgument("sign", grid.Rows[i].Cells[colFileNameFull.Index].Value.ToString()),
                            new CommandArgument("-CertificatePath", FormMain.CertificateFile),
                            new CommandArgument("-Timestamper", FormMain.CertificateTimeStampServer),
                            new CommandArgument("-CertificatePassword", FormMain.CertificatePassword, true),
                        }));
                }

                if ((bool)grid.Rows[i].Cells[colPushNugetOrg.Index].Value)
                {
                    CommandData.Add((workingDirectory, Paths.AppInstallDir, "nuget.exe",
                        new[]
                        {
                            new CommandArgument("push", grid.Rows[i].Cells[colFileNameFull.Index].Value.ToString()),
                            new CommandArgument(FormMain.ApiKey, false) { HideFromDisplay = true},
                            new CommandArgument("-Source", "https://api.nuget.org/v3/index.json") {QuoteValue = false},
                            new CommandArgument("-SkipDuplicate", null, false),
                        }));
                }

                if ((bool)grid.Rows[i].Cells[colPusNuGetTestOrg.Index].Value)
                {
                    CommandData.Add((workingDirectory, Paths.AppInstallDir, "nuget.exe",
                        new[]
                        {
                            new CommandArgument("push", grid.Rows[i].Cells[colFileNameFull.Index].Value.ToString()),
                            new CommandArgument(FormMain.TestApiKey, false) { HideFromDisplay = true},
                            new CommandArgument("-Source", "https://apiint.nugettest.org/v3/index.json") {QuoteValue = false},
                            new CommandArgument("-SkipDuplicate", null, false),
                        }));
                }

                if ((bool)grid.Rows[i].Cells[colGitHubPackages.Index].Value)
                {
                    CommandData.Add((workingDirectory, Paths.AppInstallDir, "nuget.exe",
                        new[]
                        {
                            new CommandArgument("push", grid.Rows[i].Cells[colFileNameFull.Index].Value.ToString()),
                            new CommandArgument(FormMain.GitHubPackagesApiKey, false) { HideFromDisplay = true},
                            new CommandArgument("-Source", "https://nuget.pkg.github.com/" + FormMain.GitHubPackagesUserName + "/index.json") {QuoteValue = false},
                            new CommandArgument("-SkipDuplicate", null, false),
                        }));
                }
            }

            if (CommandData.Count > 0)
            {
                CommandIndex = 1;
                FormDialogCommandShell.ExecuteCommand(this, CommandData[0].workingDirectory, CommandData[0].path,
                    CommandData[0].command, RequestNewCommand, CommandData[0].commandArguments);
            }
        }
    }
}
