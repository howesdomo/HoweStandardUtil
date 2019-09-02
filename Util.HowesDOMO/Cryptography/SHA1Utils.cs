using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Util.Cryptography
{
    public class SHA1Utils
    {
        /// <summary>
        /// SHA1 加密，返回大写字符串
        /// </summary>
        /// <param name="content">需要加密字符串</param>
        /// <returns>返回40位大写字符串(UTF8)</returns>
        public static string Encrypt(string content)
        {
            return Encrypt(content, Encoding.UTF8);
        }

        /// <summary>
        /// SHA1 加密，返回大写字符串
        /// </summary>
        /// <param name="content">需要加密字符串</param>
        /// <param name="encode">指定加密编码</param>
        /// <returns>返回40位大写字符串</returns>
        public static string Encrypt(string content, Encoding encode)
        {
            try
            {
                byte[] bytes_out = null;
                using (SHA1 sha1 = new SHA1CryptoServiceProvider())
                {
                    byte[] bytes_in = encode.GetBytes(content);
                    bytes_out = sha1.ComputeHash(bytes_in);
                }
                string result = BitConverter.ToString(bytes_out);
                result = result.Replace("-", "");
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("SHA1加密出错：" + ex.Message);
            }
        }
    }
}
