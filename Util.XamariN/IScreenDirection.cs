using System;
using System.Collections.Generic;
using System.Text;

namespace Util.XamariN
{
    /// <summary>
    /// 屏幕方向接口
    /// </summary>
    public interface IScreenDirection
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
    }
}
