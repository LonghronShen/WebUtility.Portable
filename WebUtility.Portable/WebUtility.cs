using PCLWebUtility.Internal;
using System;
using System.IO;
using System.Text;

namespace PCLWebUtility
{

    public static class WebUtility
    {

        public static string HtmlDecode(string value)
        {
            return ExtendedHtmlUtility.HtmlEntityDecode(value);
        }

        public static void HtmlDecode(string value, TextWriter output)
        {
            string str = ExtendedHtmlUtility.HtmlEntityDecode(value);
            output.Write(str);
        }

        public static string HtmlEncode(string value)
        {
            return ExtendedHtmlUtility.HtmlEntityEncode(value);
        }

        public static void HtmlEncode(string value, TextWriter output)
        {
            string str = ExtendedHtmlUtility.HtmlEntityEncode(value);
            output.Write(str);
        }

        public static string UrlDecode(string encodedValue)
        {
            return UrlUtility.UrlDecode(encodedValue);
        }

        public static string UrlEncode(string value)
        {
            return UrlUtility.UrlEncode(value);
        }

    }

}