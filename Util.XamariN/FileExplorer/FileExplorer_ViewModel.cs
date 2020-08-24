using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;

using Acr.UserDialogs;
using FFImageLoading.Svg.Forms;

using Util.ActionUtils;
using System.Reflection;

namespace Util.XamariN.FileExplorer
{
    /// <summary>
    /// V 1.0.2 - 2020-08-24 16:08:54
    /// 新增 提交选中文件/文件夹 ( 使用 Messaging Center 方式进行发送 )
    /// 
    /// V 1.0.1 - 2020-08-21 11:46:45
    /// 增加 assembly 参数, 修改引用嵌入式资源
    /// 优化 -drw- 由原本写死的信息, 改为根据实际情况进行解析
    /// 
    /// V 1.0.0 - 2020-08-11 10:00:00
    /// 首次创建
    /// </summary>
    public class FileExplorer_ViewModel : INotifyPropertyChanged
    {
        double mActionIntervalDefault
        {
            get { return 50d; }
        }

        DebounceAction mDebounceAction = new DebounceAction();

        public FileExplorer_ViewModel(string baseDirectory)
        {
            initCheckBasePath(baseDirectory);
            initCommand();
            initFileSortList();

            initUIData();
        }

        void initCheckBasePath(string baseDirectory)
        {
            var di = new DirectoryInfo(baseDirectory);

            if (di.Exists == false)
            {
                throw new IOException($"路径不存在 或 未有权限访问路径。\r\n{baseDirectory}");
            }

            // 由于 D:\Enpot 与 D:\Enpot\ 检测出来都是存在的, 但是当用户去到其子层后
            // 再获取其父路径, 只会获取到 D:\Enpot, 由于此情况会导致误判( 返回上层的计算 )
            if (di.FullName.EndsWith(di.Name) == false)
            {
                throw new IOException($"传入参数 baseDirectory 不能以斜杠结尾。\r\n{baseDirectory}");
            }

            this._BaseDirectory = di.FullName;
        }

        void initCommand()
        {
            CMD_Tap_NavBarParentFolderName = new Command(tap_NavBarParentFolderName);

            CMD_TapFileInfoModel = new Command<FileInfoModel>((m) => tapFileInfoModel(m));

            CMD_Create = new Command(createFake);

            CMD_FilterBar_ChangeVisible = new Command(filterBar_VisibleChangeFake);
            CMD_ExcuteFilter = new Command<string>((args) => executeFilter(args));

            CMD_Refresh = new Command(refreshFake);

            CMD_Tap_SortView = new Command(tap_SortViewFake);

            CMD_ChangeSelectionMode = new Command(changeSelectionModeFake);
            CMD_OnSelectionChanged = new Command(onSelectionChanged);

            CMD_CheckAll = new Command(checkAllFake);
            CMD_Reverse = new Command(reverseFake);

            CMD_Tap_Copy = new Command(tapCopyFake);
            CMD_Tap_Cut = new Command(tapCutFake);

            CMD_Tap_Paste = new Command(tapPasteFake);
            CMD_CopyCutMode_CreateDir = new Command(copyCutMode_CreateDirFake);
            CMD_ExitCopyCutMode = new Command(exitCopyCutModeFake);


            CMD_Tap_Delete = new Command(tapDeleteFake);
            CMD_Tap_Rename = new Command(tapRenameFake);

            CMD_ConfirmSelect = new Command(confirmSelectFake);
        }

        void initUIData()
        {
            search(this.BaseDirectory, 1);
        }

        private string _BaseDirectory;
        /// <summary>
        /// 最低层的路径
        /// </summary>
        public string BaseDirectory
        {
            get
            {
                return _BaseDirectory;
            }
        }

        /// <summary>
        /// 当前的目录路径
        /// </summary>
        public string CurrentDirectory
        {
            get
            {
                return this.CurrentDirectoryInfo.FullName;
            }
        }

        private DirectoryInfo _CurrentDirectoryInfo;
        public DirectoryInfo CurrentDirectoryInfo
        {
            get { return _CurrentDirectoryInfo; }
            set
            {
                _CurrentDirectoryInfo = value;
                this.OnPropertyChanged();
                this.OnPropertyChanged(nameof(CurrentDirectory));
                this.OnPropertyChanged(nameof(IsCurrentDirectoryEqBaseDirectory));
                this.OnPropertyChanged(nameof(NavBarParentFolderName));
                this.OnPropertyChanged(nameof(NavBarCurrentFolderName));
            }
        }

        public bool IsCurrentDirectoryEqBaseDirectory
        {
            get
            {
                return this.BaseDirectory == this.CurrentDirectory;
            }
        }

        /// <summary>
        /// 当前路径 FileInfoModel  
        /// </summary>
        FileInfoModel mUpperFileInfoModel { get; set; }

        #region 文件列表


        private List<FileInfoModel> list;

        /// <summary>
        /// 当前目录包含的所有文件夹与文件
        /// </summary>
        public List<FileInfoModel> List
        {
            get { return list; }
            set
            {
                list = value;
                executeFilter(string.Empty);
            }
        }

        /// <summary>
        /// 先排列文件夹
        /// </summary>
        private readonly DynamicSort sortByDir = new DynamicSort("IsDirectory", SortDirection.Descending);

        private void executeFilter(string query)
        {
            if (this.List != null)
            {
                List<FileInfoModel> r = new List<FileInfoModel>();

                if (query.IsNullOrWhiteSpace() == true)
                {
                    r.AddRange
                    (
                        this.List.SortBy<FileInfoModel>(new List<DynamicSort>() { sortByDir, this.SelectedFileSort })
                            .ToList<FileInfoModel>()
                    );
                }
                else
                {
                    var regex = new Regex(query, RegexOptions.IgnoreCase);
                    r.AddRange
                    (
                        this.List
                            .Where(i => regex.IsMatch(i.Info) == true)
                            .SortBy<FileInfoModel>(new List<DynamicSort>() { sortByDir, this.SelectedFileSort })
                            .ToList<FileInfoModel>()
                    );
                }

                this.FilterList = r;
            }
        }

        private List<FileInfoModel> _FilterList;

        /// <summary>
        /// <para>当前目录包含的所有文件夹与文件 (已过滤信息)</para>
        /// <para>界面上绑定本集合</para>
        /// </summary>
        public List<FileInfoModel> FilterList
        {
            get { return _FilterList; }
            set
            {
                _FilterList = value;
                this.OnPropertyChanged();
            }
        }

        public Command<FileInfoModel> CMD_TapFileInfoModel { get; private set; }

        private string _FilterText;

        public string FilterText
        {
            get { return _FilterText; }
            set
            {
                _FilterText = value;
                this.OnPropertyChanged();
            }
        }


        void tapFileInfoModel(FileInfoModel m)
        {
            if (this.FilterBarIsVisible == true)
            {
                this.FilterText = string.Empty; // TODO 这个时候 需要 FilterBar.Text 属性有双向绑定的功能
                this.FilterBarIsVisible = false;
            }

            if (m.IsDirectory == true)
            {
                search(m.Directory, m.Level);
            }
            else
            {
                openFileByFileType(m.Extension);
            }
        }

        #endregion

        #region 遍历文件夹

        void search(string path, int level)
        {
            List<FileInfoModel> list = new List<FileInfoModel>();
            this.CurrentDirectoryInfo = new DirectoryInfo(path);

            this.loopDirectoriesAndFiles(path, level, list);
            this.List = list;
        }

        private string getFilePermission(DirectoryInfo di)
        {
            string r = "drw";
            return r;
        }

        private string getFilePermission(FileInfo fi)
        {
            string r = "-r{0}".FormatWith(fi.IsReadOnly ? "-" : "w");
            return r;
        }

        /// <summary>
        /// 遍历文件夹
        /// </summary>
        /// <param name="dirPath">Dir path.</param>
        /// <param name="level">Level.</param>
        private void loopDirectoriesAndFiles(string dirPath, int level, IList<FileInfoModel> list)
        {
            List<Exception> dirExList = new List<Exception>(); // 用于显示报错
            List<Exception> fileExList = new List<Exception>(); // 用于显示报错

            try
            {
                #region 返回上一层 [已弃用于UI, 但逻辑仍在使用此对象 ( 判断能否返回上一层 / 获取当前层级信息 / .. )

                if (this.BaseDirectory == dirPath)
                {
                    this.mUpperFileInfoModel = null;
                }
                else // 若不是根目录, 在第一位加上目录..(返回)
                {
                    System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(dirPath);
                    FileInfoModel toAdd = new FileInfoModel()
                    {
                        IsDirectory = true,
                        IsDirectoryBack = true,

                        // 通用
                        Level = level - 1,

                        // 目录
                        DirectoryName = "..",
                        Directory = di.Parent.FullName,

                        // 文件
                        Name = string.Empty,
                        Extension = string.Empty,
                        FullName = string.Empty,

                        // 图标
                        ModelIcon = SvgImageSource.FromResource("Util.XamariN.FileExplorer.Images.folder.svg", mAssembly),

                        // 文件权限
                        FilePermission = getFilePermission(di),
                    };

                    mUpperFileInfoModel = toAdd;
                }

                #endregion

                foreach (var item in System.IO.Directory.GetDirectories(dirPath).OrderBy(i => i))
                {
                    try
                    {
                        //string msg = "|{0}{1}".FormatWith("".PadLeft(level, '_'), item);
                        //System.Diagnostics.Debug.WriteLine(msg);
                        System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(item);

                        FileInfoModel toAdd = new FileInfoModel()
                        {
                            IsDirectory = true,

                            // 通用
                            Level = level + 1,
                            LastWriteTime = di.LastWriteTime,

                            // 目录
                            DirectoryName = di.Name,
                            Directory = di.FullName,
                            ContainFileCount = di.GetDirectories().Length + di.GetFiles().Length,

                            // 文件
                            Name = di.Name,
                            Extension = di.Extension,
                            FullName = di.FullName,

                            // 图标
                            ModelIcon = SvgImageSource.FromResource("Util.XamariN.FileExplorer.Images.folder.svg", mAssembly),

                            // 文件权限
                            FilePermission = getFilePermission(di),
                        };

                        list.Add(toAdd);
                    }
                    catch (Exception dirEx)
                    {
                        dirExList.Add(dirEx);
                    }
                }

                foreach (var item in System.IO.Directory.GetFiles(dirPath).OrderBy(i => i))
                {
                    try
                    {
                        //string msg = "|{0}{1}".FormatWith("".PadLeft(level, '_'), item);
                        //System.Diagnostics.Debug.WriteLine(msg);
                        System.IO.FileInfo di = new System.IO.FileInfo(item);

                        FileInfoModel toAdd = new FileInfoModel()
                        {
                            IsDirectory = false,

                            // 通用
                            Level = level,
                            LastWriteTime = di.LastWriteTime,

                            // 目录
                            DirectoryName = di.DirectoryName,
                            Directory = di.Directory.FullName,

                            // 文件
                            Name = di.Name,
                            Extension = di.Extension,
                            FullName = di.FullName,
                            FileLength = di.Length,
                            FileLengthInfo = Util.IO.FileUtils.GetFileLengthInfo(di.Length),

                            // 图标
                            ModelIcon = getSVGImageSource(di.Extension.ToLower()),

                            // 文件权限
                            FilePermission = getFilePermission(di),
                        };

                        list.Add(toAdd);
                    }
                    catch (Exception fileEx)
                    {
                        fileExList.Add(fileEx);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.GetInfo());
                System.Diagnostics.Debugger.Break();
            }
            finally
            {
                string msg = string.Empty;
                if (dirExList.Count > 0)
                {
                    msg += $"遍历文件夹时捕获到读取文件夹信息错误共 {dirExList.Count} 个;";
                }

                if (fileExList.Count > 0)
                {
                    msg += $"遍历文件夹时捕获到读取文件错误共 {fileExList.Count} 个;";
                }

                if (msg.IsNullOrWhiteSpace() == false)
                {
                    System.Diagnostics.Debug.WriteLine(msg);
                    System.Diagnostics.Debugger.Break();
                }
            }
        }

        Assembly mAssembly = typeof(FileExplorer_ViewModel).GetTypeInfo().Assembly;

        ImageSource getSVGImageSource(string extensionName)
        {


            ImageSource r = null;
            switch (extensionName)
            {
                case ".txt":
                    r = SvgImageSource.FromResource("Util.XamariN.FileExplorer.Images.txt.svg", mAssembly);
                    break;

                case ".html":
                    r = SvgImageSource.FromResource("Util.XamariN.FileExplorer.Images.html.svg", mAssembly);
                    break;

                case ".javascript":
                    r = SvgImageSource.FromResource("Util.XamariN.FileExplorer.Images.javascript.svg", mAssembly);
                    break;

                case ".xml":
                    r = SvgImageSource.FromResource("Util.XamariN.FileExplorer.Images.xml.svg", mAssembly);
                    break;

                case ".doc":
                case ".docx":
                    r = SvgImageSource.FromResource("Util.XamariN.FileExplorer.Images.doc.svg", mAssembly);
                    break;

                case ".xls":
                case ".xlsx":
                    r = SvgImageSource.FromResource("Util.XamariN.FileExplorer.Images.xls.svg", mAssembly);
                    break;

                case ".pdf":
                    r = SvgImageSource.FromResource("Util.XamariN.FileExplorer.Images.pdf.svg", mAssembly);
                    break;

                case ".zip":
                case ".rar":
                case ".7z":
                    r = SvgImageSource.FromResource("Util.XamariN.FileExplorer.Images.zip.svg", mAssembly);
                    break;


                case ".jpg":
                    r = SvgImageSource.FromResource("Util.XamariN.FileExplorer.Images.jpg.svg", mAssembly);
                    break;

                case ".png":
                    r = SvgImageSource.FromResource("Util.XamariN.FileExplorer.Images.png.svg", mAssembly);
                    break;

                default:
                    r = SvgImageSource.FromResource("Util.XamariN.FileExplorer.Images.file.svg", mAssembly);
                    break;
            }

            return r;
        }


        void openFileByFileType(string extensionName)
        {
            // TODO 为常用文件类型打开
            switch (extensionName)
            {
                case "txt":
                case "html":
                case "javascript":
                case "xml":
                    {
                        // TODO
                    }
                    break;

                case "doc":
                case "docx":
                    {

                    }
                    break;

                case "xls":
                case "xlsx":
                    {

                    }
                    break;

                case "pdf":
                    {

                    }
                    break;

                case "zip":
                case "rar":
                case "7z":
                    {

                    }
                    break;


                case "jpg":
                case "png":
                    {

                    }
                    break;

                default:
                    {

                    }
                    break;
            }
        }

        #endregion

        #region 导航栏

        #region 非根目录导航栏-左
        public string NavBarParentFolderName
        {
            get
            {
                if (IsCurrentDirectoryEqBaseDirectory == true)
                {
                    return string.Empty;
                }
                else
                {
                    if (this.CurrentDirectoryInfo.Parent.FullName == this.BaseDirectory)
                    {
                        return "根目录";
                    }
                    else
                    {
                        return this.CurrentDirectoryInfo.Parent.Name;
                    }
                }
            }
        }

        public Command CMD_Tap_NavBarParentFolderName { get; private set; }

        void tap_NavBarParentFolderName()
        {
            HandleBackButtonPress();
        }

        #endregion

        #region 非根目录导航栏-右
        public string NavBarCurrentFolderName
        {
            get
            {
                return this.CurrentDirectoryInfo.Name;
            }
        }

        #endregion

        #endregion

        #region 返回按钮

        /// <summary>
        /// 返回按钮
        /// </summary>
        /// <returns></returns>
        public bool HandleBackButtonPress()
        {
            bool handled = false;

            // 正常模式 / 选择模式
            if (this.SelectionMode == SelectionMode.Multiple) // 如果当前是选择模式, 按一次返回键后变回普通模式
            {
                changeSelectionModeFake();
                return true;
            }

            if (mUpperFileInfoModel != null)
            {
                search(mUpperFileInfoModel.Directory, mUpperFileInfoModel.Level);
                return true;
            }

            if (this.IsCopyCutMode == true) // 复制剪贴模式情况下 按返回按钮
            {
                this.IsCopyCutMode = false;
                return true;
            }

            if (this.UcFileExplorerSortView_IsVisible == true)
            {
                this.UcFileExplorerSortView_IsVisible = false;
                return true;
            }

            return handled;
        }

        #endregion

        #region 新建

        public Command CMD_Create { get; private set; }

        void createFake()
        {
            mDebounceAction.Debounce
            (
                interval: mActionIntervalDefault,
                action: () =>
                {
                    Device.BeginInvokeOnMainThread(create);
                },
                syncInvoke: null
            );
        }

        void create()
        {
            // TODO 如何不按返回键就能取消ActionSheet
            UserDialogs.Instance.ActionSheet
            (
                new ActionSheetConfig()
                .SetTitle("新建")
                    .Add(text: "文件", action: createFilePrompt)
                    .Add(text: "文件夹", action: createFolderPrompt)
            );
        }

        void createFolderPrompt()
        {
            Acr.UserDialogs.UserDialogs.Instance.Prompt(new Acr.UserDialogs.PromptConfig()
            {
                Title = "新建",
                Message = "请输入新建文件夹名称",
                Placeholder = "请输入新建文件夹名称",
                InputType = Acr.UserDialogs.InputType.Default,
                OkText = "确定",
                CancelText = "取消",
                OnAction = ((r) =>
                {
                    if (r.Ok)
                    {
                        createFolder(r.Text);
                    }
                })
            });
        }

        void createFolder(string folderName)
        {
            if (folderName.IsNullOrWhiteSpace() == true)
            {
                Acr.UserDialogs.UserDialogs.Instance.Toast("取消创建文件夹。【输入文件夹名称为空】");
                return;
            }

            var path = System.IO.Path.Combine(this.CurrentDirectory, folderName);

            if (File.Exists(path) == true)
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    Acr.UserDialogs.UserDialogs.Instance.Toast("文件已存在，不能创建");
                });
                return;
            }

            Directory.CreateDirectory(path);
            refresh();
        }

        void createFilePrompt()
        {
            Acr.UserDialogs.UserDialogs.Instance.Prompt(new Acr.UserDialogs.PromptConfig()
            {
                Title = "新建",
                Message = "请输入新建文件名称",
                Placeholder = "请输入新建文件名称",
                InputType = Acr.UserDialogs.InputType.Default,
                OkText = "确定",
                CancelText = "取消",
                OnAction = ((r) =>
                {
                    if (r.Ok)
                    {
                        createFile(this.CurrentDirectory, r.Text);
                    }
                })
            });
        }

        void createFile(string folder, string fileName)
        {
            if (fileName.IsNullOrWhiteSpace() == true)
            {
                Acr.UserDialogs.UserDialogs.Instance.Toast("取消创建文件。【输入文件名称为空】");
                return;
            }

            var path = Path.Combine(folder, fileName);

            if (File.Exists(path) == true)
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    Acr.UserDialogs.UserDialogs.Instance.Toast("文件已存在，不能创建");
                });
                return;
            }

            File.Create(path);
            refresh();
        }

        #endregion

        #region 搜索

        public Command CMD_FilterBar_ChangeVisible { get; private set; }

        void filterBar_VisibleChangeFake()
        {
            mDebounceAction.Debounce
            (
                interval: mActionIntervalDefault,
                action: () =>
                {
                    Device.BeginInvokeOnMainThread(filterBar_VisibleChange);
                },
                syncInvoke: null
            );
        }

        void filterBar_VisibleChange()
        {
            this.FilterBarIsVisible = !this.FilterBarIsVisible;
        }

        private bool _FilterBarIsVisible;

        public bool FilterBarIsVisible
        {
            get { return _FilterBarIsVisible; }
            set
            {
                _FilterBarIsVisible = value;
                this.OnPropertyChanged();
            }
        }

        public Command<string> CMD_ExcuteFilter { get; private set; }

        #endregion

        #region 刷新

        public Command CMD_Refresh { get; private set; }

        void refreshFake()
        {
            mDebounceAction.Debounce
            (
                interval: mActionIntervalDefault,
                action: () =>
                {
                    Device.BeginInvokeOnMainThread(refresh);
                },
                syncInvoke: null
            );
        }

        public void refresh()
        {
            if (this.IsCurrentDirectoryEqBaseDirectory)
            {
                initUIData();
            }
            else
            {
                search(this.CurrentDirectory, mUpperFileInfoModel.Level + 1);
            }
        }

        #endregion

        #region 视图

        private bool _UcFileExplorerSortView_IsVisible;

        public bool UcFileExplorerSortView_IsVisible
        {
            get { return _UcFileExplorerSortView_IsVisible; }
            set
            {
                _UcFileExplorerSortView_IsVisible = value;
                this.OnPropertyChanged();
            }
        }


        public Command CMD_Tap_SortView { get; private set; }

        void tap_SortViewFake()
        {
            mDebounceAction.Debounce
            (
                interval: mActionIntervalDefault,
                action: () =>
                {
                    Device.BeginInvokeOnMainThread(tap_SortView);
                },
                syncInvoke: null
            );
        }

        void tap_SortView()
        {
            this.UcFileExplorerSortView_IsVisible = !this.UcFileExplorerSortView_IsVisible;
        }


        private List<FileSort> _FileSortList;
        public List<FileSort> FileSortList
        {
            get { return _FileSortList; }
            set
            {
                _FileSortList = value;
                this.OnPropertyChanged();
            }
        }

        private FileSort _SelectedFileSort;
        public FileSort SelectedFileSort
        {
            get { return _SelectedFileSort; }
            set
            {
                if (_SelectedFileSort != value)
                {
                    _SelectedFileSort = value;
                    this.OnPropertyChanged();
                    this.refresh();
                }
                this.UcFileExplorerSortView_IsVisible = false; // 视图界面隐藏                
            }
        }

        void initFileSortList()
        {
            var l = new List<FileSort>();
            l.Add(new FileSort("Info", SortDirection.Ascending)
            {
                DisplayName = "升序",
                SortTypeImage = new FontImageSource() { FontFamily = "FontAwesome", Color = Color.Black, Glyph = Util_Font.FontAwesomeIcons.SortAlphaUp },
                // DirectionImage = new FontImageSource() { FontFamily = "FontAwesome", Color = Color.Black, Glyph = Util_Font.FontAwesomeIcons.ArrowUp, Size= 10d }
                Comparer = new Util_Comparer.MyStrLogicalComparer()

            });

            l.Add(new FileSort("Extension")
            {
                DisplayName = "升序",
                SortTypeImage = new FontImageSource() { FontFamily = "FontAwesome", Color = Color.Black, Glyph = Util_Font.FontAwesomeIcons.Tag },
                DirectionImage = new FontImageSource() { FontFamily = "FontAwesome", Color = Color.Black, Glyph = Util_Font.FontAwesomeIcons.ArrowUp, Size = 10d }
            });

            l.Add(new FileSort("FileLength")
            {
                DisplayName = "升序",
                SortTypeImage = new FontImageSource() { FontFamily = "FontAwesome", Color = Color.Black, Glyph = Util_Font.FontAwesomeIcons.ChartPieAlt },
                DirectionImage = new FontImageSource() { FontFamily = "FontAwesome", Color = Color.Black, Glyph = Util_Font.FontAwesomeIcons.ArrowUp, Size = 10d }
            });

            l.Add(new FileSort("LastWriteTime")
            {
                DisplayName = "升序",
                SortTypeImage = new FontImageSource() { FontFamily = "FontAwesome", Color = Color.Black, Glyph = Util_Font.FontAwesomeIcons.Clock },
                DirectionImage = new FontImageSource() { FontFamily = "FontAwesome", Color = Color.Black, Glyph = Util_Font.FontAwesomeIcons.ArrowUp, Size = 10d }
            });



            l.Add(new FileSort("Info", SortDirection.Descending)
            {
                DisplayName = "降序",
                SortTypeImage = new FontImageSource() { FontFamily = "FontAwesome", Color = Color.Black, Glyph = Util_Font.FontAwesomeIcons.SortAlphaDown },
                // DirectionImage = new FontImageSource() { FontFamily = "FontAwesome", Color = Color.Black, Glyph = Util_Font.FontAwesomeIcons.ArrowDown, Size = 10d }
                Comparer = new Util_Comparer.MyStrLogicalComparer()
            });

            l.Add(new FileSort("Extension", SortDirection.Descending)
            {
                DisplayName = "降序",
                SortTypeImage = new FontImageSource() { FontFamily = "FontAwesome", Color = Color.Black, Glyph = Util_Font.FontAwesomeIcons.Tag },
                DirectionImage = new FontImageSource() { FontFamily = "FontAwesome", Color = Color.Black, Glyph = Util_Font.FontAwesomeIcons.ArrowDown, Size = 10d }
            });

            l.Add(new FileSort("FileLength", SortDirection.Descending)
            {
                DisplayName = "降序",
                SortTypeImage = new FontImageSource() { FontFamily = "FontAwesome", Color = Color.Black, Glyph = Util_Font.FontAwesomeIcons.ChartPieAlt },
                DirectionImage = new FontImageSource() { FontFamily = "FontAwesome", Color = Color.Black, Glyph = Util_Font.FontAwesomeIcons.ArrowDown, Size = 10d }
            });

            l.Add(new FileSort("LastWriteTime", SortDirection.Descending)
            {
                DisplayName = "降序",
                SortTypeImage = new FontImageSource() { FontFamily = "FontAwesome", Color = Color.Black, Glyph = Util_Font.FontAwesomeIcons.Clock },
                DirectionImage = new FontImageSource() { FontFamily = "FontAwesome", Color = Color.Black, Glyph = Util_Font.FontAwesomeIcons.ArrowDown, Size = 10d }
            });


            this.FileSortList = l;
            this._SelectedFileSort = l[0]; // 赋值给 _SelectedFileSort 暂不执行 SelectedFileSort 里面的查询
        }

        #endregion

        private IList<object> _SelectedItems;
        /// <summary>
        /// 注意 XAML 中, SelectedItems 必须要填写 Mode = TwoWay
        /// </summary>
        public IList<object> SelectedItems
        {
            get { return _SelectedItems; }
            set
            {
                _SelectedItems = value;
                this.OnPropertyChanged();
            }
        }

        #region 操作模式 -- 1.普通模式; 2.选择模式

        public Command CMD_ChangeSelectionMode { get; private set; }

        void changeSelectionModeFake()
        {
            mDebounceAction.Debounce
            (
                interval: mActionIntervalDefault,
                action: () =>
                {
                    Device.BeginInvokeOnMainThread(changeSelectionMode);
                },
                syncInvoke: null
            );
        }

        void changeSelectionMode()
        {
            if (this.SelectionMode == SelectionMode.None)
            {
                this.ItemTemplate = this.SelectModeDataTemplate;
                this.SelectionMode = SelectionMode.Multiple;
                this.SelectBarIsVisible = true;

                if (this.SelectedItems == null)
                {
                    var oc = new ObservableCollection<object>();
                    oc.CollectionChanged += (s, e) => { this.OnPropertyChanged("SelectedItems"); };
                    this.SelectedItems = oc;
                }
                else
                {
                    this.SelectedItems.Clear();
                }
            }
            else
            {
                this.ItemTemplate = this.NormalModeDataTemplate;
                this.SelectionMode = SelectionMode.None;
                this.SelectBarIsVisible = false;
            }
        }

        private SelectionMode _SelectionMode;
        public SelectionMode SelectionMode
        {
            get { return _SelectionMode; }
            set
            {
                _SelectionMode = value;
                this.OnPropertyChanged();
            }
        }

        /// <summary>
        /// 普通模式
        /// </summary>
        public DataTemplate NormalModeDataTemplate { get; private set; }

        /// <summary>
        /// 选择模式
        /// </summary>
        public DataTemplate SelectModeDataTemplate { get; private set; }

        private DataTemplate _ItemTemplate;
        public DataTemplate ItemTemplate
        {
            get { return _ItemTemplate; }
            set
            {
                _ItemTemplate = value;
                this.OnPropertyChanged();
            }
        }

        /// <summary>
        /// 将 XAML 的 DataTemplate 资源传递给 ViewModel
        /// </summary>
        /// <param name="normalMode">普通模式DataTemplate</param>
        /// <param name="selectMode">选择模式DataTemplate</param>
        public void initDataTemplate(DataTemplate normalMode, DataTemplate selectMode)
        {
            if (this.NormalModeDataTemplate == null)
            {
                this.NormalModeDataTemplate = normalMode;
                this.ItemTemplate = this.NormalModeDataTemplate;
            }

            if (this.SelectModeDataTemplate == null)
            {
                this.SelectModeDataTemplate = selectMode;
            }
        }

        public Command CMD_OnSelectionChanged { get; private set; }

        void onSelectionChanged()
        {
            this.OnPropertyChanged("SelectedItemsInfo");
        }

        public string SelectedItemsInfo
        {
            get
            {
                if (this.FilterList == null) return string.Empty;
                if (this.SelectedItems == null) return string.Empty;

                string msg = $"{this.SelectedItems.Count} / {this.FilterList.Count}";
                return msg;
            }
        }

        #endregion

        #region 提交选中文件/文件夹

        public static readonly string MessageTag_ConfirmSelect = "FileExplorer_ConfirmSelect";

        /// <summary>
        /// 提交选中文件/文件夹
        /// </summary>
        public Command CMD_ConfirmSelect { get; set; }

        void confirmSelectFake()
        {
            mDebounceAction.Debounce
            (
                interval: mActionIntervalDefault,
                action: () =>
                {
                    Device.BeginInvokeOnMainThread(confirmSelect);
                },
                syncInvoke: null
            );
        }

        void confirmSelect()
        {
            if (this.SelectedItems == null || this.SelectedItems.Count <= 0)
            {
                Acr.UserDialogs.UserDialogs.Instance.Toast("提交失败（请勾选需要提交的文件或文件夹）。");
                return;
            }

            var msg = Util.JsonUtils.SerializeObjectWithFormatted(this.SelectedItems);
            MessagingCenter.Send<FileExplorer_ViewModel, string>
            (
                sender: this,
                message: FileExplorer_ViewModel.MessageTag_ConfirmSelect,
                args: msg
            );
        }

        #endregion

        #region 选择模式 导航栏 (上方)

        private bool _SelectBarIsVisible;
        public bool SelectBarIsVisible
        {
            get { return _SelectBarIsVisible; }
            set
            {
                _SelectBarIsVisible = value;
                this.OnPropertyChanged();
            }
        }

        #region 反选

        public Command CMD_Reverse { get; private set; }

        void reverseFake()
        {
            mDebounceAction.Debounce
            (
                interval: mActionIntervalDefault,
                action: () =>
                {
                    Device.BeginInvokeOnMainThread(reverse);
                },
                syncInvoke: null
            );
        }

        void reverse()
        {
            System.Diagnostics.Debug.WriteLine("点击反选");

            if (this.SelectedItems == null)
            {
                this.SelectedItems = new List<object>();
                foreach (var item in this.FilterList)
                {
                    this.SelectedItems.Add(item);
                }
            }
            else
            {
                var toSelectList = this.FilterList.Except<FileInfoModel>(this.SelectedItems.Select(i => (FileInfoModel)i)).ToList();
                this.SelectedItems.Clear();
                foreach (var item in toSelectList)
                {
                    this.SelectedItems.Add(item);
                }
            }

            this.OnPropertyChanged("SelectedItems");
        }

        #endregion

        #region 全选

        public Command CMD_CheckAll { get; private set; }

        void checkAllFake()
        {
            mDebounceAction.Debounce
            (
                interval: mActionIntervalDefault,
                action: () =>
                {
                    Device.BeginInvokeOnMainThread(checkAll);
                },
                syncInvoke: null
            );
        }

        void checkAll()
        {
            System.Diagnostics.Debug.WriteLine("点击全选");

            if (this.SelectedItems == null)
            {
                this.SelectedItems = new List<object>();
            }
            else
            {
                this.SelectedItems.Clear();
            }

            foreach (var item in this.FilterList)
            {
                this.SelectedItems.Add(item);
            }

            this.OnPropertyChanged("SelectedItems");
        }

        #endregion

        #endregion

        // 选择模式 工具栏 (下方) -- 复制 / 剪切 / 删除 / 重命名 / 更多
        #region 复制剪贴

        private bool _IsCopyCutMode;
        /// <summary>
        /// 复制剪贴模式
        /// </summary>
        public bool IsCopyCutMode
        {
            get { return _IsCopyCutMode; }
            set
            {
                _IsCopyCutMode = value;
                this.OnPropertyChanged();
            }
        }

        private bool _IsCopy;
        /// <summary>
        /// 复制 true ; 剪切 false
        /// </summary>
        public bool IsCopy
        {
            get { return _IsCopy; }
            set
            {
                _IsCopy = value;
                this.OnPropertyChanged();
            }
        }


        public Command CMD_Tap_Copy { get; private set; }

        void tapCopyFake()
        {
            mDebounceAction.Debounce
            (
                interval: mActionIntervalDefault,
                action: () =>
                {
                    Device.BeginInvokeOnMainThread(tapCopy);
                },
                syncInvoke: null
            );
        }


        void tapCopy()
        {
            if (this.SelectedItems == null || this.SelectedItems.Count <= 0)
            {
                // Acr.UserDialogs.UserDialogs.Instance.Toast("未勾选需要复制的文件或文件夹。");
                return;
            }

            this.HandleBackButtonPress(); // 退出多选模式, 

            this.IsCopyCutMode = true; // 进入复制剪切模式
            this.IsCopy = true;
        }

        public Command CMD_Tap_Cut { get; private set; }

        void tapCutFake()
        {
            mDebounceAction.Debounce
            (
                interval: mActionIntervalDefault,
                action: () =>
                {
                    Device.BeginInvokeOnMainThread(tapCut);
                },
                syncInvoke: null
            );
        }

        void tapCut()
        {
            if (this.SelectedItems == null || this.SelectedItems.Count <= 0)
            {
                // Acr.UserDialogs.UserDialogs.Instance.Toast("未勾选需要剪切的文件或文件夹。");
                return;
            }

            this.HandleBackButtonPress(); // 退出多选模式, 

            this.IsCopyCutMode = true; // 进入复制剪切模式
            this.IsCopy = false;
        }

        public Command CMD_Tap_Paste { get; private set; }

        void tapPasteFake()
        {
            mDebounceAction.Debounce
            (
                interval: mActionIntervalDefault,
                action: () =>
                {
                    Device.BeginInvokeOnMainThread(tapPaste);
                },
                syncInvoke: null
            );
        }

        async void tapPaste()
        {
            if (this.IsCopy) // 复制
            {
                foreach (FileInfoModel item in this.SelectedItems)
                {
                    if (item.IsDirectory)
                    {
                        var copyFrom = new DirectoryInfo(item.Directory);
                        var pasteTo = new DirectoryInfo(System.IO.Path.Combine(this.CurrentDirectoryInfo.FullName, copyFrom.Name));
                        DirectoryCopy(copyFrom.FullName, pasteTo.FullName, true);
                    }
                    else
                    {
                        var copyFrom = new FileInfo(item.FullName);
                        var pasteTo = new FileInfo(System.IO.Path.Combine(this.CurrentDirectoryInfo.FullName, copyFrom.Name));

                        if (pasteTo.Exists == true)
                        {
                            bool copy = await overwriteView(copyFrom, pasteTo);
                            if (copy == false)
                            {
                                continue;
                            }
                        }

                        File.Copy(copyFrom.FullName, pasteTo.FullName, true);
                    }
                }
            }
            else // 剪切
            {
                foreach (FileInfoModel item in this.SelectedItems)
                {
                    if (item.IsDirectory)
                    {
                        DirectoryInfo cutFrom = new DirectoryInfo(item.Directory);
                        DirectoryInfo pasteTo = new DirectoryInfo(System.IO.Path.Combine(this.CurrentDirectoryInfo.FullName, cutFrom.Name));
                        Directory.Move(cutFrom.FullName, pasteTo.FullName);
                    }
                    else
                    {
                        var cutFrom = new FileInfo(item.FullName);
                        var pasteTo = new FileInfo(System.IO.Path.Combine(this.CurrentDirectoryInfo.FullName, cutFrom.Name));

                        if (pasteTo.Exists == true)
                        {
                            bool copy = await overwriteView(cutFrom, pasteTo);
                            if (copy == false)
                            {
                                continue;
                            }
                            File.Delete(pasteTo.FullName);
                        }

                        File.Move(cutFrom.FullName, pasteTo.FullName);
                    }
                }
            }

            this.IsCopyCutMode = false;
            refresh();
        }

        /// <summary>
        /// 文件夹拷贝
        /// </summary>
        /// <param name="sourceDirName"></param>
        /// <param name="destDirName"></param>
        /// <param name="copySubDirs"></param>
        async void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
            // If the destination directory doesn't exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo copyFrom in files)
            {
                var pasteTo = new FileInfo(Path.Combine(destDirName, copyFrom.Name));

                if (pasteTo.Exists == true)
                {
                    bool copy = await overwriteView(copyFrom, pasteTo);
                    if (copy == false)
                    {
                        continue;
                    }
                }

                File.Copy(copyFrom.FullName, pasteTo.FullName, true);
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }

        /// <summary>
        /// 覆盖询问
        /// </summary>
        /// <param name="source"></param>
        /// <param name="dest"></param>
        /// <returns></returns>
        Task<bool> overwriteView(FileInfo source, FileInfo dest)
        {
            var dateTimeTemplate = "yyyy-MM-dd HH:mm:ss.fffffff";
            var msg = $"同名文件已存在, 是否覆盖\r\n{source.Name}\r\n源文件:{source.FullName}\r\n大小:{Util.IO.FileUtils.GetFileLengthInfo(source.Length)}\r\n修改时间:{source.LastWriteTime.ToString(dateTimeTemplate)}\r\n\r\n";
            msg += $"目标文件:{dest.FullName}\r\n大小:{Util.IO.FileUtils.GetFileLengthInfo(dest.Length)}\r\n修改时间:{dest.LastWriteTime.ToString(dateTimeTemplate)}\r\n\r\n";

            return Acr.UserDialogs.UserDialogs.Instance.ConfirmAsync(new ConfirmConfig()
            {
                Title = "覆盖",
                Message = msg,
                OkText = "覆盖",
                CancelText = "跳过"
            });
        }

        #endregion

        #region 复制粘贴模式 - 新建 & 取消

        public Command CMD_CopyCutMode_CreateDir { get; private set; }

        // 直接在 Command 实例化时指定了 CopyCutMode_CreateDir
        void copyCutMode_CreateDirFake()
        {
            mDebounceAction.Debounce
            (
                interval: mActionIntervalDefault,
                action: () =>
                {
                    Device.BeginInvokeOnMainThread(createFolderPrompt);
                },
                syncInvoke: null
            );
        }

        public Command CMD_ExitCopyCutMode { get; private set; }

        void exitCopyCutModeFake()
        {
            mDebounceAction.Debounce
            (
                interval: mActionIntervalDefault,
                action: () =>
                {
                    Device.BeginInvokeOnMainThread(exitCopyCutMode);
                },
                syncInvoke: null
            );
        }

        void exitCopyCutMode()
        {
            this.IsCopyCutMode = false;
        }

        #endregion

        #region 删除

        public Command CMD_Tap_Delete { get; private set; }

        void tapDeleteFake()
        {
            mDebounceAction.Debounce
            (
                interval: mActionIntervalDefault,
                action: () =>
                {
                    Device.BeginInvokeOnMainThread(tapDelete);
                },
                syncInvoke: null
            );
        }

        void tapDelete()
        {
            if (this.SelectedItems == null || this.SelectedItems.Count == 0)
            {
                return;
            }

            string msg = string.Empty;

            if (this.SelectedItems.Count == 1)
            {

                var toDelete = (FileInfoModel)this.SelectedItems[0];
                if (toDelete.IsDirectory)
                {
                    msg = $"确认删除文件夹:{toDelete.Info}?\r\n包含 {toDelete.Info2}"; // TODO 深入递归文件夹内所有文件
                }
                else
                {
                    msg = $"确认要删除 {toDelete.Info}? \r\n大小 : {toDelete.Info2}";
                }
            }

            if (this.SelectedItems.Count > 1)
            {
                var toDelete = (FileInfoModel)this.SelectedItems[0];
                msg = $"确认删除 {toDelete.Info} ...( {this.SelectedItems.Count} 项 )?"; // TODO 深入递归文件夹内所有文件
            }

            Acr.UserDialogs.UserDialogs.Instance.Confirm(new Acr.UserDialogs.ConfirmConfig()
            {
                Title = "删除",
                Message = msg,
                OkText = "确定",
                CancelText = "取消",
                OnAction = ((r) =>
                {
                    if (r == true)
                    {
                        foreach (FileInfoModel item in this.SelectedItems)
                        {
                            if (item.IsDirectory)
                            {
                                Directory.Delete(item.Directory, recursive: true);
                            }
                            else
                            {
                                File.Delete(item.FullName);
                            }
                        }

                        this.SelectedItems.Clear();
                        refresh();

                        Acr.UserDialogs.UserDialogs.Instance.Toast("删除文件已成功");
                        this.HandleBackButtonPress();
                    }
                })
            });
        }

        #endregion

        #region 重命名

        public Command CMD_Tap_Rename { get; private set; }

        void tapRenameFake()
        {
            mDebounceAction.Debounce
            (
                interval: mActionIntervalDefault,
                action: () =>
                {
                    Device.BeginInvokeOnMainThread(tapRename);
                },
                syncInvoke: null
            );
        }

        void tapRename()
        {
            if (this.SelectedItems == null || this.SelectedItems.Count == 0)
            {
                return;
            }

            string msg = string.Empty;

            if (this.SelectedItems.Count == 1)
            {
                var toRename = (FileInfoModel)this.SelectedItems[0];

                #region 重命名文件

                if (toRename.IsDirectory == false)
                {
                    Acr.UserDialogs.UserDialogs.Instance.Prompt(new Acr.UserDialogs.PromptConfig()
                    {
                        Title = "文件重命名",
                        Message = string.Empty,
                        InputType = Acr.UserDialogs.InputType.Default,
                        Text = toRename.Info,
                        OkText = "确定",
                        CancelText = "取消",
                        OnAction = ((r) =>
                        {
                            if (r.Ok)
                            {
                                try
                                {
                                    FileInfo moveToNewPath = new FileInfo(System.IO.Path.Combine(toRename.Directory, r.Text));

                                    if (moveToNewPath.Exists == true)
                                    {
                                        throw new BusinessException($"重命名失败。错误原因：文件已存在。\r\n{moveToNewPath.FullName}");
                                    }

                                    if (moveToNewPath.Directory.Exists == false)
                                    {
                                        System.IO.Directory.CreateDirectory(moveToNewPath.Directory.FullName);
                                    }

                                    File.Move(toRename.FullName, moveToNewPath.FullName);
                                    this.SelectedItems.Clear();
                                    this.HandleBackButtonPress();
                                    this.refresh();

                                    Acr.UserDialogs.UserDialogs.Instance.Toast("重命名成功");
                                }
                                catch (Exception ex)
                                {
                                    Acr.UserDialogs.UserDialogs.Instance.Alert(new AlertConfig()
                                    {
                                        Title = "捕获异常",
                                        Message = ex.GetInfo(),
                                        OkText = "确认",
                                        // OnAction = () => { }
                                    });
                                }
                            }
                        })
                    });
                }

                #endregion

                #region 重命名文件夹

                if (toRename.IsDirectory == true)
                {
                    Acr.UserDialogs.UserDialogs.Instance.Prompt(new Acr.UserDialogs.PromptConfig()
                    {
                        Title = "文件夹重命名",
                        Message = string.Empty,
                        InputType = Acr.UserDialogs.InputType.Default,
                        Text = toRename.Info,
                        OkText = "确定",
                        CancelText = "取消",
                        OnAction = ((r) =>
                        {
                            if (r.Ok)
                            {
                                try
                                {
                                    DirectoryInfo moveToNewDir = new DirectoryInfo(System.IO.Path.Combine(new DirectoryInfo(toRename.Directory).Parent.FullName, r.Text));
                                    if (moveToNewDir.Exists)
                                    {
                                        throw new BusinessException($"重命名失败。错误原因：文件夹已存在。\r\n{moveToNewDir.FullName}");
                                    }

                                    Directory.Move(toRename.Directory, moveToNewDir.FullName);

                                    this.SelectedItems.Clear();
                                    this.HandleBackButtonPress();
                                    this.refresh();

                                    Acr.UserDialogs.UserDialogs.Instance.Toast("重命名成功");
                                }
                                catch (Exception ex)
                                {
                                    Acr.UserDialogs.UserDialogs.Instance.Alert(new AlertConfig()
                                    {
                                        Title = "捕获异常",
                                        Message = ex.GetInfo(),
                                        OkText = "确认",
                                        // OnAction = () => { }
                                    });

                                    System.Diagnostics.Debugger.Break();
                                }
                            }
                        })
                    });
                }

                #endregion
            }

            if (this.SelectedItems.Count > 1)
            {
                // TODO 实现批量重命名功能
                Acr.UserDialogs.UserDialogs.Instance.Alert(new AlertConfig()
                {
                    Title = "捕获异常",
                    Message = "敬请期待批量重命名的实现",
                    OkText = "确认",
                    // OnAction = () => { } 
                });
            }
        }

        #endregion

        

        #region INotifyPropertyChanged成员

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = "")
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}