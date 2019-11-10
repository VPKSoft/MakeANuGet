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

using System.IO;
using System.Windows.Forms;

namespace MakeANuGet.DialogForms
{
    /// <summary>
    /// A dialog to fill code signing certificate details.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class FormDialogCertificate : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormDialogCertificate"/> class.
        /// </summary>
        public FormDialogCertificate()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Shows the form as a modal dialog box.
        /// </summary>
        /// <param name="certificatePassword">The code signing certificate password.</param>
        /// <param name="certificateTimeStampServer">The code signing certificate time stamp server.</param>
        /// <param name="certificateFile">The code signing certificate file.</param>
        /// <returns>One of the <see cref="T:System.Windows.Forms.DialogResult" /> values.</returns>
        public DialogResult ShowDialog(ref string certificatePassword, ref string certificateTimeStampServer,
            ref string certificateFile)
        {
            var form = new FormDialogCertificate
            {
                tbCertificateFile = {Text = certificateFile},
                tbCertificatePassword = {Text = certificatePassword},
                tbCertificateTimeStampServer = {Text = certificateTimeStampServer}
            };

            var dialogResult = form.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                certificateFile = form.tbCertificateFile.Text;
                certificatePassword = form.tbCertificatePassword.Text;
                certificateTimeStampServer = form.tbCertificateTimeStampServer.Text;
            }

            return dialogResult;
        }

        private void BtCertificateFile_Click(object sender, System.EventArgs e)
        {
            if (File.Exists(tbCertificateFile.Text))
            {
                odCertificate.InitialDirectory = Path.GetDirectoryName(tbCertificateFile.Text);
                odCertificate.FileName = tbCertificateFile.Text;
            }

            if (odCertificate.ShowDialog() == DialogResult.OK)
            {
                tbCertificateFile.Text = odCertificate.FileName;
            }
        }
    }
}
