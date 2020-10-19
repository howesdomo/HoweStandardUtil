using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Util.XamariN.AndroiD
{
    /// <summary>
    /// Android.Graphics.Bitmap 工具类
    /// </summary>
    public class Android_Graphics_BitmapUtils
    {
        /// <summary>
        /// Android.Graphics.Bitmap ToArray
        /// </summary>
        /// <param name="bitmap">需要转换的图片</param>
        /// <param name="isRecycleBitmap">转换完毕后回收 Bitmap 资源, 默认false</param>
        /// <returns>byte[]</returns>
        public static byte[] ToArray(Android.Graphics.Bitmap bitmap, bool isRecycleBitmap = false)
        {
            using (var ms = new System.IO.MemoryStream())
            {
                bitmap.Compress(Android.Graphics.Bitmap.CompressFormat.Png, 100, ms);

                if (isRecycleBitmap)
                {
                    bitmap.Recycle();
                }

                return ms.ToArray();
            }
        }

        /// <summary>
        /// 缩放 Android.Graphics.Bitmap
        /// </summary>
        /// <param name="sourceBitmap">缩放的原图</param>
        /// <param name="dstWidth">缩放后的宽度</param>
        /// <param name="dstHeight">缩放后的高度</param>
        /// <param name="filter">默认false, 如果要放大图片, 通过设置 filter = true 将为您提供更平滑的边缘</param>
        /// <returns>缩放后的 Android.Graphics.Bitmap</returns>
        public static Android.Graphics.Bitmap ScaledBitmap(Android.Graphics.Bitmap sourceBitmap, int dstWidth, int dstHeight, bool filter = false)
        {
            return Android.Graphics.Bitmap.CreateScaledBitmap(sourceBitmap, dstWidth, dstHeight, filter);
        }
    }
}