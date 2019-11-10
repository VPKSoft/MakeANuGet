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
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace MakeANuGet.HelperClasses
{
    /// <summary>
    /// A class to contains the <see cref="XDocument"/> manipulation methods moved from the main form's code.
    /// </summary>
    public class XmlUtilities
    { 
        /// <summary>
        /// Sets a value for a simple element in the XML file (metadata element).
        /// </summary>
        /// <param name="elementName">Name of the element which value to add or set or optionally delete by adding to this parameter a ';1' to the end of the element name.</param>
        /// <param name="value">The value for the element.</param>
        /// <param name="nuspec">The contents of the .nuspec file in a <see cref="XDocument"/> class instance.</param>
        public static void SetSimpleElement(XDocument nuspec, string elementName, string value)
        {
            if (nuspec != null)
            {
                var splitName = elementName.Split(';');
                bool deleteEmptyElement = false;

                if (splitName.Length > 1)
                {
                    elementName = splitName[0];
                    deleteEmptyElement = splitName[1] == "1";
                }

                var element = nuspec.Root?.Element("metadata")?.Element(elementName);

                if (string.IsNullOrEmpty(value) && deleteEmptyElement)
                {
                    element?.Remove();
                    return;
                }

                if (element == null)
                {
                    element = new XElement(elementName);
                    nuspec.Root?.Element("metadata")?.Add(element);
                }

                element.Value = value ?? string.Empty;
            }
        }

        /// <summary>
        /// Gets the file element containing the license file in a .nuspec file from the files section.
        /// </summary>
        /// <param name="document">An XML document with the data (.nuspec).</param>
        /// <param name="fileName">The file name of the license file.</param>
        /// <returns>A tuple containing the src and target attributes of a given XDocument and a file name.</returns>
        public static (string source, string target) GetFileElementSourceAndTarget(XDocument document, string fileName)
        {
            var files =
                document.Root?.Element("files")?.Elements("file").Where(f => f.Attribute("src") != null);

            var licenseFile = files?.FirstOrDefault(f =>
                // ReSharper disable once PossibleNullReferenceException (the inspection for null was made in the previous line)..
                f.Attribute("src").Value.EndsWith(fileName));

            return (licenseFile?.Attribute("src")?.Value, licenseFile?.Attribute("target")?.Value);
        }

        /// <summary>
        /// Removes a file element from a <see cref="XDocument"/> with a given <paramref name="fileName"/>.
        /// </summary>
        /// <param name="document">The <see cref="XDocument"/> document to manipulate.</param>
        /// <param name="fileName">Name of the file to remove from the files element.</param>
        public static void RemoveFileElementByFileName(XDocument document, string fileName)
        {
            fileName = Path.GetFileName(fileName);

            if (fileName == null)
            {
                return;
            }

            var files =
                document.Root?.Element("files")?.Elements("file").Where(f => f.Attribute("src") != null);

            var fileElement = files?.FirstOrDefault(f =>
                // ReSharper disable once PossibleNullReferenceException (the inspection for null was made in the previous line)..
                f.Attribute("src").Value.EndsWith(fileName));

            fileElement?.Remove();
        }

        /// <summary>
        /// Sets the license element SPDX value.
        /// </summary>
        /// <param name="nuspec">The contents of the .nuspec file in a <see cref="XDocument"/> class instance.</param>
        /// <param name="license">A <see cref="List&lt;SPDXLicense&gt;"/> containing the SPDX license data.</param>
        public static void SetLicenseElementSpdx(XDocument nuspec, object license)
        {
            if (nuspec != null)
            {
                if (!(license is List<SPDXLicense>))
                {
                    return;
                }

                // get the list of licenses from the tag..
                List<SPDXLicense> licenses = (List<SPDXLicense>)license;

                var element = nuspec.Root?.Element("metadata")?.Element("license");

                var elementType = element?.Attribute("type")?.Value;
                var elementFile = element?.Value;

                if (elementType != null && elementType == "file")
                {
                    elementFile = Path.GetFileName(elementFile);
                    var fileElements = nuspec.Root?.Element("files")?.Elements("file");

                    if (fileElements != null)
                    {
                        var licenseFileElement =
                            fileElements.FirstOrDefault(f =>
                                (f.Attribute("src")?.Value ?? string.Empty).EndsWith(
                                    elementFile));

                        licenseFileElement?.Remove();
                    }
                }

                element?.Remove();

                // select the license identifiers..
                var licenseStrings = licenses.Select(f => f.Identifier);

                element = new XElement("license", new XAttribute("type", "expression"))
                {
                    Value = string.Join(" OR ", licenseStrings),
                };

                nuspec.Root?.Element("metadata")?.Add(element);
            }
        }

        /// <summary>
        /// Sets the license element as a file reference.
        /// </summary>
        /// <param name="nuspec">The contents of the .nuspec file in a <see cref="XDocument"/> class instance.</param>
        /// <param name="fileName">Name of the file used as a license.</param>
        /// <param name="target">The target element's value.</param>
        /// <param name="nuspecFile">The location of the actual .nuspec file to be used to get a relative path for the icon file.</param>
        public static void SetLicenseElementFile(XDocument nuspec, string fileName, string target, string nuspecFile)
        {
            if (nuspec != null)
            {
                var element = nuspec.Root?.Element("files");

                fileName = RelativePath.GetRelativePath(fileName, nuspecFile);

                if (element == null)
                {
                    var fileElement = new XElement("files");
                    fileElement.Add(new XElement("file", new XAttribute("src", fileName), new XAttribute("target", target)));
                    nuspec.Root?.Add(fileElement);
                }
                else
                {
                    RemoveFileElementByFileName(nuspec, fileName);
                    element.Add(new XElement("file", new XAttribute("src", fileName), new XAttribute("target", target)));
                }

                element = nuspec.Root?.Element("metadata")?.Element("license");
                element?.Remove();

                element = new XElement("license", new XAttribute("type", "file"));
                var fileNameNoPath = Path.GetFileName(fileName);
                element.Value = fileNameNoPath;
                nuspec.Root?.Element("metadata")?.Add(element);
            }
        }

        /// <summary>
        /// Sets the icon element as a file reference.
        /// </summary>
        /// <param name="nuspec">The contents of the .nuspec file in a <see cref="XDocument"/> class instance.</param>
        /// <param name="fileName">Name of the file used as an icon.</param>
        /// <param name="target">The target element's value.</param>
        /// <param name="nuspecFile">The location of the actual .nuspec file to be used to get a relative path for the icon file.</param>
        public static void SetIconElementFile(XDocument nuspec, string fileName, string target, string nuspecFile)
        {
            if (nuspec != null)
            {
                var element = nuspec.Root?.Element("files");

                var fileNameNoPath = Path.GetFileName(fileName);
                if (fileNameNoPath == null)
                {
                    return;
                }

                fileName = RelativePath.GetRelativePath(fileName, nuspecFile);

                if (element == null)
                {
                    var fileElement = new XElement("files");
                    fileElement.Add(new XElement("file", new XAttribute("src", fileNameNoPath), new XAttribute("target", target)));
                    nuspec.Root?.Add(fileElement);
                }
                else
                {
                    RemoveFileElementByFileName(nuspec, fileName);
                    element.Add(new XElement("file", new XAttribute("src", fileNameNoPath), new XAttribute("target", target)));
                }

                element = nuspec.Root?.Element("metadata")?.Element("icon");
                if (element == null)
                {
                    element = new XElement("icon") {Value = fileName};
                    nuspec.Root?.Element("metadata")?.Add(element);
                }
            }
        }

        /// <summary>
        /// Gets the file element entries from a .nuspec XML document.
        /// </summary>
        /// <param name="nuspec">The contents of the .nuspec file in a <see cref="XDocument"/> class instance.</param>
        /// <returns>A List&lt;NuspecFileElement&gt; class instances containing the file elements.</returns>
        public static List<NuspecFileElement> GetFileElementData(XDocument nuspec)
        {
            List<NuspecFileElement> result = new List<NuspecFileElement>();

            var fileElements = nuspec.Root?.Element("files")?.Elements("file");
            if (fileElements != null)
            {
                foreach (var fileElement in fileElements)
                {
                    result.Add(new NuspecFileElement
                    {
                        SrcAttribute = fileElement.Attribute("src")?.Value,
                        TargetAttribute = fileElement.Attribute("target")?.Value,
                        ExcludeAttribute = fileElement.Attribute("exclude")?.Value,
                    });
                }
            }

            return result;
        }

        /// <summary>
        /// Gets the files element entries from the contentFiles element from a .nuspec XML document.
        /// </summary>
        /// <param name="nuspec">The nuspec.</param>
        /// <returns>System.Collections.Generic.List&lt;MakeANuGet.HelperClasses.NuspecFileContentElement&gt; class instances containing the files elements.</returns>
        public static List<NuspecFileContentElement> GetContentFileElementData(XDocument nuspec)
        {
            bool BoolAttributeValue(string value)
            {
                return value != null && bool.Parse(value);
            }

            List<NuspecFileContentElement> result = new List<NuspecFileContentElement>();

            var filesElements = nuspec.Root?.Element("metadata")?.Element("contentFiles")?.Elements("files");

            if (filesElements != null)
            {
                foreach (var filesElement in filesElements)
                {
                    result.Add(new NuspecFileContentElement
                    {
                        IncludeAttribute = filesElement.Attribute("include")?.Value,
                        ExcludeAttribute = filesElement.Attribute("exclude")?.Value,
                        BuildActionAttribute = filesElement.Attribute("buildAction")?.Value,
                        CopyToOutputAttribute = BoolAttributeValue(filesElement.Attribute("copyToOutput")?.Value),
                        FlattenAttribute = BoolAttributeValue(filesElement.Attribute("flatten")?.Value),
                    });
                }
            }

            return result;
        }
    }
}
