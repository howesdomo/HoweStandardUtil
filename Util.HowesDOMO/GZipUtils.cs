using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Util
{
    /// <summary>
    /// V 1.0.0.0 - 2018-12-3 09:46:27
    /// GZip 压缩信息
    /// </summary>
    public class GZipUtils
    {

        /// <summary>
        /// GZip压缩
        /// 核心方法
        /// </summary>
        /// <param name="toZipByteArr">待压缩的byte[]</param>
        /// <returns>压缩后的byte[]</returns>
        public static byte[] Compress(byte[] toZipByteArr)
        {
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                using (System.IO.Compression.GZipStream compressedzipStream = new System.IO.Compression.GZipStream(ms, System.IO.Compression.CompressionMode.Compress, true))
                {
                    compressedzipStream.Write(toZipByteArr, 0, toZipByteArr.Length);
                    compressedzipStream.Close();
                    return ms.ToArray();
                }
            }
        }

        #region 压缩

        /// <summary>
        /// 将传入字符串以GZip算法压缩后，返回byte[]
        /// </summary>
        /// <param name="toZipString">需要压缩的字符串</param>
        /// <returns>压缩后的byte[]</returns>
        public static byte[] Compress2ByteArr(string toZipString)
        {
            if (toZipString.IsNullOrWhiteSpace() == true)
            {
                return null;
            }
            else
            {
                byte[] toZipByteArr = System.Text.Encoding.UTF8.GetBytes(toZipString);
                return GZipUtils.Compress(toZipByteArr);
            }
        }

        /// <summary>
        /// 将传入字符串以GZip算法压缩后，返回Base64Str
        /// </summary>
        /// <param name="toZipString">需要压缩的字符串</param>
        /// <returns>压缩后的Base64Str</returns>
        public static string Compress2String(string toZipString)
        {
            if (toZipString.IsNullOrWhiteSpace() == true)
            {
                return string.Empty;
            }
            else
            {
                byte[] toZipByteArr = System.Text.Encoding.UTF8.GetBytes(toZipString);
                byte[] zippedByteArr = GZipUtils.Compress(toZipByteArr);
                return Convert.ToBase64String(zippedByteArr);
            }
        }

        #endregion


        /// <summary>
        /// GZip解压
        /// 核心方法
        /// </summary>
        /// <param name="zippedByteArr">经GZip压缩后的byte[]</param>
        /// <returns>原始byte[]</returns>
        public static byte[] Decompress(byte[] zippedByteArr)
        {
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream(zippedByteArr))
            {
                using (System.IO.Compression.GZipStream compressedzipStream = new System.IO.Compression.GZipStream(ms, System.IO.Compression.CompressionMode.Decompress))
                {
                    using (System.IO.MemoryStream outBuffer = new System.IO.MemoryStream())
                    {

                        byte[] block = new byte[1024];
                        while (true)
                        {
                            int bytesRead = compressedzipStream.Read(block, 0, block.Length);
                            if (bytesRead <= 0)
                            {
                                break;
                            }
                            else
                            {
                                outBuffer.Write(block, 0, bytesRead);
                            }
                        }

                        return outBuffer.ToArray();
                    }
                }
            }
        }

        #region 解压

        /// <summary>
        /// 将传入Base64Str以GZip算法解压缩
        /// </summary>
        /// <param name="zippedString">经GZip压缩后的Base64Str</param>
        /// <returns>原始字符串</returns>
        public static string Decompress2String(string zippedString)
        {
            if (zippedString.IsNullOrWhiteSpace() == true)
            {
                return string.Empty;
            }
            else
            {
                byte[] zippedByteArr = Convert.FromBase64String(zippedString.ToString());
                byte[] originalByteArr = GZipUtils.Decompress(zippedByteArr);
                return System.Text.Encoding.UTF8.GetString(originalByteArr);
            }
        }

        /// <summary>
        /// 将传入Base64Str以GZip算法解压缩
        /// </summary>
        /// <param name="zippedString">经GZip压缩后的Base64Str</param>
        /// <returns>原始byte[]</returns>
        public static byte[] Decompress2ByteArr(string zippedString)
        {
            if (zippedString.IsNullOrWhiteSpace() == true)
            {
                return null;
            }
            else
            {
                byte[] zippedByteArr = Convert.FromBase64String(zippedString.ToString());
                return GZipUtils.Decompress(zippedByteArr);
            }
        }

        #endregion

    }
}
