using System;
using System.Collections.Generic;
using System.Text;

namespace Util.XamariN.Common
{
    public class ImageSourceUtils
    {
        private static string StreamType = "stream://";

        private static string UriType = "uri://";

        private static string FileType = "file://";

        private static string ResourceType = "res://";

        /// <summary>
        /// 根据字符串获取颜色
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static Xamarin.Forms.ImageSource String2ImageSource(string args)
        {
            Xamarin.Forms.ImageSource result = null;

            try
            {
                if (args.StartsWith(ImageSourceUtils.StreamType, StringComparison.CurrentCultureIgnoreCase) == true)
                {
                    result = Xamarin.Forms.ImageSource.FromStream(() =>
                    {
                        string base64Str = args.Substring(ImageSourceUtils.StreamType.Length, args.Length - ImageSourceUtils.StreamType.Length);
                        return new System.IO.MemoryStream(Convert.FromBase64String(base64Str));

                        //    //// 遇过的坑
                        //    //// 由于 Write 后, Stream 的 Position 位于 Stream的最后
                        //    //// 导致 ImageSource 获取后无法读取,
                        //    //// 解决方法 Write 后, 重新定位到 Stream 的首位即可
                        //    //System.IO.MemoryStream ms = new System.IO.MemoryStream();
                        //    //byte[] buf = Convert.FromBase64String(base64);
                        //    //ms.Write(buf, 0, buf.Length);
                        //    //ms.Seek(0, System.IO.SeekOrigin.Begin);
                        //    //return ms;
                    });
                }
                else if (args.StartsWith(ImageSourceUtils.UriType, StringComparison.CurrentCultureIgnoreCase) == true)
                {
                    string uriStr = args.Substring(ImageSourceUtils.UriType.Length, args.Length - ImageSourceUtils.UriType.Length);
                    result = Xamarin.Forms.ImageSource.FromUri(new Uri(uriStr));
                }
                else if (args.StartsWith(ImageSourceUtils.ResourceType, StringComparison.CurrentCultureIgnoreCase) == true)
                {
                    string res = args.Substring(ImageSourceUtils.ResourceType.Length, args.Length - ImageSourceUtils.ResourceType.Length);
                    result = Xamarin.Forms.ImageSource.FromResource(res);
                }
                else if (args.StartsWith(ImageSourceUtils.FileType, StringComparison.CurrentCultureIgnoreCase) == true)
                {
                    string filePath = args.Substring(ImageSourceUtils.FileType.Length, args.Length - ImageSourceUtils.FileType.Length);
                    result = Xamarin.Forms.ImageSource.FromFile(filePath);
                }
                else
                {
                    throw new Exception("没有匹配的图片资源类型");
                }

                return result;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.GetFullInfo());
#if DEBUG
                System.Diagnostics.Debugger.Break();
#endif
                throw ex;
            }
        }

    }
}
