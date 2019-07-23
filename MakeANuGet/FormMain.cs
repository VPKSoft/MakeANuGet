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
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using VPKSoft.Utils;
using System.Diagnostics;
using System.Threading;
using System.Xml;
using System.Reflection;

namespace MakeANuGet
{
    /// <summary>
    /// The main form for the MakeANuGet software.
    /// </summary>
    public partial class FormMain : Form
    {
        // use the self developed "not a markup language"..
        private VPKNml vnml = null;

        // the settings path (%LOCALAPPDATA%\MakeANuGet)
        private string settingsPath;

        // the settings file name (to store the API key only)..
        private string settingsFile;

        // the C# project file (*.cs) to make the NuGet from..
        private string csprojFile;

        // the .nuspec file for the NuGet package generation..
        private string nuspecFile;

        // the .nuspec file is a XML document..
        XmlDocument nuspec;

        // a binary path for the release folder of your library..
        string binaryPath;

        // an assembly name for your library..
        string assemblyName;

        // the assembly which from which to NuGet package is to be created..
        Assembly assemblyNuget;

        // your nuget.org API key
        string apiKey;

        // your apiint.nugettest.org API key
        string testApiKey;

        // a path to the common settings .vnml file..
        string vmmlPath;

        /// <summary>
        /// The main form for the software.
        /// </summary>
        public FormMain()
        {
            InitializeComponent();

            // create the settings folder if it doesn't already exists (%LOCALAPPDATA%\MakeANuGet)..
            settingsPath = Paths.MakeAppSettingsFolder();

            // load the NuGet API key..
            vnml = new VPKNml();
            settingsFile = Path.Combine(settingsPath, "settings.vnml");
            vmmlPath = Path.Combine(settingsPath, "defaults.vnml");
            vnml.Load(settingsFile);

            apiKey = vnml["api", "key", ""].ToString();

            testApiKey = vnml["apitest", "key", ""].ToString();

            // set the API key to the text box..
            tbApiKey.Text = cbTestNuGet.Checked ? testApiKey : apiKey;

            SetStepZero();
        }


        #region ValidityChecks
        /// <summary>
        /// The first step is to check if the .nuspec file actually exists and the XML document isn't null.
        /// </summary>
        private void CheckStepOne()
        {
            if (File.Exists(nuspecFile) && nuspec != null)
            {
                btGenerateNuget.Enabled = true; // and enabled the next step..;
                mnuFillWithDefaults.Enabled = true; // set the default fill menu to enabled..
            }
        }

        /// <summary>
        /// Blinks a text box's background color to indicate a missing or an invalid value.
        /// </summary>
        /// <param name="textBox">The text box of which background to blink in case of an error.</param>
        /// <param name="blinkText">The erroneous value (text) for blinking.</param>
        /// <returns>True if the value was invalid; otherwise false.</returns>
        private bool BlinkTextBox(TextBox textBox, string blinkText)
        {
            return BlinkTextBox(textBox, (() => { return textBox.Text == blinkText || textBox.Text.Trim() == string.Empty; }));
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
                    if ((i % 2) == 0)
                    {
                        textBox.BackColor = Color.Red;
                    }
                    else
                    {
                        textBox.BackColor = SystemColors.Window;
                    }
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
                  BlinkTextBox(tbLicenseFile, (() => { return tbLicenseFile.Tag == null; })) ||
                  BlinkTextBox(tbProjectURL, "http://PROJECT_URL_HERE_OR_DELETE_THIS_LINE") ||
                  BlinkTextBox(tbIconURL, "http://ICON_URL_HERE_OR_DELETE_THIS_LINE") ||
                  BlinkTextBox(tbReleaseNotes, "Summary of changes made in this release of the package.") ||
                  BlinkTextBox(tbCopyright, "Copyright " + DateTime.Now.Year));
        }

        /// <summary>
        /// Clear all data if another project is loaded.
        /// </summary>
        private void SetStepZero()
        {
            csprojFile = null;
            nuspecFile = null;
            nuspec = null;
            assemblyNuget = null;

            binaryPath = null;
            assemblyName = null;
            mnuFillWithDefaults.Enabled = false;
            btGenerateNuget.Enabled = false;
            btPushNugetPackage.Enabled = false;
            btGenerateNugetPackage.Enabled = false;

            btAddLicenseByType.Enabled = false;
            btSelectLicenseByType.Enabled = false;
            btLicenseFile.Enabled = false;
            btClearLicenseUrl.Enabled = false;
            cbTestNuGet.Enabled = false;
        }
        #endregion

        // a user wishes to open a project (.cs) to generate a NuGet package..
        private void mnuOpenProject_Click(object sender, EventArgs e)
        {
            // display an open file dialog for the .csproj file..
            if (odCSProj.ShowDialog() == DialogResult.OK)
            {
                // clear the data..
                SetStepZero();
            
                // save the file name..
                csprojFile = odCSProj.FileName;

                // set the form's title..
                Text = $"Make a NuGet - [{csprojFile}]";

                // get a file name for the .nuspec file..
                nuspecFile = Path.ChangeExtension(csprojFile, ".nuspec");

                // create a XML document (traditional - sorry) ;-)   ..
                XmlDocument csproj = new XmlDocument();

                // load the .csproj file..
                csproj.Load(csprojFile);

                // set the initial directory for the 
                odAnyFile.InitialDirectory = Path.GetDirectoryName(csprojFile);                                

                // get the assembly name and the binary path from the .csproj file for the NuGet generation..
                foreach (XmlNode node in csproj.DocumentElement.ChildNodes)
                {
                    // catch the PropertyGroup node..
                    if (node.Name == "PropertyGroup")
                    {
                        // loop through the child nodes of the PropertyGroup node..
                        foreach (XmlNode propertyGroupNode in node.ChildNodes)
                        {
                            // try to get the assembly name with the following conditions..
                            if (propertyGroupNode.Name == "AssemblyName" && 
                                assemblyName == null &&
                                node.Attributes["Condition"] == null)
                            {
                                assemblyName = propertyGroupNode.InnerText; // ..found, so set it..
                            }
                            // try to get release output path with the following conditions..
                            else if (propertyGroupNode.Name == "OutputPath" && 
                                binaryPath == null && 
                                node.Attributes["Condition"] != null &&
                                node.Attributes["Condition"].Value.Trim(' ') == " '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ".Trim(' '))
                            {
                                binaryPath = propertyGroupNode.InnerText; // ..found, so set it..
                            }

                            // if the required information was found then break the loop..
                            if (binaryPath != null && assemblyName != null)
                            {
                                break;
                            }
                        }
                    }

                }

                // combine the assembly DLL name..
                binaryPath = Path.Combine(Path.GetDirectoryName(csprojFile), binaryPath, assemblyName + ".dll");

                // load the assembly to get data from it..
                assemblyNuget = Assembly.LoadFile(binaryPath);

                // if the .nuspec already exists, then load it..
                if (File.Exists(nuspecFile))
                {
                    nuspec = new XmlDocument();
                    nuspec.Load(nuspecFile);
                    btGenerateNugetPackage.Enabled = true; // and enabled the next step..
                    mnuFillWithDefaults.Enabled = true; // set the default fill menu to enabled..
                    btAddLicenseByType.Enabled = true; // enabled..
                    btSelectLicenseByType.Enabled = true; // enabled..
                    btLicenseFile.Enabled = true; // enabled..
                    btClearLicenseUrl.Enabled = true; // enabled..
                    cbTestNuGet.Enabled = true; // enabled..

                    DisplayXMLData(); // display the loaded data..
                }

                // enable the NuGet generation button..
                btGenerateNuget.Enabled = true;
            }
        }

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
                object[] obj = assemblyNuget.GetCustomAttributes(false);

                // loop through the attributes..
                foreach (object o in obj)
                {
                    // if a AssemblyCopyrightAttribute exists..
                    if (o.GetType() == typeof(System.Reflection.AssemblyCopyrightAttribute))
                    {
                        // return it as a string..
                        AssemblyCopyrightAttribute aca = (AssemblyCopyrightAttribute)o;
                        return aca.Copyright;
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
        private string AssemblyIconURL
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

        /// <summary>
        /// Displays the relevant contents of the .nuspec file.
        /// </summary>
        private void DisplayXMLData()
        {
            if (nuspec != null)
            {
                // loop through the nodes as in the old times..
                foreach (XmlNode node in nuspec.DocumentElement.FirstChild.ChildNodes)
                {
                    if (node.Name == "tags") // value found so display it..
                    {
                        tbTags.Text = node.InnerText;
                    }
                    else if (node.Name == "licenseUrl") // value found so display it..
                    {
                        tbLicenseUrl.Text = node.InnerText;
                    }
                    else if (node.Name == "projectUrl") // value found so display it..
                    {
                        tbProjectURL.Text = node.InnerText;
                    }
                    else if (node.Name == "iconUrl") // value found so display it..
                    {
                        tbIconURL.Text = node.InnerText;
                    }
                    else if (node.Name == "releaseNotes") // value found so display it..
                    {
                        tbReleaseNotes.Text = node.InnerText;
                    }
                    else if (node.Name == "copyright") // value found so display it..
                    {
                        tbCopyright.Text = node.InnerText;
                    }
                    else if (node.Name == "description") // value found so display it..
                    {
                        tbDescription.Text = node.InnerText;
                    }
                    else if (node.Name == "requireLicenseAcceptance") // value found so display it..
                    {
                        cbRequireLicenseAcceptance.Checked = bool.Parse(node.InnerText);
                    }
                    // value found so display it; gets trickier here as there are a few different options for
                    // the new license attribute..
                    else if (node.Name == "license") 
                    {
                        // the "expression" license may contain many SPDX licenses listed by the Linux Foundation (https://spdx.org/licenses/)..
                        if (node.Attributes["type"].Value == "expression")
                        {
                            // construct a list of SPDX licenses..
                            List<SPDXLicense> licenses = new List<SPDXLicense>();

                            // the licenses are combined with a text " OR " or " AND ", so split them..
                            string[] licenseIds = node.InnerText.Split(new string[] { " OR ", " AND " }, StringSplitOptions.RemoveEmptyEntries);

                            // get a licenses for each occurrence..
                            foreach (string licenseId in licenseIds)
                            {
                                // ..and add them to the list..
                                licenses.Add(FormDialogQuerySPDXLicense.SPDXLicenseCollection.GetLicenseByIdentifier(licenseId));
                            }

                            // set the text "as is"..
                            tbLicenseFile.Text = node.InnerText;

                            // save the licenses to the text box's Tag property..
                            tbLicenseFile.Tag = licenses;
                        }
                        // a license may also be an embedded file within the NuGet..
                        else if (node.Attributes["type"].Value == "file")
                        {
                            // the file name is without a path..
                            tbLicenseFile.Text = node.InnerText;

                            // the files node in the .nuspec file must contain a relative path the license file
                            // so do try to get it..
                            tbLicenseFile.Tag = GetLicenseFileNode(nuspec, node.InnerText);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Saves the data on the form to the .nuspec file.
        /// </summary>
        private void SaveXMLData()
        {
            // a node containing the deprecated "licenseUrl", 
            // mark as null to detect if one was found further in the code..
            XmlNode nodeLicenseUrl = null;

            if (nuspec != null)
            {
                // a flag indicating whether a license node exists within the .nuspec file..
                bool licenseFileOrSPDXNodeExists = false;

                // loop through the nodes as in the old times..
                foreach (XmlNode node in nuspec.DocumentElement.FirstChild.ChildNodes)
                {
                    if (node.Name == "tags") // value found so save it..
                    {
                        node.InnerText = tbTags.Text;
                    }
                    else if (node.Name == "licenseUrl") // value found so save it..
                    {
                        // if a deprecated node containing the license URL is found
                        // add it to a removal variable if not defined..
                        if (tbLicenseUrl.Text == string.Empty)
                        {
                            nodeLicenseUrl = node;
                        }
                        else
                        {
                            node.InnerText = tbLicenseUrl.Text; // value found so save it..
                        }
                    }
                    else if (node.Name == "projectUrl") // value found so save it..
                    {
                        node.InnerText = tbProjectURL.Text;
                    }
                    else if (node.Name == "iconUrl") // value found so save it..
                    {
                        node.InnerText = tbIconURL.Text;
                    }
                    else if (node.Name == "releaseNotes") // value found so save it..
                    {
                        node.InnerText = tbReleaseNotes.Text;
                    }
                    else if (node.Name == "copyright") // value found so save it..
                    {
                        node.InnerText = tbCopyright.Text;
                    }
                    else if (node.Name == "description") // value found so save it..
                    {
                        node.InnerText = tbDescription.Text;
                    }
                    else if (node.Name == "requireLicenseAcceptance") // value found so save it..
                    {
                        node.InnerText = cbRequireLicenseAcceptance.Checked.ToString().ToLowerInvariant();
                    }
                    // value found so save it; gets trickier here as there are a few different options for
                    // the new license attribute..
                    else if (node.Name == "license")
                    {
                        // the license data if any is stored in the tag of the
                        // license text box..
                        object license = tbLicenseFile.Tag;

                        // if license data was found, parse it..
                        if (license != null)
                        {
                            // a license file should be embedded within the NuGet..
                            if (license.GetType() == typeof(string))
                            {
                                // set the type attribute value to "file"..
                                XmlAttribute attribute = nuspec.CreateAttribute("type");
                                attribute.Value = "file";

                                // save the file name to the node's inner text..
                                node.InnerText = tbLicenseFile.Text;

                                // set the attribute's value..
                                node.Attributes.Append(attribute);
                            }
                            // the "expression" license may contain many SPDX licenses listed by the Linux Foundation (https://spdx.org/licenses/)..
                            else if (license.GetType() == typeof(List<SPDXLicense>))
                            {
                                // set the type attribute value to "expression"..
                                XmlAttribute attribute = nuspec.CreateAttribute("type");
                                attribute.Value = "expression";

                                // get the list of licenses from the tag..
                                List<SPDXLicense> licenses = (List<SPDXLicense>)license;

                                // select the license identifiers..
                                var licenseStrings = licenses.Select(f => f.Identifier);

                                // and concatenate them with a separate string of " OR "..
                                node.InnerText = string.Join(" OR ", licenseStrings);

                                // set the attribute's value..
                                node.Attributes.Append(attribute);
                            }
                        }

                        // set the flag indicating whether a license node exists within the .nuspec file..
                        licenseFileOrSPDXNodeExists = true;
                    }
                }

                // if the new "license" node was found, then finish constructing the it..
                if (!licenseFileOrSPDXNodeExists)
                {
                    // first just create a dummy element with a type attribute value of "none"..
                    XmlElement element = nuspec.CreateElement("license");
                    element.InnerText = "";
                    element.SetAttribute("type", "none");

                    // get the license attribute's value..
                    object license = tbLicenseFile.Tag;

                    // ..only do something with it if there is something to do with (haha)..
                    if (license != null)
                    {
                        // a type of string indicates a file license..
                        if (license.GetType() == typeof(string))
                        {
                            // set the attribute's type to a file..
                            XmlAttribute attribute = nuspec.CreateAttribute("type");
                            attribute.Value = "file";

                            // and set the node's contents a file name..
                            element.InnerText = tbLicenseFile.Text;

                            // append the attribute..
                            element.Attributes.Append(attribute);

                            // a file node must also be added if the license type is file..
                            AppendLicenseFileNode(nuspec, license as string);
                        }
                        // the license type is "expression" == SPDX license - in the saving phase
                        // this is actually easier to handle..
                        else if (license.GetType() == typeof(List<SPDXLicense>))
                        {
                            // set the attribute's type to an expression..
                            XmlAttribute attribute = nuspec.CreateAttribute("type");
                            attribute.Value = "expression";

                            // get the license list..
                            List<SPDXLicense> licenses = (List<SPDXLicense>)license;

                            // get the license identifiers in the license list..
                            var licenseStrings = licenses.Select(f => f.Identifier);

                            // concatenate the contained license(s) with " OR "..
                            element.InnerText = string.Join(" OR ", licenseStrings);

                            // append the attribute..
                            element.Attributes.Append(attribute);
                        }
                    }

                    // if the license was defined, the append it to the XML (.nuspec)..
                    if (license != null)
                    {
                        nuspec.DocumentElement.FirstChild.AppendChild(element);
                    }
                }

                // if the URL definition was empty..
                if (nodeLicenseUrl != null)
                {
                    // ..remove it as it's deprecated..
                    nuspec.DocumentElement.FirstChild.RemoveChild(nodeLicenseUrl);
                }

                // save the .nuspec..
                nuspec.Save(nuspecFile);
            }
        }

        /// <summary>
        /// Gets the file element containing the license file in a .nuspec file from the files section.
        /// </summary>
        /// <param name="document">An XML document with the data (.nuspec).</param>
        /// <param name="fileName">The file name of the license file.</param>
        /// <returns>A relative path contained in the XML node: files.</returns>
        private string GetLicenseFileNode(XmlDocument document, string fileName)
        {
            // first assume a null value..
            XmlNode fileNode = null;

            // loop through the nodes again..
            foreach (XmlNode node in document.DocumentElement)
            {
                // if a files node was found..
                if (node.Name == "files")
                {
                    fileNode = node; // save it to a variable..
                    break; // ..and break..
                }
            }

            // nothing found - nothing to do..
            if (fileNode == null)
            {
                return null;
            }

            // try to find a matching file entry from files node..
            foreach (XmlNode node in fileNode.ChildNodes)
            {
                try
                {
                    // if the following conditions are met..
                    if (node.Name == "file" && node.Attributes["src"].Value.EndsWith(fileName) && node.Attributes["target"].Value == string.Empty)
                    {
                        // return the value..
                        return node.Attributes["src"].Value;
                    }
                }
                catch
                {
                    // error occurred, so do continue..
                    continue;
                }
            }
            // fail to null value..
            return null;
        }

        /// <summary>
        /// Appends a file element under the files node in case the license type is file.
        /// </summary>
        /// <param name="document">A XML document (.nuspec) file.</param>
        /// <param name="relativeFileName">The relative file name to append under the files node in the .nuspec file.</param>
        private void AppendLicenseFileNode(XmlDocument document, string relativeFileName)
        {
            // first assume a null value..
            XmlNode fileNode = null;

            // loop through the nodes again..
            foreach (XmlNode node in document.DocumentElement)
            {
                // check if the XML document (.nuspec) contains a files node..
                if (node.Name == "files")
                {
                    fileNode = node; // the node was found so save it..
                    break; // ..and break the loop..
                }
            }

            // a flag indicating if a specific file element was found
            // under the files node..
            bool nodeFound = false;

            // if the files node was found in the document..
            if (fileNode != null)
            {
                // try to find a matching file entry from files node..
                foreach (XmlNode node in fileNode.ChildNodes)
                {
                    try
                    {
                        // if the following conditions are met..
                        if (node.Name == "file" && node.Attributes["src"].Value == relativeFileName && node.Attributes["target"].Value == string.Empty)
                        {
                            // ..set the flag that a correct node already exists..
                            nodeFound = true;
                            break; // ..and break the loop..
                        }
                    }
                    catch
                    {
                        // error occurred, so do continue..
                        continue;
                    }
                }

                // if no node was found then create one..
                if (!nodeFound)
                {
                    // it is a file node..
                    XmlNode node = document.CreateNode("element", "file", "");

                    // it has an attribute called "src"..
                    XmlAttribute src = nuspec.CreateAttribute("src");

                    // ..and it has an attribute called "target"..
                    XmlAttribute target = nuspec.CreateAttribute("target");

                    // set the "src" attribute's value to the relative file name..
                    src.Value = relativeFileName;

                    // the "target" attribute's value in this case is empty..
                    target.Value = string.Empty;

                    // append the attributes to the node..
                    node.Attributes.Append(src);
                    node.Attributes.Append(target);

                    // append the node..
                    fileNode.AppendChild(node);
                }
            }
            // no files node was found in the .nuspec..
            else
            {
                // ..so construct one..
                fileNode = document.CreateNode("element", "files", "");

                // again add the attributes to the file node..
                XmlNode node = document.CreateNode("element", "file", "");
                XmlAttribute src = nuspec.CreateAttribute("src");
                XmlAttribute target = nuspec.CreateAttribute("target");


                // set the "src" attribute's value to the relative file name..
                src.Value = relativeFileName;

                // the "target" attribute's value in this case is empty..
                target.Value = string.Empty;

                // append the attributes to the node..
                node.Attributes.Append(src);
                node.Attributes.Append(target);

                // append the file node to the files node..
                fileNode.AppendChild(node);

                // append the files node to the document's root node as a child..
                document.DocumentElement.AppendChild(fileNode);
            }
        }

        // a user decided to close the form, so save some setting which
        // are presumed to be constant for the developer..
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            vnml["api", "key"] = apiKey; // the NuGet API key..
            vnml["apitest", "key"] = testApiKey; // the test NuGet API key..
            vnml.Save(settingsFile);

            // the assembly copyright..
            AssemblyCopyright = tbCopyright.Text;

            // the need for a "consumer" to accept the license..
            AssemblyMustAcceptLicense = cbRequireLicenseAcceptance.Checked;

            // an icon URL for the NuGet..
            AssemblyIconURL = tbIconURL.Text;
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
                SaveXMLData();

                // generate a NuGet package..
                if (RunSpecNuGet(" pack -Prop Configuration=Release"))
                {
                    // if successful, enable the push NuGet button..
                    btPushNugetPackage.Enabled = true;
                }
            }
        }

        // a user wishes to push the NuGet package to nuget.org (https://www.nuget.org)..
        private void btPushNugetPackage_Click(object sender, EventArgs e)
        {
            // enumerate the files in the directory where the .csproj file resides..
            string[] nupkgs = Directory.GetFiles(Path.GetDirectoryName(csprojFile), "*.nupkg");

            // initialize a list of FileInfo class instances..
            List<FileInfo> nupkgsInfo = new List<FileInfo>();

            // loop through the gotten files and get their information..
            foreach (string nupkg in nupkgs)
            {
                nupkgsInfo.Add(new FileInfo(nupkg));
            }

            // sort the files with their last write times..
            nupkgsInfo = nupkgsInfo.OrderBy(f => f.LastWriteTime).ToList();

            // pick the newest file..
            string np = Path.GetFileName(nupkgsInfo.Last().Name);

            // push the NuGet package to nuget.org (https://int.nugettest.org) (NOTE: For testing!)..
            if (cbTestNuGet.Checked)
            {
                RunSpecNuGet($" push {np} {tbApiKey.Text} -Source https://apiint.nugettest.org/v3/index.json");
            }
            // push the NuGet package to nuget.org (https://www.nuget.org)..
            else
            {
                RunSpecNuGet($" push {np} {tbApiKey.Text} -Source https://api.nuget.org/v3/index.json");
            }            
        }

        /// <summary>
        /// Updates the contained nuget.exe.
        /// </summary>
        private void UpdateNugetEXE()
        {
            string processPath = Path.Combine(VPKSoft.Utils.Paths.AppInstallDir, "nuget.exe");

            // the output from the nuget.exe is piped to the lower black text box..
            tbProcessOutput.AppendText("> " + processPath + " update - self" + Environment.NewLine);

            // create a process..
            Process process = new Process();

            // give it the process file name..
            process.StartInfo.FileName = processPath;

            // give the process it's arguments..
            process.StartInfo.Arguments = "update -self";

            // no shell execution..
            process.StartInfo.UseShellExecute = false;

            // no exclusive window..
            process.StartInfo.CreateNoWindow = true;

            // set the working directory to the same as the .csproj file location..
            process.StartInfo.WorkingDirectory = Path.GetDirectoryName(csprojFile);

            // redirect the process output(s)..
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;

            // subscribe to the process events with anonymous event handlers..
            process.OutputDataReceived += new DataReceivedEventHandler((sender, e) =>
            {
                // append new line endings to the each output string..
                if (!String.IsNullOrEmpty(e.Data))
                {
                    // invocation is required (another process)..
                    Invoke(new MethodInvoker(delegate { tbProcessOutput.AppendText(e.Data + Environment.NewLine); }));
                }
            });

            process.ErrorDataReceived += new DataReceivedEventHandler((sender, e) =>
            {
                // append new line endings to the each output string..
                if (!String.IsNullOrEmpty(e.Data))
                {
                    // invocation is required (another process)..
                    Invoke(new MethodInvoker(delegate { tbProcessOutput.AppendText(e.Data + Environment.NewLine); }));
                }
            });

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

            // first check there is everything in place..
            if (!string.IsNullOrEmpty(csprojFile))
            {
                // assume success..
                returnValue = true;
                // ..\..\nuget\nuget.exe spec ConfLib.csproj - Force
                string processPath = Path.Combine(VPKSoft.Utils.Paths.AppInstallDir, "nuget.exe");

                // the output from the nuget.exe is piped to the lower black text box..
                tbProcessOutput.AppendText("> " + processPath + parameters + Environment.NewLine);

                // create a process..
                Process process = new Process();

                // give it the process file name..
                process.StartInfo.FileName = processPath;

                // give the process it's arguments..
                process.StartInfo.Arguments = parameters;

                // no shell execution..
                process.StartInfo.UseShellExecute = false;

                // no exclusive window..
                process.StartInfo.CreateNoWindow = true;

                // set the working directory to the same as the .csproj file location..
                process.StartInfo.WorkingDirectory = Path.GetDirectoryName(csprojFile);

                // redirect the process output(s)..
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;

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
                    nuspec = new XmlDocument();
                    nuspec.Load(nuspecFile);

                    // display the contents of the .nuspec file..
                    DisplayXMLData();

                    btGenerateNugetPackage.Enabled = true; // and enabled the next step..;
                    mnuFillWithDefaults.Enabled = true; // set the default fill menu to enabled..
                    btAddLicenseByType.Enabled = true; // enabled..
                    btSelectLicenseByType.Enabled = true; // enabled..
                    btLicenseFile.Enabled = true; // enabled..
                    btClearLicenseUrl.Enabled = true; // enabled..
                    cbTestNuGet.Enabled = true; // enabled..


                    // fill empty fields with defaults..
                    tbCopyright.Text = tbCopyright.Text == string.Empty ? AssemblyCopyright : tbCopyright.Text;
                    cbRequireLicenseAcceptance.Checked = AssemblyMustAcceptLicense;
                    tbIconURL.Text = tbIconURL.Text == string.Empty ? AssemblyIconURL : tbIconURL.Text;
                }

                // check the process exit code and show an error dialog if the exit code is not 0..
                if (process.ExitCode != 0)
                {
                    returnValue = false; // indicate failure..
                    MessageBox.Show($"Process exited with an error: {process.ExitCode}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
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

        #region InternalEvents
        // a user wishes to fill the "common" fields with default values..
        private void mnuFillWithDefaults_Click(object sender, EventArgs e)
        {
            tbCopyright.Text = AssemblyCopyright;
            tbIconURL.Text = AssemblyIconURL;
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
                List<SPDXLicense> licenses = new List<SPDXLicense>(new SPDXLicense[] { license });

                // set the selected license to the Tag property of the text box..
                tbLicenseFile.Tag = licenses;

                // set the text for the text box to match the license list..
                tbLicenseFile.Text = SPDXLicenseCollection.ConstructLicenseString(licenses);
            }            
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
                }
                // create a new instance of List<SPDXLicense> and add the selected license to it..
                else
                {
                    // create a list of SPDXLicense class instances..
                    List<SPDXLicense> licenses = new List<SPDXLicense>(new SPDXLicense[] { license });

                    // set the Tag value..
                    tbLicenseFile.Tag = licenses;

                    // set the text for the text box to match the license list..
                    tbLicenseFile.Text = SPDXLicenseCollection.ConstructLicenseString(licenses);
                }
            }
        }

        // a user wishes to use a file for a license..
        private void btLicenseFile_Click(object sender, EventArgs e)
        {
            if (odAnyFile.ShowDialog() == DialogResult.OK)
            {
                string relativePath = odAnyFile.FileName.Replace(Path.GetDirectoryName(csprojFile) + "\\", string.Empty);
                tbLicenseFile.Tag = relativePath;
                tbLicenseFile.Text = Path.GetFileName(odAnyFile.FileName); 
            }
        }

        // clear the deprecated license URL text box..
        private void btClearLicenseUrl_Click(object sender, EventArgs e)
        {
            tbLicenseUrl.Text = string.Empty;
        }

        // a user wishes to check for updates for the current nuget.exe..
        private void mnuUpdateNuGetEXE_Click(object sender, EventArgs e)
        {
            UpdateNugetEXE();
        }

        // a user wishes to enter the NuGet API keys..
        private void mnuEnterAPIKeys_Click(object sender, EventArgs e)
        {
            FormDialogAPIKeys.Execute(ref apiKey, ref testApiKey);
        }

        // a user toggles the test NuGet check box..
        private void cbTestNuGet_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            tbApiKey.Text = checkBox.Checked ? testApiKey : apiKey;
            btPushNugetPackage.Text = checkBox.Checked ? "Push NuGet package to the int.nugettest.org" : "Push NuGet package to the nuget.org";
        }

        // show to user the about dialog..
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new VPKSoft.About.FormAbout(this, "MIT", "https://github.com/VPKSoft/MageANuGet/blob/master/LICENSE");
        }
        #endregion
    }
}
