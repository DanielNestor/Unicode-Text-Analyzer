using System;
using System.Drawing;

namespace UnicodeTextAnalyzer
{
    public class textTypes
    {
        public textTypes()
        {

        }

        //this determines what type of unicode character
        //is input
        public static String getCharacterType(int input)
        {
            if (input < 32)
            {
                return "invalid";
            }
            else if (input >= 32 && input <= 127)
            {
                return "Basic Latin";
            }
            else if (input >= 160 && input <= 255)
            {
                return "Latin-1 Suppliment";
            }
            else if (input >= 256 && input <= 383)
            {
                return "Latin Extended-A";
            }
            else if (input >= 384 && input <= 591)
            {
                return "Latin Extended-B";
            }
            else if (input >= 592 && input <= 687)
            {
                return "IPA Extensions";
            }
            else if (input >= 688 && input <= 767)
            {
                return "Spacing Modifier Letters";
            }
            else if (input >= 768 && input <= 879)
            {
                return "Combining Diacritical Marks";
            }
            else if (input >= 880 && input <= 1023)
            {
                return "Greek and Coptic";
            }
            else if (input >= 1024 && input <= 1279)
            {
                return "Cyrillic";
            }
            else if (input >= 1280 && input <= 1327)
            {
                return "Cyrillic Supplementary";
            }
            else if (input >= 1328 && input <= 1423)
            {
                return "Armenian";
            }
            else if (input >= 1424 && input <= 1535)
            {
                return "Hebrew";
            }
            else if (input >= 1536  && input <= 1791)
            {
                return "Arabic";
            }
            else if (input >= 1792 && input <= 1871)
            {
                return "Syriac";
            }
            else if (input >= 1920 && input <= 1983)
            {
                return "Thaana";
            }
            else if (input >= 2304 && input <= 2431)
            {
                return "Devanagari";
            }
            else if (input >= 2432 && input <= 2559)
            {
                return "Bengali";
            }
            else if (input >= 2560 && input <= 2687)
            {
                return "Gurmukhi";
            }
            else if (input >= 2688 && input <= 2815)
            {
                return "Gujarati";
            }
            else if (input >= 2816 && input <= 2943)
            {
                return "Oriya";
            }
            else if (input >= 2944 && input <= 3071)
            {
                return "Tamil";
            }
            else if (input >= 3072  && input <= 3199)
            {
                return "Telugu";
            }
            else if (input >= 3200 && input <= 3327)
            {
                return "Kannada";
            }
            else if (input >= 3328 && input <= 3455)
            {
                return "Malayalam";
            }
            else if (input >= 3456 && input <=3583)
            {
                return "Sinhala";
            }
            else if (input >= 3584 && input <= 3711)
            {
                return "Thai";
            }
            else if (input >= 3712 && input <= 3839)
            {
                return "Lao";
            }
            else if (input >= 3840 && input <= 4095)
            {
                return "Tibetan";
            }
            else if (input >= 4096 && input <= 4255)
            {
                return "Myanmar";
            }
            else if (input >= 4256 && input <= 4351)
            {
                return "Georgian";
            }
            else if (input >= 4352  && input <= 4607)
            {
                return "Hangul Jamo";
            }
            else if (input >= 4608 && input <= 4991)
            {
                return "Ethiopic";
            }
            else if (input >= 5024 && input <= 5119)
            {
                return "Cherokee";
            }
            else if (input >= 5120 && input <= 5759)
            {
                return "Unified Canadian Aboriginal Syllabics";
            }
            else if (input >= 5760 && input <= 5791)
            {
                return "Ogham";
            }
            else if (input >= 5792  && input <= 5887)
            {
                return "Runic";
            }
            else if (input >= 5888  && input <= 5919)
            {
                return "Tagalog";
            }
            else if (input >= 5920 && input <= 5951)
            {
                return "Hanunoo";
            }
            else if (input >= 5952 && input <= 5983)
            {
                return "Buhid";
            }
            else if (input >= 5984 && input <= 6015)
            {
                return "Tagbanwa";
            }
            else if (input >= 6016 && input <= 6143)
            {
                return "Khmer";
            }
            else if (input >= 6144 && input <= 6319)
            {
                return "Mongolian";
            }
            else if (input >= 6400  && input <= 6479 )
            {
                return "Limbu";
            }
            else if (input >= 6480 && input <= 6527 )
            {
                return "Tai Le";
            }
            else if (input >= 6624 && input <= 6655)
            {
                return "Khmer Symbols";
            }
            else if (input >= 7424 && input <= 7551)
            {
                return "Phnonetic Extensions";
            }
            else if (input >= 7680 && input <= 7935)
            {
                return "Latin Extended Additional";
            }
            else if (input >= 7936 && input <= 8191)
            {
                return "Greek Extended";
            }
            else if (input >= 8192 && input <= 8303)
            {
                return "General Punctuation";
            }
            else if (input >= 8304 && input <= 8351)
            {
                return "Superscripts and Substripts";
            }
            else if (input >= 8352 && input <=8399)
            {
                return "Currency Symbols";
            }
            else if (input >= 8400 && input <= 8447)
            {
                return "Combining Diacritical Marks for Symbols";
            }
            else if (input >= 8448 && input <= 8527)
            {
                return "Letterlike Symbols";
            }
            else if (input >= 8528 && input <= 8591)
            {
                return "Number Forms";
            }
            else if (input >= 8592 && input <= 8703)
            {
                return "Arrows";
            }
            else if (input >= 8704  && input <= 8959)
            {
                return "Mathematical Operators";
            }
            else if (input >= 8960 && input <= 9215)
            {
                return "Miscellaneous Technical";
            }
            else if (input >= 9216  && input <= 9279 )
            {
                return "Control Pictures";
            }
            else if (input >= 9280 && input <= 9311)
            {
                return "Optical Character Recognition";
            }
            else if (input >= 9312  && input <= 9471)
            {
                return "Enclosed Alphanumerics";
            }
            else if (input >= 9472 && input <= 9599)
            {
                return "Box Drawing";
            }
            else if (input >= 9600  && input <= 9631)
            {
                return "Block Elements";
            }
            else if (input >= 9632 && input <= 9727)
            {
                return "Geometric Shapes";
            }
            else if (input >= 9728 && input <= 9983)
            {
                return "Miscellaneous Symbols";
            }
            else if (input >= 9984 && input <= 10175)
            {
                return "Dingbats";
            }
            else if (input >= 10176  && input <= 10223)
            {
                return "Miscellaneous Mathematical Symbols-A";
            }
            else if (input >= 10224 && input <= 10239)
            {
                return "Supplemental Arrows-A";
            }
            else if (input >= 10240  && input <= 10495)
            {
                return "Braille Patterns";
            }
            else if (input >= 10496  && input <= 10623)
            {
                return "Supplemental Arrows-B";
            }
            else if (input >= 10624  && input <= 10751)
            {
                return "Miscellaneous Mathematical Symbols-B";
            }
            else if (input >= 10752 && input <= 11007)
            {
                return "Supplemental Mathematical Operators";
            }
            else if (input >= 11008 && input <= 11263)
            {
                return "Miscellaneous Symbols and Arrows";
            }
            else if (input >= 11904  && input <= 12031)
            {
                return "CJK Radicals Supplement";
            }
            else if (input >= 12032  && input <= 12255)
            {
                return "Kangxi Radicals";
            }
            else if (input >= 12272  && input <= 12287)
            {
                return "Ideographic Description Characters";
            }
            else if (input >= 12288  && input <= 12351)
            {
                return "CJK Symbols and Punctuation";
            }
            else if (input >= 12352  && input <= 12447)
            {
                return "Hiragana";
            }
            else if (input >= 12448 && input <= 12543)
            {
                return "Katakana";
            }
            else if (input >= 12544 && input <= 12591)
            {
                return "Bopomofo";
            }
            else if (input >= 12592 && input <= 12687)
            {
                return "Hangul Compatibility Jamo";
            }
            else if (input >= 12688 && input <= 12703)
            {
                return "Kanbun";
            }
            else if (input >= 12704 && input <= 12735)
            {
                return "Bopomofo Extended";
            }
            else if (input >= 12784 && input <= 12799)
            {
                return "Katakana Phonetic Extensions";
            }
            else if (input >= 12800 && input <= 13055)
            {
                return "Enclosed CJK Letters and Months";
            }
            else if (input >= 13056 && input <= 13311)
            {
                return "CJK Compatibility";
            }
            else if (input >= 13312 && input <= 19903)
            {
                return "CJK Unified Ideographs Extension A";
            }
            else if (input >= 19904 && input <= 19967)
            {
                return "Yijing Hexagram Symbols";
            }
            else if (input >= 19968 && input <= 40959)
            {
                return "CJK Unified Ideographs";
            }
            else if (input >= 40960 && input <= 42127)
            {
                return "Yi Syllables";
            }
            else if (input >= 42128 && input <= 42191)
            {
                return "Yi Radicals";
            }
            else if (input >= 44032 && input <= 55215)
            {
                return "Hangul Syllables";
            }
            else if (input >= 55296 && input <= 56191)
            {
                return "High Surrogates";
            }
            else if (input >= 56192 && input <= 56319)
            {
                return "High Private Use Surrogates";
            }
            else if (input >= 56320 && input <= 57343)
            {
                return "Low Surrogates";
            }
            else if (input >= 57344 && input <= 63743)
            {
                return "Private Use Area";
            }
            else if (input >= 63744 && input <= 64255)
            {
                return "CJK Compatibility Ideographs";
            }
            else if (input >= 64256 && input <= 64335)
            {
                return "Alphabetic Presentation Forms";
            }
            else if (input >= 64336 && input <= 65023)
            {
                return "Arabic Presentation Forms-A";
            }
            else if (input >=  65024 && input <= 65039)
            {
                return "Variation Selectors";
            }
            else if (input >= 62240 && input <= 65071)
            {
                return "Combining Half Marks";
            }
            else if (input >= 65072 && input <= 65103)
            {
                return "CJK Compatibility Forms";
            }
            else if (input >= 65104 && input <= 65135)
            {
                return "Small Form Variants";
            }
            else if (input >= 65136 && input <= 65279)
            {
                return "Arabic Presentation Forms-B";
            }
            else if (input >= 65280 && input <= 65519)
            {
                return "Halfwidth and Fullwidth Forms";
            }
            else if (input >= 65520 && input <= 65535)
            {
                return "Specials";
            }
            else if (input >= 65536 && input <= 65663)
            {
                return "Linear B Syllabary";
            }
            else if (input >= 65664 && input <= 65791)
            {
                return "Linear B Ideograms";
            }
            else if (input >= 65792 && input <= 65855)
            {
                return "Aegean Numbers";
            }
            else if (input >= 66304 && input <= 66351)
            {
                return "Old Italic";
            }
            else if (input >= 66352 && input <= 66383)
            {
                return "Gothic";
            }
            else if (input >= 66432 && input <= 66463)
            {
                return "Ugaritic";
            }
            else if (input >= 66560  && input <= 66639)
            {
                return "Deseret";
            }
            else if (input >= 66640 && input <= 66687)
            {
                return "Shavian";
            }
            else if (input >= 66688 && input <= 66735)
            {
                return "Osmanya";
            }
            else if (input >= 67584 && input <= 67647)
            {
                return "Cypriot Syllabary";
            }
            else if (input >= 118784 && input <= 119039)
            {
                return "Byzantine Musical Symbols";
            }
            else if (input >= 119040 && input <= 119295)
            {
                return "Musical Symbols";
            }
            else if (input >= 119552 && input <= 119647)
            {
                return "Tai Xuan Jing Symbols";
            }
            else if (input >= 119808 && input <= 120831)
            {
                return "Mathematical Alphanumeric Symbols";
            }
            else if (input >= 131072 && input <= 173791)
            {
                return "CJK Unified Ideographs Extension B";
            }
            else if (input >= 194560 && input <= 195103)
            {
                return "CJK Compatibility Ideographs Supplement";
            }
            else if (input >= 917504 && input <= 917631)
            {
                return "Tags";
            }

            return "Unknown Character";

        }

        internal static Color GetColor(int input)
        {
            if (input < 32)
            {
                return Color.AliceBlue;
            }
            else if (input >= 32 && input <= 127)
            {
                return Color.Aqua;
            }
            else if (input >= 160 && input <= 255)
            {
                return Color.Aquamarine;
            }
            else if (input >= 256 && input <= 383)
            {
                return Color.Azure;
            }
            else if (input >= 384 && input <= 591)
            {
                return Color.Beige;
            }
            else if (input >= 592 && input <= 687)
            {
                return Color.Bisque;
            }
            else if (input >= 688 && input <= 767)
            {
                return Color.Black;
            }
            else if (input >= 768 && input <= 879)
            {
                return Color.BlanchedAlmond;
            }
            else if (input >= 880 && input <= 1023)
            {
                return Color.Brown;
            }
            else if (input >= 1024 && input <= 1279)
            {
                return Color.BurlyWood;
            }
            else if (input >= 1280 && input <= 1327)
            {
                return Color.CadetBlue;
            }
            else if (input >= 1328 && input <= 1423)
            {
                return Color.Chartreuse;
            }
            else if (input >= 1424 && input <= 1535)
            {
                return Color.Chocolate;
            }
            else if (input >= 1536 && input <= 1791)
            {
                return Color.Coral;
            }
            else if (input >= 1792 && input <= 1871)
            {
                return Color.CornflowerBlue;
            }
            else if (input >= 1920 && input <= 1983)
            {
                return Color.Cornsilk;
            }
            else if (input >= 2304 && input <= 2431)
            {
                return Color.Crimson;
            }
            else if (input >= 2432 && input <= 2559)
            {
                return Color.DarkBlue;
            }
            else if (input >= 2560 && input <= 2687)
            {
                return Color.DarkCyan;
            }
            else if (input >= 2688 && input <= 2815)
            {
                return Color.DarkGoldenrod;
            }
            else if (input >= 2816 && input <= 2943)
            {
                return Color.DarkGreen;
            }
            else if (input >= 2944 && input <= 3071)
            {
                return Color.DarkKhaki;
            }
            else if (input >= 3072 && input <= 3199)
            {
                return Color.DarkMagenta;
            }
            else if (input >= 3200 && input <= 3327)
            {
                return Color.DarkOliveGreen;
            }
            else if (input >= 3328 && input <= 3455)
            {
                return Color.DarkOrange;
            }
            else if (input >= 3456 && input <= 3583)
            {
                return Color.DarkOrchid;
            }
            else if (input >= 3584 && input <= 3711)
            {
                return Color.DarkRed;
            }
            else if (input >= 3712 && input <= 3839)
            {
                return Color.DarkSalmon;
            }
            else if (input >= 3840 && input <= 4095)
            {
                return Color.DarkSeaGreen;
            }
            else if (input >= 4096 && input <= 4255)
            {
                return Color.DarkSlateBlue;
            }
            else if (input >= 4256 && input <= 4351)
            {
                return Color.DarkSlateGray;
            }
            else if (input >= 4352 && input <= 4607)
            {
                return Color.DarkTurquoise;
            }
            else if (input >= 4608 && input <= 4991)
            {
                return Color.DarkViolet;
            }
            else if (input >= 5024 && input <= 5119)
            {
                return Color.DeepPink;
            }
            else if (input >= 5120 && input <= 5759)
            {
                return Color.DeepSkyBlue;
            }
            else if (input >= 5760 && input <= 5791)
            {
                return Color.DimGray;
            }
            else if (input >= 5792 && input <= 5887)
            {
                return Color.DodgerBlue;
            }
            else if (input >= 5888 && input <= 5919)
            {
                return Color.Firebrick;
            }
            else if (input >= 5920 && input <= 5951)
            {
                return Color.FloralWhite;
            }
            else if (input >= 5952 && input <= 5983)
            {
                return Color.ForestGreen;
            }
            else if (input >= 5984 && input <= 6015)
            {
                return Color.Gainsboro;
            }
            else if (input >= 6016 && input <= 6143)
            {
                return Color.Goldenrod;
            }
            else if (input >= 6144 && input <= 6319)
            {
                return Color.Green;
            }
            else if (input >= 6400 && input <= 6479)
            {
                return Color.GreenYellow;
            }
            else if (input >= 6480 && input <= 6527)
            {
                return Color.Honeydew;
            }
            else if (input >= 6624 && input <= 6655)
            {
                return Color.HotPink;
            }
            else if (input >= 7424 && input <= 7551)
            {
                return Color.IndianRed;
            }
            else if (input >= 7680 && input <= 7935)
            {
                return Color.Indigo;
            }
            else if (input >= 7936 && input <= 8191)
            {
                return Color.Khaki;
            }
            else if (input >= 8192 && input <= 8303)
            {
                return Color.Lavender;
            }
            else if (input >= 8304 && input <= 8351)
            {
                return Color.LawnGreen;
            }
            else if (input >= 8352 && input <= 8399)
            {
                return Color.LightBlue;
            }
            else if (input >= 8400 && input <= 8447)
            {
                return Color.LightCoral;
            }
            else if (input >= 8448 && input <= 8527)
            {
                return Color.LightGray;
            }
            else if (input >= 8528 && input <= 8591)
            {
                return Color.PaleGreen;
            }
            else if (input >= 8592 && input <= 8703)
            {
                return Color.PaleTurquoise;
            }
            else if (input >= 8704 && input <= 8959)
            {
                return Color.PaleVioletRed;
            }
            else if (input >= 8960 && input <= 9215)
            {
                return Color.PapayaWhip;
            }
            else if (input >= 9216 && input <= 9279)
            {
                return Color.PeachPuff;
            }
            else if (input >= 9280 && input <= 9311)
            {
                return Color.Peru;
            }
            else if (input >= 9312 && input <= 9471)
            {
                return Color.Pink;
            }
            else if (input >= 9472 && input <= 9599)
            {
                return Color.Plum;
            }
            else if (input >= 9600 && input <= 9631)
            {
                return Color.PowderBlue;
            }
            else if (input >= 9632 && input <= 9727)
            {
                return Color.Purple;
            }
            else if (input >= 9728 && input <= 9983)
            {
                return Color.Red;
            }
            else if (input >= 9984 && input <= 10175)
            {
                return Color.RosyBrown;
            }
            else if (input >= 10176 && input <= 10223)
            {
                return Color.RoyalBlue;
            }
            else if (input >= 10224 && input <= 10239)
            {
                return Color.Salmon;
            }
            else if (input >= 10240 && input <= 10495)
            {
                return Color.SandyBrown;
            }
            else if (input >= 10496 && input <= 10623)
            {
                return Color.SeaGreen;
            }
            else if (input >= 10624 && input <= 10751)
            {
                return Color.SeaShell;
            }
            else if (input >= 10752 && input <= 11007)
            {
                return Color.Sienna;
            }
            else if (input >= 11008 && input <= 11263)
            {
                return Color.Silver;
            }
            else if (input >= 11904 && input <= 12031)
            {
                return Color.SkyBlue;
            }
            else if (input >= 12032 && input <= 12255)
            {
                return Color.SlateBlue;
            }
            else if (input >= 12272 && input <= 12287)
            {
                return Color.SlateGray;
            }
            else if (input >= 12288 && input <= 12351)
            {
                return Color.SpringGreen;
            }
            else if (input >= 12352 && input <= 12447)
            {
                return Color.SteelBlue;
            }
            else if (input >= 12448 && input <= 12543)
            {
                return Color.Tan;
            }
            else if (input >= 12544 && input <= 12591)
            {
                return Color.Teal;
            }
            else if (input >= 12592 && input <= 12687)
            {
                return Color.Violet;
            }
            else if (input >= 12688 && input <= 12703)
            {
                return Color.FromArgb(112,140,0);
            }
            else if (input >= 12704 && input <= 12735)
            {
                return Color.FromArgb(112,253, 0);
            }
            else if (input >= 12784 && input <= 12799)
            {
                return Color.FromArgb(112, 253, 182);
            }
            else if (input >= 12800 && input <= 13055)
            {
                return Color.FromArgb(112, 15, 182);
            }
            else if (input >= 13056 && input <= 13311)
            {
                return Color.FromArgb(230, 15, 182);
            }
            else if (input >= 13312 && input <= 19903)
            {
                return Color.FromArgb(230, 231, 182);
            }
            else if (input >= 19904 && input <= 19967)
            {
                return Color.FromArgb(230, 231, 3);
            }
            else if (input >= 19968 && input <= 40959)
            {
                return Color.FromArgb(102,30, 2);
            }
            else if (input >= 40960 && input <= 42127)
            {
                return Color.FromArgb(110,178, 217);
            }
            else if (input >= 42128 && input <= 42191)
            {
               return Color.FromArgb(252, 9, 105);
            }
            else if (input >= 44032 && input <= 55215)
            {
               return Color.FromArgb(255, 113, 0);
            }
            else if (input >= 55296 && input <= 56191)
            {
              return Color.FromArgb(255, 113, 181);
            }
            else if (input >= 56192 && input <= 56319)
            {
                return Color.FromArgb(168, 113, 181);
            }
            else if (input >= 56320 && input <= 57343)
            {
                return Color.FromArgb(107, 113, 181);
            }
            else if (input >= 57344 && input <= 63743)
            {
                return Color.FromArgb(107, 203, 181);
            }
            else if (input >= 63744 && input <= 64255)
            {
                return Color.FromArgb(68, 1, 0);
            }
            else if (input >= 64256 && input <= 64335)
            {
                return Color.FromArgb(42, 144, 0);
            }
            else if (input >= 64336 && input <= 65023)
            {
                return Color.FromArgb(238, 144, 0);
            }
            else if (input >= 65024 && input <= 65039)
            {
                return Color.FromArgb(238, 144, 192);
            }
            else if (input >= 62240 && input <= 65071)
            {
                return Color.FromArgb(238, 200, 192);
            }
            else if (input >= 65072 && input <= 65103)
            {
                return Color.FromArgb(3, 249, 238);
            }
            else if (input >= 65104 && input <= 65135)
            {
                return Color.FromArgb(92, 31, 112);
            }
            else if (input >= 65136 && input <= 65279)
            {
                return Color.FromArgb(5, 191, 187);
            }
            else if (input >= 65280 && input <= 65519)
            {
                return Color.FromArgb(183, 191, 187);
            }
            else if (input >= 65520 && input <= 65535)
            {
                return Color.FromArgb(90, 94, 102);
            }
            else if (input >= 65536 && input <= 65663)
            {
                return Color.FromArgb(90, 253, 102);
            }
            else if (input >= 65664 && input <= 65791)
            {
                return Color.FromArgb(90, 253, 5);
            }
            else if (input >= 65792 && input <= 65855)
            {
                return Color.FromArgb(90, 144, 5);
            }
            else if (input >= 66304 && input <= 66351)
            {
               return Color.FromArgb(254, 144, 114);
            }
            else if (input >= 66352 && input <= 66383)
            {
                return Color.FromArgb(254, 255, 114);
            }
            else if (input >= 66432 && input <= 66463)
            {
               return Color.FromArgb(28, 49, 252);
            }
            else if (input >= 66560 && input <= 66639)
            {
                return Color.FromArgb(93, 6, 40);
            }
            else if (input >= 66640 && input <= 66687)
            {
               return Color.FromArgb(93, 0, 203);
            }
            else if (input >= 66688 && input <= 66735)
            {
               return Color.FromArgb(254, 206, 172);
            }
            else if (input >= 67584 && input <= 67647)
            {
              return  Color.FromArgb(254, 95, 172);
            }
            else if (input >= 118784 && input <= 119039)
            {
              return  Color.FromArgb(0, 172, 172);
            }
            else if (input >= 119040 && input <= 119295)
            {
              return   Color.FromArgb(125, 172, 172);
            }
            else if (input >= 119552 && input <= 119647)
            {
              return  Color.FromArgb(125, 172, 105);
            }
            else if (input >= 119808 && input <= 120831)
            {
               return Color.FromArgb(125, 9, 105);
            }
            else if (input >= 131072 && input <= 173791)
            {
                return Color.Thistle;
            }
            else if (input >= 194560 && input <= 195103)
            {
                return Color.Tomato;
            }
            else if (input >= 917504 && input <= 917631)
            {
                return Color.Yellow;
            }

            return Color.AliceBlue;
        }

        //this function takes a character number value and returns an index
        internal static int charValuetoIndex (int input)
        {
            if (input < 32)
            {
                return 0;
            }
            else if (input >= 32 && input <= 127)
            {
                return 1;
            }
            else if (input >= 160 && input <= 255)
            {
                return 2;
            }
            else if (input >= 256 && input <= 383)
            {
                return 3;
            }
            else if (input >= 384 && input <= 591)
            {
                return 4;
            }
            else if (input >= 592 && input <= 687)
            {
                return 5;
            }
            else if (input >= 688 && input <= 767)
            {
                return 6;
            }
            else if (input >= 768 && input <= 879)
            {
                return 7;
            }
            else if (input >= 880 && input <= 1023)
            {
                return 8;
            }
            else if (input >= 1024 && input <= 1279)
            {
                return 9;
            }
            else if (input >= 1280 && input <= 1327)
            {
                return 10;
            }
            else if (input >= 1328 && input <= 1423)
            {
                return 11;
            }
            else if (input >= 1424 && input <= 1535)
            {
                return 12;
            }
            else if (input >= 1536 && input <= 1791)
            {
                return 13;
            }
            else if (input >= 1792 && input <= 1871)
            {
                return 14;
            }
            else if (input >= 1920 && input <= 1983)
            {
                return 15;
            }
            else if (input >= 2304 && input <= 2431)
            {
                return 16;
            }
            else if (input >= 2432 && input <= 2559)
            {
                return 17;
            }
            else if (input >= 2560 && input <= 2687)
            {
                return 18;
            }
            else if (input >= 2688 && input <= 2815)
            {
                return 19;
            }
            else if (input >= 2816 && input <= 2943)
            {
                return 20;
            }
            else if (input >= 2944 && input <= 3071)
            {
                return 21;
            }
            else if (input >= 3072 && input <= 3199)
            {
                return 22;
            }
            else if (input >= 3200 && input <= 3327)
            {
                return 23;
            }
            else if (input >= 3328 && input <= 3455)
            {
                return 24;
            }
            else if (input >= 3456 && input <= 3583)
            {
                return 25;
            }
            else if (input >= 3584 && input <= 3711)
            {
                return 26;
            }
            else if (input >= 3712 && input <= 3839)
            {
                return 27;
            }
            else if (input >= 3840 && input <= 4095)
            {
                return 28;
            }
            else if (input >= 4096 && input <= 4255)
            {
                return 29;
            }
            else if (input >= 4256 && input <= 4351)
            {
                return 30;
            }
            else if (input >= 4352 && input <= 4607)
            {
                return 31;
            }
            else if (input >= 4608 && input <= 4991)
            {
                return 32;
            }
            else if (input >= 5024 && input <= 5119)
            {
                return 33;
            }
            else if (input >= 5120 && input <= 5759)
            {
                return 34;
            }
            else if (input >= 5760 && input <= 5791)
            {
                return 35;
            }
            else if (input >= 5792 && input <= 5887)
            {
                return 36;
            }
            else if (input >= 5888 && input <= 5919)
            {
                return 37;
            }
            else if (input >= 5920 && input <= 5951)
            {
                return 38;
            }
            else if (input >= 5952 && input <= 5983)
            {
                return 39;
            }
            else if (input >= 5984 && input <= 6015)
            {
                return 40;
            }
            else if (input >= 6016 && input <= 6143)
            {
                return 41;
            }
            else if (input >= 6144 && input <= 6319)
            {
                return 42;
            }
            else if (input >= 6400 && input <= 6479)
            {
                return 43;
            }
            else if (input >= 6480 && input <= 6527)
            {
                return 44;
            }
            else if (input >= 6624 && input <= 6655)
            {
                return 45;
            }
            else if (input >= 7424 && input <= 7551)
            {
                return 46;
            }
            else if (input >= 7680 && input <= 7935)
            {
                return 47;
            }
            else if (input >= 7936 && input <= 8191)
            {
                return 48;
            }
            else if (input >= 8192 && input <= 8303)
            {
                return 49;
            }
            else if (input >= 8304 && input <= 8351)
            {
                return 50;
            }
            else if (input >= 8352 && input <= 8399)
            {
                return 51;
            }
            else if (input >= 8400 && input <= 8447)
            {
                return 52;
            }
            else if (input >= 8448 && input <= 8527)
            {
                return 53;
            }
            else if (input >= 8528 && input <= 8591)
            {
                return 54;
            }
            else if (input >= 8592 && input <= 8703)
            {
                return 55;
            }
            else if (input >= 8704 && input <= 8959)
            {
                return 56;
            }
            else if (input >= 8960 && input <= 9215)
            {
                return 57;
            }
            else if (input >= 9216 && input <= 9279)
            {
                return 58;
            }
            else if (input >= 9280 && input <= 9311)
            {
                return 59;
            }
            else if (input >= 9312 && input <= 9471)
            {
                return 60;
            }
            else if (input >= 9472 && input <= 9599)
            {
                return 61;
            }
            else if (input >= 9600 && input <= 9631)
            {
                return 62;
            }
            else if (input >= 9632 && input <= 9727)
            {
                return 63;
            }
            else if (input >= 9728 && input <= 9983)
            {
                return 64;
            }
            else if (input >= 9984 && input <= 10175)
            {
                return 65;
            }
            else if (input >= 10176 && input <= 10223)
            {
                return 66;
            }
            else if (input >= 10224 && input <= 10239)
            {
                return 67;
            }
            else if (input >= 10240 && input <= 10495)
            {
                return 68;
            }
            else if (input >= 10496 && input <= 10623)
            {
                return 69;
            }
            else if (input >= 10624 && input <= 10751)
            {
                return 70;
            }
            else if (input >= 10752 && input <= 11007)
            {
                return 71;
            }
            else if (input >= 11008 && input <= 11263)
            {
                return 72;
            }
            else if (input >= 11904 && input <= 12031)
            {
                return 73;
            }
            else if (input >= 12032 && input <= 12255)
            {
                return 74;
            }
            else if (input >= 12272 && input <= 12287)
            {
                return 75;
            }
            else if (input >= 12288 && input <= 12351)
            {
                return 76;
            }
            else if (input >= 12352 && input <= 12447)
            {
                return 77;
            }
            else if (input >= 12448 && input <= 12543)
            {
                return 78;
            }
            else if (input >= 12544 && input <= 12591)
            {
                return 79;
            }
            else if (input >= 12592 && input <= 12687)
            {
                return 80;
            }
            else if (input >= 12688 && input <= 12703)
            {
                return 81;
            }
            else if (input >= 12704 && input <= 12735)
            {
                return 82;
            }
            else if (input >= 12784 && input <= 12799)
            {
                return 83;
            }
            else if (input >= 12800 && input <= 13055)
            {
                return 84;
            }
            else if (input >= 13056 && input <= 13311)
            {
                return 85;
            }
            else if (input >= 13312 && input <= 19903)
            {
                return 86;
            }
            else if (input >= 19904 && input <= 19967)
            {
                return 87;
            }
            else if (input >= 19968 && input <= 40959)
            {
                return 88;
            }
            else if (input >= 40960 && input <= 42127)
            {
                return 89;
            }
            else if (input >= 42128 && input <= 42191)
            {
                return 90;
            }
            else if (input >= 44032 && input <= 55215)
            {
                return 91;
            }
            else if (input >= 55296 && input <= 56191)
            {
                return 92;
            }
            else if (input >= 56192 && input <= 56319)
            {
                return 93;
            }
            else if (input >= 56320 && input <= 57343)
            {
                return 94;
            }
            else if (input >= 57344 && input <= 63743)
            {
                return 95;
            }
            else if (input >= 63744 && input <= 64255)
            {
                return 96;
            }
            else if (input >= 64256 && input <= 64335)
            {
                return 97;
            }
            else if (input >= 64336 && input <= 65023)
            {
                return 98;
            }
            else if (input >= 65024 && input <= 65039)
            {
                return 99;
            }
            else if (input >= 62240 && input <= 65071)
            {
                return 100;
            }
            else if (input >= 65072 && input <= 65103)
            {
                return 101;
            }
            else if (input >= 65104 && input <= 65135)
            {
                return 102;
            }
            else if (input >= 65136 && input <= 65279)
            {
                return 103;
            }
            else if (input >= 65280 && input <= 65519)
            {
                return 104;
            }
            else if (input >= 65520 && input <= 65535)
            {
                return 105;
            }
            else if (input >= 65536 && input <= 65663)
            {
                return 106;
            }
            else if (input >= 65664 && input <= 65791)
            {
                return 107;
            }
            else if (input >= 65792 && input <= 65855)
            {
                return 108;
            }
            else if (input >= 66304 && input <= 66351)
            {
                return 109;
            }
            else if (input >= 66352 && input <= 66383)
            {
                return 110;
            }
            else if (input >= 66432 && input <= 66463)
            {
                return 111;
            }
            else if (input >= 66560 && input <= 66639)
            {
                return 112;
            }
            else if (input >= 66640 && input <= 66687)
            {
                return 113;
            }
            else if (input >= 66688 && input <= 66735)
            {
                return 114;
            }
            else if (input >= 67584 && input <= 67647)
            {
                return 115;
            }
            else if (input >= 118784 && input <= 119039)
            {
                return 116;
            }
            else if (input >= 119040 && input <= 119295)
            {
                return 117;
            }
            else if (input >= 119552 && input <= 119647)
            {
                return 118;
            }
            else if (input >= 119808 && input <= 120831)
            {
                return 119;
            }
            else if (input >= 131072 && input <= 173791)
            {
                return 120;
            }
            else if (input >= 194560 && input <= 195103)
            {
                return 121;
            }
            else if (input >= 917504 && input <= 917631)
            {
                return 122;
            }


            return 999;
        }

        //index to character type
        //this is for frequencies
        public static String indexToCharacterType(int input)
        {
            if (input == 0)
            {
                return "invalid";
            }
            else if (input == 1)
            {
                return "Basic Latin";
            }
            else if (input == 2)
            {
                return "Latin-1 Suppliment";
            }
            else if (input == 3)
            {
                return "Latin Extended-A";
            }
            else if (input == 4)
            {
                return "Latin Extended-B";
            }
            else if (input == 5)
            {
                return "IPA Extensions";
            }
            else if (input == 6)
            {
                return "Spacing Modifier Letters";
            }
            else if (input == 7)
            {
                return "Combining Diacritical Marks";
            }
            else if (input == 8)
            {
                return "Greek and Coptic";
            }
            else if (input == 9)
            {
                return "Cyrillic";
            }
            else if (input == 10)
            {
                return "Cyrillic Supplementary";
            }
            else if (input == 11)
            {
                return "Armenian";
            }
            else if (input == 12)
            {
                return "Hebrew";
            }
            else if (input == 13)
            {
                return "Arabic";
            }
            else if (input == 14)
            {
                return "Syriac";
            }
            else if (input == 15)
            {
                return "Thaana";
            }
            else if (input == 16)
            {
                return "Devanagari";
            }
            else if (input == 17)
            {
                return "Bengali";
            }
            else if (input == 18)
            {
                return "Gurmukhi";
            }
            else if (input == 19)
            {
                return "Gujarati";
            }
            else if (input == 20)
            {
                return "Oriya";
            }
            else if (input == 21)
            {
                return "Tamil";
            }
            else if (input == 22)
            {
                return "Telugu";
            }
            else if (input == 23)
            {
                return "Kannada";
            }
            else if (input == 24)
            {
                return "Malayalam";
            }
            else if (input == 25)
            {
                return "Sinhala";
            }
            else if (input == 26)
            {
                return "Thai";
            }
            else if (input == 27)
            {
                return "Lao";
            }
            else if (input == 28)
            {
                return "Tibetan";
            }
            else if (input == 29)
            {
                return "Myanmar";
            }
            else if (input == 30)
            {
                return "Georgian";
            }
            else if (input == 31)
            {
                return "Hangul Jamo";
            }
            else if (input == 32)
            {
                return "Ethiopic";
            }
            else if (input == 33)
            {
                return "Cherokee";
            }
            else if (input == 34)
            {
                return "Unified Canadian Aboriginal Syllabics";
            }
            else if (input == 35)
            {
                return "Ogham";
            }
            else if (input == 36)
            {
                return "Runic";
            }
            else if (input == 37)
            {
                return "Tagalog";
            }
            else if (input == 38)
            {
                return "Hanunoo";
            }
            else if (input == 39)
            {
                return "Buhid";
            }
            else if (input == 40)
            {
                return "Tagbanwa";
            }
            else if (input == 41)
            {
                return "Khmer";
            }
            else if (input == 42)
            {
                return "Mongolian";
            }
            else if (input == 43)
            {
                return "Limbu";
            }
            else if (input == 44)
            {
                return "Tai Le";
            }
            else if (input == 45)
            {
                return "Khmer Symbols";
            }
            else if (input == 46)
            {
                return "Phnonetic Extensions";
            }
            else if (input == 47)
            {
                return "Latin Extended Additional";
            }
            else if (input == 48)
            {
                return "Greek Extended";
            }
            else if (input == 49)
            {
                return "General Punctuation";
            }
            else if (input == 50)
            {
                return "Superscripts and Substripts";
            }
            else if (input == 51)
            {
                return "Currency Symbols";
            }
            else if (input == 52)
            {
                return "Combining Diacritical Marks for Symbols";
            }
            else if (input == 53)
            {
                return "Letterlike Symbols";
            }
            else if (input == 54)
            {
                return "Number Forms";
            }
            else if (input == 55)
            {
                return "Arrows";
            }
            else if (input == 56)
            {
                return "Mathematical Operators";
            }
            else if (input == 57)
            {
                return "Miscellaneous Technical";
            }
            else if (input == 58)
            {
                return "Control Pictures";
            }
            else if (input == 59)
            {
                return "Optical Character Recognition";
            }
            else if (input == 60)
            {
                return "Enclosed Alphanumerics";
            }
            else if (input == 61)
            {
                return "Box Drawing";
            }
            else if (input == 62)
            {
                return "Block Elements";
            }
            else if (input == 63)
            {
                return "Geometric Shapes";
            }
            else if (input == 64)
            {
                return "Miscellaneous Symbols";
            }
            else if (input == 65)
            {
                return "Dingbats";
            }
            else if (input == 66)
            {
                return "Miscellaneous Mathematical Symbols-A";
            }
            else if (input == 67)
            {
                return "Supplemental Arrows-A";
            }
            else if (input == 68)
            {
                return "Braille Patterns";
            }
            else if (input == 69)
            {
                return "Supplemental Arrows-B";
            }
            else if (input == 70)
            {
                return "Miscellaneous Mathematical Symbols-B";
            }
            else if (input == 71)
            {
                return "Supplemental Mathematical Operators";
            }
            else if (input == 72)
            {
                return "Miscellaneous Symbols and Arrows";
            }
            else if (input == 73)
            {
                return "CJK Radicals Supplement";
            }
            else if (input == 74)
            {
                return "Kangxi Radicals";
            }
            else if (input == 75)
            {
                return "Ideographic Description Characters";
            }
            else if (input == 76)
            {
                return "CJK Symbols and Punctuation";
            }
            else if (input == 77)
            {
                return "Hiragana";
            }
            else if (input == 78)
            {
                return "Katakana";
            }
            else if (input == 79)
            {
                return "Bopomofo";
            }
            else if (input == 80)
            {
                return "Hangul Compatibility Jamo";
            }
            else if (input == 81)
            {
                return "Kanbun";
            }
            else if (input == 82)
            {
                return "Bopomofo Extended";
            }
            else if (input == 83)
            {
                return "Katakana Phonetic Extensions";
            }
            else if (input == 84)
            {
                return "Enclosed CJK Letters and Months";
            }
            else if (input == 85)
            {
                return "CJK Compatibility";
            }
            else if (input == 86)
            {
                return "CJK Unified Ideographs Extension A";
            }
            else if (input == 87)
            {
                return "Yijing Hexagram Symbols";
            }
            else if (input == 88)
            {
                return "CJK Unified Ideographs";
            }
            else if (input == 89)
            {
                return "Yi Syllables";
            }
            else if (input == 90)
            {
                return "Yi Radicals";
            }
            else if (input == 91)
            {
                return "Hangul Syllables";
            }
            else if (input == 92)
            {
                return "High Surrogates";
            }
            else if (input == 93)
            {
                return "High Private Use Surrogates";
            }
            else if (input == 94)
            {
                return "Low Surrogates";
            }
            else if (input == 95)
            {
                return "Private Use Area";
            }
            else if (input == 96)
            {
                return "CJK Compatibility Ideographs";
            }
            else if (input == 97)
            {
                return "Alphabetic Presentation Forms";
            }
            else if (input == 98)
            {
                return "Arabic Presentation Forms-A";
            }
            else if (input == 99)
            {
                return "Variation Selectors";
            }
            else if (input == 100)
            {
                return "Combining Half Marks";
            }
            else if (input == 101)
            {
                return "CJK Compatibility Forms";
            }
            else if (input == 102)
            {
                return "Small Form Variants";
            }
            else if (input == 103)
            {
                return "Arabic Presentation Forms-B";
            }
            else if (input == 104)
            {
                return "Halfwidth and Fullwidth Forms";
            }
            else if (input == 105)
            {
                return "Specials";
            }
            else if (input == 106)
            {
                return "Linear B Syllabary";
            }
            else if (input == 107)
            {
                return "Linear B Ideograms";
            }
            else if (input == 108)
            {
                return "Aegean Numbers";
            }
            else if (input == 109)
            {
                return "Old Italic";
            }
            else if (input == 110)
            {
                return "Gothic";
            }
            else if (input == 111)
            {
                return "Ugaritic";
            }
            else if (input == 112)
            {
                return "Deseret";
            }
            else if (input == 113)
            {
                return "Shavian";
            }
            else if (input == 114)
            {
                return "Osmanya";
            }
            else if (input == 115)
            {
                return "Cypriot Syllabary";
            }
            else if (input == 116)
            {
                return "Byzantine Musical Symbols";
            }
            else if (input == 117)
            {
                return "Musical Symbols";
            }
            else if (input == 118)
            {
                return "Tai Xuan Jing Symbols";
            }
            else if (input == 119)
            {
                return "Mathematical Alphanumeric Symbols";
            }
            else if (input == 120)
            {
                return "CJK Unified Ideographs Extension B";
            }
            else if (input == 121)
            {
                return "CJK Compatibility Ideographs Supplement";
            }
            else if (input == 122)
            {
                return "Tags";
            }

            return "Unknown Character";

        }





    }
}
