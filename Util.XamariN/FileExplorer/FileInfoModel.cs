using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Util.XamariN.FileExplorer
{
    public class FileInfoModel : Util.UIComponent.VirtualModel
    {
        public FileInfoModel()
        {

        }

        [JsonIgnore]
        public ImageSource ModelIcon { get; set; }

        public int Level { get; set; }

        public bool IsDirectory { get; set; }

        /// <summary>
        /// 返回上一层
        /// </summary>
        public bool IsDirectoryBack { get; set; }

        #region 文件夹

        /// <summary>
        /// 文件夹地址
        /// </summary>
        public string Directory { get; set; }

        /// <summary>
        /// 文件夹名称
        /// </summary>
        public string DirectoryName { get; set; }

        /// <summary>
        /// 文件夹内含文件数量
        /// </summary>
        public int ContainFileCount { get; set; }

        #endregion

        #region 文件

        public string Name { get; set; }

        public string Extension { get; set; }

        public string FullName { get; set; }

        public long FileLength { get; set; }

        public string FileLengthInfo { get; set; }

        #endregion

        public DateTime CreationTime { get; set; }

        public DateTime LastWriteTime { get; set; }

        #region UI

        public string Info
        {
            get
            {
                if (IsDirectory == true)
                {
                    return this.DirectoryName;
                }
                else
                {
                    return this.Name;
                }
            }
        }

        private string _FilePermission;

        public string FilePermission
        {
            get { return _FilePermission; }
            set { _FilePermission = value; }
        }


        public string Info2
        {
            get
            {
                if (IsDirectory == true)
                {
                    if (IsDirectoryBack == false)
                    {
                        return "{0} 项".FormatWith(this.ContainFileCount);
                    }
                    else
                    {
                        return "返回上一层";
                    }
                }
                else
                {
                    return this.FileLengthInfo;
                }
            }
        }

        public string LastWriteDateInfo
        {
            get
            {
                string r = string.Empty;
                if (IsDirectoryBack == false)
                {
                    r = this.LastWriteTime.ToString("yyyy-MM-dd");
                }
                return r;
            }
        }

        public string LastWriteTimeInfo
        {
            get
            {
                string r = string.Empty;
                if (IsDirectoryBack == false)
                {
                    r = this.LastWriteTime.ToString("HH:mm:ss.fff");
                }
                return r;
            }
        }

        #endregion

        public System.Windows.Input.ICommand ShowAlertCommand { get; private set; } = new Command
        (
            execute: () =>
            {
                string msg = $"Execute";
                System.Diagnostics.Debug.WriteLine(msg);

                System.Diagnostics.Debugger.Break();
            },
            canExecute: () =>
            {
                string msg = $"can Execute";
                System.Diagnostics.Debug.WriteLine(msg);

                System.Diagnostics.Debugger.Break();

                return true;
            }
        );

    }
}
