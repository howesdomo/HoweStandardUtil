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
    public class MyAndroidAssetsUtils : Util.XamariN.IAndroidAssetsUtils
    {
        private Android.App.Activity mAppActivity { get; set; }

        private Android.Content.Res.AssetManager mAssetManager { get; set; }

        #region 构造函数 + 单例模式

        private MyAndroidAssetsUtils()
        {

        }

        private static MyAndroidAssetsUtils s_Instance;

        private static object objLock = new object();

        public static MyAndroidAssetsUtils GetInstance(Android.App.Activity activity = null)
        {
            lock (objLock)
            {
                if (s_Instance == null)
                {
                    s_Instance = new MyAndroidAssetsUtils();
                    if (s_Instance.mAppActivity == null && activity == null)
                    {
                        throw new Exception("MyIntentUtils.GetInstance 单例首次创建, 请传入 activity 参数");
                    }

                    if (activity != null)
                    {
                        s_Instance.mAppActivity = activity;
                    }
                    s_Instance.mAssetManager = activity.Assets;
                }
                return s_Instance;
            }
        }

        #endregion

        public bool IsExist(string path)
        {
            try
            {
                mAssetManager.Open(path);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public string GetString(string path)
        {
            using (System.IO.StreamReader sr = new System.IO.StreamReader(mAssetManager.Open(path)))
            {
                return sr.ReadToEnd();
            }
        }

        // *** 勿删 ***
        //[Obsolete] // 由于Assets 的内容是在 APK 里面的, 所以没有办法获取绝对路径
        ///// <param name="path"></param>
        ///// <returns></returns>
        //public string GetPath(string path)
        //{
        //    string finalPath = "file:///android_asset/" + path;
        //    if (System.IO.File.Exists(finalPath))
        //    {
        //        var fi = new System.IO.FileInfo(finalPath);
        //        return fi.FullName;
        //    }
        //    else
        //    {
        //        return string.Empty;
        //    }
        //}

        public System.IO.Stream GetStream(string path)
        {
            return mAssetManager.Open(path);
        }        
    }
}