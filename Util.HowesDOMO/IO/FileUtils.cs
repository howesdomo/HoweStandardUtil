using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Util.IO
{
    /// <summary>
    /// 不要直接复制到 HoweUtil
    /// 
    /// V 1.0.2 - 2021-04-02 13:48:35
    /// 获取文件的MD5值
    /// 
    /// V 1.0.1 - 2019-10-17 14:54:30
    /// SaveBase64StrToFile 添加可选参数 fileEncoding, 默认输出为 UTF-8
    /// </summary>
    public class FileUtils
    {
        /// <summary>
        /// 读取文件为Base64Str
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static string GetFileToBase64Str(string filePath)
        {
            string base64Str = string.Empty;

            string finalPath = Path.Combine
            (
                Environment.CurrentDirectory,
                "Temp",
                "DeleteAfterRead",
                "{0}{1}".FormatWith(Guid.NewGuid().ToString(), new FileInfo(filePath).Extension)
            );

            FileInfo fi = new FileInfo(finalPath);

            if (Directory.Exists(fi.Directory.FullName) == false)
            {
                Directory.CreateDirectory(fi.Directory.FullName);
            }

            File.Copy(filePath, finalPath);

            using (FileStream filestream = new FileStream(finalPath, FileMode.Open))
            {
                byte[] byteArry = new byte[filestream.Length];
                filestream.Read(byteArry, 0, byteArry.Length);
                base64Str = Convert.ToBase64String(byteArry);
            }

            File.Delete(finalPath);

            return base64Str;
        }

        /// <summary>
        /// Base64Str存储到文件
        /// </summary>
        /// <param name="filePath">文件存放位置</param>
        /// <param name="base64Str">文件base64字符串</param>
        /// <param name="ignoreExistFile">忽略已存在文件，若 true 删除文件</param>
        /// <param name="fileEncoding">指定文件编码格式 (可空) 默认输出为 UTF-8</param>
        public static void SaveBase64StrToFile(string filePath, string base64Str, bool ignoreExistFile = false, System.Text.Encoding fileEncoding = null)
        {
            byte[] byteArray;

            try
            {
                byteArray = Convert.FromBase64String(base64Str);
            }
            catch (Exception ex)
            {
                string errorMsg = "执行Util.IO.FileUtils.SaveBase64StrToFile发生错误。";
                throw new Exception(errorMsg, ex);
            }

            FileInfo fi = new FileInfo(filePath);

            if (Directory.Exists(fi.Directory.FullName) == false)
            {
                Directory.CreateDirectory(fi.Directory.FullName);
            }

            if (fi.Exists == true)
            {
                if (ignoreExistFile == true)
                {
                    File.Delete(filePath);
                }
                else
                {
                    throw new Exception("文件已存在。");
                }
            }

            using (FileStream filestream = new FileStream(filePath, FileMode.CreateNew))
            {
                if (fileEncoding != null) // 根据程序员指定的格式进行输出, 否则默认输出为 UTF-8
                {
                    string str = System.Text.Encoding.UTF8.GetString(byteArray);
                    byteArray = fileEncoding.GetBytes(str);
                }

                filestream.Write(byteArray, 0, byteArray.Length);
            }

            //亦可采用 byteArray.Save(filePath); // ByteExtension 的 Save 方法
        }

        /// <summary>
        /// 获取文件大小信息
        /// </summary>
        /// <param name="fileLen">文件大小长度</param>
        /// <param name="level">当前等级</param>
        /// <returns>返回文件大小信息</returns>
        public static string GetFileLengthInfo(long fileLen, int level = 1, long? lastModResult = null)
        {
            if (fileLen < 1024L)
            {
                string template = string.Empty;
                string numberStr = string.Empty; // 数值

                switch (level)
                {
                    case 1: template = "{0} B"; break;
                    case 2: template = "{0} KB"; break;
                    case 3: template = "{0} MB"; break;
                    case 4: template = "{0} GB"; break;
                    case 5: template = "{0} TB"; break;
                    default: break;
                }

                if (lastModResult.HasValue == true && lastModResult.Value > 0) // 存在余数, 计算小数点后的值
                {
                    decimal right = decimal.Parse(lastModResult.Value.ToString()) / 1024M;
                    string rightStr = right.ToString();
                    string rightInfo = string.Empty;
                    if (rightStr.Length >= 4)
                    {
                        rightInfo = rightStr.Substring(2, 2);
                    }
                    else
                    {
                        rightInfo = rightStr.Substring(2);
                    }

                    numberStr = "{0}.{1}".FormatWith(fileLen, rightInfo);
                }
                else
                {
                    numberStr = fileLen.ToString();
                }

                return template.FormatWith(numberStr);
            }
            else
            {
                long modResult = fileLen % 1024L;
                if (modResult > 0)
                {
                    return GetFileLengthInfo(fileLen / 1024L, level + 1, modResult);
                }
                else
                {
                    return GetFileLengthInfo(fileLen / 1024L, level + 1, null);
                }
            }
        }
        
        /// <summary>
        /// 获取文件名(去掉扩展名)
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static string GetFileNameWithoutExtension(string filePath)
        {
            return GetFileNameWithoutExtension(new FileInfo(filePath));
        }

        /// <summary>
        /// 获取文件名(去掉扩展名)
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static string GetFileNameWithoutExtension(FileInfo fileInfo)
        {
            if (fileInfo.Exists == false)
            {
                return string.Empty;
            }

            string pattern = fileInfo.Extension + "$";
            System.Text.RegularExpressions.MatchCollection match = System.Text.RegularExpressions.Regex.Matches(fileInfo.Name, pattern);
            if (match == null || match.Count == 0)
            {
                return fileInfo.Name;
            }
            else
            {
                return fileInfo.Name.Substring(0, match[match.Count - 1].Index);
            }
        }
		
		/// <summary>
        /// 获取文件的MD5值
        /// </summary>
        /// <param name="fi"></param>
        /// <returns></returns>
        public static string MD5(FileInfo fi)
        {
            StringBuilder sb = new StringBuilder(capacity: 32); // MD5 长度是32位字符串

            System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            using (FileStream file = new FileStream(fi.FullName, FileMode.Open))
            {
                byte[] byteArray = md5.ComputeHash(file);
                for (int i = 0; i < byteArray.Length; i++)
                {
                    sb.Append(byteArray[i].ToString("x2"));
                }
            }

            return sb.ToString();
        }
    }
}
