using System;

namespace Util.XamariN
{
    /// <summary>
    /// V 1.0.2 - 2020-06-12 16:35:12
    /// 开始录制执行成功后 返回保存文件路径
    /// 
    /// V 1.0.1 - 2020-06-11 14:00:02
    /// 增加接口逻辑, 使 Client 端更方便地使用
    /// 
    /// V 1.0.0 - 2020-06-09 18:51:40
    /// 首次创建
    /// </summary>
    public interface IAndroidScreenRecord
    {
        /// <summary>
        /// 开始屏幕录制
        /// </summary>
        /// <returns></returns>
        System.IO.FileInfo StartRecord(DateTime? imageFileDateTime = null, string dirName = "");

        /// <summary>
        /// 停止屏幕录制
        /// </summary>
        void StopRecord();

        /// <summary>
        /// 设置静默模式
        /// </summary>
        /// <param name="v"></param>
        void SetIsSilent(bool v);

        /// <summary>
        /// 设置 Dpi
        /// </summary>
        /// <param name="v"></param>
        void SetDpi(int v);

        System.IO.FileInfo Get_ScreenVideoFileInfo(DateTime? imageFileDateTime = null, string dirName = "");
    }
}
