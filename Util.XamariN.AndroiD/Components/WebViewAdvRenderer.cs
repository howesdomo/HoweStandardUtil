// V 1.0.0 - 2020-09-01 15:28:45
// 首次创建 
// 支持 Url Scheme 跳转到其他 Activity

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Webkit;
using Android.Widget;
using Java.Net;

[assembly: Xamarin.Forms.ExportRenderer(typeof(Util.XamariN.Components.WebViewAdv), typeof(Util.XamariN.AndroiD.Components.WebViewAdvRenderer))]
namespace Util.XamariN.AndroiD.Components
{
    public class WebViewAdvRenderer : Xamarin.Forms.Platform.Android.WebViewRenderer
    {
        public WebViewAdvRenderer(Android.Content.Context context) : base(context)
        {

        }

        protected override void OnElementChanged(Xamarin.Forms.Platform.Android.ElementChangedEventArgs<Xamarin.Forms.WebView> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null) // 初始化时进入 if
            {
                var webView = Control;

                Android.Webkit.WebViewClient webViewClient = new Android.Webkit.WebViewClient();

                #region 对于 LoadWithOverviewMode 的解析

                // https://developer.android.com/reference/android/webkit/WebSettings -- setLoadWithOverviewMode
                // Sets whether the WebView loads pages in overview mode, that is, zooms out the content to fit on screen by width. 
                // This setting is taken into account when the content width is greater than the width of the WebView control,
                // for example, when getUseWideViewPort() is enabled.The default is false.

                #endregion
                webView.Settings.LoadWithOverviewMode = false; // 当页面宽度超过WebView显示宽度时，缩小页面适应WebView。默认false

                #region 对于 UseWideViewPort 的解析

                // https://developer.android.com/reference/android/webkit/WebSettings -- setUseWideViewPort
                // Sets whether the WebView should enable support for the "viewport" HTML meta tag or should use a wide viewport.
                // When the value of the setting is false, the layout width is always set to the width of the WebView control in
                // device - independent(CSS) pixels.When the value is true and the page contains the viewport meta tag, 
                // the value of the width specified in the tag is used.If the page does not contain the tag or does not provide a width,
                // then a wide viewport will be used.

                // https://developer.android.com/reference/android/webkit/WebSettings -- getUseWideViewPort
                // the WebView supports the "viewport" HTML meta tag or will use a wide viewport.
                // true if the WebView supports the viewport meta tag

                #endregion
                webView.Settings.UseWideViewPort = true; // 设置 WebView 支持 viewport meta tag

                webView.SetWebViewClient(new MyWebViewClient());

                webView.SetWebChromeClient(new MyWebChromeClient());
            }
        }

        private class MyWebViewClient : Android.Webkit.WebViewClient
        {
            public override void OnPageStarted(Android.Webkit.WebView view, string url, Android.Graphics.Bitmap favicon)
            {
                base.OnPageStarted(view, url, favicon);
            }

            public override void OnPageFinished(Android.Webkit.WebView view, string url)
            {
                base.OnPageFinished(view, url);
            }

            public override bool ShouldOverrideUrlLoading(Android.Webkit.WebView view, Android.Webkit.IWebResourceRequest request)
            {
                string url = request.Url.ToString();
                if (url.IsNullOrWhiteSpace())
                {
                    return false;
                }

                if (url.StartsWith("url://") || url.StartsWith("http://") || url.StartsWith("https://") || url.StartsWith("ftp://"))
                {
                    return base.ShouldOverrideUrlLoading(view, request);
                }

                try
                {
                    // Intent intent = new Intent(Intent.ACTION_VIEW, Android.Net.Uri.Parse(url)); // Java 源码
                    // intent.setFlags(Intent.FLAG_ACTIVITY_NEW_TASK); // Java 源码

                    Intent intent = new Intent(Intent.ActionView, Android.Net.Uri.Parse(url));
                    intent.SetFlags(ActivityFlags.NewTask);

                    Android.App.Application.Context.StartActivity(intent);
                    return true;
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.GetFullInfo());
                    System.Diagnostics.Debugger.Break();

                    // 防止crash (如果手机上没有安装处理某个scheme开头的url的APP, 会导致crash)
                    // 没有安装该app时，返回true，表示拦截自定义链接，但不跳转，避免弹出上面的错误页面
                    return true;
                }
            }
        }

        // 参考demo网站
        // Chromium WebView Samples
        // https://github.com/googlearchive/chromium-webview-samples
        // 
        // WebChromeClient是辅助WebView处理Javascript的对话框，网站图标，网站title，加载进度等
        private class MyWebChromeClient : Android.Webkit.WebChromeClient
        {
            public override void OnProgressChanged(Android.Webkit.WebView view, int newProgress)
            {
                base.OnProgressChanged(view, newProgress);
            }


            public override bool OnJsAlert(WebView view, string url, string message, JsResult result)
            {
                return base.OnJsAlert(view, url, message, result);
            }
        }
    }
}