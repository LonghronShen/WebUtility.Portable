using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace PCLWebUtility.Internal
{

    internal class ExtendedHtmlUtility
    {

        private static Regex entityResolver = new Regex(@"([&][#](?'decimal'[0-9]+);)|([&][#][(x|X)](?'hex'[0-9a-fA-F]+);)|([&](?'html'\w+);)");

        private static string EntityLookup(string entity)
        {
            switch (entity)
            {
                case "Aacute":
                    return Convert.ToChar(0xc1).ToString();

                case "aacute":
                    return Convert.ToChar(0xe1).ToString();

                case "acirc":
                    return Convert.ToChar(0xe2).ToString();

                case "Acirc":
                    return Convert.ToChar(0xc2).ToString();

                case "acute":
                    return Convert.ToChar(180).ToString();

                case "AElig":
                    return Convert.ToChar(0xc6).ToString();

                case "aelig":
                    return Convert.ToChar(230).ToString();

                case "Agrave":
                    return Convert.ToChar(0xc0).ToString();

                case "agrave":
                    return Convert.ToChar(0xe0).ToString();

                case "alefsym":
                    return Convert.ToChar(0x2135).ToString();

                case "Alpha":
                    return Convert.ToChar(0x391).ToString();

                case "alpha":
                    return Convert.ToChar(0x3b1).ToString();

                case "amp":
                    return Convert.ToChar(0x26).ToString();

                case "and":
                    return Convert.ToChar(0x2227).ToString();

                case "ang":
                    return Convert.ToChar(0x2220).ToString();

                case "aring":
                    return Convert.ToChar(0xe5).ToString();

                case "Aring":
                    return Convert.ToChar(0xc5).ToString();

                case "asymp":
                    return Convert.ToChar(0x2248).ToString();

                case "Atilde":
                    return Convert.ToChar(0xc3).ToString();

                case "atilde":
                    return Convert.ToChar(0xe3).ToString();

                case "auml":
                    return Convert.ToChar(0xe4).ToString();

                case "Auml":
                    return Convert.ToChar(0xc4).ToString();

                case "bdquo":
                    return Convert.ToChar(0x201e).ToString();

                case "Beta":
                    return Convert.ToChar(0x392).ToString();

                case "beta":
                    return Convert.ToChar(0x3b2).ToString();

                case "brvbar":
                    return Convert.ToChar(0xa6).ToString();

                case "bull":
                    return Convert.ToChar(0x2022).ToString();

                case "cap":
                    return Convert.ToChar(0x2229).ToString();

                case "Ccedil":
                    return Convert.ToChar(0xc7).ToString();

                case "ccedil":
                    return Convert.ToChar(0xe7).ToString();

                case "cedil":
                    return Convert.ToChar(0xb8).ToString();

                case "cent":
                    return Convert.ToChar(0xa2).ToString();

                case "chi":
                    return Convert.ToChar(0x3c7).ToString();

                case "Chi":
                    return Convert.ToChar(0x3a7).ToString();

                case "circ":
                    return Convert.ToChar(710).ToString();

                case "clubs":
                    return Convert.ToChar(0x2663).ToString();

                case "cong":
                    return Convert.ToChar(0x2245).ToString();

                case "copy":
                    return Convert.ToChar(0xa9).ToString();

                case "crarr":
                    return Convert.ToChar(0x21b5).ToString();

                case "cup":
                    return Convert.ToChar(0x222a).ToString();

                case "curren":
                    return Convert.ToChar(0xa4).ToString();

                case "dagger":
                    return Convert.ToChar(0x2020).ToString();

                case "Dagger":
                    return Convert.ToChar(0x2021).ToString();

                case "darr":
                    return Convert.ToChar(0x2193).ToString();

                case "dArr":
                    return Convert.ToChar(0x21d3).ToString();

                case "deg":
                    return Convert.ToChar(0xb0).ToString();

                case "Delta":
                    return Convert.ToChar(0x394).ToString();

                case "delta":
                    return Convert.ToChar(0x3b4).ToString();

                case "diams":
                    return Convert.ToChar(0x2666).ToString();

                case "divide":
                    return Convert.ToChar(0xf7).ToString();

                case "eacute":
                    return Convert.ToChar(0xe9).ToString();

                case "Eacute":
                    return Convert.ToChar(0xc9).ToString();

                case "Ecirc":
                    return Convert.ToChar(0xca).ToString();

                case "ecirc":
                    return Convert.ToChar(0xea).ToString();

                case "Egrave":
                    return Convert.ToChar(200).ToString();

                case "egrave":
                    return Convert.ToChar(0xe8).ToString();

                case "empty":
                    return Convert.ToChar(0x2205).ToString();

                case "emsp":
                    return Convert.ToChar(0x2003).ToString();

                case "ensp":
                    return Convert.ToChar(0x2002).ToString();

                case "epsilon":
                    return Convert.ToChar(0x3b5).ToString();

                case "Epsilon":
                    return Convert.ToChar(0x395).ToString();

                case "equiv":
                    return Convert.ToChar(0x2261).ToString();

                case "Eta":
                    return Convert.ToChar(0x397).ToString();

                case "eta":
                    return Convert.ToChar(0x3b7).ToString();

                case "eth":
                    return Convert.ToChar(240).ToString();

                case "ETH":
                    return Convert.ToChar(0xd0).ToString();

                case "Euml":
                    return Convert.ToChar(0xcb).ToString();

                case "euml":
                    return Convert.ToChar(0xeb).ToString();

                case "euro":
                    return Convert.ToChar(0x20ac).ToString();

                case "exist":
                    return Convert.ToChar(0x2203).ToString();

                case "fnof":
                    return Convert.ToChar(0x192).ToString();

                case "forall":
                    return Convert.ToChar(0x2200).ToString();

                case "frac12":
                    return Convert.ToChar(0xbd).ToString();

                case "frac14":
                    return Convert.ToChar(0xbc).ToString();

                case "frac34":
                    return Convert.ToChar(190).ToString();

                case "frasl":
                    return Convert.ToChar(0x2044).ToString();

                case "gamma":
                    return Convert.ToChar(0x3b3).ToString();

                case "Gamma":
                    return Convert.ToChar(0x393).ToString();

                case "ge":
                    return Convert.ToChar(0x2265).ToString();

                case "gt":
                    return Convert.ToChar(0x3e).ToString();

                case "hArr":
                    return Convert.ToChar(0x21d4).ToString();

                case "harr":
                    return Convert.ToChar(0x2194).ToString();

                case "hearts":
                    return Convert.ToChar(0x2665).ToString();

                case "hellip":
                    return Convert.ToChar(0x2026).ToString();

                case "Iacute":
                    return Convert.ToChar(0xcd).ToString();

                case "iacute":
                    return Convert.ToChar(0xed).ToString();

                case "icirc":
                    return Convert.ToChar(0xee).ToString();

                case "Icirc":
                    return Convert.ToChar(0xce).ToString();

                case "iexcl":
                    return Convert.ToChar(0xa1).ToString();

                case "Igrave":
                    return Convert.ToChar(0xcc).ToString();

                case "igrave":
                    return Convert.ToChar(0xec).ToString();

                case "image":
                    return Convert.ToChar(0x2111).ToString();

                case "infin":
                    return Convert.ToChar(0x221e).ToString();

                case "int":
                    return Convert.ToChar(0x222b).ToString();

                case "Iota":
                    return Convert.ToChar(0x399).ToString();

                case "iota":
                    return Convert.ToChar(0x3b9).ToString();

                case "iquest":
                    return Convert.ToChar(0xbf).ToString();

                case "isin":
                    return Convert.ToChar(0x2208).ToString();

                case "iuml":
                    return Convert.ToChar(0xef).ToString();

                case "Iuml":
                    return Convert.ToChar(0xcf).ToString();

                case "kappa":
                    return Convert.ToChar(0x3ba).ToString();

                case "Kappa":
                    return Convert.ToChar(0x39a).ToString();

                case "Lambda":
                    return Convert.ToChar(0x39b).ToString();

                case "lambda":
                    return Convert.ToChar(0x3bb).ToString();

                case "lang":
                    return Convert.ToChar(0x2329).ToString();

                case "laquo":
                    return Convert.ToChar(0xab).ToString();

                case "larr":
                    return Convert.ToChar(0x2190).ToString();

                case "lArr":
                    return Convert.ToChar(0x21d0).ToString();

                case "lceil":
                    return Convert.ToChar(0x2308).ToString();

                case "ldquo":
                    return Convert.ToChar(0x201c).ToString();

                case "le":
                    return Convert.ToChar(0x2264).ToString();

                case "lfloor":
                    return Convert.ToChar(0x230a).ToString();

                case "lowast":
                    return Convert.ToChar(0x2217).ToString();

                case "loz":
                    return Convert.ToChar(0x25ca).ToString();

                case "lrm":
                    return Convert.ToChar(0x200e).ToString();

                case "lsaquo":
                    return Convert.ToChar(0x2039).ToString();

                case "lsquo":
                    return Convert.ToChar(0x2018).ToString();

                case "lt":
                    return Convert.ToChar(60).ToString();

                case "macr":
                    return Convert.ToChar(0xaf).ToString();

                case "mdash":
                    return Convert.ToChar(0x2014).ToString();

                case "micro":
                    return Convert.ToChar(0xb5).ToString();

                case "middot":
                    return Convert.ToChar(0xb7).ToString();

                case "minus":
                    return Convert.ToChar(0x2212).ToString();

                case "Mu":
                    return Convert.ToChar(0x39c).ToString();

                case "mu":
                    return Convert.ToChar(0x3bc).ToString();

                case "nabla":
                    return Convert.ToChar(0x2207).ToString();

                case "nbsp":
                    return Convert.ToChar(160).ToString();

                case "ndash":
                    return Convert.ToChar(0x2013).ToString();

                case "ne":
                    return Convert.ToChar(0x2260).ToString();

                case "ni":
                    return Convert.ToChar(0x220b).ToString();

                case "not":
                    return Convert.ToChar(0xac).ToString();

                case "notin":
                    return Convert.ToChar(0x2209).ToString();

                case "nsub":
                    return Convert.ToChar(0x2284).ToString();

                case "ntilde":
                    return Convert.ToChar(0xf1).ToString();

                case "Ntilde":
                    return Convert.ToChar(0xd1).ToString();

                case "Nu":
                    return Convert.ToChar(0x39d).ToString();

                case "nu":
                    return Convert.ToChar(0x3bd).ToString();

                case "oacute":
                    return Convert.ToChar(0xf3).ToString();

                case "Oacute":
                    return Convert.ToChar(0xd3).ToString();

                case "Ocirc":
                    return Convert.ToChar(0xd4).ToString();

                case "ocirc":
                    return Convert.ToChar(0xf4).ToString();

                case "OElig":
                    return Convert.ToChar(0x152).ToString();

                case "oelig":
                    return Convert.ToChar(0x153).ToString();

                case "ograve":
                    return Convert.ToChar(0xf2).ToString();

                case "Ograve":
                    return Convert.ToChar(210).ToString();

                case "oline":
                    return Convert.ToChar(0x203e).ToString();

                case "Omega":
                    return Convert.ToChar(0x3a9).ToString();

                case "omega":
                    return Convert.ToChar(0x3c9).ToString();

                case "Omicron":
                    return Convert.ToChar(0x39f).ToString();

                case "omicron":
                    return Convert.ToChar(0x3bf).ToString();

                case "oplus":
                    return Convert.ToChar(0x2295).ToString();

                case "or":
                    return Convert.ToChar(0x2228).ToString();

                case "ordf":
                    return Convert.ToChar(170).ToString();

                case "ordm":
                    return Convert.ToChar(0xba).ToString();

                case "Oslash":
                    return Convert.ToChar(0xd8).ToString();

                case "oslash":
                    return Convert.ToChar(0xf8).ToString();

                case "otilde":
                    return Convert.ToChar(0xf5).ToString();

                case "Otilde":
                    return Convert.ToChar(0xd5).ToString();

                case "otimes":
                    return Convert.ToChar(0x2297).ToString();

                case "Ouml":
                    return Convert.ToChar(0xd6).ToString();

                case "ouml":
                    return Convert.ToChar(0xf6).ToString();

                case "para":
                    return Convert.ToChar(0xb6).ToString();

                case "part":
                    return Convert.ToChar(0x2202).ToString();

                case "permil":
                    return Convert.ToChar(0x2030).ToString();

                case "perp":
                    return Convert.ToChar(0x22a5).ToString();

                case "Phi":
                    return Convert.ToChar(0x3a6).ToString();

                case "phi":
                    return Convert.ToChar(0x3c6).ToString();

                case "Pi":
                    return Convert.ToChar(0x3a0).ToString();

                case "pi":
                    return Convert.ToChar(960).ToString();

                case "piv":
                    return Convert.ToChar(0x3d6).ToString();

                case "plusmn":
                    return Convert.ToChar(0xb1).ToString();

                case "pound":
                    return Convert.ToChar(0xa3).ToString();

                case "Prime":
                    return Convert.ToChar(0x2033).ToString();

                case "prime":
                    return Convert.ToChar(0x2032).ToString();

                case "prod":
                    return Convert.ToChar(0x220f).ToString();

                case "prop":
                    return Convert.ToChar(0x221d).ToString();

                case "psi":
                    return Convert.ToChar(0x3c8).ToString();

                case "Psi":
                    return Convert.ToChar(0x3a8).ToString();

                case "quot":
                    return Convert.ToChar(0x22).ToString();

                case "radic":
                    return Convert.ToChar(0x221a).ToString();

                case "rang":
                    return Convert.ToChar(0x232a).ToString();

                case "raquo":
                    return Convert.ToChar(0xbb).ToString();

                case "rarr":
                    return Convert.ToChar(0x2192).ToString();

                case "rArr":
                    return Convert.ToChar(0x21d2).ToString();

                case "rceil":
                    return Convert.ToChar(0x2309).ToString();

                case "rdquo":
                    return Convert.ToChar(0x201d).ToString();

                case "real":
                    return Convert.ToChar(0x211c).ToString();

                case "reg":
                    return Convert.ToChar(0xae).ToString();

                case "rfloor":
                    return Convert.ToChar(0x230b).ToString();

                case "rho":
                    return Convert.ToChar(0x3c1).ToString();

                case "Rho":
                    return Convert.ToChar(0x3a1).ToString();

                case "rlm":
                    return Convert.ToChar(0x200f).ToString();

                case "rsaquo":
                    return Convert.ToChar(0x203a).ToString();

                case "rsquo":
                    return Convert.ToChar(0x2019).ToString();

                case "sbquo":
                    return Convert.ToChar(0x201a).ToString();

                case "Scaron":
                    return Convert.ToChar(0x160).ToString();

                case "scaron":
                    return Convert.ToChar(0x161).ToString();

                case "sdot":
                    return Convert.ToChar(0x22c5).ToString();

                case "sect":
                    return Convert.ToChar(0xa7).ToString();

                case "shy":
                    return Convert.ToChar(0xad).ToString();

                case "sigma":
                    return Convert.ToChar(0x3c3).ToString();

                case "Sigma":
                    return Convert.ToChar(0x3a3).ToString();

                case "sigmaf":
                    return Convert.ToChar(0x3c2).ToString();

                case "sim":
                    return Convert.ToChar(0x223c).ToString();

                case "spades":
                    return Convert.ToChar(0x2660).ToString();

                case "sub":
                    return Convert.ToChar(0x2282).ToString();

                case "sube":
                    return Convert.ToChar(0x2286).ToString();

                case "sum":
                    return Convert.ToChar(0x2211).ToString();

                case "sup":
                    return Convert.ToChar(0x2283).ToString();

                case "sup1":
                    return Convert.ToChar(0xb9).ToString();

                case "sup2":
                    return Convert.ToChar(0xb2).ToString();

                case "sup3":
                    return Convert.ToChar(0xb3).ToString();

                case "supe":
                    return Convert.ToChar(0x2287).ToString();

                case "szlig":
                    return Convert.ToChar(0xdf).ToString();

                case "Tau":
                    return Convert.ToChar(0x3a4).ToString();

                case "tau":
                    return Convert.ToChar(0x3c4).ToString();

                case "there4":
                    return Convert.ToChar(0x2234).ToString();

                case "theta":
                    return Convert.ToChar(0x3b8).ToString();

                case "Theta":
                    return Convert.ToChar(920).ToString();

                case "thetasym":
                    return Convert.ToChar(0x3d1).ToString();

                case "thinsp":
                    return Convert.ToChar(0x2009).ToString();

                case "thorn":
                    return Convert.ToChar(0xfe).ToString();

                case "THORN":
                    return Convert.ToChar(0xde).ToString();

                case "tilde":
                    return Convert.ToChar(0x2dc).ToString();

                case "times":
                    return Convert.ToChar(0xd7).ToString();

                case "trade":
                    return Convert.ToChar(0x2122).ToString();

                case "Uacute":
                    return Convert.ToChar(0xda).ToString();

                case "uacute":
                    return Convert.ToChar(250).ToString();

                case "uarr":
                    return Convert.ToChar(0x2191).ToString();

                case "uArr":
                    return Convert.ToChar(0x21d1).ToString();

                case "Ucirc":
                    return Convert.ToChar(0xdb).ToString();

                case "ucirc":
                    return Convert.ToChar(0xfb).ToString();

                case "Ugrave":
                    return Convert.ToChar(0xd9).ToString();

                case "ugrave":
                    return Convert.ToChar(0xf9).ToString();

                case "uml":
                    return Convert.ToChar(0xa8).ToString();

                case "upsih":
                    return Convert.ToChar(0x3d2).ToString();

                case "Upsilon":
                    return Convert.ToChar(0x3a5).ToString();

                case "upsilon":
                    return Convert.ToChar(0x3c5).ToString();

                case "Uuml":
                    return Convert.ToChar(220).ToString();

                case "uuml":
                    return Convert.ToChar(0xfc).ToString();

                case "weierp":
                    return Convert.ToChar(0x2118).ToString();

                case "Xi":
                    return Convert.ToChar(0x39e).ToString();

                case "xi":
                    return Convert.ToChar(0x3be).ToString();

                case "yacute":
                    return Convert.ToChar(0xfd).ToString();

                case "Yacute":
                    return Convert.ToChar(0xdd).ToString();

                case "yen":
                    return Convert.ToChar(0xa5).ToString();

                case "Yuml":
                    return Convert.ToChar(0x178).ToString();

                case "yuml":
                    return Convert.ToChar(0xff).ToString();

                case "zeta":
                    return Convert.ToChar(950).ToString();

                case "Zeta":
                    return Convert.ToChar(0x396).ToString();

                case "zwj":
                    return Convert.ToChar(0x200d).ToString();

                case "zwnj":
                    return Convert.ToChar(0x200c).ToString();
            }
            return "";
        }

        public static int HexToInt(string hexstr)
        {
            int num2 = 0;
            hexstr = hexstr.ToUpper();
            char[] chArray = hexstr.ToCharArray();
            for (int i = chArray.Length - 1; i >= 0; i--)
            {
                if ((chArray[i] >= '0') && (chArray[i] <= '9'))
                {
                    num2 += (chArray[i] - '0') * ((int) Math.Pow(16.0, (double) ((chArray.Length - 1) - i)));
                }
                else if ((chArray[i] >= 'A') && (chArray[i] <= 'F'))
                {
                    num2 += (chArray[i] - '7') * ((int) Math.Pow(16.0, (double) ((chArray.Length - 1) - i)));
                }
                else
                {
                    return 0;
                }
            }
            return num2;
        }

        public static string HtmlEntityDecode(string encodedText)
        {
            return entityResolver.Replace(encodedText, new MatchEvaluator(ExtendedHtmlUtility.ResolveEntityAngleAmp));
        }

        public static string HtmlEntityDecode(string encodedText, bool encodeTagsToo)
        {
            if (encodeTagsToo)
            {
                return entityResolver.Replace(encodedText, new MatchEvaluator(ExtendedHtmlUtility.ResolveEntityAngleAmp));
            }
            return entityResolver.Replace(encodedText, new MatchEvaluator(ExtendedHtmlUtility.ResolveEntityNotAngleAmp));
        }

        public static string HtmlEntityEncode(string unicodeText)
        {
            return HtmlEntityEncode(unicodeText, true);
        }

        public static string HtmlEntityEncode(string unicodeText, bool encodeTagsToo)
        {
            string str = string.Empty;
            foreach (char ch in unicodeText)
            {
                int num = ch;
                switch (num)
                {
                    case 60:
                    {
                        if (encodeTagsToo)
                        {
                            str = str + "&lt;";
                        }
                        continue;
                    }
                    case 0x3e:
                    {
                        if (encodeTagsToo)
                        {
                            str = str + "&gt;";
                        }
                        continue;
                    }
                    case 0x26:
                    {
                        if (encodeTagsToo)
                        {
                            str = str + "&amp;";
                        }
                        continue;
                    }
                }
                if ((ch >= ' ') && (ch <= '~'))
                {
                    str = str + ch;
                }
                else
                {
                    str = str + ("&#" + num.ToString(NumberFormatInfo.InvariantInfo) + ";");
                }
            }
            return str;
        }

        private static string ResolveEntityAngleAmp(Match matchToProcess)
        {
            if (matchToProcess.Groups["decimal"].Success)
            {
                return Convert.ToChar(Convert.ToInt32(matchToProcess.Groups["decimal"].Value)).ToString();
            }
            if (matchToProcess.Groups["hex"].Success)
            {
                return Convert.ToChar(HexToInt(matchToProcess.Groups["hex"].Value)).ToString();
            }
            if (matchToProcess.Groups["html"].Success)
            {
                return EntityLookup(matchToProcess.Groups["html"].Value);
            }
            return "Y";
        }

        private static string ResolveEntityNotAngleAmp(Match matchToProcess)
        {
            if (matchToProcess.Groups["decimal"].Success)
            {
                return Convert.ToChar(Convert.ToInt32(matchToProcess.Groups["decimal"].Value)).ToString();
            }
            if (matchToProcess.Groups["hex"].Success)
            {
                return Convert.ToChar(HexToInt(matchToProcess.Groups["hex"].Value)).ToString();
            }
            if (matchToProcess.Groups["html"].Success)
            {
                string str3;
                string entity = matchToProcess.Groups["html"].Value;
                if (((str3 = entity.ToLower()) != null) && (((str3 == "lt") || (str3 == "gt")) || (str3 == "amp")))
                {
                    return ("&" + entity + ";");
                }
                return EntityLookup(entity);
            }
            return "X";
        }

    }

}