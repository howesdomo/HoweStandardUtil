using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace System
{
    public static class StringExtension
    {
        #region 空值判断

        public static bool IsNullOrEmpty(this string s)
        {
            return string.IsNullOrEmpty(s);
        }

        public static bool IsNullOrWhiteSpace(this string s)
        {
            return string.IsNullOrWhiteSpace(s);
        }

        #endregion 空值判断

        #region Trim

        /// <summary>
        /// 去掉换行符号后 Trim
        /// </summary>
        /// <param name="content"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static string TrimAdv(this string content, params object[] args)
        {
            if (content == null)
            {
                return null;
            }

            return content.Replace("\r", "").Replace("\n", "").Trim();
        }

        #endregion

        #region String.Format ( 格式化 )

        public static string FormatWith(this string format, params object[] args)
        {
            return string.Format(format, args);
        }

        public static string Format(IFormatProvider provider, string format, params object[] args)
        {
            return string.Format(provider, format, args);
        }

        // *** 尽管第1个的Format功能强大到可以取代中间的三个，但它的效率不高。
        // 以下3个重载是出于性能的考虑而增加的
        public static string Format(this string format, object arg0)
        {
            return string.Format(format, arg0);
        }

        public static string Format(this string format, object arg0, object arg1)
        {
            return string.Format(format, arg0, arg1);
        }

        public static string Format(this string format, object arg0, object arg1, object arg2)
        {
            return string.Format(format, arg0, arg1, arg2);
        }

        #endregion

        #region Regex 正则表达式

        /// <summary>
        /// 判断是否符合正则表达式
        /// </summary>
        /// <param name="s"></param>
        /// <param name="pattern"></param>
        /// <returns></returns>
        public static bool IsMatch(this string s, string pattern)
        {
            if (s == null) return false;
            else return Regex.IsMatch(s, pattern);
        }

        /// <summary>
        /// 获取符合正则表达式的值
        /// </summary>
        /// <param name="s"></param>
        /// <param name="pattern"></param>
        /// <returns></returns>
        public static string Match(this string s, string pattern)
        {
            if (s == null) return "";
            return Regex.Match(s, pattern).Value;
        }

        /// <summary>
        /// 使用正则表达式进行替换字符串
        /// </summary>
        /// <param name="s"></param>
        /// <param name="pattern"></param>
        /// <param name="replaceValue"></param>
        /// <returns></returns>
        public static string ReplaceWithRegexPattern(this string s, string pattern, string replaceValue)
        {
            if (s == null) return "";
            return Regex.Replace(s, pattern, replaceValue);
        }

        #endregion

        #region 常用类型转换

        public static bool IsBoolean(this string s)
        {
            bool i;
            return bool.TryParse(s, out i);
        }

        public static bool ToBoolean(this string s)
        {
            return bool.Parse(s);
        }

        public static bool IsInt(this string s)
        {
            int i;
            return int.TryParse(s, out i);
        }

        public static int ToInt(this string s)
        {
            return int.Parse(s);
        }

        public static bool IsLong(this string s)
        {
            long i;
            return long.TryParse(s, out i);
        }

        public static long ToLong(this string s)
        {
            return long.Parse(s);
        }

        public static bool IsDouble(this string s)
        {
            double i;
            return double.TryParse(s, out i);
        }

        public static double ToDouble(this string s)
        {
            return double.Parse(s);
        }

        public static bool IsDecimal(this string s)
        {
            decimal i;
            return decimal.TryParse(s, out i);
        }

        public static decimal ToDecimal(this string s)
        {
            return decimal.Parse(s);
        }

        public static bool IsDateTime(this string s)
        {
            DateTime i;
            return DateTime.TryParse(s, out i);
        }

        public static DateTime ToDateTime(this string s)
        {
            return DateTime.Parse(s);
        }

        #endregion

        #region 字符串转化 美化

        public static string ToCamel(this string s)
        {
            // 尚可进一步优化 根据英文单词 进行驼峰式命名
            if (s.IsNullOrEmpty()) return s;
            return s[0].ToString().ToLower() + s.Substring(1);
        }

        public static string ToPascal(this string s)
        {
            // 尚可进一步优化 根据英文单词 进行Pascal命名
            if (s.IsNullOrEmpty()) return s;
            return s[0].ToString().ToUpper() + s.Substring(1);
        }

        /// <summary>
        /// 显示特殊字符，可以用于检测 SerialPort 接收回来的数据
        /// <para>例如常用的符号<para>
        /// <para>x02 显示为[STX],<para>
        /// <para>/r 显示为 [CR], <para>
        /// <para>/n 显示为 [LF],<para>
        /// <para>位于最后的空格显示为 [Space]<para>
        /// </summary>
        /// <param name="content">转换内容</param>
        /// <returns></returns>
        public static string StringShowSpecialSymbol(this string content)
        {
            StringBuilder sb = new StringBuilder(capacity: (content.Length * 2));
            for (int index = 0; index < content.Length; index++)
            {
                char c = content[index];
                int value = (int)c;

                switch (value)
                {
                    case 00: sb.Append("[NUL]"); break;
                    case 01: sb.Append("[SOH]"); break;
                    case 02: sb.Append("[STX]"); break;
                    case 03: sb.Append("[ETX]"); break;
                    case 04: sb.Append("[EOT]"); break;
                    case 05: sb.Append("[0x05]"); break;
                    case 06: sb.Append("[0x06]"); break;
                    case 07: sb.Append("[0x07]"); break;
                    case 08: sb.Append("[0x08]"); break;
                    case 09: sb.Append("[TAB]"); break;
                    case 10: sb.Append("[LF]"); break;
                    case 11: sb.Append("[0x11]"); break;
                    case 12: sb.Append("[0x12]"); break;
                    case 13: sb.Append("[CR]"); break;
                    case 14: sb.Append("[0x14]"); break;
                    case 15: sb.Append("[0x15]"); break;
                    case 16: sb.Append("[0x16]"); break;
                    case 17: sb.Append("[0x17]"); break;
                    case 18: sb.Append("[0x18]"); break;
                    case 19: sb.Append("[0x19]"); break;
                    case 20: sb.Append("[0x20]"); break;
                    case 21: sb.Append("[0x21]"); break;
                    case 22: sb.Append("[0x22]"); break;
                    case 23: sb.Append("[0x23]"); break;
                    case 24: sb.Append("[0x24]"); break;
                    case 25: sb.Append("[0x25]"); break;
                    case 26: sb.Append("[0x26]"); break;
                    case 27: sb.Append("[0x27]"); break;
                    case 28: sb.Append("[0x28]"); break;
                    case 29: sb.Append("[0x29]"); break;
                    case 30: sb.Append("[0x30]"); break;
                    case 31: sb.Append("[0x31]"); break;
                    case 32:
                        {
                            if (content.Length == (index + 1)) // 若位于最后, 则显式显示
                            {
                                sb.Append("[Space]");

                            }
                            else // 位于其他地方, 则显示空格
                            {
                                sb.Append(c);
                            }
                        }
                        break;
                    //			case 33: sb.Append("[0x33]"); break;
                    //			case 34: sb.Append("[0x34]"); break;			
                    //			case 35: sb.Append("[0x35]"); break;
                    //			case 36: sb.Append("[0x36]"); break;
                    //			case 37: sb.Append("[0x37]"); break;
                    //			case 38: sb.Append("[0x38]"); break;
                    //			case 39: sb.Append("[0x39]"); break;
                    //			case 40: sb.Append("[0x40]"); break;
                    //			case 41: sb.Append("[0x41]"); break;
                    //			case 42: sb.Append("[0x42]"); break;
                    //			case 43: sb.Append("[0x43]"); break;
                    //			case 44: sb.Append("[0x44]"); break;
                    //			case 45: sb.Append("[0x45]"); break;
                    //			case 46: sb.Append("[0x46]"); break;
                    //			case 47: sb.Append("[0x47]"); break;
                    //			case 48: sb.Append("[0x48]"); break;
                    //			case 49: sb.Append("[0x49]"); break;
                    //			case 50: sb.Append("[0x50]"); break;
                    //			case 51: sb.Append("[0x51]"); break;
                    //			case 52: sb.Append("[0x52]"); break;
                    //			case 53: sb.Append("[0x53]"); break;
                    //			case 54: sb.Append("[0x54]"); break;
                    //			case 55: sb.Append("[0x55]"); break;
                    //			case 56: sb.Append("[0x56]"); break;
                    //			case 57: sb.Append("[0x57]"); break;
                    //			case 58: sb.Append("[0x58]"); break;
                    //			case 59: sb.Append("[0x59]"); break;
                    //			case 60: sb.Append("[0x60]"); break;
                    //			case 61: sb.Append("[0x61]"); break;
                    //			case 62: sb.Append("[0x62]"); break;
                    //			case 63: sb.Append("[0x63]"); break;
                    //			case 64: sb.Append("[0x64]"); break;
                    //			case 65: sb.Append("[0x65]"); break;
                    //			case 66: sb.Append("[0x66]"); break;
                    //			case 67: sb.Append("[0x67]"); break;
                    //			case 68: sb.Append("[0x68]"); break;
                    //			case 69: sb.Append("[0x69]"); break;
                    //			case 70: sb.Append("[0x70]"); break;
                    //			case 71: sb.Append("[0x71]"); break;
                    //			case 72: sb.Append("[0x72]"); break;
                    //			case 73: sb.Append("[0x73]"); break;
                    //			case 74: sb.Append("[0x74]"); break;
                    //			case 75: sb.Append("[0x75]"); break;
                    //			case 76: sb.Append("[0x76]"); break;
                    //			case 77: sb.Append("[0x77]"); break;
                    //			case 78: sb.Append("[0x78]"); break;
                    //			case 79: sb.Append("[0x79]"); break;
                    //			case 80: sb.Append("[0x80]"); break;
                    //			case 81: sb.Append("[0x81]"); break;
                    //			case 82: sb.Append("[0x82]"); break;
                    //			case 83: sb.Append("[0x83]"); break;
                    //			case 84: sb.Append("[0x84]"); break;
                    //			case 85: sb.Append("[0x85]"); break;
                    //			case 86: sb.Append("[0x86]"); break;
                    //			case 87: sb.Append("[0x87]"); break;
                    //			case 88: sb.Append("[0x88]"); break;
                    //			case 89: sb.Append("[0x89]"); break;
                    //			case 90: sb.Append("[0x90]"); break;
                    //			case 91: sb.Append("[0x91]"); break;
                    //			case 92: sb.Append("[0x92]"); break;
                    //			case 93: sb.Append("[0x93]"); break;
                    //			case 94: sb.Append("[0x94]"); break;
                    //			case 95: sb.Append("[0x95]"); break;
                    //			case 96: sb.Append("[0x96]"); break;
                    //			case 97: sb.Append("[0x97]"); break;
                    //			case 98: sb.Append("[0x98]"); break;
                    //			case 99: sb.Append("[0x99]"); break;
                    //			case 100: sb.Append("[0x100]"); break;
                    //			case 101: sb.Append("[0x101]"); break;
                    //			case 102: sb.Append("[0x102]"); break;
                    //			case 103: sb.Append("[0x103]"); break;
                    //			case 104: sb.Append("[0x104]"); break;
                    //			case 105: sb.Append("[0x105]"); break;
                    //			case 106: sb.Append("[0x106]"); break;
                    //			case 107: sb.Append("[0x107]"); break;
                    //			case 108: sb.Append("[0x108]"); break;
                    //			case 109: sb.Append("[0x109]"); break;
                    //			case 110: sb.Append("[0x110]"); break;
                    //			case 111: sb.Append("[0x111]"); break;
                    //			case 112: sb.Append("[0x112]"); break;
                    //			case 113: sb.Append("[0x113]"); break;
                    //			case 114: sb.Append("[0x114]"); break;
                    //			case 115: sb.Append("[0x115]"); break;
                    //			case 116: sb.Append("[0x116]"); break;
                    //			case 117: sb.Append("[0x117]"); break;
                    //			case 118: sb.Append("[0x118]"); break;
                    //			case 119: sb.Append("[0x119]"); break;
                    //			case 120: sb.Append("[0x120]"); break;
                    //			case 121: sb.Append("[0x121]"); break;
                    //			case 122: sb.Append("[0x122]"); break;
                    //			case 123: sb.Append("[0x123]"); break;
                    //			case 124: sb.Append("[0x124]"); break;
                    //			case 125: sb.Append("[0x125]"); break;
                    //			case 126: sb.Append("[0x126]"); break;
                    case 127: sb.Append("[0x127]"); break;
                    //// 大于 127 的变成了问号			
                    //			case 128: sb.Append("[0x128]"); break;
                    //			case 129: sb.Append("[0x129]"); break;
                    //			case 130: sb.Append("[0x130]"); break;
                    //			case 131: sb.Append("[0x131]"); break;
                    //			case 132: sb.Append("[0x132]"); break;
                    //			case 133: sb.Append("[0x133]"); break;
                    //			case 134: sb.Append("[0x134]"); break;
                    //			case 135: sb.Append("[0x135]"); break;
                    //			case 136: sb.Append("[0x136]"); break;
                    //			case 137: sb.Append("[0x137]"); break;
                    //			case 138: sb.Append("[0x138]"); break;
                    //			case 139: sb.Append("[0x139]"); break;
                    //			case 140: sb.Append("[0x140]"); break;
                    //			case 141: sb.Append("[0x141]"); break;
                    //			case 142: sb.Append("[0x142]"); break;
                    //			case 143: sb.Append("[0x143]"); break;
                    //			case 144: sb.Append("[0x144]"); break;
                    //			case 145: sb.Append("[0x145]"); break;
                    //			case 146: sb.Append("[0x146]"); break;
                    //			case 147: sb.Append("[0x147]"); break;
                    //			case 148: sb.Append("[0x148]"); break;
                    //			case 149: sb.Append("[0x149]"); break;
                    //			case 150: sb.Append("[0x150]"); break;
                    //			case 151: sb.Append("[0x151]"); break;
                    //			case 152: sb.Append("[0x152]"); break;
                    //			case 153: sb.Append("[0x153]"); break;
                    //			case 154: sb.Append("[0x154]"); break;
                    //			case 155: sb.Append("[0x155]"); break;
                    //			case 156: sb.Append("[0x156]"); break;
                    //			case 157: sb.Append("[0x157]"); break;
                    //			case 158: sb.Append("[0x158]"); break;
                    //			case 159: sb.Append("[0x159]"); break;
                    //			case 160: sb.Append("[0x160]"); break;
                    //			case 161: sb.Append("[0x161]"); break;
                    //			case 162: sb.Append("[0x162]"); break;
                    //			case 163: sb.Append("[0x163]"); break;
                    //			case 164: sb.Append("[0x164]"); break;
                    //			case 165: sb.Append("[0x165]"); break;
                    //			case 166: sb.Append("[0x166]"); break;
                    //			case 167: sb.Append("[0x167]"); break;
                    //			case 168: sb.Append("[0x168]"); break;
                    //			case 169: sb.Append("[0x169]"); break;
                    //			case 170: sb.Append("[0x170]"); break;
                    //			case 171: sb.Append("[0x171]"); break;
                    //			case 172: sb.Append("[0x172]"); break;
                    //			case 173: sb.Append("[0x173]"); break;
                    //			case 174: sb.Append("[0x174]"); break;
                    //			case 175: sb.Append("[0x175]"); break;
                    //			case 176: sb.Append("[0x176]"); break;
                    //			case 177: sb.Append("[0x177]"); break;
                    //			case 178: sb.Append("[0x178]"); break;
                    //			case 179: sb.Append("[0x179]"); break;
                    //			case 180: sb.Append("[0x180]"); break;
                    //			case 181: sb.Append("[0x181]"); break;
                    //			case 182: sb.Append("[0x182]"); break;
                    //			case 183: sb.Append("[0x183]"); break;
                    //			case 184: sb.Append("[0x184]"); break;
                    //			case 185: sb.Append("[0x185]"); break;
                    //			case 186: sb.Append("[0x186]"); break;
                    //			case 187: sb.Append("[0x187]"); break;
                    //			case 188: sb.Append("[0x188]"); break;
                    //			case 189: sb.Append("[0x189]"); break;
                    //			case 190: sb.Append("[0x190]"); break;
                    //			case 191: sb.Append("[0x191]"); break;
                    //			case 192: sb.Append("[0x192]"); break;
                    //			case 193: sb.Append("[0x193]"); break;
                    //			case 194: sb.Append("[0x194]"); break;
                    //			case 195: sb.Append("[0x195]"); break;
                    //			case 196: sb.Append("[0x196]"); break;
                    //			case 197: sb.Append("[0x197]"); break;
                    //			case 198: sb.Append("[0x198]"); break;
                    //			case 199: sb.Append("[0x199]"); break;
                    //			case 200: sb.Append("[0x200]"); break;
                    //			case 201: sb.Append("[0x201]"); break;
                    //			case 202: sb.Append("[0x202]"); break;
                    //			case 203: sb.Append("[0x203]"); break;
                    //			case 204: sb.Append("[0x204]"); break;
                    //			case 205: sb.Append("[0x205]"); break;
                    //			case 206: sb.Append("[0x206]"); break;
                    //			case 207: sb.Append("[0x207]"); break;
                    //			case 208: sb.Append("[0x208]"); break;
                    //			case 209: sb.Append("[0x209]"); break;
                    //			case 210: sb.Append("[0x210]"); break;
                    //			case 211: sb.Append("[0x211]"); break;
                    //			case 212: sb.Append("[0x212]"); break;
                    //			case 213: sb.Append("[0x213]"); break;
                    //			case 214: sb.Append("[0x214]"); break;
                    //			case 215: sb.Append("[0x215]"); break;
                    //			case 216: sb.Append("[0x216]"); break;
                    //			case 217: sb.Append("[0x217]"); break;
                    //			case 218: sb.Append("[0x218]"); break;
                    //			case 219: sb.Append("[0x219]"); break;
                    //			case 220: sb.Append("[0x220]"); break;
                    //			case 221: sb.Append("[0x221]"); break;
                    //			case 222: sb.Append("[0x222]"); break;
                    //			case 223: sb.Append("[0x223]"); break;
                    //			case 224: sb.Append("[0x224]"); break;
                    //			case 225: sb.Append("[0x225]"); break;
                    //			case 226: sb.Append("[0x226]"); break;
                    //			case 227: sb.Append("[0x227]"); break;
                    //			case 228: sb.Append("[0x228]"); break;
                    //			case 229: sb.Append("[0x229]"); break;
                    //			case 230: sb.Append("[0x230]"); break;
                    //			case 231: sb.Append("[0x231]"); break;
                    //			case 232: sb.Append("[0x232]"); break;
                    //			case 233: sb.Append("[0x233]"); break;
                    //			case 234: sb.Append("[0x234]"); break;
                    //			case 235: sb.Append("[0x235]"); break;
                    //			case 236: sb.Append("[0x236]"); break;
                    //			case 237: sb.Append("[0x237]"); break;
                    //			case 238: sb.Append("[0x238]"); break;
                    //			case 239: sb.Append("[0x239]"); break;
                    //			case 240: sb.Append("[0x240]"); break;
                    //			case 241: sb.Append("[0x241]"); break;
                    //			case 242: sb.Append("[0x242]"); break;
                    //			case 243: sb.Append("[0x243]"); break;
                    //			case 244: sb.Append("[0x244]"); break;
                    //			case 245: sb.Append("[0x245]"); break;
                    //			case 246: sb.Append("[0x246]"); break;
                    //			case 247: sb.Append("[0x247]"); break;
                    //			case 248: sb.Append("[0x248]"); break;
                    //			case 249: sb.Append("[0x249]"); break;
                    //			case 250: sb.Append("[0x250]"); break;
                    //			case 251: sb.Append("[0x251]"); break;
                    //			case 252: sb.Append("[0x252]"); break;
                    //			case 253: sb.Append("[0x253]"); break;
                    //			case 254: sb.Append("[0x254]"); break;
                    default:
                        sb.Append(c);
                        break;
                }
            }

            return sb.ToString();
        }

        #endregion

        #region GZip

        public static string GZip_Compress2String(this string toZipString)
        {
            string r = Util.GZipUtils.Compress2String(toZipString);
            return r;
        }

        public static string GZip_Decompress2String(this string zippedString)
        {
            string r = Util.GZipUtils.Decompress2String(zippedString);
            return r;
        }

        #endregion

        #region DES 加密 & 解密

        /// <summary>
        /// DES 加密
        /// </summary>
        /// <param name="toEncryptString"></param>
        /// <returns></returns>
        public static string DES_Encrypt(this string toEncryptString)
        {
            return Util.Cryptography.DESUtils.Encrypt(toEncryptString);
        }

        /// <summary>
        /// DES 解密
        /// </summary>
        /// <param name="textToEncrypt"></param>
        /// <returns></returns>
        public static string DES_Decrypt(this string toDecryptString)
        {
            return Util.Cryptography.DESUtils.Decrypt(toDecryptString);
        }

        #endregion

        #region RSA 加密 & 解密

        /// <summary>
        /// RSA 加密
        /// </summary>
        /// <param name="toEncryptString">加密的信息</param>
        /// <param name="publickey">公钥(可空)</param>
        /// <returns>Base64Str</returns>
        public static string RSA_Encrypt(this string toEncryptString, string publickey = "")
        {
            return Util.Cryptography.RSAUtils.Encrypt2Base64Str(toEncryptString, publickey);
        }


        /// <summary>
        /// RSA 解密
        /// </summary>
        /// <param name="toDecryptString">Base64Str</param>
        /// <param name="privateKey">私钥(可空)</param>
        /// <returns>解密信息</returns>
        public static string RSA_Decrypt(this string toDecryptString, string privateKey = "")
        {
            return Util.Cryptography.RSAUtils.Decrypt2String(toDecryptString, privateKey);
        }


        #endregion

        #region SHA1 加密

        /// <summary>
        /// SHA1 加密，返回大写字符串
        /// </summary>
        /// <param name="content">需要加密字符串</param>
        /// <param name="encode">指定加密编码</param>
        /// <returns>返回40位大写字符串</returns>
        public static string SHA1_Encrypt(this string toEncryptString, Text.Encoding encoding = null)
        {
            if (encoding == null)
            {
                encoding = Text.Encoding.UTF8;
            }
            return Util.Cryptography.SHA1Utils.Encrypt(toEncryptString, encoding);
        }

        #endregion
    }
}
