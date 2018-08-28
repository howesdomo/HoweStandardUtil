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
        /// 屏幕方向强制横屏
        /// </summary>
        void ForceLandscape();

        /// <summary>
        /// 屏幕方向固定 ( 不根据陀螺仪监控结果改变 )
        /// </summary>
        void ForceNosensor();
    }
}
