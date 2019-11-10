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
using System.IO;

namespace MakeANuGet.HelperClasses
{
    /// <summary>
    /// A class to help with relative paths.
    /// </summary>
    public class RelativePath
    {
        /// <summary>
        /// Gets the relative path (at leas it should).
        /// </summary>
        /// <param name="path">The path to relate to the <paramref name="basePath"/>.</param>
        /// <param name="basePath">The base path to relate the <paramref name="path"/>.</param>
        /// <param name="addCurrentPathSymbol">A value indicating whether the current path symbol (.) should be added to the result if no '..' relation starts the resulting string.</param>
        /// <returns>A relative path to compared to the given <paramref name="basePath"/> if successful; otherwise <paramref name="path"/> is returned.</returns>
        public static string GetRelativePath(string path, string basePath, bool addCurrentPathSymbol = false)
        {
            try
            {
                // (C):: https://social.msdn.microsoft.com/Forums/vstudio/en-US/954346c8-cbe8-448c-80d0-d3fc27796e9c/how-to-convert-absolute-file-path-to-relative-path-in-c?forum=csharpgeneral
                // (C):: https://social.msdn.microsoft.com/Forums/vstudio/en-US/aa5e2334-874c-424f-91ab-155e1a39cc12/replacing-20-in-uriabsoluteuri?forum=csharpgeneral
                var uriPath = new Uri(path);
                var uriBase = new Uri(basePath);

                var result = uriBase.MakeRelativeUri(uriPath).ToString();

                result = Uri.UnescapeDataString(result);

                result = result.Replace('/', Path.DirectorySeparatorChar);

                if (addCurrentPathSymbol && !result.StartsWith("."))
                {
                    result = "." + Path.DirectorySeparatorChar + result;
                }

                return result;
            }
            catch
            {
                return path;
            }
        }
    }
}
