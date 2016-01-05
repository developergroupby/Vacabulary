using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Vacabulary.Models
{
    public class Subtitles
    {
        public static readonly IEnumerable<string> SupportedFileExtensions = new[] {"txt", "srt", "smi", "s2k", "ssa", "ass", "sub/idx"};

        public static bool IsSupported(string fileName)
        {
            string fileExtension = GetFileExtension(fileName);
            return SupportedFileExtensions.Any(ext => ext.Equals(fileExtension, StringComparison.OrdinalIgnoreCase));
        }

        public static string GetFileExtension(string fileName)
        {
            int lastDotIndex = fileName.LastIndexOf('.');
            if (lastDotIndex < 0)
            {
                return null;
            }

            return fileName.Substring(lastDotIndex + 1);
        }
    }
}