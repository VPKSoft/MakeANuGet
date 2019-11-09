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

namespace MakeANuGet
{
    /// <summary>
    /// A dialog to select a SPDX license from a list.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    // ReSharper disable once InconsistentNaming
    public partial class FormDialogQuerySPDXLicense : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormDialogQuerySPDXLicense"/> class.
        /// </summary>
        public FormDialogQuerySPDXLicense()
        {
            InitializeComponent();

            // list the licenses..
            ListLicenses();
        }

        /// <summary>
        /// An internal list of the SPDX licenses.
        /// </summary>
        // ReSharper disable once InconsistentNaming
        internal static SPDXLicenseCollection SPDXLicenseCollection = new SPDXLicenseCollection();

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            // list the licenses..
            ListLicenses();
        }

        /// <summary>
        /// Lists the SPDX licenses contained within the class either by using a search string or list all of the licenses.
        /// </summary>
        private void ListLicenses()
        {
            // cleat the list box..
            lbLicenseList.Items.Clear();

            // a variable for the license list..

            // if the search text box isn't empty then filter the licenses..
            var licenses = tbSearch.Text.Trim() != string.Empty
                ? SPDXLicenseCollection.SearchSPDXLicenses(tbSearch.Text)
                : SPDXLicenseCollection.GetSPDXLicenses();

            // loop through the collection and add the licenses to the list box..
            foreach (SPDXLicense license in licenses)
            {
                lbLicenseList.Items.Add(license);
            }

            // after a search there is no selected item in the list box..
            btOK.Enabled = false; // ..so disable the OK button..
        }

        // set the OK button to enabled/disabled based on whether there is an item selected..
        private void lbLicenseList_SelectedIndexChanged(object sender, EventArgs e)
        {
            btOK.Enabled = lbLicenseList.SelectedIndex != -1;
        }

        /// <summary>
        /// Displays the dialog and returns the user selected license.
        /// </summary>
        /// <returns>An instance to a SPDXLicense class if one was selected; otherwise null.</returns>
        public static SPDXLicense Execute()
        {
            // create a new instance of "this" class..
            FormDialogQuerySPDXLicense licenseQuery = new FormDialogQuerySPDXLicense();

            // show the dialog..
            if (licenseQuery.ShowDialog() == DialogResult.OK)
            {
                // if OK, then return the selected license..
                return licenseQuery.lbLicenseList.SelectedItem as SPDXLicense;
            }
            else
            {
                // the user canceled so return null..
                return null;
            }
        }
    }
}
