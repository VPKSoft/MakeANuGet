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

using System.Collections.Generic;
using System.Linq;

namespace MakeANuGet
{
    /// <summary>
    /// A class containing a single SPDX license entry (https://spdx.org/licenses/).
    /// </summary>
    public class SPDXLicense
    {
        /// <summary>
        /// Gets or sets the name of the license.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the license.
        /// </summary>
        public string Identifier { get; set; }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        public override string ToString()
        {
            return Name + $" (ID: {Identifier})";
        }
    }

    /// <summary>
    /// A class containing SPDX license identifiers with their names.
    /// <note type="note">Update at: 2019/02/28.</note>
    /// </summary>
    public class SPDXLicenseCollection
    {
        /// <summary>
        /// The SPDX licenses contained in this class (2019/02/28).
        /// </summary>
        private List<SPDXLicense> licenses = new List<SPDXLicense>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SPDXLicenseCollection"/> class.
        /// </summary>
        public SPDXLicenseCollection()
        {
            licenses.Add(new SPDXLicense { Name = "BSD Zero Clause License", Identifier = "0BSD" });
            licenses.Add(new SPDXLicense { Name = "Attribution Assurance License", Identifier = "AAL" });
            licenses.Add(new SPDXLicense { Name = "Abstyles License", Identifier = "Abstyles" });
            licenses.Add(new SPDXLicense { Name = "Adobe Systems Incorporated Source Code License Agreement", Identifier = "Adobe-2006" });
            licenses.Add(new SPDXLicense { Name = "Adobe Glyph List License", Identifier = "Adobe-Glyph" });
            licenses.Add(new SPDXLicense { Name = "Amazon Digital Services License", Identifier = "ADSL" });
            licenses.Add(new SPDXLicense { Name = "Academic Free License v1.1", Identifier = "AFL-1.1" });
            licenses.Add(new SPDXLicense { Name = "Academic Free License v1.2", Identifier = "AFL-1.2" });
            licenses.Add(new SPDXLicense { Name = "Academic Free License v2.0", Identifier = "AFL-2.0" });
            licenses.Add(new SPDXLicense { Name = "Academic Free License v2.1", Identifier = "AFL-2.1" });
            licenses.Add(new SPDXLicense { Name = "Academic Free License v3.0", Identifier = "AFL-3.0" });
            licenses.Add(new SPDXLicense { Name = "Afmparse License", Identifier = "Afmparse" });
            licenses.Add(new SPDXLicense { Name = "Affero General Public License v1.0 only", Identifier = "AGPL-1.0-only" });
            licenses.Add(new SPDXLicense { Name = "Affero General Public License v1.0 or later", Identifier = "AGPL-1.0-or-later" });
            licenses.Add(new SPDXLicense { Name = "GNU Affero General Public License v3.0 only", Identifier = "AGPL-3.0-only" });
            licenses.Add(new SPDXLicense { Name = "GNU Affero General Public License v3.0 or later", Identifier = "AGPL-3.0-or-later" });
            licenses.Add(new SPDXLicense { Name = "Aladdin Free Public License", Identifier = "Aladdin" });
            licenses.Add(new SPDXLicense { Name = "AMD's plpa_map.c License", Identifier = "AMDPLPA" });
            licenses.Add(new SPDXLicense { Name = "Apple MIT License", Identifier = "AML" });
            licenses.Add(new SPDXLicense { Name = "Academy of Motion Picture Arts and Sciences BSD", Identifier = "AMPAS" });
            licenses.Add(new SPDXLicense { Name = "ANTLR Software Rights Notice", Identifier = "ANTLR-PD" });
            licenses.Add(new SPDXLicense { Name = "Apache License 1.0", Identifier = "Apache-1.0" });
            licenses.Add(new SPDXLicense { Name = "Apache License 1.1", Identifier = "Apache-1.1" });
            licenses.Add(new SPDXLicense { Name = "Apache License 2.0", Identifier = "Apache-2.0" });
            licenses.Add(new SPDXLicense { Name = "Adobe Postscript AFM License", Identifier = "APAFML" });
            licenses.Add(new SPDXLicense { Name = "Adaptive Public License 1.0", Identifier = "APL-1.0" });
            licenses.Add(new SPDXLicense { Name = "Apple Public Source License 1.0", Identifier = "APSL-1.0" });
            licenses.Add(new SPDXLicense { Name = "Apple Public Source License 1.1", Identifier = "APSL-1.1" });
            licenses.Add(new SPDXLicense { Name = "Apple Public Source License 1.2", Identifier = "APSL-1.2" });
            licenses.Add(new SPDXLicense { Name = "Apple Public Source License 2.0", Identifier = "APSL-2.0" });
            licenses.Add(new SPDXLicense { Name = "Artistic License 1.0 w/clause 8", Identifier = "Artistic-1.0-cl8" });
            licenses.Add(new SPDXLicense { Name = "Artistic License 1.0 (Perl)", Identifier = "Artistic-1.0-Perl" });
            licenses.Add(new SPDXLicense { Name = "Artistic License 1.0", Identifier = "Artistic-1.0" });
            licenses.Add(new SPDXLicense { Name = "Artistic License 2.0", Identifier = "Artistic-2.0" });
            licenses.Add(new SPDXLicense { Name = "Bahyph License", Identifier = "Bahyph" });
            licenses.Add(new SPDXLicense { Name = "Barr License", Identifier = "Barr" });
            licenses.Add(new SPDXLicense { Name = "Beerware License", Identifier = "Beerware" });
            licenses.Add(new SPDXLicense { Name = "BitTorrent Open Source License v1.0", Identifier = "BitTorrent-1.0" });
            licenses.Add(new SPDXLicense { Name = "BitTorrent Open Source License v1.1", Identifier = "BitTorrent-1.1" });
            licenses.Add(new SPDXLicense { Name = "Borceux license", Identifier = "Borceux" });
            licenses.Add(new SPDXLicense { Name = "BSD 1-Clause License", Identifier = "BSD-1-Clause" });
            licenses.Add(new SPDXLicense { Name = "BSD 2-Clause FreeBSD License", Identifier = "BSD-2-Clause-FreeBSD" });
            licenses.Add(new SPDXLicense { Name = "BSD 2-Clause NetBSD License", Identifier = "BSD-2-Clause-NetBSD" });
            licenses.Add(new SPDXLicense { Name = "BSD-2-Clause Plus Patent License", Identifier = "BSD-2-Clause-Patent" });
            licenses.Add(new SPDXLicense { Name = "BSD 2-Clause \"Simplified\" License", Identifier = "BSD-2-Clause" });
            licenses.Add(new SPDXLicense { Name = "BSD with attribution", Identifier = "BSD-3-Clause-Attribution" });
            licenses.Add(new SPDXLicense { Name = "BSD 3-Clause Clear License", Identifier = "BSD-3-Clause-Clear" });
            licenses.Add(new SPDXLicense { Name = "Lawrence Berkeley National Labs BSD variant license", Identifier = "BSD-3-Clause-LBNL" });
            licenses.Add(new SPDXLicense { Name = "BSD 3-Clause No Nuclear License 2014", Identifier = "BSD-3-Clause-No-Nuclear-License-2014" });
            licenses.Add(new SPDXLicense { Name = "BSD 3-Clause No Nuclear License", Identifier = "BSD-3-Clause-No-Nuclear-License" });
            licenses.Add(new SPDXLicense { Name = "BSD 3-Clause No Nuclear Warranty", Identifier = "BSD-3-Clause-No-Nuclear-Warranty" });
            licenses.Add(new SPDXLicense { Name = "BSD 3-Clause \"New\" or \"Revised\" License", Identifier = "BSD-3-Clause" });
            licenses.Add(new SPDXLicense { Name = "BSD-4-Clause (University of California-Specific)", Identifier = "BSD-4-Clause-UC" });
            licenses.Add(new SPDXLicense { Name = "BSD 4-Clause \"Original\" or \"Old\" License", Identifier = "BSD-4-Clause" });
            licenses.Add(new SPDXLicense { Name = "BSD Protection License", Identifier = "BSD-Protection" });
            licenses.Add(new SPDXLicense { Name = "BSD Source Code Attribution", Identifier = "BSD-Source-Code" });
            licenses.Add(new SPDXLicense { Name = "Boost Software License 1.0", Identifier = "BSL-1.0" });
            licenses.Add(new SPDXLicense { Name = "bzip2 and libbzip2 License v1.0.5", Identifier = "bzip2-1.0.5" });
            licenses.Add(new SPDXLicense { Name = "bzip2 and libbzip2 License v1.0.6", Identifier = "bzip2-1.0.6" });
            licenses.Add(new SPDXLicense { Name = "Caldera License", Identifier = "Caldera" });
            licenses.Add(new SPDXLicense { Name = "Computer Associates Trusted Open Source License 1.1", Identifier = "CATOSL-1.1" });
            licenses.Add(new SPDXLicense { Name = "Creative Commons Attribution 1.0 Generic", Identifier = "CC-BY-1.0" });
            licenses.Add(new SPDXLicense { Name = "Creative Commons Attribution 2.0 Generic", Identifier = "CC-BY-2.0" });
            licenses.Add(new SPDXLicense { Name = "Creative Commons Attribution 2.5 Generic", Identifier = "CC-BY-2.5" });
            licenses.Add(new SPDXLicense { Name = "Creative Commons Attribution 3.0 Unported", Identifier = "CC-BY-3.0" });
            licenses.Add(new SPDXLicense { Name = "Creative Commons Attribution 4.0 International", Identifier = "CC-BY-4.0" });
            licenses.Add(new SPDXLicense { Name = "Creative Commons Attribution Non Commercial 1.0 Generic", Identifier = "CC-BY-NC-1.0" });
            licenses.Add(new SPDXLicense { Name = "Creative Commons Attribution Non Commercial 2.0 Generic", Identifier = "CC-BY-NC-2.0" });
            licenses.Add(new SPDXLicense { Name = "Creative Commons Attribution Non Commercial 2.5 Generic", Identifier = "CC-BY-NC-2.5" });
            licenses.Add(new SPDXLicense { Name = "Creative Commons Attribution Non Commercial 3.0 Unported", Identifier = "CC-BY-NC-3.0" });
            licenses.Add(new SPDXLicense { Name = "Creative Commons Attribution Non Commercial 4.0 International", Identifier = "CC-BY-NC-4.0" });
            licenses.Add(new SPDXLicense { Name = "Creative Commons Attribution Non Commercial No Derivatives 1.0 Generic", Identifier = "CC-BY-NC-ND-1.0" });
            licenses.Add(new SPDXLicense { Name = "Creative Commons Attribution Non Commercial No Derivatives 2.0 Generic", Identifier = "CC-BY-NC-ND-2.0" });
            licenses.Add(new SPDXLicense { Name = "Creative Commons Attribution Non Commercial No Derivatives 2.5 Generic", Identifier = "CC-BY-NC-ND-2.5" });
            licenses.Add(new SPDXLicense { Name = "Creative Commons Attribution Non Commercial No Derivatives 3.0 Unported", Identifier = "CC-BY-NC-ND-3.0" });
            licenses.Add(new SPDXLicense { Name = "Creative Commons Attribution Non Commercial No Derivatives 4.0 International", Identifier = "CC-BY-NC-ND-4.0" });
            licenses.Add(new SPDXLicense { Name = "Creative Commons Attribution Non Commercial Share Alike 1.0 Generic", Identifier = "CC-BY-NC-SA-1.0" });
            licenses.Add(new SPDXLicense { Name = "Creative Commons Attribution Non Commercial Share Alike 2.0 Generic", Identifier = "CC-BY-NC-SA-2.0" });
            licenses.Add(new SPDXLicense { Name = "Creative Commons Attribution Non Commercial Share Alike 2.5 Generic", Identifier = "CC-BY-NC-SA-2.5" });
            licenses.Add(new SPDXLicense { Name = "Creative Commons Attribution Non Commercial Share Alike 3.0 Unported", Identifier = "CC-BY-NC-SA-3.0" });
            licenses.Add(new SPDXLicense { Name = "Creative Commons Attribution Non Commercial Share Alike 4.0 International", Identifier = "CC-BY-NC-SA-4.0" });
            licenses.Add(new SPDXLicense { Name = "Creative Commons Attribution No Derivatives 1.0 Generic", Identifier = "CC-BY-ND-1.0" });
            licenses.Add(new SPDXLicense { Name = "Creative Commons Attribution No Derivatives 2.0 Generic", Identifier = "CC-BY-ND-2.0" });
            licenses.Add(new SPDXLicense { Name = "Creative Commons Attribution No Derivatives 2.5 Generic", Identifier = "CC-BY-ND-2.5" });
            licenses.Add(new SPDXLicense { Name = "Creative Commons Attribution No Derivatives 3.0 Unported", Identifier = "CC-BY-ND-3.0" });
            licenses.Add(new SPDXLicense { Name = "Creative Commons Attribution No Derivatives 4.0 International", Identifier = "CC-BY-ND-4.0" });
            licenses.Add(new SPDXLicense { Name = "Creative Commons Attribution Share Alike 1.0 Generic", Identifier = "CC-BY-SA-1.0" });
            licenses.Add(new SPDXLicense { Name = "Creative Commons Attribution Share Alike 2.0 Generic", Identifier = "CC-BY-SA-2.0" });
            licenses.Add(new SPDXLicense { Name = "Creative Commons Attribution Share Alike 2.5 Generic", Identifier = "CC-BY-SA-2.5" });
            licenses.Add(new SPDXLicense { Name = "Creative Commons Attribution Share Alike 3.0 Unported", Identifier = "CC-BY-SA-3.0" });
            licenses.Add(new SPDXLicense { Name = "Creative Commons Attribution Share Alike 4.0 International", Identifier = "CC-BY-SA-4.0" });
            licenses.Add(new SPDXLicense { Name = "Creative Commons Zero v1.0 Universal", Identifier = "CC0-1.0" });
            licenses.Add(new SPDXLicense { Name = "Common Development and Distribution License 1.0", Identifier = "CDDL-1.0" });
            licenses.Add(new SPDXLicense { Name = "Common Development and Distribution License 1.1", Identifier = "CDDL-1.1" });
            licenses.Add(new SPDXLicense { Name = "Community Data License Agreement Permissive 1.0", Identifier = "CDLA-Permissive-1.0" });
            licenses.Add(new SPDXLicense { Name = "Community Data License Agreement Sharing 1.0", Identifier = "CDLA-Sharing-1.0" });
            licenses.Add(new SPDXLicense { Name = "CeCILL Free Software License Agreement v1.0", Identifier = "CECILL-1.0" });
            licenses.Add(new SPDXLicense { Name = "CeCILL Free Software License Agreement v1.1", Identifier = "CECILL-1.1" });
            licenses.Add(new SPDXLicense { Name = "CeCILL Free Software License Agreement v2.0", Identifier = "CECILL-2.0" });
            licenses.Add(new SPDXLicense { Name = "CeCILL Free Software License Agreement v2.1", Identifier = "CECILL-2.1" });
            licenses.Add(new SPDXLicense { Name = "CeCILL-B Free Software License Agreement", Identifier = "CECILL-B" });
            licenses.Add(new SPDXLicense { Name = "CeCILL-C Free Software License Agreement", Identifier = "CECILL-C" });
            licenses.Add(new SPDXLicense { Name = "Clarified Artistic License", Identifier = "ClArtistic" });
            licenses.Add(new SPDXLicense { Name = "CNRI Jython License", Identifier = "CNRI-Jython" });
            licenses.Add(new SPDXLicense { Name = "CNRI Python Open Source GPL Compatible License Agreement", Identifier = "CNRI-Python-GPL-Compatible" });
            licenses.Add(new SPDXLicense { Name = "CNRI Python License", Identifier = "CNRI-Python" });
            licenses.Add(new SPDXLicense { Name = "Condor Public License v1.1", Identifier = "Condor-1.1" });
            licenses.Add(new SPDXLicense { Name = "copyleft-next 0.3.0", Identifier = "copyleft-next-0.3.0" });
            licenses.Add(new SPDXLicense { Name = "copyleft-next 0.3.1", Identifier = "copyleft-next-0.3.1" });
            licenses.Add(new SPDXLicense { Name = "Common Public Attribution License 1.0", Identifier = "CPAL-1.0" });
            licenses.Add(new SPDXLicense { Name = "Common Public License 1.0", Identifier = "CPL-1.0" });
            licenses.Add(new SPDXLicense { Name = "Code Project Open License 1.02", Identifier = "CPOL-1.02" });
            licenses.Add(new SPDXLicense { Name = "Crossword License", Identifier = "Crossword" });
            licenses.Add(new SPDXLicense { Name = "CrystalStacker License", Identifier = "CrystalStacker" });
            licenses.Add(new SPDXLicense { Name = "CUA Office Public License v1.0", Identifier = "CUA-OPL-1.0" });
            licenses.Add(new SPDXLicense { Name = "Cube License", Identifier = "Cube" });
            licenses.Add(new SPDXLicense { Name = "curl License", Identifier = "curl" });
            licenses.Add(new SPDXLicense { Name = "Deutsche Freie Software Lizenz", Identifier = "D-FSL-1.0" });
            licenses.Add(new SPDXLicense { Name = "diffmark license", Identifier = "diffmark" });
            licenses.Add(new SPDXLicense { Name = "DOC License", Identifier = "DOC" });
            licenses.Add(new SPDXLicense { Name = "Dotseqn License", Identifier = "Dotseqn" });
            licenses.Add(new SPDXLicense { Name = "DSDP License", Identifier = "DSDP" });
            licenses.Add(new SPDXLicense { Name = "dvipdfm License", Identifier = "dvipdfm" });
            licenses.Add(new SPDXLicense { Name = "Educational Community License v1.0", Identifier = "ECL-1.0" });
            licenses.Add(new SPDXLicense { Name = "Educational Community License v2.0", Identifier = "ECL-2.0" });
            licenses.Add(new SPDXLicense { Name = "Eiffel Forum License v1.0", Identifier = "EFL-1.0" });
            licenses.Add(new SPDXLicense { Name = "Eiffel Forum License v2.0", Identifier = "EFL-2.0" });
            licenses.Add(new SPDXLicense { Name = "eGenix.com Public License 1.1.0", Identifier = "eGenix" });
            licenses.Add(new SPDXLicense { Name = "Entessa Public License v1.0", Identifier = "Entessa" });
            licenses.Add(new SPDXLicense { Name = "Eclipse Public License 1.0", Identifier = "EPL-1.0" });
            licenses.Add(new SPDXLicense { Name = "Eclipse Public License 2.0", Identifier = "EPL-2.0" });
            licenses.Add(new SPDXLicense { Name = "Erlang Public License v1.1", Identifier = "ErlPL-1.1" });
            licenses.Add(new SPDXLicense { Name = "EU DataGrid Software License", Identifier = "EUDatagrid" });
            licenses.Add(new SPDXLicense { Name = "European Union Public License 1.0", Identifier = "EUPL-1.0" });
            licenses.Add(new SPDXLicense { Name = "European Union Public License 1.1", Identifier = "EUPL-1.1" });
            licenses.Add(new SPDXLicense { Name = "European Union Public License 1.2", Identifier = "EUPL-1.2" });
            licenses.Add(new SPDXLicense { Name = "Eurosym License", Identifier = "Eurosym" });
            licenses.Add(new SPDXLicense { Name = "Fair License", Identifier = "Fair" });
            licenses.Add(new SPDXLicense { Name = "Frameworx Open License 1.0", Identifier = "Frameworx-1.0" });
            licenses.Add(new SPDXLicense { Name = "FreeImage Public License v1.0", Identifier = "FreeImage" });
            licenses.Add(new SPDXLicense { Name = "FSF All Permissive License", Identifier = "FSFAP" });
            licenses.Add(new SPDXLicense { Name = "FSF Unlimited License", Identifier = "FSFUL" });
            licenses.Add(new SPDXLicense { Name = "FSF Unlimited License (with License Retention)", Identifier = "FSFULLR" });
            licenses.Add(new SPDXLicense { Name = "Freetype Project License", Identifier = "FTL" });
            licenses.Add(new SPDXLicense { Name = "GNU Free Documentation License v1.1 only", Identifier = "GFDL-1.1-only" });
            licenses.Add(new SPDXLicense { Name = "GNU Free Documentation License v1.1 or later", Identifier = "GFDL-1.1-or-later" });
            licenses.Add(new SPDXLicense { Name = "GNU Free Documentation License v1.2 only", Identifier = "GFDL-1.2-only" });
            licenses.Add(new SPDXLicense { Name = "GNU Free Documentation License v1.2 or later", Identifier = "GFDL-1.2-or-later" });
            licenses.Add(new SPDXLicense { Name = "GNU Free Documentation License v1.3 only", Identifier = "GFDL-1.3-only" });
            licenses.Add(new SPDXLicense { Name = "GNU Free Documentation License v1.3 or later", Identifier = "GFDL-1.3-or-later" });
            licenses.Add(new SPDXLicense { Name = "Giftware License", Identifier = "Giftware" });
            licenses.Add(new SPDXLicense { Name = "GL2PS License", Identifier = "GL2PS" });
            licenses.Add(new SPDXLicense { Name = "3dfx Glide License", Identifier = "Glide" });
            licenses.Add(new SPDXLicense { Name = "Glulxe License", Identifier = "Glulxe" });
            licenses.Add(new SPDXLicense { Name = "gnuplot License", Identifier = "gnuplot" });
            licenses.Add(new SPDXLicense { Name = "GNU General Public License v1.0 only", Identifier = "GPL-1.0-only" });
            licenses.Add(new SPDXLicense { Name = "GNU General Public License v1.0 or later", Identifier = "GPL-1.0-or-later" });
            licenses.Add(new SPDXLicense { Name = "GNU General Public License v2.0 only", Identifier = "GPL-2.0-only" });
            licenses.Add(new SPDXLicense { Name = "GNU General Public License v2.0 or later", Identifier = "GPL-2.0-or-later" });
            licenses.Add(new SPDXLicense { Name = "GNU General Public License v3.0 only", Identifier = "GPL-3.0-only" });
            licenses.Add(new SPDXLicense { Name = "GNU General Public License v3.0 or later", Identifier = "GPL-3.0-or-later" });
            licenses.Add(new SPDXLicense { Name = "gSOAP Public License v1.3b", Identifier = "gSOAP-1.3b" });
            licenses.Add(new SPDXLicense { Name = "Haskell Language Report License", Identifier = "HaskellReport" });
            licenses.Add(new SPDXLicense { Name = "Historical Permission Notice and Disclaimer", Identifier = "HPND" });
            licenses.Add(new SPDXLicense { Name = "IBM PowerPC Initialization and Boot Software", Identifier = "IBM-pibs" });
            licenses.Add(new SPDXLicense { Name = "ICU License", Identifier = "ICU" });
            licenses.Add(new SPDXLicense { Name = "Independent JPEG Group License", Identifier = "IJG" });
            licenses.Add(new SPDXLicense { Name = "ImageMagick License", Identifier = "ImageMagick" });
            licenses.Add(new SPDXLicense { Name = "iMatix Standard Function Library Agreement", Identifier = "iMatix" });
            licenses.Add(new SPDXLicense { Name = "Imlib2 License", Identifier = "Imlib2" });
            licenses.Add(new SPDXLicense { Name = "Info-ZIP License", Identifier = "Info-ZIP" });
            licenses.Add(new SPDXLicense { Name = "Intel ACPI Software License Agreement", Identifier = "Intel-ACPI" });
            licenses.Add(new SPDXLicense { Name = "Intel Open Source License", Identifier = "Intel" });
            licenses.Add(new SPDXLicense { Name = "Interbase Public License v1.0", Identifier = "Interbase-1.0" });
            licenses.Add(new SPDXLicense { Name = "IPA Font License", Identifier = "IPA" });
            licenses.Add(new SPDXLicense { Name = "IBM Public License v1.0", Identifier = "IPL-1.0" });
            licenses.Add(new SPDXLicense { Name = "ISC License", Identifier = "ISC" });
            licenses.Add(new SPDXLicense { Name = "JasPer License", Identifier = "JasPer-2.0" });
            licenses.Add(new SPDXLicense { Name = "JSON License", Identifier = "JSON" });
            licenses.Add(new SPDXLicense { Name = "Licence Art Libre 1.2", Identifier = "LAL-1.2" });
            licenses.Add(new SPDXLicense { Name = "Licence Art Libre 1.3", Identifier = "LAL-1.3" });
            licenses.Add(new SPDXLicense { Name = "Latex2e License", Identifier = "Latex2e" });
            licenses.Add(new SPDXLicense { Name = "Leptonica License", Identifier = "Leptonica" });
            licenses.Add(new SPDXLicense { Name = "GNU Library General Public License v2 only", Identifier = "LGPL-2.0-only" });
            licenses.Add(new SPDXLicense { Name = "GNU Library General Public License v2 or later", Identifier = "LGPL-2.0-or-later" });
            licenses.Add(new SPDXLicense { Name = "GNU Lesser General Public License v2.1 only", Identifier = "LGPL-2.1-only" });
            licenses.Add(new SPDXLicense { Name = "GNU Lesser General Public License v2.1 or later", Identifier = "LGPL-2.1-or-later" });
            licenses.Add(new SPDXLicense { Name = "GNU Lesser General Public License v3.0 only", Identifier = "LGPL-3.0-only" });
            licenses.Add(new SPDXLicense { Name = "GNU Lesser General Public License v3.0 or later", Identifier = "LGPL-3.0-or-later" });
            licenses.Add(new SPDXLicense { Name = "Lesser General Public License For Linguistic Resources", Identifier = "LGPLLR" });
            licenses.Add(new SPDXLicense { Name = "libpng License", Identifier = "Libpng" });
            licenses.Add(new SPDXLicense { Name = "libtiff License", Identifier = "libtiff" });
            licenses.Add(new SPDXLicense { Name = "Licence Libre du Québec – Permissive version 1.1", Identifier = "LiLiQ-P-1.1" });
            licenses.Add(new SPDXLicense { Name = "Licence Libre du Québec – Réciprocité version 1.1", Identifier = "LiLiQ-R-1.1" });
            licenses.Add(new SPDXLicense { Name = "Licence Libre du Québec – Réciprocité forte version 1.1", Identifier = "LiLiQ-Rplus-1.1" });
            licenses.Add(new SPDXLicense { Name = "Linux Kernel Variant of OpenIB.org license", Identifier = "Linux-OpenIB" });
            licenses.Add(new SPDXLicense { Name = "Lucent Public License Version 1.0", Identifier = "LPL-1.0" });
            licenses.Add(new SPDXLicense { Name = "Lucent Public License v1.02", Identifier = "LPL-1.02" });
            licenses.Add(new SPDXLicense { Name = "LaTeX Project Public License v1.0", Identifier = "LPPL-1.0" });
            licenses.Add(new SPDXLicense { Name = "LaTeX Project Public License v1.1", Identifier = "LPPL-1.1" });
            licenses.Add(new SPDXLicense { Name = "LaTeX Project Public License v1.2", Identifier = "LPPL-1.2" });
            licenses.Add(new SPDXLicense { Name = "LaTeX Project Public License v1.3a", Identifier = "LPPL-1.3a" });
            licenses.Add(new SPDXLicense { Name = "LaTeX Project Public License v1.3c", Identifier = "LPPL-1.3c" });
            licenses.Add(new SPDXLicense { Name = "MakeIndex License", Identifier = "MakeIndex" });
            licenses.Add(new SPDXLicense { Name = "MirOS License", Identifier = "MirOS" });
            licenses.Add(new SPDXLicense { Name = "MIT No Attribution", Identifier = "MIT-0" });
            licenses.Add(new SPDXLicense { Name = "Enlightenment License (e16)", Identifier = "MIT-advertising" });
            licenses.Add(new SPDXLicense { Name = "CMU License", Identifier = "MIT-CMU" });
            licenses.Add(new SPDXLicense { Name = "enna License", Identifier = "MIT-enna" });
            licenses.Add(new SPDXLicense { Name = "feh License", Identifier = "MIT-feh" });
            licenses.Add(new SPDXLicense { Name = "MIT License", Identifier = "MIT" });
            licenses.Add(new SPDXLicense { Name = "MIT +no-false-attribs license", Identifier = "MITNFA" });
            licenses.Add(new SPDXLicense { Name = "Motosoto License", Identifier = "Motosoto" });
            licenses.Add(new SPDXLicense { Name = "mpich2 License", Identifier = "mpich2" });
            licenses.Add(new SPDXLicense { Name = "Mozilla Public License 1.0", Identifier = "MPL-1.0" });
            licenses.Add(new SPDXLicense { Name = "Mozilla Public License 1.1", Identifier = "MPL-1.1" });
            licenses.Add(new SPDXLicense { Name = "Mozilla Public License 2.0 (no copyleft exception)", Identifier = "MPL-2.0-no-copyleft-exception" });
            licenses.Add(new SPDXLicense { Name = "Mozilla Public License 2.0", Identifier = "MPL-2.0" });
            licenses.Add(new SPDXLicense { Name = "Microsoft Public License", Identifier = "MS-PL" });
            licenses.Add(new SPDXLicense { Name = "Microsoft Reciprocal License", Identifier = "MS-RL" });
            licenses.Add(new SPDXLicense { Name = "Matrix Template Library License", Identifier = "MTLL" });
            licenses.Add(new SPDXLicense { Name = "Multics License", Identifier = "Multics" });
            licenses.Add(new SPDXLicense { Name = "Mup License", Identifier = "Mup" });
            licenses.Add(new SPDXLicense { Name = "NASA Open Source Agreement 1.3", Identifier = "NASA-1.3" });
            licenses.Add(new SPDXLicense { Name = "Naumen Public License", Identifier = "Naumen" });
            licenses.Add(new SPDXLicense { Name = "Net Boolean Public License v1", Identifier = "NBPL-1.0" });
            licenses.Add(new SPDXLicense { Name = "University of Illinois/NCSA Open Source License", Identifier = "NCSA" });
            licenses.Add(new SPDXLicense { Name = "Net-SNMP License", Identifier = "Net-SNMP" });
            licenses.Add(new SPDXLicense { Name = "NetCDF license", Identifier = "NetCDF" });
            licenses.Add(new SPDXLicense { Name = "Newsletr License", Identifier = "Newsletr" });
            licenses.Add(new SPDXLicense { Name = "Nethack General Public License", Identifier = "NGPL" });
            licenses.Add(new SPDXLicense { Name = "Norwegian Licence for Open Government Data", Identifier = "NLOD-1.0" });
            licenses.Add(new SPDXLicense { Name = "No Limit Public License", Identifier = "NLPL" });
            licenses.Add(new SPDXLicense { Name = "Nokia Open Source License", Identifier = "Nokia" });
            licenses.Add(new SPDXLicense { Name = "Netizen Open Source License", Identifier = "NOSL" });
            licenses.Add(new SPDXLicense { Name = "Noweb License", Identifier = "Noweb" });
            licenses.Add(new SPDXLicense { Name = "Netscape Public License v1.0", Identifier = "NPL-1.0" });
            licenses.Add(new SPDXLicense { Name = "Netscape Public License v1.1", Identifier = "NPL-1.1" });
            licenses.Add(new SPDXLicense { Name = "Non-Profit Open Software License 3.0", Identifier = "NPOSL-3.0" });
            licenses.Add(new SPDXLicense { Name = "NRL License", Identifier = "NRL" });
            licenses.Add(new SPDXLicense { Name = "NTP License", Identifier = "NTP" });
            licenses.Add(new SPDXLicense { Name = "Open CASCADE Technology Public License", Identifier = "OCCT-PL" });
            licenses.Add(new SPDXLicense { Name = "OCLC Research Public License 2.0", Identifier = "OCLC-2.0" });
            licenses.Add(new SPDXLicense { Name = "ODC Open Database License v1.0", Identifier = "ODbL-1.0" });
            licenses.Add(new SPDXLicense { Name = "Open Data Commons Attribution License v1.0", Identifier = "ODC-By-1.0" });
            licenses.Add(new SPDXLicense { Name = "SIL Open Font License 1.0", Identifier = "OFL-1.0" });
            licenses.Add(new SPDXLicense { Name = "SIL Open Font License 1.1", Identifier = "OFL-1.1" });
            licenses.Add(new SPDXLicense { Name = "Open Government Licence v1.0", Identifier = "OGL-UK-1.0" });
            licenses.Add(new SPDXLicense { Name = "Open Government Licence v2.0", Identifier = "OGL-UK-2.0" });
            licenses.Add(new SPDXLicense { Name = "Open Government Licence v3.0", Identifier = "OGL-UK-3.0" });
            licenses.Add(new SPDXLicense { Name = "Open Group Test Suite License", Identifier = "OGTSL" });
            licenses.Add(new SPDXLicense { Name = "Open LDAP Public License v1.1", Identifier = "OLDAP-1.1" });
            licenses.Add(new SPDXLicense { Name = "Open LDAP Public License v1.2", Identifier = "OLDAP-1.2" });
            licenses.Add(new SPDXLicense { Name = "Open LDAP Public License v1.3", Identifier = "OLDAP-1.3" });
            licenses.Add(new SPDXLicense { Name = "Open LDAP Public License v1.4", Identifier = "OLDAP-1.4" });
            licenses.Add(new SPDXLicense { Name = "Open LDAP Public License v2.0.1", Identifier = "OLDAP-2.0.1" });
            licenses.Add(new SPDXLicense { Name = "Open LDAP Public License v2.0 (or possibly 2.0A and 2.0B)", Identifier = "OLDAP-2.0" });
            licenses.Add(new SPDXLicense { Name = "Open LDAP Public License v2.1", Identifier = "OLDAP-2.1" });
            licenses.Add(new SPDXLicense { Name = "Open LDAP Public License v2.2.1", Identifier = "OLDAP-2.2.1" });
            licenses.Add(new SPDXLicense { Name = "Open LDAP Public License 2.2.2", Identifier = "OLDAP-2.2.2" });
            licenses.Add(new SPDXLicense { Name = "Open LDAP Public License v2.2", Identifier = "OLDAP-2.2" });
            licenses.Add(new SPDXLicense { Name = "Open LDAP Public License v2.3", Identifier = "OLDAP-2.3" });
            licenses.Add(new SPDXLicense { Name = "Open LDAP Public License v2.4", Identifier = "OLDAP-2.4" });
            licenses.Add(new SPDXLicense { Name = "Open LDAP Public License v2.5", Identifier = "OLDAP-2.5" });
            licenses.Add(new SPDXLicense { Name = "Open LDAP Public License v2.6", Identifier = "OLDAP-2.6" });
            licenses.Add(new SPDXLicense { Name = "Open LDAP Public License v2.7", Identifier = "OLDAP-2.7" });
            licenses.Add(new SPDXLicense { Name = "Open LDAP Public License v2.8", Identifier = "OLDAP-2.8" });
            licenses.Add(new SPDXLicense { Name = "Open Market License", Identifier = "OML" });
            licenses.Add(new SPDXLicense { Name = "OpenSSL License", Identifier = "OpenSSL" });
            licenses.Add(new SPDXLicense { Name = "Open Public License v1.0", Identifier = "OPL-1.0" });
            licenses.Add(new SPDXLicense { Name = "OSET Public License version 2.1", Identifier = "OSET-PL-2.1" });
            licenses.Add(new SPDXLicense { Name = "Open Software License 1.0", Identifier = "OSL-1.0" });
            licenses.Add(new SPDXLicense { Name = "Open Software License 1.1", Identifier = "OSL-1.1" });
            licenses.Add(new SPDXLicense { Name = "Open Software License 2.0", Identifier = "OSL-2.0" });
            licenses.Add(new SPDXLicense { Name = "Open Software License 2.1", Identifier = "OSL-2.1" });
            licenses.Add(new SPDXLicense { Name = "Open Software License 3.0", Identifier = "OSL-3.0" });
            licenses.Add(new SPDXLicense { Name = "ODC Public Domain Dedication & License 1.0", Identifier = "PDDL-1.0" });
            licenses.Add(new SPDXLicense { Name = "PHP License v3.0", Identifier = "PHP-3.0" });
            licenses.Add(new SPDXLicense { Name = "PHP License v3.01", Identifier = "PHP-3.01" });
            licenses.Add(new SPDXLicense { Name = "Plexus Classworlds License", Identifier = "Plexus" });
            licenses.Add(new SPDXLicense { Name = "PostgreSQL License", Identifier = "PostgreSQL" });
            licenses.Add(new SPDXLicense { Name = "psfrag License", Identifier = "psfrag" });
            licenses.Add(new SPDXLicense { Name = "psutils License", Identifier = "psutils" });
            licenses.Add(new SPDXLicense { Name = "Python License 2.0", Identifier = "Python-2.0" });
            licenses.Add(new SPDXLicense { Name = "Qhull License", Identifier = "Qhull" });
            licenses.Add(new SPDXLicense { Name = "Q Public License 1.0", Identifier = "QPL-1.0" });
            licenses.Add(new SPDXLicense { Name = "Rdisc License", Identifier = "Rdisc" });
            licenses.Add(new SPDXLicense { Name = "Red Hat eCos Public License v1.1", Identifier = "RHeCos-1.1" });
            licenses.Add(new SPDXLicense { Name = "Reciprocal Public License 1.1", Identifier = "RPL-1.1" });
            licenses.Add(new SPDXLicense { Name = "Reciprocal Public License 1.5", Identifier = "RPL-1.5" });
            licenses.Add(new SPDXLicense { Name = "RealNetworks Public Source License v1.0", Identifier = "RPSL-1.0" });
            licenses.Add(new SPDXLicense { Name = "RSA Message-Digest License", Identifier = "RSA-MD" });
            licenses.Add(new SPDXLicense { Name = "Ricoh Source Code Public License", Identifier = "RSCPL" });
            licenses.Add(new SPDXLicense { Name = "Ruby License", Identifier = "Ruby" });
            licenses.Add(new SPDXLicense { Name = "Sax Public Domain Notice", Identifier = "SAX-PD" });
            licenses.Add(new SPDXLicense { Name = "Saxpath License", Identifier = "Saxpath" });
            licenses.Add(new SPDXLicense { Name = "SCEA Shared Source License", Identifier = "SCEA" });
            licenses.Add(new SPDXLicense { Name = "Sendmail License 8.23", Identifier = "Sendmail-8.23" });
            licenses.Add(new SPDXLicense { Name = "Sendmail License", Identifier = "Sendmail" });
            licenses.Add(new SPDXLicense { Name = "SGI Free Software License B v1.0", Identifier = "SGI-B-1.0" });
            licenses.Add(new SPDXLicense { Name = "SGI Free Software License B v1.1", Identifier = "SGI-B-1.1" });
            licenses.Add(new SPDXLicense { Name = "SGI Free Software License B v2.0", Identifier = "SGI-B-2.0" });
            licenses.Add(new SPDXLicense { Name = "Simple Public License 2.0", Identifier = "SimPL-2.0" });
            licenses.Add(new SPDXLicense { Name = "Sun Industry Standards Source License v1.2", Identifier = "SISSL-1.2" });
            licenses.Add(new SPDXLicense { Name = "Sun Industry Standards Source License v1.1", Identifier = "SISSL" });
            licenses.Add(new SPDXLicense { Name = "Sleepycat License", Identifier = "Sleepycat" });
            licenses.Add(new SPDXLicense { Name = "Standard ML of New Jersey License", Identifier = "SMLNJ" });
            licenses.Add(new SPDXLicense { Name = "Secure Messaging Protocol Public License", Identifier = "SMPPL" });
            licenses.Add(new SPDXLicense { Name = "SNIA Public License 1.1", Identifier = "SNIA" });
            licenses.Add(new SPDXLicense { Name = "Spencer License 86", Identifier = "Spencer-86" });
            licenses.Add(new SPDXLicense { Name = "Spencer License 94", Identifier = "Spencer-94" });
            licenses.Add(new SPDXLicense { Name = "Spencer License 99", Identifier = "Spencer-99" });
            licenses.Add(new SPDXLicense { Name = "Sun Public License v1.0", Identifier = "SPL-1.0" });
            licenses.Add(new SPDXLicense { Name = "SugarCRM Public License v1.1.3", Identifier = "SugarCRM-1.1.3" });
            licenses.Add(new SPDXLicense { Name = "Scheme Widget Library (SWL) Software License Agreement", Identifier = "SWL" });
            licenses.Add(new SPDXLicense { Name = "TCL/TK License", Identifier = "TCL" });
            licenses.Add(new SPDXLicense { Name = "TCP Wrappers License", Identifier = "TCP-wrappers" });
            licenses.Add(new SPDXLicense { Name = "TMate Open Source License", Identifier = "TMate" });
            licenses.Add(new SPDXLicense { Name = "TORQUE v2.5+ Software License v1.1", Identifier = "TORQUE-1.1" });
            licenses.Add(new SPDXLicense { Name = "Trusster Open Source License", Identifier = "TOSL" });
            licenses.Add(new SPDXLicense { Name = "Technische Universitaet Berlin License 1.0", Identifier = "TU-Berlin-1.0" });
            licenses.Add(new SPDXLicense { Name = "Technische Universitaet Berlin License 2.0", Identifier = "TU-Berlin-2.0" });
            licenses.Add(new SPDXLicense { Name = "Unicode License Agreement - Data Files and Software (2015)", Identifier = "Unicode-DFS-2015" });
            licenses.Add(new SPDXLicense { Name = "Unicode License Agreement - Data Files and Software (2016)", Identifier = "Unicode-DFS-2016" });
            licenses.Add(new SPDXLicense { Name = "Unicode Terms of Use", Identifier = "Unicode-TOU" });
            licenses.Add(new SPDXLicense { Name = "The Unlicense", Identifier = "Unlicense" });
            licenses.Add(new SPDXLicense { Name = "Universal Permissive License v1.0", Identifier = "UPL-1.0" });
            licenses.Add(new SPDXLicense { Name = "Vim License", Identifier = "Vim" });
            licenses.Add(new SPDXLicense { Name = "VOSTROM Public License for Open Source", Identifier = "VOSTROM" });
            licenses.Add(new SPDXLicense { Name = "Vovida Software License v1.0", Identifier = "VSL-1.0" });
            licenses.Add(new SPDXLicense { Name = "W3C Software Notice and License (1998-07-20)", Identifier = "W3C-19980720" });
            licenses.Add(new SPDXLicense { Name = "W3C Software Notice and Document License (2015-05-13)", Identifier = "W3C-20150513" });
            licenses.Add(new SPDXLicense { Name = "W3C Software Notice and License (2002-12-31)", Identifier = "W3C" });
            licenses.Add(new SPDXLicense { Name = "Sybase Open Watcom Public License 1.0", Identifier = "Watcom-1.0" });
            licenses.Add(new SPDXLicense { Name = "Wsuipa License", Identifier = "Wsuipa" });
            licenses.Add(new SPDXLicense { Name = "Do What The F*ck You Want To Public License", Identifier = "WTFPL" });
            licenses.Add(new SPDXLicense { Name = "X11 License", Identifier = "X11" });
            licenses.Add(new SPDXLicense { Name = "Xerox License", Identifier = "Xerox" });
            licenses.Add(new SPDXLicense { Name = "XFree86 License 1.1", Identifier = "XFree86-1.1" });
            licenses.Add(new SPDXLicense { Name = "xinetd License", Identifier = "xinetd" });
            licenses.Add(new SPDXLicense { Name = "X.Net License", Identifier = "Xnet" });
            licenses.Add(new SPDXLicense { Name = "XPP License", Identifier = "xpp" });
            licenses.Add(new SPDXLicense { Name = "XSkat License", Identifier = "XSkat" });
            licenses.Add(new SPDXLicense { Name = "Yahoo! Public License v1.0", Identifier = "YPL-1.0" });
            licenses.Add(new SPDXLicense { Name = "Yahoo! Public License v1.1", Identifier = "YPL-1.1" });
            licenses.Add(new SPDXLicense { Name = "Zed License", Identifier = "Zed" });
            licenses.Add(new SPDXLicense { Name = "Zend License v2.0", Identifier = "Zend-2.0" });
            licenses.Add(new SPDXLicense { Name = "Zimbra Public License v1.3", Identifier = "Zimbra-1.3" });
            licenses.Add(new SPDXLicense { Name = "Zimbra Public License v1.4", Identifier = "Zimbra-1.4" });
            licenses.Add(new SPDXLicense { Name = "zlib/libpng License with Acknowledgement", Identifier = "zlib-acknowledgement" });
            licenses.Add(new SPDXLicense { Name = "zlib License", Identifier = "Zlib" });
            licenses.Add(new SPDXLicense { Name = "Zope Public License 1.1", Identifier = "ZPL-1.1" });
            licenses.Add(new SPDXLicense { Name = "Zope Public License 2.0", Identifier = "ZPL-2.0" });
            licenses.Add(new SPDXLicense { Name = "Zope Public License 2.1", Identifier = "ZPL-2.1" });
        }

        /// <summary>
        /// Constructs a simple SPDX license string.
        /// </summary>
        /// <param name="licenses">The licenses to construct the string from.</param>
        /// <returns>A simple SPDX license string.</returns>
        public static string ConstructLicenseString(List<SPDXLicense> licenses)
        {
            // select the license identifiers from the license list..
            var licenseStrings = licenses.Select(f => f.Identifier);

            // and concatenate them with a separate string of " OR "..
            return string.Join(" OR ", licenseStrings);
        }

        /// <summary>
        /// Searches the SPDX licenses with a specified filter string.
        /// </summary>
        /// <param name="filter">The filter string to be used for searching.</param>
        /// <returns>A collection of SPDX licenses matching the given filter string.</returns>
        public IEnumerable<SPDXLicense> SearchSPDXLicenses(string filter)
        {
            return licenses.
                Where(
                f => f.Identifier.ToLowerInvariant().Contains(filter.ToLowerInvariant()) ||
                f.Name.ToLowerInvariant().Contains(filter.ToLowerInvariant())).OrderBy(f => f.Name.ToLowerInvariant());
        }

        /// <summary>
        /// Gets the license by it's identifier.
        /// </summary>
        /// <param name="identifier">The identifier of the license.</param>
        /// <returns>An instance to a SPDXLicense class if a license with a given identifier was found; otherwise null.</returns>
        public SPDXLicense GetLicenseByIdentifier(string identifier)
        {
            foreach (SPDXLicense license in licenses)
            {
                if (license.Identifier == identifier)
                {
                    return license;
                }
            }
            return null;
        }

        /// <summary>
        /// Gets all the SPDX licenses contained in the class.
        /// </summary>
        /// <returns>A collection of SPDX licenses.</returns>
        public IEnumerable<SPDXLicense> GetSPDXLicenses()
        {
            return licenses.OrderBy(f => f.Name.ToLowerInvariant());
        }
    }
}
