using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Vacabulary.Models
{
    public enum SubtitleFileTypes
    {
        [Description("txt")]
        Txt,
        [Description("srt")]
        Srt,
        [Description("smi")]
        Smi,
        [Description("s2k")]
        S2k,
        [Description("ssa")]
        Ssa,
        [Description("ass")]
        Ass,
        [Description("sub/ids")]
        SubIdx,
    }

    public static class SubtitleFileTypesMethods
    {
        public static string ToFileExtenstion(this SubtitleFileTypes fileType)
        {
            return GetCustomDescription(fileType);
        }

        public static string GetCustomDescription(object objEnum)
        {
            var fi = objEnum.GetType().GetField(objEnum.ToString());
            var attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
            return (attributes.Length > 0) ? attributes[0].Description : objEnum.ToString();
        }
    }
}