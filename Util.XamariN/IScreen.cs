using System;
using System.Collections.Generic;
using System.Text;

namespace Util.XamariN
{
    /// <summary>
    /// 屏幕方向接口
    /// </summary>
    public interface IScreen
    {
        /// <summary>
        /// 屏幕方向根据陀螺仪监控结果改变
        /// </summary>
        void Unspecified();

        /// <summary>
        /// 屏幕方向强制竖屏
        /// </summary>
        void ForcePortrait();

        /// <summary>
        /// 屏幕方向强制反向竖屏
        /// </summary>
        void ForceReversePortrait();

        /// <summary>
        /// 屏幕方向强制向左横屏
        /// </summary>
        void ForceLandscapeLeft();

        /// <summary>
        /// 屏幕方向强制向右横屏
        /// </summary>
        void ForceLandscapeRight();

        /// <summary>
        /// 屏幕方向固定 ( 不根据陀螺仪监控结果改变 )
        /// </summary>
        void ForceNosensor();

        /// <summary>
        /// 屏幕常亮
        /// Get 获取是否屏幕常亮状态
        /// Set 设置/取消 屏幕常亮
        /// </summary>
        bool ScreenKeepOn { get; set; }

        /// <summary>
        /// 设置全屏
        /// </summary>
        void FullScreen();

        /// <summary>
        /// 取消设置全屏
        /// </summary>
        void CancelFullScreen();
    }
}
