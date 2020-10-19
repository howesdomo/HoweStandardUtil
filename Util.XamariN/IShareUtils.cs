using System;
using System.Collections.Generic;
using System.Text;

namespace Util.XamariN
{
    /// <summary>
    /// V 1.0.0 - 2020-10-13 17:36:50
    /// 首次创建, 常用的分享功能初步实现, 待完善
    /// </summary>
    public interface IShareUtils
    {
        void ShareMsg(string msg, List<string> filters = null, string chooserTitle = "");

        #region ShareMsg

        void ShareMsg(string msg, string filter, string chooserTitle = "");

        void ShareMsg2WeChat(string msg);

        void ShareMsg2QQ(string msg);

        void ShareMsg2TIM(string msg);

        void ShareMsg2EStrongs(string msg);

        #endregion

        void ShareFile(string filePath, List<string> filters = null, string chooserTitle = "");

        #region ShareFile

        void ShareFile(string filePath, string filter, string chooserTitle = "");

        void ShareFile2WeChat(string filePath);

        void ShareFile2QQ(string filePath);

        void ShareFile2TIM(string filePath);

        void ShareFile2EStrongs(string filePath);

        #endregion

        void ShareImage(byte[] imageData, List<string> filters = null, string chooserTitle = "");

        /// <summary>
        /// Android 使用
        /// </summary>
        /// <param name="packageName"></param>
        /// <param name="activityName"></param>
        /// <param name="appname"></param>
        /// <param name="msgTitle"></param>
        /// <param name="msgText"></param>
        void ShareMsg2Xxx
        (
            string packageName,
            string activityName,
            string appname,
            string msgTitle,
            string msgText
        );
    }
}
