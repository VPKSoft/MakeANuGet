using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakeANuGet.DialogForms
{
    /// <summary>
    /// A dialog form to query a description for MSI package signing.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class FormDialogQueryDescription : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormDialogQueryDescription"/> class.
        /// </summary>
        public FormDialogQueryDescription()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Shows the form as a modal dialog box.
        /// </summary>
        /// <returns>A string containing the user-entered description for MSI signing if one was provided; null otherwise.</returns>
        public new static string ShowDialog()
        {
            var form = new FormDialogQueryDescription();
            if (form.ShowDialog(null) == DialogResult.OK)
            {
                return form.tbDescription.Text.Trim() == string.Empty ? null : form.tbDescription.Text.Trim();
            }

            return null;
        }
    }
}
