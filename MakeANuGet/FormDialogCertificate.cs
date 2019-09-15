using System.IO;
using System.Windows.Forms;

namespace MakeANuGet
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
