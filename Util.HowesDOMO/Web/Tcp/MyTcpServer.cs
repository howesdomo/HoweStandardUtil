using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Util.Web
{
    /// <summary>
    /// V 1.0.11 - 2021-03-15 10:32:12
    /// 修复 Send 与 StandardSend Encoding 参数的错误调用
    /// 
    /// V 1.0.10 - 2021-03-08 14:30:00
    /// 1 修复Bug : 属性  (System.Threading.ManualResetEvent) mTcpListen_AutoSetEvent 改为非静态属性
    /// 在一个项目中启用多个 MyTcpClient 实例时, 静态的 (System.Threading.ManualResetEvent) mTcpListen_AutoSetEvent 属性
    /// 会导致不同实例的读取时机错乱
    /// 2 SendMethods 修改参数 bool isShowSendContent 改为 bool?, 新增参数 Encoding 用于发送与 mSendEncoding 不相同的编码的数据
    /// 
    /// V 1.0.9
    /// 1 服务器发送信息优化为 并行foreach
    /// 2 增加 Send byte[]
    /// 3 发送信息增加参数 isShowSendContent
    /// 4 TaskReceive 设置为 LongRunning
    /// 
    /// V 1.0.8
    /// StartServer 指定IP地址的情况下, 增加2个成功校验的情况 ( localhost 与 127.0.0.1 )
    /// 
    /// V 1.0.7
    /// Receive 方法中增加对 Socket 状态的判断
    /// 
    /// V 1.0.6
    /// 1 优化标准接收时清理空出来的Byte
    /// 2 增强校验, 发送信息前校验服务状态
    /// 3 增加属性 IsServerStart
    /// 4 同步接收信息时候 和 状态日志时间
    /// 
    /// V 1.0.5
    /// 在 .net framework 4.0 上测试, 根据测试时遇到的情况修改了对应的代码
    /// 
    /// V 1.0.4
    /// 修复接收时出现异常后无法继续接受信息的bug
    /// 
    /// V 1.0.3
    /// 取消有关 Xamarin.Forms 的代码 ( 删除 Xamarin.Essentials.MainThread.BeginInvokeOnMainThread ), 使本类可以更好地迁移到 .net Standard 上
    /// 
    /// V 1.0.2
    /// 取消单例模式
    /// 在构造函数中提供接收模式的设置 ( 默认使用Howe自定义接收方式 )
    /// 
    /// V 1.0.1
    /// 优化异步方法的 继续 & 停止
    /// 
    /// V 1.0.0
    /// 首次创建
    /// </summary>
    public class MyTcpServer
    {
        /// <summary>
        /// TcpClient 的接收方式 默认采用 Howe 自定义的接收
        /// true: 默认接收; false: 自定义接收
        /// </summary>
        public bool mIsStandardReceive { get; set; } = false;

        public MyTcpServer()
        {
            initTimer();
        }

        public MyTcpServer(bool isStandardReceive)
        {
            this.mIsStandardReceive = isStandardReceive;
            initTimer();
        }

        //定义Socket对象
        TcpListener mTcpListener { get; set; }

        /// <summary>
        /// 服务已开启
        /// </summary>
        public bool IsServerStart
        {
            get
            {
                return mTcpListener != null;
            }
        }

        //定义监听线程
        Task mTaskListen { get; set; }

        public Encoding mSendEncoding { get; set; }

        public Encoding mReceiveEncoding { get; set; }

        ////定义接收客户端数据线程
        //Task taskReceive { get; set; }

        // 定义双方通信
        LinkedList<StateObject> mRemoteClientLinkedList { get; set; } = new LinkedList<StateObject>();

        private string _IP;
        public string IP
        {
            get { return _IP; }
            set { _IP = value; }
        }

        private int _Port;
        public int Port
        {
            get { return _Port; }
            set { _Port = value; }
        }

        private string mPatternIPV4
        {
            get
            {
                return "(?<=(\\b|\\D))(((\\d{1,2})|(1\\d{2})|(2[0-4]\\d)|(25[0-5]))\\.){3}((\\d{1,2})|(1\\d{2})|(2[0-4]\\d)|(25[0-5]))(?=(\\b|\\D))";
            }
        }

        private string mServerHeadInfo;

        public void StartServer(string argsIP = "", string argsPort = "48001")
        {
            if (mTcpListener != null)
            {
                return;
            }

            mTcpListen_WhileArgs = true;

            string msg = string.Empty;

            IPAddress ip = null;

            #region IP

            if (argsIP.IsNullOrWhiteSpace() == true) // 匹配 IPV4
            {
                // 采用以下代码获取本机 IP 地址
                var ipAddressList = Dns.GetHostAddresses(Dns.GetHostName()).ToList();
                foreach (IPAddress item in ipAddressList)
                {
                    if (Regex.IsMatch(item.ToString(), mPatternIPV4, RegexOptions.IgnoreCase)) // 匹配 IPV4
                    {
                        ip = item;
                        break;
                    }
                }

                if (ip == null)
                {
                    throw new ArgumentNullException("匹配 IPV4 失败。");
                }
            }
            else // 寻找输入的 IP
            {
                ip = Dns.GetHostAddresses(Dns.GetHostName()).FirstOrDefault(i => i.ToString() == argsIP);

                if (ip == null)
                {
                    if (argsIP == "localhost" || argsIP == "127.0.0.1")
                    {
                        ip = IPAddress.Parse(argsIP);
                    }
                    else
                    {
                        throw new ArgumentNullException($"输入IP地址有误。{argsIP} 不在 Dns.GetHostName() 返回结果中");
                    }
                }
            }

            #endregion

            int port = Convert.ToInt32(argsPort);

            mServerHeadInfo = $"TcpServer({ip}:{port})";
            msg = $"{mServerHeadInfo}: MyTcpServer正在启动...";
            onStatusChange(msg);

            TcpListener tcpListener = new TcpListener(ip, port);
            tcpListener.Start();

            msg = $"{mServerHeadInfo}: TcpListener已启动";
            onStatusChange(msg);

            mTaskListen = new Task(() => { ListenClientConnect(); });
            mTaskListen.ContinueWith((task) =>
            {
                if (task.Exception != null)
                {
                    onStatusChange($"{task.Exception.GetFullInfo()}", Util.UIModel.ConsoleMsgType.ERROR);
                    System.Diagnostics.Debugger.Break();
                }

                string taskListenMsg = "监听服务已完成，完成时状态为：";
                taskListenMsg = taskListenMsg + string.Format("IsCanceled={0}\nIsCompleted={1}\nIsFaulted={2};",
                                    task.IsCanceled,  // 因被取消而完成
                                    task.IsCompleted, // 成功完成
                                    task.IsFaulted    // 因发生异常而完成
                                    );

                System.Diagnostics.Debug.WriteLine(taskListenMsg);
                onStatusChange($"{mServerHeadInfo}: 监听服务已停止");
            });

            mTaskListen.Start();

            msg = $"{mServerHeadInfo}: 监听客户端连接服务已启动";
            onStatusChange(msg);

            // UI
            IP = ip.ToString();
            Port = port;

            startTimer();
            msg = $"{mServerHeadInfo}: 定时检查客户端连接状态服务已启动";
            onStatusChange(msg);

            // 呼应 StopServer 最后一句
            mTcpListener = tcpListener; // StartServer 的最后一步 必定是 mTcpListener = Xxx;           

            msg = $"{mServerHeadInfo}: MyTcpServer启动完毕";
            onStatusChange(msg);
        }

        bool mTcpListen_WhileArgs { get; set; }

        // 2021-03-08 不能采用静态, 创建多个实例时, 会令到读取的控制混乱
        // public static System.Threading.ManualResetEvent mTcpListen_AutoSetEvent = new System.Threading.ManualResetEvent(false);
        public System.Threading.ManualResetEvent mTcpListen_AutoSetEvent { get; set; } = new System.Threading.ManualResetEvent(false);

        // 监听
        private void ListenClientConnect()
        {
            while (mTcpListen_WhileArgs)
            {
                if (mTcpListener == null)
                {
                    System.Threading.Thread.Sleep(200);
                }
                else
                {
                    mTcpListen_AutoSetEvent.Reset();

                    mTcpListener.BeginAcceptTcpClient(new AsyncCallback(AcceptTcpClient_AsyncCallBack), mTcpListener);

                    mTcpListen_AutoSetEvent.WaitOne();
                }
            }
        }

        void AcceptTcpClient_AsyncCallBack(IAsyncResult ar)
        {
            TcpListener tcpListener = (TcpListener)ar.AsyncState;
            TcpClient remoteClient = null;

            try
            {
                remoteClient = tcpListener.EndAcceptTcpClient(ar);
            }
            catch (Exception ex)
            {
                if (mTcpListen_WhileArgs == false) // 手动停止服务
                {
                    return;
                }
                // 其他情况
                else
                {
                    onStatusChange($"{ex.GetFullInfo()}", Util.UIModel.ConsoleMsgType.ERROR);
                    System.Diagnostics.Debugger.Break();
                    return;
                }
            }

            mTcpListen_AutoSetEvent.Set();
            mRemoteClientLinkedList.AddLast(new StateObject(remoteClient));

            string msg = $"{mServerHeadInfo}: Client Connected! Local:{remoteClient.Client.LocalEndPoint} <-- Client:{remoteClient.Client.RemoteEndPoint}";
            onStatusChange(msg);

            // 创建线程循环接收客户端发送的数据
            Task taskReceive = new Task(() => Receive(new StateObject(remoteClient)), TaskCreationOptions.LongRunning);
            taskReceive.ContinueWith((task) =>
            {
                if (task.Exception != null)
                {
                    onStatusChange($"{task.Exception.GetFullInfo()}", Util.UIModel.ConsoleMsgType.ERROR);
                    System.Diagnostics.Debugger.Break();
                }

                string taskReceiveMsg = "taskReceive 任务完成，完成时状态为：";
                taskReceiveMsg = taskReceiveMsg + string.Format("IsCanceled={0}\nIsCompleted={1}\nIsFaulted={2};",
                                    task.IsCanceled,  // 因被取消而完成
                                    task.IsCompleted, // 成功完成
                                    task.IsFaulted    // 因发生异常而完成
                                    );

                System.Diagnostics.Debug.WriteLine(taskReceiveMsg);
                taskReceiveMsg = "一个连接断开了";
                onStatusChange(taskReceiveMsg);
            });

            // 传入双方通信socket
            taskReceive.Start();
        }

        public void StopServer()
        {
            Task.Factory.StartNew(stopServerActualMethod);
        }

        private void stopServerActualMethod()
        {
            string msg = string.Empty;

            msg = $"{mServerHeadInfo}: 正在停止监听服务...";
            onStatusChange(msg);

            stopTimer();

            if (mTaskListen != null) // && taskListen.Status == TaskStatus.Running)
            {
                mTcpListen_WhileArgs = false;
                mTcpListen_AutoSetEvent.Set();
            }

            if (mRemoteClientLinkedList.Count > 0)
            {
                foreach (var item in mRemoteClientLinkedList)
                {
                    item.TcpClient_WhileArgs = false;
                    item.TcpClient_AutoSetEvent.Set();
                }
            }

            System.Threading.Thread.Sleep(1000);

            if (this.mTcpListener != null)
            {
                mTcpListener.Stop();
                msg = $"{mServerHeadInfo}: 已停止TcpListener";
                onStatusChange(msg);
            }

            if (mRemoteClientLinkedList.Count > 0)
            {
                foreach (var item in mRemoteClientLinkedList)
                {
                    item.TcpClient.Close();
                }

                mRemoteClientLinkedList.Clear();

                msg = $"{mServerHeadInfo}: 已停止客户端连接";
                onStatusChange(msg);
            }

            mTaskListen = null;

            // 更新 UI 信息
            IP = string.Empty;
            Port = -1;

            // 呼应 StartServer 最后一句
            mTcpListener = null; // StopServer 的最后一步 必定是 mTcpListener = null

            msg = $"{mServerHeadInfo}: 已成功停止TcpServer所有相关服务";
            onStatusChange(msg);
        }

        // 接收客户端数据
        private void Receive(StateObject obj)
        {
            while (obj.TcpClient_WhileArgs)
            {
                obj.TcpClient_AutoSetEvent.Reset();

                if (obj.TcpClient.Client.IsConnectedAdv() == false) { break; }

                new Task(() =>
                {
                    string receiveMsg = string.Empty;
                    try
                    {
                        if (mIsStandardReceive)
                        {
                            receiveMsg = obj.TcpClient.StandardReceive(mReceiveEncoding ?? Encoding.UTF8);
                            // 由于无法提前知晓信息长度, 故需要处理多出来的 \0
                            receiveMsg = receiveMsg.Trim('\0');
                        }
                        else
                        {
                            receiveMsg = obj.TcpClient.Receive(mReceiveEncoding ?? Encoding.UTF8);
                        }

                        // 接收到的内容全是\0, 马上检验当前Socket状态
                        if (receiveMsg.IsNullOrWhiteSpace() == true && obj.TcpClient.Client.IsConnectedAdv() == false) { return; }

                        DateTime receiveDateTime = DateTime.Now;
                        onStatusChange($"从[{obj.TcpClient.Client.RemoteEndPoint}]接收到信息, 信息长度{receiveMsg.Length}, 信息内容:\r\n{receiveMsg}", Util.UIModel.ConsoleMsgType.INFO, receiveDateTime);
                        onReceiveText(new TcpXxxEventArgs(receiveMsg, obj.TcpClient.Client.RemoteEndPoint.ToString(), receiveDateTime));

                        obj.TcpClient_AutoSetEvent.Set();
                    }
                    catch (Exception ex)
                    {
                        if (obj.TcpClient.Client.IsConnectedAdv() == false) // 已断开连接
                        {
                            obj.TcpClient_WhileArgs = false;
                        }
                        else
                        {
                            onStatusChange($"Receive捕获到异常来自{obj.TcpClient.Client.RemoteEndPoint}\r\n{ex.GetFullInfo()}", Util.UIModel.ConsoleMsgType.ERROR);
                            obj.TcpClient_AutoSetEvent.Set();
                        }
                    }
                }).Start();

                obj.TcpClient_AutoSetEvent.WaitOne();
            }
        }

        void handleIsShowSendContent(bool? isShowSendContent, int countSendClient, string sendContent)
        {
            if (isShowSendContent.HasValue == true)
            {
                string statusChangeMsg = $"Send:向 {countSendClient} 个客户端发送信息";
                if (isShowSendContent.Value == true)
                {
                    statusChangeMsg += $"\r\n发送信息:{sendContent}";
                }
                else
                {
                    statusChangeMsg += $"\r\n发送信息长度:{sendContent.Length}";
                }
                onStatusChange(statusChangeMsg);
            }
        }

        public void Send(string sendContent, Encoding encoding = null, bool? isShowSendContent = false)
        {
            if (this.IsServerStart == false)
            {
                onStatusChange("Server服务未启动", UIModel.ConsoleMsgType.ERROR);
                return;
            }

            int countSendClient = 0;
            Parallel.ForEach(mRemoteClientLinkedList, item =>
            {
                var tcpClient = item.TcpClient;

                if (tcpClient.Client.IsConnectedAdv() == false)
                {
                    return;
                }

                if (encoding != null)
                {
                    tcpClient.Send(sendContent, encoding); // 自定义扩展方法
                }
                else
                {
                    tcpClient.Send(sendContent, mSendEncoding ?? Encoding.UTF8); // 自定义扩展方法
                }
                countSendClient = countSendClient + 1;
            });

            handleIsShowSendContent(isShowSendContent, countSendClient, sendContent);
        }

        public void Send(byte[] byteArr, Encoding encodingGetString = null, bool? isShowSendContent = false)
        {
            if (this.IsServerStart == false)
            {
                onStatusChange("Server服务未启动", UIModel.ConsoleMsgType.ERROR);
                return;
            }

            int countSendClient = 0;
            Parallel.ForEach(mRemoteClientLinkedList, item =>
            {
                var tcpClient = item.TcpClient;

                if (tcpClient.Client.IsConnectedAdv() == false)
                {
                    return;
                }

                tcpClient.Send(byteArr); // 自定义扩展方法
                countSendClient = countSendClient + 1;
            });

            if (isShowSendContent.HasValue == true)
            {
                var sendContent = string.Empty;

                if (encodingGetString != null)
                {
                    sendContent = encodingGetString.GetString(byteArr);
                }
                else
                {
                    sendContent = (mSendEncoding ?? Encoding.UTF8).GetString(byteArr);
                }

                handleIsShowSendContent(isShowSendContent, countSendClient, sendContent);
            }
        }

        public void StandardSend(string sendContent, Encoding encoding = null, bool? isShowSendContent = false)
        {
            if (this.IsServerStart == false)
            {
                onStatusChange("Server服务未启动", UIModel.ConsoleMsgType.ERROR);
                return;
            }

            int countSendClient = 0;
            Parallel.ForEach(mRemoteClientLinkedList, item =>
            {
                var tcpClient = item.TcpClient;
                if (tcpClient.Client.IsConnectedAdv() == false)
                {
                    return;
                }

                if (encoding != null)
                {
                    tcpClient.StandardSend(sendContent, encoding); // 自定义扩展方法
                }
                else
                {
                    tcpClient.StandardSend(sendContent, mSendEncoding ?? Encoding.UTF8); // 自定义扩展方法
                }

                countSendClient = countSendClient + 1;
            });

            handleIsShowSendContent(isShowSendContent, countSendClient, sendContent);
        }

        public void StandardSend(byte[] byteArr, Encoding encodingGetString = null, bool? isShowSendContent = false)
        {
            if (this.IsServerStart == false)
            {
                onStatusChange("Server服务未启动", UIModel.ConsoleMsgType.ERROR);
                return;
            }

            int countSendClient = 0;
            Parallel.ForEach(mRemoteClientLinkedList, item =>
            {
                var tcpClient = item.TcpClient;
                if (tcpClient.Client.IsConnectedAdv() == false)
                {
                    return;
                }

                tcpClient.StandardSend(byteArr);
                countSendClient = countSendClient + 1;
            });

            if (isShowSendContent.HasValue == true)
            {
                var sendContent = string.Empty;

                if (encodingGetString != null)
                {
                    sendContent = encodingGetString.GetString(byteArr);
                }
                else
                {
                    sendContent = (mSendEncoding ?? Encoding.UTF8).GetString(byteArr);
                }

                handleIsShowSendContent(isShowSendContent, countSendClient, sendContent);
            }
        }

        #region 定时器

        System.Timers.Timer mTimer { get; set; }

        void initTimer()
        {
            mTimer = new System.Timers.Timer();
            mTimer.Interval = 20 * 1000; // 10 秒
            mTimer.Elapsed += mTimer_Elapsed;
        }

        void startTimer()
        {
            mTimer.Start();
        }

        void stopTimer()
        {
            mTimer.Stop();
        }

        void mTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            string msg = string.Empty;

            try
            {
                msg = $"定时检查客户端连接状态开始...";
                onStatusChange(msg);

                msg = $"当前连接客户端数量 {mRemoteClientLinkedList.Count}";
                onStatusChange(msg);

                if (mRemoteClientLinkedList.Count <= 0)
                {
                    return;
                }

                List<StateObject> toRemove = new List<StateObject>();
                foreach (var item in mRemoteClientLinkedList)
                {
                    if (item.TcpClient.Client.IsConnectedAdv() == false)
                    {
                        // msg = $"检测到有已断开的 TcpClient [{item.TcpClient.GetHashCode()}], Connected : {item.TcpClient.Client.Connected}";
                        msg = $"检测到有已断开的 TcpClient [{item.TcpClient.GetHashCode()}]"; // 使用 TcpClient.Client.Connected 无法正确判断, 故使用 Socket_IsConnectedAdv 方法检查
                        System.Diagnostics.Debug.WriteLine(msg);
                        toRemove.Add(item);
                    }
                }

                msg = $"定时检查客户端连接状态结果共 {toRemove.Count} 个断开连接";
                onStatusChange(msg);

                if (toRemove.Count <= 0)
                {
                    return;
                }

                foreach (var item in toRemove)
                {
                    item.TcpClient_WhileArgs = false;
                    item.TcpClient_AutoSetEvent.Set();
                }

                System.Threading.Thread.Sleep(1000);

                foreach (var item in toRemove)
                {
                    msg = $"移除断开 TcpClient [{item.TcpClient.GetHashCode()}]"; // 其实已经断开了, 这里只是从List中移除走
                    mRemoteClientLinkedList.Remove(item);

                    onStatusChange(msg);
                }
            }
            finally
            {
                msg = $"定时检查客户端连接状态结束";
                onStatusChange(msg);
            }
        }

        #endregion

        /// <summary>
        /// 设置发送/接收信息编码
        /// </summary>
        /// <param name="e"></param>
        public void SetEncoding(Encoding e1, Encoding e2)
        {
            mSendEncoding = e1;
            mReceiveEncoding = e2;
        }

        /// <summary>
        /// 设置发送/接收信息编码 ( 发送/接收信息编码相同 )
        /// </summary>
        /// <param name="e"></param>
        public void SetEncoding(Encoding e)
        {
            SetEncoding(e, e);
        }

        #region 注册事件 - 服务状态更新时间

        public EventHandler<TcpXxxStatusChangeEventArgs> StatusChange;

        private void onStatusChange(string msg, Util.UIModel.ConsoleMsgType consoleMsgType = Util.UIModel.ConsoleMsgType.INFO, DateTime? entryTime = null)
        {
            System.Diagnostics.Debug.WriteLine(msg);

            bool isConnect = mTcpListener != null;
            int linkClientListCount = 0;
            if (mRemoteClientLinkedList != null) { linkClientListCount = mRemoteClientLinkedList.Count; }

            var args = new TcpXxxStatusChangeEventArgs
            (
                isConnect,
                linkClientListCount,
                consoleMsgType,
                msg,
                entryTime.HasValue ? entryTime.Value : DateTime.Now
            );
            StatusChange?.Invoke(this, args);
        }

        #endregion

        #region 注册事件 - 接收信息

        public EventHandler<TcpXxxEventArgs> ReceiveText;

        private void onReceiveText(TcpXxxEventArgs args)
        {
            ReceiveText?.Invoke(this, args);
        }
        #endregion
    }

    /// <summary>
    /// 用于控制异步方法
    /// </summary>
    public class StateObject
    {
        public StateObject(TcpClient c)
        {
            this.TcpClient = c;
            this.HashCode = c.GetHashCode();
        }

        public TcpClient TcpClient = null;

        public int HashCode { get; set; }

        public bool TcpClient_WhileArgs { get; set; } = true;

        public System.Threading.ManualResetEvent TcpClient_AutoSetEvent { get; set; } = new System.Threading.ManualResetEvent(false);
    }
}
