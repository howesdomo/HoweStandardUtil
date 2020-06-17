using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Util.Web
{
    public class HttpUtils
    {
        private const double s_Timeout = 30000; // 30 秒

        /// <summary>
        /// HttpPost 最新方法
        /// </summary>
        /// <param name="url">访问地址</param>
        /// <param name="data">传输数据 dynamic</param>
        /// <param name="encodingName">设置编码码制 ( 默认UTF-8 )</param>
        /// <param name="timeout">设置超时 ( 默认30秒 )</param>
        /// <returns></returns>
        public static Task<HttpResponseMessage> HttpPost(string url, dynamic data, string encodingName = "utf-8", double timeout = s_Timeout)
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

            System.Net.Http.StringContent stringContent = new System.Net.Http.StringContent(postContent, encoding, "application/json");
            return client.PostAsync(url, stringContent);
        }

        /// <summary>
        /// V1 - 测试结果 : 采用此方法Post无法将图片发送到服务器
        /// 发送一个含有 图片的 json 字符串 报错
        /// The Uri string is too long
        /// </summary>
        /// <param name="url">访问地址</param>
        /// <param name="data">传输数据 dynamic</param>
        /// <param name="encodingName">设置编码码制 ( 默认UTF-8 )</param>
        /// <param name="timeout">设置超时 ( 默认30秒 )</param>
        /// <returns></returns>
        public static Task<HttpResponseMessage> HttpPostWithFormUrlEncodedContent(string url, dynamic data, string encodingName = "utf-8", double timeout = s_Timeout)
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
            return client.PostAsync(url, stringContent);
        }

        ///// <summary>
        ///// V1 - 测试结果 : 采用此方法Post无法将图片发送到服务器 - Bak
        ///// 发送一个含有 图片的 json 字符串 报错
        ///// The Uri string is too long
        ///// </summary>
        ///// <param name="url">访问地址</param>
        ///// <param name="data">传输数据 dynamic</param>
        ///// <param name="encodingName">设置编码码制 ( 默认UTF-8 )</param>
        ///// <param name="timeout">设置超时 ( 默认30秒 )</param>
        ///// <returns></returns>
        //public static Task<HttpResponseMessage> HttpPostWithFormUrlEncodedContent(string url, dynamic data, string encodingName = "utf-8", double timeout = s_Timeout)
        //{
        //    if (url.ToLower().StartsWith("https:"))
        //    {
        //        System.Net.ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback((sender, certificate, chain, sslPolicyErrors) => { return true; });
        //    }

        //    Encoding encoding = null;

        //    try
        //    {
        //        encoding = Encoding.GetEncoding(encodingName);
        //    }
        //    catch (Exception)
        //    {
        //        encoding = Encoding.UTF8;
        //    }

        //    var client = new System.Net.Http.HttpClient();
        //    client.Timeout = TimeSpan.FromMilliseconds(timeout);

        //    string postContent = string.Empty;

        //    if (data is string)
        //    {
        //        // postContent = data;
        //        postContent = data.ToString();
        //    }
        //    else
        //    {
        //        postContent = Newtonsoft.Json.JsonConvert.SerializeObject(data);
        //    }

        //    List<KeyValuePair<string, string>> paramList = new List<KeyValuePair<string, string>>();
        //    paramList.Add(new KeyValuePair<string, string>("value", postContent));

        //    return client.PostAsync(url, new System.Net.Http.FormUrlEncodedContent(paramList));
        //}

        /// <summary>
        /// V2 - HttpPost 最新方法
        /// 能够发送一张图片的内容到服务器
        /// </summary>
        /// <param name="url">访问地址</param>
        /// <param name="data">传输数据 dynamic</param>
        /// <param name="encodingName">设置编码码制 ( 默认UTF-8 )</param>
        /// <param name="timeout">设置超时 ( 默认30秒 )</param>
        /// <returns></returns>
        public static Task<HttpResponseMessage> HttpPostWithStringContent(string url, dynamic data, string encodingName = "utf-8", double timeout = s_Timeout)
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
            return client.PostAsync(url, httpContent);
        }


        public static Task<HttpResponseMessage> HttpGet(string url, double timeout = s_Timeout)
        {
            if (url.ToLower().StartsWith("https:"))
            {
                System.Net.ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback((sender, certificate, chain, sslPolicyErrors) => { return true; });
            }

            var client = new System.Net.Http.HttpClient();
            client.Timeout = TimeSpan.FromMilliseconds(timeout);

            return client.GetAsync(url);
        }
    }
}
