using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Util.Web
{
    /// <summary>
    /// V 1.0.1
    /// 整理常用的 Post 方法
    /// </summary>
    public class HttpUtils
    {
        private const double s_Timeout = 30000; // 30 秒

        #region Post == form-data

        /// <summary>
        /// 采用 form-data 方式进行 Post, 推荐使用进行发送文件 + 数据
        /// </summary>
        /// <param name="url">访问地址</param>
        /// <param name="data">传输数据 dynamic</param>
        /// <param name="fileInfos">上传文件FileInfo集合</param>
        /// <param name="encodingName">设置编码码制 ( 默认UTF-8 )</param>
        /// <param name="timeout">设置超时 ( 默认30秒 )</param>
        /// <returns></returns>
        public static Task<string> HttpPostWithFileInfos(string url, dynamic data, IEnumerable<System.IO.FileInfo> fileInfos, string encodingName = "utf-8", double timeout = s_Timeout)
        {
            if (url.ToLower().StartsWith("https:"))
            {
                System.Net.ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback((sender, certificate, chain, sslPolicyErrors) => { return true; });
            }

            Encoding encoding = null;

            try
            {
                encoding = Encoding.GetEncoding(encodingName);
            }
            catch (Exception)
            {
                encoding = Encoding.UTF8;
            }

            using (var client = new System.Net.Http.HttpClient())
            {
                client.Timeout = TimeSpan.FromMilliseconds(timeout);

                using (MultipartFormDataContent form = new MultipartFormDataContent())
                {
                    #region 参数 上传文件 赋值

                    foreach (System.IO.FileInfo item_FileInto in fileInfos)
                    {
                        ByteArrayContent fileContent = new ByteArrayContent(System.IO.File.ReadAllBytes(item_FileInto.FullName)); // 需要进行 Dispose 吗?
                        fileContent.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("multipart/form-data");
                        form.Add
                        (
                            content: fileContent,
                            name: System.IO.Path.GetFileNameWithoutExtension(item_FileInto.FullName),
                            fileName: System.IO.Path.GetFileName(item_FileInto.FullName)
                        );
                    }

                    #endregion

                    #region 参数 value 赋值

                    string postContent = string.Empty;

                    if (data is string)
                    {
                        postContent = data.ToString();
                    }
                    else
                    {
                        postContent = Util.JsonUtils.SerializeObject(data);
                    }

                    form.Add(content: new StringContent(postContent), name: "value");

                    #endregion

                    HttpResponseMessage resMsg = client.PostAsync(url, form).Result;

                    return resMsg.Content.ReadAsStringAsync();
                }
            }
        }

        /// <summary>
        /// 采用 form-data 方式进行 Post, 推荐使用进行发送文件 + 数据
        /// </summary>
        /// <param name="url">访问地址</param>
        /// <param name="data">传输数据 dynamic</param>
        /// <param name="filePaths">上传文件路径集合</param>
        /// <param name="encodingName">设置编码码制 ( 默认UTF-8 )</param>
        /// <param name="timeout">设置超时 ( 默认30秒 )</param>
        /// <returns></returns>
        public static Task<string> HttpPostWithFilePaths(string url, dynamic data, IEnumerable<string> filePaths, string encodingName = "utf-8", double timeout = s_Timeout)
        {
            return HttpPostWithFileInfos(url, data, filePaths.Select(i => new FileInfo(i)), encodingName, timeout);
        }

        #endregion

        #region Post == x-www-form-urlencoded

        /// <summary>
        /// 采用 x-www-form-urlencoded 方式进行 Post
        /// 
        /// V1 - 测试结果 : 采用此方法Post无法将图片发送到服务器
        /// 发送一个含有 图片的 json 字符串 报错
        /// The Uri string is too long
        /// 
        /// 最原始的方法
        /// </summary>
        /// <param name="url">访问地址</param>
        /// <param name="data">传输数据 dynamic</param>
        /// <param name="encodingName">设置编码码制 ( 默认UTF-8 )</param>
        /// <param name="timeout">设置超时 ( 默认30秒 )</param>
        /// <returns></returns>
        public static Task<string> HttpPostWithFormUrlEncodedContent(string url, dynamic data, string encodingName = "utf-8", double timeout = s_Timeout)
        {
            if (url.ToLower().StartsWith("https:"))
            {
                System.Net.ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback((sender, certificate, chain, sslPolicyErrors) => { return true; });
            }

            Encoding encoding = null;

            try
            {
                encoding = Encoding.GetEncoding(encodingName);
            }
            catch (Exception)
            {
                encoding = Encoding.UTF8;
            }

            var client = new System.Net.Http.HttpClient();
            client.Timeout = TimeSpan.FromMilliseconds(timeout);

            string postContent = string.Empty;

            if (data is string)
            {
                // postContent = data;
                postContent = data.ToString();
            }
            else
            {
                postContent = Newtonsoft.Json.JsonConvert.SerializeObject(data);
            }

            var formParams = new Dictionary<string, string>()
            {
                ["value"] = postContent
            };

            var stringFormParams = new Func<IDictionary<string, string>, string>((dic) =>
            {
                string result = "";
                foreach (var param in dic)
                {
                    if (result.Length > 0) { result += "&"; }
                    result += param.Key + "=" + System.Net.WebUtility.UrlEncode(param.Value);
                }
                return result;
            }).Invoke(formParams);

            var stringContent = new StringContent(stringFormParams, encoding, "application/x-www-form-urlencoded");
            // return client.PostAsync(url, stringContent);
            HttpResponseMessage resMsg = client.PostAsync(url, stringContent).Result;
            return resMsg.Content.ReadAsStringAsync();
        }

        #endregion

        #region Post == raw

        /// <summary>
        /// 采用 raw 方式进行 Post, 推荐使用发送 JsonStr
        /// </summary>
        /// <param name="url">访问地址</param>
        /// <param name="data">传输数据 dynamic</param>
        /// <param name="encodingName">设置编码码制 ( 默认UTF-8 )</param>
        /// <param name="timeout">设置超时 ( 默认30秒 )</param>
        /// <returns></returns>
        public static Task<string> HttpPostWithStringContent(string url, dynamic data, string encodingName = "utf-8", double timeout = s_Timeout)
        {
            if (url.ToLower().StartsWith("https:"))
            {
                System.Net.ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback((sender, certificate, chain, sslPolicyErrors) => { return true; });
            }

            Encoding encoding = null;

            try
            {
                encoding = Encoding.GetEncoding(encodingName);
            }
            catch (Exception)
            {
                encoding = Encoding.UTF8;
            }

            var client = new System.Net.Http.HttpClient();
            client.Timeout = TimeSpan.FromMilliseconds(timeout);

            string postContent = string.Empty;
            if (data is string)
            {
                // postContent = data;
                postContent = data.ToString();
            }
            else
            {
                postContent = Newtonsoft.Json.JsonConvert.SerializeObject(data);
            }

            System.Net.Http.StringContent httpContent = new System.Net.Http.StringContent(postContent, encoding, "application/json");
            // return client.PostAsync(url, httpContent);
            HttpResponseMessage resMsg = client.PostAsync(url, httpContent).Result;
            return resMsg.Content.ReadAsStringAsync();
        }

        #endregion

        #region Get

        public static Task<string> HttpGet(string url, double timeout = s_Timeout)
        {
            if (url.ToLower().StartsWith("https:"))
            {
                System.Net.ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback((sender, certificate, chain, sslPolicyErrors) => { return true; });
            }

            var client = new System.Net.Http.HttpClient();
            client.Timeout = TimeSpan.FromMilliseconds(timeout);

            // return client.GetAsync(url);
            HttpResponseMessage httpResMsg = client.GetAsync(url).Result;
            return httpResMsg.Content.ReadAsStringAsync();
        }

        #endregion
    }
}
