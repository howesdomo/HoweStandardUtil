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

namespace Util.XamariN.AndroiD.Extensions
{
    /// <summary>
    /// Android.Graphics.Bitmap 扩展方法 ( 推荐创建 Xamarin.Android 代码时候在 using 中加上 )
    /// </summary>
    public static class Android_Graphics_BitmapExtensions
    {
        /// <summary>
        /// Android.Graphics.Bitmap ToArray
        /// </summary>
        /// <param name="bitmap">需要转换的图片</param>
        /// <param name="isRecycleBitmap">转换完毕后回收 Bitmap 资源, 默认false</param>
        /// <returns>byte[]</returns>
        public static byte[] ToArray(this Android.Graphics.Bitmap bitmap, bool isRecycleBitmap = false)
        {
            return Android_Graphics_BitmapUtils.ToArray(bitmap, isRecycleBitmap);
        }

        /// <summary>
        /// 缩放 Android.Graphics.Bitmap
        /// </summary>
        /// <param name="sourceBitmap">缩放的原图</param>
        /// <param name="dstWidth">缩放后的宽度</param>
        /// <param name="dstHeight">缩放后的高度</param>
        /// <param name="filter">默认false, 如果要放大图片, 通过设置 filter = true 将为您提供更平滑的边缘</param>
        /// <returns>缩放后的 Android.Graphics.Bitmap</returns>
        public static Android.Graphics.Bitmap ScaledBitmap(this Android.Graphics.Bitmap bitmap, int dstWidth, int dstHeight, bool filter = false)
        {
            return Android_Graphics_BitmapUtils.ScaledBitmap(bitmap, dstWidth, dstHeight, filter);
        }

    }
}