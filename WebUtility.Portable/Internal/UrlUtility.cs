using System;

namespace PCLWebUtility.Internal
{

    internal class UrlUtility
    {
        public static string UrlDecode(string text)
        {
            text = text.Replace("+", " ");
            return Uri.UnescapeDataString(text);
        }

        public static string UrlEncode(string text)
        {
            return Uri.EscapeDataString(text);
        }

    }

}