using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeANuGet.HelperClasses
{
    /// <summary>
    /// A class to store a .nuspec contentFiles element data.
    /// </summary>
    public class NuspecFileContentElement
    {
        /// <summary>
        /// Gets or sets the include attribute value.
        /// </summary>
        public string IncludeAttribute { get; set; }

        /// <summary>
        /// Gets or sets the exclude attribute value.
        /// </summary>
        public string ExcludeAttribute { get; set; }

        /// <summary>
        /// Gets or sets the buildAction attribute value.
        /// </summary>
        public string BuildActionAttribute { get; set; }

        /// <summary>
        /// Gets or sets the copyToOutput attribute value.
        /// </summary>
        public bool CopyToOutputAttribute { get; set; }

        /// <summary>
        /// Gets or sets the flatten attribute value.
        /// </summary>
        public bool FlattenAttribute { get; set; }
    }
}
