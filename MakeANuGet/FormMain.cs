#region License
/*
MIT License

Copyright(c) 2019 Petteri Kautonen

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/
#endregion

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using VPKSoft.Utils;
using System.Diagnostics;
using System.Threading;
using System.Reflection;
using System.Xml.Linq;
using MakeANuGet.DialogForms;
using MakeANuGet.HelperClasses;
using VPKSoft.ScintillaLexers;
using static MakeANuGet.HelperClasses.XmlUtilities;

namespace MakeANuGet
{
    /// <summary>
    /// The main form for the MakeANuGet software.
    /// </summary>
    public partial class FormMain : Form
    {
        /// <summary>
        /// The main form for the software.
        /// </summary>
        public FormMain()
        {
            InitializeComponent();

            // ReSharper disable once CommentTypo
            // create the settings folder if it doesn't already exists (%LOCALAPPDATA%\MakeANuGet)..
            var settingsPath = Paths.MakeAppSettingsFolder();

            // load the NuGet API key..
            vnml = new VPKNml();
            settingsFile = Path.Combine(settingsPath, "settings.vnml");
            vmmlPath = Path.Combine(settingsPath, "defaults.vnml");
            vnml.Load(settingsFile);

            apiKey = vnml["api", "key", ""].ToString();

            // ReSharper disable once StringLiteralTypo
            testApiKey = vnml["apitest", "key", ""].ToString();

            certificatePassword = vnml["certificate", "password", ""].ToString();

            certificateFile = vnml["certificate", "file", ""].ToString();

            certificateTimeStampServer = vnml["certificate", "timeStampServer", ""].ToString();

            signPackage = bool.Parse(vnml["certificate", "use", false].ToString());

            // set the API key to the text box..
            btApiKey.Tag = cbTestNuGet.Checked ? testApiKey : apiKey;
            btApiKey.Text = bool.Parse(pnToggleApiKeyVisible.Tag.ToString())
                ? btApiKey.Tag.ToString()
                : new string('•', btApiKey.Tag.ToString().Length);

            // display the test menu in a debug session..
            mnuTest.Visible = Debugger.IsAttached;

            if (Debugger.IsAttached)
            {
                var initialDirectory = Path.GetFullPath(Path.Combine(Paths.AppInstallDir, "..", "..", "..", "VPKSoft.MakeANugetTest"));
                odCSProj.InitialDirectory = initialDirectory;
                var testPath = Path.GetFullPath(Path.Combine(Paths.AppInstallDir, "..", "..", "..", "VPKSoft.MakeANugetTest", "NugetIcons"));
                odIconFile.InitialDirectory = testPath;
            }

            ScintillaLexers.CreateLexer(scintillaNuspecContents,
                LexerEnumerations.LexerType.Xml);

            // this is suitable for XML files..
            scintillaNuspecContents.TabWidth = 2;
            scintillaNuspecContents.UseTabs = false;

            SetStepZero();
        }

        #region PrivateFields
        // use the self developed "not a markup language"..
        private readonly VPKNml vnml;

        // the settings file name (to store the API key only)..
        private readonly string settingsFile;

        // the C# project file (*.cs) to make the NuGet from..
        private string csprojFile;

        // the .nuspec file for the NuGet package generation..
        private string nuspecFile;

        // the .nuspec file is a XML document..
        private XDocument nuspec;

        // a binary path for the release folder of your library..
        private string binaryPath;

        // an assembly name for your library..
        private string assemblyName;

        // the assembly which from which to NuGet package is to be created..
        private Assembly assemblyNuget;

        // your nuget.org API key
        private string apiKey;

        // ReSharper disable twice CommentTypo
        // your apiint.nugettest.org API key
        private string testApiKey;

        // a path to the common settings .vnml file..
        // ReSharper disable once IdentifierTypo
        private readonly string vmmlPath;

        // a password for a certificate file to sign the nuget package..
        private string certificatePassword;

        // an URL for the certificate time stamp server..
        private string certificateTimeStampServer;

        // the certificate file to be used for signing the nuget package..
        private string certificateFile;

        // a value indicating whether to sign the nuget package with a certificate
        private bool signPackage;
        #endregion

        #region ValidityChecks
        /// <summary>
        /// Blinks a text box's background color to indicate a missing or an invalid value.
        /// </summary>
        /// <param name="textBox">The text box of which background to blink in case of an error.</param>
        /// <param name="blinkText">The erroneous value (text) for blinking.</param>
        /// <returns>True if the value was invalid; otherwise false.</returns>
        private bool BlinkTextBox(TextBox textBox, string blinkText)
        {
            return BlinkTextBox(textBox, () => textBox.Text == blinkText || textBox.Text.Trim() == string.Empty);
        }

        /// <summary>
        /// Blinks a text box's background color to indicate a missing or an invalid value.
        /// </summary>
        /// <param name="textBox">The text box of which background to blink in case of an error.</param>
        /// <param name="condition">A function to validate the value.</param>
        /// <returns>True if the value was invalid; otherwise false.</returns>
        private bool BlinkTextBox(TextBox textBox, Func<bool> condition)
        {
            // test the condition and in case of true blink to indicate an error..
            if (condition()) 
            {
                // a value of 3 seconds should be enough..
                for (int i = 0; i < 10; i++)
                {
                    // the logic with remainder..
                    textBox.BackColor = (i % 2) == 0 ? Color.Red : SystemColors.Window;
                    // non-asynchronous blinking - sorry..
                    Application.DoEvents();

                    // sleep for 300 milliseconds..
                    Thread.Sleep(300); 
                }
                return true;
            }
            else
            {
                // indicate a valid value..
                return false;
            }
        }

        /// <summary>
        /// Validate the input values on the form and indicate erroneous fields.
        /// </summary>
        /// <returns>True if the data was valid; otherwise false.</returns>
        private bool ValidateStepTwo()
        {
            // The text "constants" are the "empty" values for a NuGet package..
            return
                !(BlinkTextBox(tbTags, "Tag1 Tag2") ||                  
// Removed as deprecated: BlinkTextBox(tbLicenseUrl, "http://LICENSE_URL_HERE_OR_DELETE_THIS_LINE") ||
                  BlinkTextBox(tbLicenseFile, (() => tbLicenseFile.Tag == null)) ||
                  BlinkTextBox(tbProjectURL, "http://PROJECT_URL_HERE_OR_DELETE_THIS_LINE") ||
                  BlinkTextBox(tbReleaseNotes, "Summary of changes made in this release of the package.") ||
                  BlinkTextBox(tbCopyright, "Copyright " + DateTime.Now.Year));
        }

        /// <summary>
        /// Clear all data if another project is loaded.
        /// </summary>
        private void SetStepZero()
        {
            SetGuiEnabled(false);
        }

        /// <summary>
        /// Sets the GUI enabled or disabled.
        /// </summary>
        /// <param name="enabled">if set to <c>true</c> the GUI is enabled.</param>
        private void SetGuiEnabled(bool enabled)
        {
            if (!enabled)
            {
                csprojFile = null;
                nuspecFile = null;
                nuspec = null;
                assemblyNuget = null;

                binaryPath = null;
                assemblyName = null;

                cbForceNuspec.Checked = false;
                cbTestNuGet.Checked = false;
                tbTags.Text = string.Empty;
                tbTags.Text = string.Empty;
                tbLicenseFile.Text = string.Empty;
                tbLicenseFileTarget.Text = string.Empty;
                tbProjectURL.Text = string.Empty;
                tbIcon.Text = string.Empty;
                tbIconTarget.Text = string.Empty;
                tbReleaseNotes.Text = string.Empty;
                tbCopyright.Text = string.Empty;
                tbDescription.Text = string.Empty;
                cbRequireLicenseAcceptance.Checked = false;
                tbIconURL.Text = string.Empty;
                tbLicenseUrl.Text = string.Empty;
                scintillaNuspecContents.Text = string.Empty;
                tbLicenseFile.Tag = null;
                tbIcon.Tag = null;
                dgvFiles.Rows.Clear();
            }

            btSaveFileChanges.Enabled = enabled;
            btUndoFileChanges.Enabled = enabled;
            mnuFillWithDefaults.Enabled = enabled;
            mnuSaveChanges.Enabled = enabled;
            cbForceNuspec.Enabled = enabled;
            cbTestNuGet.Enabled = enabled;
            lbTags.Enabled = enabled;
            tbTags.Enabled = enabled;
            lbLicenseFileOrType.Enabled = enabled;
            tbLicenseFile.Enabled = enabled;
            tbLicenseFileTarget.Enabled = enabled;
            btLicenseFile.Enabled = enabled;
            btSelectLicenseByType.Enabled = enabled;
            btAddLicenseByType.Enabled = enabled;
            lbProjectURL.Enabled = enabled;
            tbProjectURL.Enabled = enabled;
            lbIcon.Enabled = enabled;
            tbIcon.Enabled = enabled;
            tbIconTarget.Enabled = enabled;
            btIconFile.Enabled = enabled;
            lbReleaseNotes.Enabled = enabled;
            tbReleaseNotes.Enabled = enabled;
            lbCopyright.Enabled = enabled;
            tbCopyright.Enabled = enabled;
            lbDescription.Enabled = enabled;
            tbDescription.Enabled = enabled;
            lbRequireLicenseAcceptance.Enabled = enabled;
            cbRequireLicenseAcceptance.Enabled = enabled;
            lbIconURL.Enabled = enabled;
            tbIconURL.Enabled = enabled;
            btClearIconUrl.Enabled = enabled;
            lbLicenseUrl.Enabled = enabled;
            tbLicenseUrl.Enabled = enabled;
            btClearLicenseUrl.Enabled = enabled;
            scintillaNuspecContents.Enabled = enabled;
            btSaveXMLChanges.Enabled = enabled;
            lbFiles.Enabled = enabled;
            dgvFiles.Enabled = enabled;
        }
        #endregion

        #region Settings
        // ReSharper disable once CommentTypo
        /// <summary>
        /// Gets or sets the assembly copyright value. For the getter the copyright is first tried to be gotten from the actual assembly 
        /// and if not found then the value is defaulted to a saved setting if any. The setter saves a default value to a file called
        /// "%LOCALAPPDATA%\MakeANuGet\defaults.vnml".
        /// </summary>
        private string AssemblyCopyright
        {
            get
            {
                // get the basic attributes for the assembly..
                var obj = assemblyNuget.GetCustomAttributes(false);

                // loop through the attributes..
                foreach (var o in obj)
                {
                    // if a AssemblyCopyrightAttribute exists..
                    if (o is AssemblyCopyrightAttribute assemblyCopyrightAttribute)
                    {
                        // return it as a string..
                        return assemblyCopyrightAttribute.Copyright;
                    }
                }

                // fall back to the saved default value and..
                VPKNml vnmlDefaults = new VPKNml();
                vnmlDefaults.Load(vmmlPath);

                // ..return it..
                return vnmlDefaults["defaults", "copyright", ""].ToString();
            }

            set
            {
                // save the default value to the defaults.vnml file..
                VPKNml vnmlDefaults = new VPKNml();
                vnmlDefaults.Load(vmmlPath);
                vnmlDefaults["defaults", "copyright"] = value;
                vnmlDefaults.Save(vmmlPath);
            }
        }

        /// <summary>
        /// Gets or sets a default value for the "requireLicenseAcceptance" in the .nuspec file.
        /// </summary>
        private bool AssemblyMustAcceptLicense
        {
            get
            {
                // return the value..
                VPKNml vnmlDefaults = new VPKNml();
                vnmlDefaults.Load(vmmlPath);
                return bool.Parse(vnmlDefaults["defaults", "requireLicenseAcceptance", "True"].ToString());
            }

            set
            {
                // save the value..
                VPKNml vnmlDefaults = new VPKNml();
                vnmlDefaults.Load(vmmlPath);
                vnmlDefaults["defaults", "requireLicenseAcceptance"] = value.ToString();
                vnmlDefaults.Save(vmmlPath);
            }
        }

        /// <summary>
        /// Gets or set a default value for the "iconUrl" in the .nuspec file.
        /// </summary>
        private string AssemblyIconUrl
        {
            get
            {
                // return the value..
                VPKNml vnmlDefaults = new VPKNml();
                vnmlDefaults.Load(vmmlPath);
                return vnmlDefaults["defaults", "iconUrl", ""].ToString();
            }

            set
            {
                // save the value..
                VPKNml vnmlDefaults = new VPKNml();
                vnmlDefaults.Load(vmmlPath);
                vnmlDefaults["defaults", "iconUrl"] = value;
                vnmlDefaults.Save(vmmlPath);
            }
        }
        #endregion

        #region XmlData
        /// <summary>
        /// Displays the relevant contents of the .nuspec file.
        /// </summary>
        private void DisplayXmlData()
        {
            if (nuspec != null)
            {
                var metadataElement = nuspec.Root?.Element("metadata");
                tbTags.Text = metadataElement?.Element("tags")?.Value;

                tbLicenseUrl.Text = metadataElement?.Element("licenseUrl")?.Value;
                tbProjectURL.Text = metadataElement?.Element("projectUrl")?.Value;
                tbIconURL.Text = metadataElement?.Element("iconUrl")?.Value;
                tbReleaseNotes.Text = metadataElement?.Element("releaseNotes")?.Value;
                tbCopyright.Text = metadataElement?.Element("copyright")?.Value;
                tbDescription.Text = metadataElement?.Element("description")?.Value;

                tbIcon.Text = metadataElement?.Element("icon")?.Value;
                var iconFileElement =  GetFileElementSourceAndTarget(nuspec, tbIcon.Text);
                tbIcon.Tag = iconFileElement.source;
                tbIconTarget.Text = iconFileElement.target;

                var boolString = metadataElement?.Element("requireLicenseAcceptance")?.Value; 
                cbRequireLicenseAcceptance.Checked = boolString != null && bool.Parse(boolString);

                tbDescription.Text = metadataElement?.Element("description")?.Value;

                var licenseElement =  metadataElement?.Element("license"); // the license is bit more complicated..
                var licenseType = licenseElement?.Attribute("type")?.Value;
                if (licenseType != null)
                {
                    // the "expression" license may contain many SPDX licenses listed by the Linux Foundation (https://spdx.org/licenses/)..
                    if (licenseType == "expression")
                    {
                        // construct a list of SPDX licenses..
                        List<SPDXLicense> licenses = new List<SPDXLicense>();

                        // the licenses are combined with a text " OR " or " AND ", so split them..
                        string[] licenseIds = licenseElement.Value.Split(new[] { " OR ", " AND " }, StringSplitOptions.RemoveEmptyEntries);

                        // get a licenses for each occurrence..
                        foreach (string licenseId in licenseIds)
                        {
                            // ..and add them to the list..
                            licenses.Add(FormDialogQuerySPDXLicense.SPDXLicenseCollection.GetLicenseByIdentifier(licenseId));
                        }

                        // set the text..
                        tbLicenseFile.Text = SPDXLicenseCollection.ConstructLicenseString(licenses);

                        // save the licenses to the text box's Tag property..
                        tbLicenseFile.Tag = licenses;
                    }
                    // a license may also be an embedded file within the NuGet..
                    else if (licenseType == "file")
                    {
                        // the file name is without a path..
                        tbLicenseFile.Text = licenseElement.Value;

                        // the files node in the .nuspec file must contain a relative path the license file
                        // so do try to get it..
                        var fileElement = GetFileElementSourceAndTarget(nuspec, licenseElement.Value);

                        tbLicenseFile.Tag = fileElement.source;
                        tbLicenseFileTarget.Text = fileElement.target;
                    }
                }

                DisplayFileElements();
            }
        }

        /// <summary>
        /// Saves the data on the form to the .nuspec file.
        /// </summary>
        private void SaveXmlData()
        {
            // save the .nuspec..
            nuspec?.Save(nuspecFile);
        }

        /// <summary>
        /// Displays the file elements defined in the .nuspec file.
        /// </summary>
        private void DisplayFileElements()
        {
            dgvFiles.Rows.Clear();
            if (nuspec != null)
            {
                var dataEntries = GetFileElementData(nuspec);
                foreach (var dataEntry in dataEntries)
                {
                    var rowIndex = dgvFiles.Rows.Add();
                    dgvFiles.Rows[rowIndex].Cells[colFile.Index].Value = dataEntry.SrcAttribute;
                    dgvFiles.Rows[rowIndex].Cells[colTarget.Index].Value = dataEntry.TargetAttribute;
                    dgvFiles.Rows[rowIndex].Cells[colExcludePattern.Index].Value = dataEntry.ExcludeAttribute;
                    dgvFiles.Rows[rowIndex].Cells[colCopyToOutput.Index].Value = false;
                    dgvFiles.Rows[rowIndex].Cells[colFlatten.Index].Value = false;
                    dgvFiles.Rows[rowIndex].Cells[colUseContentElement.Index].Value = false;
                }

                var contentFilesEntries = GetContentFileElementData(nuspec);
                foreach (var contentFilesEntry in contentFilesEntries)
                {
                    var rowIndex = dgvFiles.Rows.Add();
                    dgvFiles.Rows[rowIndex].Cells[colFile.Index].Value = contentFilesEntry.IncludeAttribute;
                    dgvFiles.Rows[rowIndex].Cells[colExcludePattern.Index].Value = contentFilesEntry.ExcludeAttribute;
                    dgvFiles.Rows[rowIndex].Cells[colBuildAction.Index].Value = contentFilesEntry.BuildActionAttribute;
                    dgvFiles.Rows[rowIndex].Cells[colCopyToOutput.Index].Value = contentFilesEntry.CopyToOutputAttribute;
                    dgvFiles.Rows[rowIndex].Cells[colFlatten.Index].Value = contentFilesEntry.FlattenAttribute;
                    dgvFiles.Rows[rowIndex].Cells[colUseContentElement.Index].Value = true;
                }
            }
        }

        /// <summary>
        /// Updates the files defined in the file <see cref="DataGridView"/>.
        /// </summary>
        private void UpdateFiles()
        {
            bool ValueToBool(object value)
            {
                if (value == null)
                {
                    return false;
                }

                if (value is bool boolValue)
                {
                    return boolValue;
                }

                return false;
            }

            List<NuspecFileContentElement> contentElements = new List<NuspecFileContentElement>();
            List<NuspecFileElement> fileElements = new List<NuspecFileElement>();

            foreach (DataGridViewRow row in dgvFiles.Rows)
            {
                if (row.Cells[colUseContentElement.Index].Value is bool &&
                    (bool) row.Cells[colUseContentElement.Index].Value)
                {
                    contentElements.Add(new NuspecFileContentElement
                        {
                            IncludeAttribute = (string) row.Cells[colFile.Index].Value,
                            ExcludeAttribute = (string) row.Cells[colExcludePattern.Index].Value,
                            BuildActionAttribute = (string) row.Cells[colBuildAction.Index].Value,
                            CopyToOutputAttribute = ValueToBool(row.Cells[colCopyToOutput.Index].Value),
                            FlattenAttribute = ValueToBool(row.Cells[colFlatten.Index].Value),
                        }
                    );
                }
                else
                {
                    fileElements.Add(new NuspecFileElement
                    {
                        SrcAttribute = (string) row.Cells[colFile.Index].Value,
                        TargetAttribute = (string) row.Cells[colTarget.Index].Value,
                        ExcludeAttribute = (string) row.Cells[colExcludePattern.Index].Value,
                    });
                }
            }

            UpdateContentFilesAndFiles(nuspec, contentElements, fileElements);
            DisplayXmlData();
        }
        #endregion

        #region NuGetProcess
        // gets the path to the generated .nupkg file..
        private string GetNugetFile()
        {
            var csprojPath = Path.GetDirectoryName(csprojFile);

            if (csprojPath == null)
            {
                return string.Empty;
            }

            // enumerate the files in the directory where the .csproj file resides..
            string[] nugPackages = Directory.GetFiles(csprojPath, "*.nupkg");

            // initialize a list of FileInfo class instances..
            List<FileInfo> nugPackagesInfo = new List<FileInfo>();

            // loop through the gotten files and get their information..
            foreach (string nupkg in nugPackages)
            {
                nugPackagesInfo.Add(new FileInfo(nupkg));
            }

            // sort the files with their last write times..
            nugPackagesInfo = nugPackagesInfo.OrderBy(f => f.LastWriteTime).ToList();

            // pick the newest file..
            return Path.GetFileName(nugPackagesInfo.Last().Name);
        }

        // a user wishes to push the NuGet package to nuget.org (https://www.nuget.org)..
        private void btPushNugetPackage_Click(object sender, EventArgs e)
        {
            string np = GetNugetFile();

            // push the NuGet package to nuget.org (https://int.nugettest.org) (NOTE: For testing!)..
            RunSpecNuGet(cbTestNuGet.Checked
                ? $" push {np} {btApiKey.Tag} -Source https://apiint.nugettest.org/v3/index.json"
                : $" push {np} {btApiKey.Tag} -Source https://api.nuget.org/v3/index.json");
        }

        /// <summary>
        /// Updates the contained nuget.exe.
        /// </summary>
        private void UpdateNugetExe()
        {
            string processPath = Path.Combine(Paths.AppInstallDir, "nuget.exe");

            if (!File.Exists(processPath))
            {
                return;
            }

            // the output from the nuget.exe is piped to the lower black text box..
            tbProcessOutput.AppendText("> " + processPath + " update - self" + Environment.NewLine);

            // create a process..
            Process process = new Process
            {
                StartInfo =
                {
                    FileName = processPath,
                    Arguments = "update -self",
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    WorkingDirectory = Paths.AppInstallDir,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true
                }
            };

            // give it the process file name..

            // give the process it's arguments..

            // no shell execution..

            // no exclusive window..

            // set the working directory to the same as the .csproj file location..

            // redirect the process output(s)..

            // subscribe to the process events with anonymous event handlers..
            process.OutputDataReceived += (sender, e) =>
            {
                // append new line endings to the each output string..
                if (!String.IsNullOrEmpty(e.Data))
                {
                    // invocation is required (another process)..
                    Invoke(new MethodInvoker(delegate { tbProcessOutput.AppendText(e.Data + Environment.NewLine); }));
                }
            };

            process.ErrorDataReceived += (sender, e) =>
            {
                // append new line endings to the each output string..
                if (!String.IsNullOrEmpty(e.Data))
                {
                    // invocation is required (another process)..
                    Invoke(new MethodInvoker(delegate { tbProcessOutput.AppendText(e.Data + Environment.NewLine); }));
                }
            };

            // start the process after "hefty" initialization..
            process.Start();

            // asynchronously read the standard output of the spawned process. 
            // This raises OutputDataReceived events for each line of output.
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();

            // wait for the process to exit while "pumping" the software to be "responsive"..
            while (!process.HasExited)
            {
                Application.DoEvents();
                Thread.Sleep(100);
            }
            Application.DoEvents();

            // empty line to the output..
            tbProcessOutput.AppendText(Environment.NewLine);

            using (process)
            {
                // dispose of the process..
            }
        }

        /// <summary>
        /// Signs the nuget package with a code signing certificate.
        /// </summary>
        private void SignPackage()
        {
            var csprojPath = Path.GetDirectoryName(csprojFile);
            if (!signPackage || csprojPath == null)
            {
                return;
            }

            string processPath = Path.Combine(Paths.AppInstallDir, "nuget.exe");

            var package = GetNugetFile();

            // the output from the nuget.exe is piped to the lower black text box..
            // ReSharper disable once StringLiteralTypo
            tbProcessOutput.AppendText("> " + processPath + $" sign \"{package}\" -CertificatePath \"{certificateFile}\" -Timestamper {certificateTimeStampServer} -CertificatePassword \"{new string('•', certificatePassword.Length)}\" " + Environment.NewLine);

            // create a process..
            Process process = new Process
            {
                StartInfo =
                {
                    FileName = processPath,
                    Arguments =
                        $"sign \"{package}\" -CertificatePath \"{certificateFile}\" -Timestamper {certificateTimeStampServer} -CertificatePassword \"{certificatePassword}\"",
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    WorkingDirectory = csprojPath,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true
                }
            };

            // give it the process file name..

            // give the process it's arguments..

            // no shell execution..

            // no exclusive window..

            // set the working directory to the same as the .csproj file location..

            // redirect the process output(s)..

            // subscribe to the process events with anonymous event handlers..
            process.OutputDataReceived += (sender, e) =>
            {
                // append new line endings to the each output string..
                if (!String.IsNullOrEmpty(e.Data))
                {
                    // invocation is required (another process)..
                    Invoke(new MethodInvoker(delegate { tbProcessOutput.AppendText(e.Data + Environment.NewLine); }));
                }
            };

            process.ErrorDataReceived += (sender, e) =>
            {
                // append new line endings to the each output string..
                if (!String.IsNullOrEmpty(e.Data))
                {
                    // invocation is required (another process)..
                    Invoke(new MethodInvoker(delegate { tbProcessOutput.AppendText(e.Data + Environment.NewLine); }));
                }
            };

            // start the process after "hefty" initialization..
            process.Start();

            // asynchronously read the standard output of the spawned process. 
            // This raises OutputDataReceived events for each line of output.
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();

            // wait for the process to exit while "pumping" the software to be "responsive"..
            while (!process.HasExited)
            {
                Application.DoEvents();
                Thread.Sleep(100);
            }
            Application.DoEvents();

            // empty line to the output..
            tbProcessOutput.AppendText(Environment.NewLine);

            using (process)
            {
                // dispose of the process..
            }
        }


        /// <summary>
        /// Tries to push a generated NuGet package to nuget.org (https://www.nuget.org).
        /// </summary>
        /// <param name="parameters">Parameters for the nuget.exe.</param>
        /// <returns>True if the package was pushed successfully; otherwise false.</returns>
        private bool RunSpecNuGet(string parameters)
        {
            // a flag indicating if the push was successful..
            bool returnValue = false;

            var csprojPath = Path.GetDirectoryName(csprojFile);

            // first check there is everything in place..
            if (!string.IsNullOrEmpty(csprojFile) && csprojPath != null)
            {
                // assume success..
                returnValue = true;
                // ..\..\nuget\nuget.exe spec ConfLib.csproj - Force
                string processPath = Path.Combine(Paths.AppInstallDir, "nuget.exe");

                // the output from the nuget.exe is piped to the lower black text box..

                var commandEcho = "> " + processPath + parameters + Environment.NewLine;

                // hide the API key in case of a screen shot, etc..
                commandEcho = commandEcho.Replace(btApiKey.Tag.ToString(), new string('•', btApiKey.Tag.ToString().Length));
                    
                tbProcessOutput.AppendText(commandEcho);

                // create a process..
                Process process = new Process
                {
                    StartInfo =
                    {
                        FileName = processPath,
                        Arguments = parameters,
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        WorkingDirectory = csprojPath,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true
                    }
                };

                // give it the process file name..

                // give the process it's arguments..

                // no shell execution..

                // no exclusive window..

                // set the working directory to the same as the .csproj file location..

                // redirect the process output(s)..

                // subscribe to the process events with anonymous event handlers..
                process.OutputDataReceived += (sender, e) =>
                {
                    // append new line endings to the each output string..
                    if (!string.IsNullOrEmpty(e.Data))
                    {
                        // invocation is required (another process)..
                        Invoke(new MethodInvoker(delegate { tbProcessOutput.AppendText(e.Data + Environment.NewLine); }));
                    }
                };

                process.ErrorDataReceived += (sender, e) =>
                {
                    // append new line endings to the each output string..
                    if (!String.IsNullOrEmpty(e.Data))
                    {
                        // invocation is required (another process)..
                        Invoke(new MethodInvoker(delegate { tbProcessOutput.AppendText(e.Data + Environment.NewLine); }));
                    }
                };

                // start the process after "hefty" initialization..
                process.Start();

                // asynchronously read the standard output of the spawned process. 
                // This raises OutputDataReceived events for each line of output.
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();

                // wait for the process to exit while "pumping" the software to be "responsive"..
                while (!process.HasExited)
                {
                    Application.DoEvents();
                    Thread.Sleep(100);
                }
                Application.DoEvents();

                // reload the .nuspec file..
                if (File.Exists(nuspecFile))
                {
                    nuspec = XDocument.Load(nuspecFile);

                    // display the contents of the .nuspec file..
                    DisplayXmlData();

                    btGenerateNugetPackage.Enabled = true; // and enabled the next step..;

                    SetGuiEnabled(true);

                    // fill empty fields with defaults..
                    tbCopyright.Text = tbCopyright.Text == string.Empty ? AssemblyCopyright : tbCopyright.Text;
                    cbRequireLicenseAcceptance.Checked = AssemblyMustAcceptLicense;
                    tbIconURL.Text = tbIconURL.Text == string.Empty ? AssemblyIconUrl : tbIconURL.Text;
                }

                // check the process exit code and show an error dialog if the exit code is not 0..
                if (process.ExitCode != 0)
                {
                    returnValue = false; // indicate failure..
                    MessageBox.Show($@"Process exited with an error: {process.ExitCode}.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                // empty line to the output..
                tbProcessOutput.AppendText(Environment.NewLine);

                // scroll the process output to the end..
                tbProcessOutput.SelectionStart = tbProcessOutput.Text.Length;
                tbProcessOutput.ScrollToCaret();

                using (process)
                {
                    // dispose of the process..
                }
            }
            return returnValue; // return the result (true == success)..
        }
        #endregion

        #region InternalEvents
        // a user wishes to open a project (.cs) to generate a NuGet package..
        private void mnuOpenProject_Click(object sender, EventArgs e)
        {
            // display an open file dialog for the .csproj file..
            if (odCSProj.ShowDialog() == DialogResult.OK)
            {
                // display the main tab..
                tcMain.SelectedTab = tabMain;

                // clear the data..
                SetStepZero();
            
                // save the file name..
                csprojFile = odCSProj.FileName;

                // set the form's title..
                Text = $@"Make a NuGet - [{csprojFile}]";

                // get a file name for the .nuspec file..
                nuspecFile = Path.ChangeExtension(csprojFile, ".nuspec");

                // load the .csproj file..
                if (csprojFile != null)
                {
                    // create a XDocument class instance..
                    var csproj = XDocument.Load(csprojFile);
                    XNamespace xNamespace = "http://schemas.microsoft.com/developer/msbuild/2003";
                    // set the initial directory for the 
                    odAnyFile.InitialDirectory = Path.GetDirectoryName(csprojFile);
                    
                    var propertyGroups = csproj.Root?.Elements(xNamespace + "PropertyGroup");

                    // get the assembly name and the binary path from the .csproj file for the NuGet generation..
                    if (propertyGroups != null)
                    {
                        foreach (XElement element in propertyGroups)
                        {
                            var propertyGroupElements = element.Elements(xNamespace + "AssemblyName");

                            if (assemblyName == null)
                            {
                                foreach (var propertyGroupElement in propertyGroupElements)
                                {
                                    if (assemblyName == null)
                                    {
                                        assemblyName = propertyGroupElement.Value;
                                    }
                                }
                            }

                            if (binaryPath == null)
                            {
                                //foreach (var conditionAttribute in conditionAttributes)
                                var conditionAttribute = element.Attribute("Condition");
                                {
                                    if (conditionAttribute?.Value.Trim(' ') ==
                                        " '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ".Trim(' '))
                                    {
                                        binaryPath = element.Element(xNamespace + "OutputPath")?.Value;
                                    }
                                }
                            }

                            if (assemblyName != null && binaryPath != null)
                            {
                                break;
                            }
                        }
                    }

                    var csprojPath = Path.GetDirectoryName(csprojFile);

                    // combine the assembly DLL name..
                    if (binaryPath == null || csprojPath == null)
                    {
                        return;
                    }
                    binaryPath = Path.Combine(csprojPath, binaryPath, assemblyName + ".dll");

                    // load the assembly to get data from it..
                    assemblyNuget = Assembly.LoadFile(binaryPath);

                    // if the .nuspec already exists, then load it..
                    if (File.Exists(nuspecFile))
                    {
                        if (nuspecFile != null)
                        {
                            nuspec = XDocument.Load(nuspecFile);
                        }

                        SetGuiEnabled(true);

                        btGenerateNugetPackage.Enabled = true; // and enabled the next step..

                        DisplayXmlData(); // display the loaded data..
                    }

                    // enable the NuGet generation button..
                    btGenerateNuget.Enabled = true;

                }
            }
        }

        // a user decided to close the form, so save some setting which
        // are presumed to be constant for the developer..
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            vnml["api", "key"] = apiKey; // the NuGet API key..
            // ReSharper disable once StringLiteralTypo
            vnml["apitest", "key"] = testApiKey; // the test NuGet API key..

            // the certificate settings..
            vnml["certificate", "password"] = certificatePassword;
            vnml["certificate", "file"] = certificateFile;
            vnml["certificate", "timeStampServer"] = certificateTimeStampServer;
            vnml["certificate", "use"] = signPackage;

            vnml.Save(settingsFile);

            // the assembly copyright..
            AssemblyCopyright = tbCopyright.Text;

            // the need for a "consumer" to accept the license..
            AssemblyMustAcceptLicense = cbRequireLicenseAcceptance.Checked;

            // an icon URL for the NuGet..
            AssemblyIconUrl = tbIconURL.Text;
        }

        // a user wished to generate a .nuspec file..
        private void btGenerateNuget_Click(object sender, EventArgs e)
        {
            // ..so do try to generate it..
            RunSpecNuGet(" spec " + "\"" + csprojFile + "\"" + (cbForceNuspec.Checked ? " -Force" : string.Empty));
        }

        // a user wished to generate a NuGet package..
        private void btGenerateNugetPackage_Click(object sender, EventArgs e)
        {
            // validate first..
            // TODO::add extra validation..
            if (ValidateStepTwo())
            {
                // save the .nuspec contents..
                SaveXmlData();

                // generate a NuGet package..
                if (RunSpecNuGet(" pack -Prop Configuration=Release"))
                {
                    // if successful, enable the push NuGet button..
                    btPushNugetPackage.Enabled = true;

                    // sign the package if set..
                    SignPackage();
                }
            }
        }

        // a user wishes to fill the "common" fields with default values..
        private void mnuFillWithDefaults_Click(object sender, EventArgs e)
        {
            tbCopyright.Text = AssemblyCopyright;
            tbIconURL.Text = AssemblyIconUrl;
            cbRequireLicenseAcceptance.Checked = AssemblyMustAcceptLicense;
        }

        // a user wishes to select a license..
        private void btSelectLicenseByType_Click(object sender, EventArgs e)
        {
            SPDXLicense license;
            // show the SPDX license dialog..
            if ((license = FormDialogQuerySPDXLicense.Execute()) != null)
            {
                // create a list of SPDXLicense class instances..
                List<SPDXLicense> licenses = new List<SPDXLicense>(new[] { license });

                // set the selected license to the Tag property of the text box..
                tbLicenseFile.Tag = licenses;

                // set the text for the text box to match the license list..
                tbLicenseFile.Text = SPDXLicenseCollection.ConstructLicenseString(licenses);

                // set the target to nothing..
                tbLicenseFileTarget.Text = string.Empty;
            }

            SetLicenseElementSpdx(nuspec, tbLicenseFile.Tag);
        }

        // a user wishes to add to an existing license (https://spdx.org/spdx-specification-21-web-version#h.jxpfx0ykyb60)..
        private void btAddLicenseByType_Click(object sender, EventArgs e)
        {
            SPDXLicense license;
            // show the SPDX license dialog..
            if ((license = FormDialogQuerySPDXLicense.Execute()) != null)
            {
                // if the license list is already stored in the Tag value, then add to it..
                if (tbLicenseFile.Tag != null && tbLicenseFile.Tag.GetType() == typeof(List<SPDXLicense>))
                {
                    // get a list of SPDXLicense class instances..
                    List<SPDXLicense> licenses = (List<SPDXLicense>)tbLicenseFile.Tag;

                    // add the license to the list..
                    licenses.Add(license);

                    // set the Tag property of the text box..
                    tbLicenseFile.Tag = licenses;

                    // set the text for the text box to match the license list..
                    tbLicenseFile.Text = SPDXLicenseCollection.ConstructLicenseString(licenses);

                    // set the target to nothing..
                    tbLicenseFileTarget.Text = string.Empty;
                }
                // create a new instance of List<SPDXLicense> and add the selected license to it..
                else
                {
                    // create a list of SPDXLicense class instances..
                    List<SPDXLicense> licenses = new List<SPDXLicense>(new[] { license });

                    // set the Tag value..
                    tbLicenseFile.Tag = licenses;

                    // set the text for the text box to match the license list..
                    tbLicenseFile.Text = SPDXLicenseCollection.ConstructLicenseString(licenses);

                    // set the target to nothing..
                    tbLicenseFileTarget.Text = string.Empty;
                }
            }
            SetLicenseElementSpdx(nuspec, tbLicenseFile.Tag);
        }

        // a user wishes to use a file for a license..
        private void btLicenseFile_Click(object sender, EventArgs e)
        {
            if (sender.Equals(btLicenseFile))
            {
                if (odAnyFile.ShowDialog() == DialogResult.OK)
                {
                    SetLicenseElementFile(nuspec, odAnyFile.FileName, tbLicenseFileTarget.Text, nuspecFile);

                    string relativePath =
                        RelativePath.GetRelativePath(odAnyFile.FileName, nuspecFile);

                    tbLicenseFile.Tag = relativePath;
                    tbLicenseFile.Text = Path.GetFileName(odAnyFile.FileName);
                    tbLicenseFileTarget.Text = string.Empty;
                }
            }
            else if (sender.Equals(btIconFile) || sender.Equals(tbIconTarget))
            {
                if (odIconFile.ShowDialog() == DialogResult.OK)
                {
                    SetIconElementFile(nuspec, odIconFile.FileName, tbIconTarget.Text, nuspecFile);
                    string relativePath =
                        RelativePath.GetRelativePath(odIconFile.FileName, nuspecFile);

                    tbIcon.Tag = relativePath;
                    tbIcon.Text = Path.GetFileName(odIconFile.FileName);
                    tbIconTarget.Text = string.Empty;
                }
            }
        }

        // clear a one of the deprecated boxes..
        private void btClearDeprecatedText_Click(object sender, EventArgs e)
        {
            if (sender.Equals(btClearLicenseUrl))
            {
                tbLicenseUrl.Text = string.Empty;
            }
            else if (sender.Equals(btClearIconUrl))
            {
                tbIconURL.Text = string.Empty;
            }
        }

        // a user wishes to check for updates for the current nuget.exe..
        private void mnuUpdateNuGetEXE_Click(object sender, EventArgs e)
        {
            UpdateNugetExe();
        }

        // a user wishes to enter the NuGet API keys..
        private void mnuEnterAPIKeys_Click(object sender, EventArgs e)
        {
            FormDialogApiKeys.Execute(ref apiKey, ref testApiKey);
        }

        // a user toggles the test NuGet check box..
        private void cbTestNuGet_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            btApiKey.Tag = checkBox.Checked ? testApiKey : apiKey;
            btApiKey.Text = bool.Parse(pnToggleApiKeyVisible.Tag.ToString())
                ? btApiKey.Tag.ToString()
                : new string('•', btApiKey.Tag.ToString().Length);

            // ReSharper disable once StringLiteralTypo
            btPushNugetPackage.Text = checkBox.Checked ? "Push NuGet package to the int.nugettest.org" : "Push NuGet package to the nuget.org";
        }

        // show to user the about dialog..
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ReSharper disable once ObjectCreationAsStatement
            new VPKSoft.About.FormAbout(this, "MIT", "https://github.com/VPKSoft/MageANuGet/blob/master/LICENSE");
        }

        // shows the detail dialog for the code signing certificate settings..
        private void MnuCertificateSettings_Click(object sender, EventArgs e)
        {
            new FormDialogCertificate().ShowDialog(ref certificatePassword, ref certificateTimeStampServer,
                ref certificateFile);
        }

        // the user wishes to change, add or update the certificate settings..
        private void CbUseCodeSigningCertificate_CheckedChanged(object sender, EventArgs e)
        {
            var checkBox = (CheckBox) sender;

            if (checkBox.Checked)
            {
                if (certificatePassword == string.Empty || certificateFile == string.Empty ||
                    certificateTimeStampServer == string.Empty)
                {
                    new FormDialogCertificate().ShowDialog(ref certificatePassword, ref certificateTimeStampServer,
                        ref certificateFile);

                    if (certificatePassword == string.Empty || certificateFile == string.Empty ||
                        certificateTimeStampServer == string.Empty)
                    {
                        checkBox.Checked = false;
                    }
                }
            }

            signPackage = checkBox.Checked;
        }

        private void mnuTest_Click(object sender, EventArgs e)
        {
            if (odIconFile.ShowDialog() == DialogResult.OK)
            {
                var iconFile = odIconFile.FileName;
                MessageBox.Show(RelativePath.GetRelativePath(iconFile, nuspecFile));
            }
        }

        private void tcMain_Selected(object sender, TabControlEventArgs e)
        {
            if (nuspecFile != null && e.TabPage.Equals(tabNuspec))
            {
                scintillaNuspecContents.Text = nuspec.ToString();
            }
        }

        private void tcMain_Click(object sender, EventArgs e)
        {
            var tabControl = (TabControl) sender;
            if (nuspec != null && tabControl.SelectedTab.Equals(tabNuspec))
            {
                scintillaNuspecContents.Text = @"<?xml version=""1.0""?>" + Environment.NewLine + nuspec;
            }
        }

        private void mnuSaveChanges_Click(object sender, EventArgs e)
        {
            SaveXmlData();
        }

        private void tbSimpleElement_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox) sender;
            SetSimpleElement(nuspec, textBox.Tag.ToString(), textBox.Text);
        }

        private void lbCopyright_Click(object sender, EventArgs e)
        {
            tbCopyright.SelectedText = "©";
        }

        private void cbRequireLicenseAcceptance_CheckedChanged(object sender, EventArgs e)
        {
            var checkBox = (CheckBox) sender;
            SetSimpleElement(nuspec, checkBox.Tag.ToString(), checkBox.Checked.ToString().ToLower());
        }

        private void pnToggleApiKeyVisible_Click(object sender, EventArgs e)
        {
            var panel = (Panel) sender;
            var enabled = !bool.Parse(panel.Tag.ToString());
            panel.Tag = enabled.ToString();

            panel.BackgroundImage =
                enabled ? Properties.Resources.eye_password_visible : Properties.Resources.eye_password_hidden;

            btApiKey.Text = enabled 
                ? btApiKey.Tag.ToString()
                : new string('•', btApiKey.Tag.ToString().Length);
        }

        private void btSaveXMLChanges_Click(object sender, EventArgs e)
        {
            if (nuspec != null)
            {
                try
                {
                    nuspec = XDocument.Parse(scintillaNuspecContents.Text);
                    SaveXmlData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($@"XML parsing error: {ex.Message}.", @"Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
        }
        private void dgvFiles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dataGridView = (DataGridView)sender;

            if (dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                if (odAnyFile.ShowDialog() == DialogResult.OK)
                {
                    var relativePath = RelativePath.GetRelativePath(odAnyFile.FileName, nuspecFile);
                    dataGridView.Rows[e.RowIndex].Cells[colFile.Index].Value = relativePath;
                }
            }
        }
        private void dgvFiles_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            var dataGridView = (DataGridView) sender;
            if (dataGridView.Rows[e.RowIndex].Cells[colUseContentElement.Index].Value is bool isContentElementRow)
            {
                if (!isContentElementRow)
                {
                    if (e.ColumnIndex == colBuildAction.Index ||
                        e.ColumnIndex == colCopyToOutput.Index ||
                        e.ColumnIndex == colFlatten.Index)
                    {
                        e.Cancel = true;
                    }
                }
                else
                {
                    if (e.ColumnIndex == colTarget.Index)
                    {
                        e.Cancel = true;
                    }
                }
            }
        }

        private void btUndoFileChanges_Click(object sender, EventArgs e)
        {
            DisplayFileElements();
        }

        private void btSaveFileChanges_Click(object sender, EventArgs e)
        {
            UpdateFiles();
            SaveXmlData();
        }

        private void HelpLink_Click(object sender, EventArgs e)
        {
            var label = (Label) sender;
            try
            {
                Process.Start(label.Tag.ToString());
            }
            catch
            {
                // ignored..
            }
        }
        #endregion
    }
}
