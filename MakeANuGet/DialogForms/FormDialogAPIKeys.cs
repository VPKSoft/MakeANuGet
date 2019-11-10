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
using System.Windows.Forms;

namespace MakeANuGet.DialogForms
{
    /// <summary>
    /// A dialog for saving or changing your NuGet API keys.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class FormDialogApiKeys : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormDialogApiKeys"/> class.
        /// </summary>
        public FormDialogApiKeys()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Shows an instance of this dialog to query NuGet API keys from the user.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        /// <param name="apiTestKey">The API test key.</param>
        public static void Execute(ref string apiKey, ref string apiTestKey)
        {
            // create an instance of this class..
            FormDialogApiKeys formDialogApiKeys = new FormDialogApiKeys
            {
                tbNuGetAPIKey = {Text = apiKey}, tbTestNuGetAPIKey = {Text = apiTestKey}
            };

            // set the API keys..

            // if the user accepted, save the given API keys..
            if (formDialogApiKeys.ShowDialog() == DialogResult.OK)
            {
                apiKey = formDialogApiKeys.tbNuGetAPIKey.Text;
                apiTestKey = formDialogApiKeys.tbTestNuGetAPIKey.Text;
            }
        }

        // at least the main API key is required..
        private void tbNuGetAPIKey_TextChanged(object sender, EventArgs e)
        {
            btOK.Enabled = ((TextBox)sender).Text.Trim() != string.Empty;
        }

        // a link label was clicked..
        private void common_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel linkLabel = (LinkLabel)sender;
            System.Diagnostics.Process.Start(linkLabel.Text);
        }
    }
}
