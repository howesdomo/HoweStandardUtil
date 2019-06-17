using System;
using System.Text;

namespace Util.Cryptography
{
    /// <summary>
    /// 数据加密标准（英语：Data Encryption Standard，缩写为 DES）是一种对称密钥加密块密码演算法，1976年被美国联邦政府的国家标准局确定为联邦资料处理标准（FIPS），
    /// 随后在国际上广泛流传开来。它基于使用56位密钥的对称算法。这个算法因为包含一些机密设计元素，相对短的密钥长度以及怀疑内含美国国家安全局（NSA）的后门而在开始时有争议，
    /// DES因此受到了强烈的学院派式的审查，并以此推动了现代的块密码及其密码分析的发展。
    /// DES现在已经不是一种安全的加密方法，主要因为它使用的56位密钥过短。1999年1月，distributed.net与电子前哨基金会合作，在22小时15分钟内即公开破解了一个DES密钥。
    /// 也有一些分析报告提出了该算法的理论上的弱点，虽然在实际中难以应用。为了提供实用所需的安全性，可以使用DES的衍生算法3DES来进行加密，虽然3DES也存在理论上的攻击方法。
    /// 在2001年，DES作为一个标准已经被高级加密标准（AES）所取代。另外，DES已经不再作为国家标准科技协会（前国家标准局）的一个标准。    /// 
    /// </summary>
    public class DESUtils
    {
        // http://www.cnblogs.com/Lawson/archive/2012/05/20/2510781.html
        //DES加密
        //DES是一种对称加密(Data Encryption Standard)算法，以前我写过一篇文章：.NET中加密解密相关知识，有过简单描述。

        //DES算法一般有两个关键点，第一个是加密算法，第二个是数据补位。



        //加密算法常见的有ECB模式和CBC模式：
        //ECB模式：电子密本方式，这是JAVA封装的DES算法的默认模式，就是将数据按照8个字节一段进行DES加密或解密得到一段8个字节的密文或者明文，最后一段不足8个字节，则补足8个字节（注意：这里就涉及到数据补位了）进行计算，之后按照顺序将计算所得的数据连在一起即可，各段数据之间互不影响。

        //CBC模式：密文分组链接方式，这是.NET封装的DES算法的默认模式，它比较麻烦，加密步骤如下：
        //1、首先将数据按照8个字节一组进行分组得到D1D2......Dn（若数据不是8的整数倍，就涉及到数据补位了）
        //2、第一组数据D1与向量I异或后的结果进行DES加密得到第一组密文C1（注意：这里有向量I的说法，ECB模式下没有使用向量I）
        //3、第二组数据D2与第一组的加密结果C1异或以后的结果进行DES加密，得到第二组密文C2
        //4、之后的数据以此类推，得到Cn
        //5、按顺序连为C1C2C3......Cn即为加密结果。


        //数据补位一般有NoPadding和PKCS7Padding(JAVA中是PKCS5Padding)填充方式，PKCS7Padding和PKCS5Padding实际只是协议不一样，根据相关资料说明：PKCS5Padding明确定义了加密块是8字节，PKCS7Padding加密快可以是1-255之间。但是封装的DES算法默认都是8字节，所以可以认为他们一样。数据补位实际是在数据不满8字节的倍数，才补充到8字节的倍数的填充过程。

        //NoPadding填充方式：算法本身不填充，比如.NET的padding提供了有None，Zeros方式，分别为不填充和填充0的方式。

        //PKCS7Padding（PKCS5Padding）填充方式：为.NET和JAVA的默认填充方式，对加密数据字节长度对8取余为r，如r大于0，则补8-r个字节，字节为8-r的值；如果r等于0，则补8个字节8。比如：
        //加密字符串为为AAA，则补位为AAA55555;加密字符串为BBBBBB，则补位为BBBBBB22；加密字符串为CCCCCCCC，则补位为CCCCCCCC88888888。

        //由于为ECB模式，因此IV这里设置什么值都是可以的，当为CBC模式下，则需要设置为其他值，比如：public static byte[] IV = { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08 }，才能正常加密解密。

        //总结
        //对于.NET和JAVA在使用DES对称加密时，需要大家指定一样的算法和填充模式，并且JAVA在写DES加解密算法时，还需要根据创建Cipher对象的不同，正确使用IV向量。在不同系统需要互相数据时，必须要明确的是加密算法，Key和算法模式，再根据不同模式是否需要IV向量，最后是填充模式。


        // TODO 编写DESUtils单元测试



        private static string sEncryptionKey = "12345678";

        public static void SetEncryptionKey(string key)
        {
            if (key.IsNullOrEmpty())
            {
                throw new Exception("加密 key 为null。");
            }

            if (key.Length < 8)
            {
                throw new Exception("加密 key 长度小于8位。");
            }

            sEncryptionKey = key.Substring(0, 8);
            sRgbKey = Encoding.UTF8.GetBytes(sEncryptionKey);
            //initProvider();
        }

        /// <summary>
        /// 用于对称算法的密钥
        /// </summary>
        private static byte[] sRgbKey { get; set; }


        [Obsolete]
        /// <summary>
        /// 用于对称算法的初始化向量 ( 弃用 )
        /// </summary>
        private static byte[] sRgbIV = new byte[] { 10, 20, 30, 40, 50, 60, 70, 80 };

        /// <summary>
        /// 兼容其他语言的 DES 加密算法, 故设置以下配置进行兼容
        /// </summary>
        /// <returns></returns>
        private static System.Security.Cryptography.DESCryptoServiceProvider initProvider()
        {

            System.Security.Cryptography.DESCryptoServiceProvider r = new System.Security.Cryptography.DESCryptoServiceProvider();

            r.Padding = System.Security.Cryptography.PaddingMode.PKCS7; // 补位
            r.Mode = System.Security.Cryptography.CipherMode.ECB; // 兼容其他语言的Des加密算法

            if (sRgbKey == null)
            {
                sRgbKey = Encoding.UTF8.GetBytes(sEncryptionKey);
            }

            r.Key = sRgbKey;
            return r;
        }

        /// <summary>
        /// DES 加密
        /// </summary>
        /// <param name="toEncryptString"></param>
        /// <returns></returns>
        public static string Encrypt(string toEncryptString)
        {
            string r = string.Empty;

            if (toEncryptString.IsNullOrWhiteSpace())
            {
                return string.Empty;
            }

            System.Security.Cryptography.DESCryptoServiceProvider provider = initProvider();

            // System.Security.Cryptography.ICryptoTransform cryptoTransform = provider.CreateEncryptor(sRgbKey, sRgbIV); // 为了兼容其他语言的Des加密算法 不使用 sRgbIV
            System.Security.Cryptography.ICryptoTransform cryptoTransform = provider.CreateEncryptor();

            byte[] bytes = Encoding.UTF8.GetBytes(toEncryptString);

            using (System.IO.MemoryStream memoryStream = new System.IO.MemoryStream())
            {
                using
                (
                    System.Security.Cryptography.CryptoStream cryptoStream = new System.Security.Cryptography.CryptoStream
                    (
                        stream: memoryStream,
                        transform: cryptoTransform,
                        mode: System.Security.Cryptography.CryptoStreamMode.Write
                    )
                )
                {
                    cryptoStream.Write(bytes, 0, bytes.Length);
                    cryptoStream.FlushFinalBlock();
                    r = Convert.ToBase64String(memoryStream.ToArray());
                }
            }

            return r;
        }

        /// <summary>
        /// DES 解密
        /// </summary>
        /// <param name="toDecryptString"></param>
        /// <returns></returns>
        public static string Decrypt(string toDecryptString)
        {
            string r = string.Empty;

            if (toDecryptString.IsNullOrWhiteSpace())
            {
                return string.Empty;
            }

            byte[] buffer = new byte[toDecryptString.Length];
            buffer = Convert.FromBase64String(toDecryptString);

            System.Security.Cryptography.DESCryptoServiceProvider provider = initProvider();

            // System.Security.Cryptography.ICryptoTransform cryptoTransform = provider.CreateEncryptor(sRgbKey, sRgbIV); // 为了兼容其他语言的Des加密算法 不使用 sRgbIV
            System.Security.Cryptography.ICryptoTransform cryptoTransform = provider.CreateDecryptor();

            using (System.IO.MemoryStream memoryStream = new System.IO.MemoryStream())
            {
                using
                (
                    System.Security.Cryptography.CryptoStream cryptoStream = new System.Security.Cryptography.CryptoStream
                    (
                        stream: memoryStream,
                        transform: cryptoTransform,
                        mode: System.Security.Cryptography.CryptoStreamMode.Write
                    )
                )
                {
                    cryptoStream.Write(buffer, 0, buffer.Length);
                    cryptoStream.FlushFinalBlock();
                    r = Encoding.UTF8.GetString(memoryStream.ToArray());
                }
            }

            return r;
        }

    }
}
