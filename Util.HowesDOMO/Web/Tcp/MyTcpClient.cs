using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Util.Web
{
    /// <summary>
    /// V 1.0.9 - 2021-03-08 14:30:00
    /// 1 修复Bug : 属性  (System.Threading.ManualResetEvent) mTcpListen_AutoSetEvent 改为非静态属性
    /// 在一个项目中启用多个 MyTcpClient 实例时, 静态的 (System.Threading.ManualResetEvent) mTcpListen_AutoSetEvent 属性
    /// 会导致不同实例的读取时机错乱
    /// 2 SendMethods 修改参数 bool isShowSendContent 改为 bool?, 新增参数 Encoding 用于发送与 mSendEncoding 不相同的编码的数据
    /// 
    /// V 1.0.8
    /// 1 增加 Send byte[]
    /// 2 发送信息增加参数 isShowSendContent
    /// 3 TaskReceive 设置为 LongRunning
    /// 
    /// V 1.0.7
    /// Receive 方法中增加对 Socket 状态的判断
    /// 
    /// V 1.0.6
    /// 1 增加属性 IsConnectServer
    /// 2 修复BUG 当服务器未开启服务时, 执行 Start() 方法报错捕获
    /// 3 同步接收信息时候 和 状态日志时间
    /// 4 修复BUG, 在标准接收状态下, 当服务器停止服务后, 没有判断服务器状态, 导致不停接收空信息
    /// 
    /// V 1.0.5
    /// 优化标准接收时清理空出来的Byte
    /// 
    /// V 1.0.4
    /// 修复Bug：服务端停止服务, 客户端的接收方法没有处理抛出来的异常导致接收卡死
    /// 
    /// V 1.0.3
    /// 取消有关 Xamarin.Forms 的代码 ( 删除 Xamarin.Essentials.MainThread.BeginInvokeOnMainThread ), 使本类可以更好地迁移到 .net Standard 上
    /// 
    /// V 1.0.2
    /// 取消单例模式
    /// 在构造函数中提供接收模式的设置 ( 默认使用Howe自定义接收方式 )
    /// 
    /// V 1.0.1
    /// 异步等待接收
    /// 
    /// V 1.0.0
    /// 首次创建
    /// </summary>
    public class MyTcpClient
    {
        /// <summary>
        /// TcpClient 的接收方式 默认采用 Howe 自定义的接收
        /// true: 默认接收; false: 自定义接收
        /// </summary>
        public bool mIsStandardReceive { get; set; } = false;

        public MyTcpClient()
        {

        }

        public MyTcpClient(bool isStandardReceive)
        {
            this.mIsStandardReceive = isStandardReceive;
        }

        TcpClient mTcpClient { get; set; }

        /// <summary>
        /// 已连接服务器
        /// </summary>
        public bool IsConnectServer
        {
            get
            {
                bool r = false;
                if (mTcpClient != null && mTcpClient.Client.IsConnectedAdv() == true)
                {
                    r = true;
                }
                return r;
            }
        }

        // 创建接收消息的线程
        Task mTaskReceive { get; set; }

        public Encoding mSendEncoding { get; set; }

        public Encoding mReceiveEncoding { get; set; }

        /// <summary>
        /// 正在连接的服务器地址
        /// </summary>
        private string mServerHeadInfo;
        /// <summary>
        /// 正在连接的服务器地址
        /// </summary>
        public string ServerHeadInfo
        {
            get
            {
                return mServerHeadInfo;
            }
        }

        public void Start(string argsIP, string argsPort)
        {
            Stop();
            string msg = string.Empty;

            try
            {
                IPAddress ip = IPAddress.Parse(argsIP);
                int port = Convert.ToInt32(argsPort);

                mServerHeadInfo = $"服务器地址({ip}:{port})";
                msg = $"{mServerHeadInfo}: MyTcpClient正在启动...";
                onStatusChange(msg);

                // 连接服务端
                mTcpClient = new TcpClient();
                mContinue = true;
                mTcpClient.Connect(ip, port); // 开始侦听

                msg = $"Client : Server Connected!\r\n Local:{mTcpClient.Client.LocalEndPoint} --> Server:{mTcpClient.Client.RemoteEndPoint}";
                onStatusChange(msg);

                // 开启线程不停地接收服务端发送的数据
                // mTaskReceive = new Task(() => ReceiveSync(), TaskCreationOptions.LongRunning); // 同步 (测试能成功读取)
                mTaskReceive = new Task(() => ReceiveAsync(), TaskCreationOptions.LongRunning); // 异步 (默认采用异步方式)

                mTaskReceive.ContinueWith((task) =>
                {
                    if (task.Exception != null)
                    {
                        onStatusChange($"{task.Exception.GetFullInfo()}", Util.UIModel.ConsoleMsgType.ERROR);
                        System.Diagnostics.Debugger.Break();
                    }

                    string taskListenMsg = "服务已完成，完成时状态为：";
                    taskListenMsg = taskListenMsg + string.Format("IsCanceled={0}\nIsCompleted={1}\nIsFaulted={2};",
                                        task.IsCanceled,  // 因被取消而完成
                                        task.IsCompleted, // 成功完成
                                        task.IsFaulted    // 因发生异常而完成
                                        );

                    System.Diagnostics.Debug.WriteLine(taskListenMsg);
                    onStatusChange($"{mServerHeadInfo}: 监听服务已停止");
                });

                if (mCharStartErrorList != null)
                {
                    mCharStartErrorList.Clear();
                    mCharStartErrorList = null;
                }
                mCharStartErrorList = new List<DateTime>();

                mTaskReceive.Start();
            }
            catch (Exception ex)
            {
                mContinue = false;
                mTcpClient = null;

                msg = $"捕获异常:{ex.GetFullInfo()}";
                onStatusChange(msg, UIModel.ConsoleMsgType.ERROR);
            }
        }

        public void Stop()
        {
            onStatusChange($"正在停止TcpClient");

            if (this.IsConnectServer == true)
            {
                mContinue = false;
                mTcpClient.Client.Close();
            }

            mTcpClient = null;
            onStatusChange($"已成功停止TcpClient");
        }

        /// <summary>
        /// 接收数据 (同步处理)
        /// </summary>
        private void ReceiveSync()
        {
            while (mContinue)
            {
                if (mTcpClient.Client.IsConnectedAdv() == false) { break; }

                try
                {
                    string receiveMsg = string.Empty;
                    if (mIsStandardReceive) // 标准接收方式
                    {
                        receiveMsg = mTcpClient.StandardReceive();
                    }
                    else // Howe 自定义接收方式
                    {
                        receiveMsg = mTcpClient.Receive();
                    }

                    // 由于无法提前知晓信息长度, 故需要处理多出来的 \0
                    receiveMsg = receiveMsg.Trim('\0');

                    if (receiveMsg.IsNullOrWhiteSpace() == true && mTcpClient.Client.IsConnectedAdv() == false)
                    {
                        throw new Exception("与服务器已断开连接（可能是服务端已停止服务）");
                    }

                    DateTime receiveDateTime = DateTime.Now;
                    onStatusChange(msg: $"接收到的信息:{receiveMsg}", entryTime: receiveDateTime);
                    onReceiveText(new TcpXxxEventArgs(receiveMsg, mTcpClient.Client.RemoteEndPoint.ToString(), receiveDateTime));
                }
                catch (System.IO.IOException ioException)
                {
                    if (mTcpClient.Connected == false) // 疑问 这里用 Connected 合理???
                    {
                        break;
                    }

                    onStatusChange($"{ioException.GetFullInfo()}");

                    throw ioException;
                }
                catch (Exception ex)
                {
                    string msg = $"{ex.GetFullInfo()}";
                    onStatusChange(msg, Util.UIModel.ConsoleMsgType.ERROR);

                    #region 连续捕获 7 次 相同的异常, 跳出 while 循环 ( 异常估计是由于已与服务器断开连接 )

                    if (System.Text.RegularExpressions.Regex.IsMatch(msg, @"\(Char\)Start"))
                    {
                        mCharStartErrorList.Add(DateTime.Now);
                    }

                    if (mCharStartErrorList.Count >= 10)
                    {
                        int sum = 0;

                        for (int i = mCharStartErrorList.Count; i > 0; i--)
                        {
                            if (mCharStartErrorList[i].Ticks - mCharStartErrorList[i - 1].Ticks < 500)
                            {
                                sum = sum + 1;
                            }
                        }

                        if (sum > 7) { break; }
                    }

                    #endregion
                }
            }
        }

        // 2021-03-08 不能采用静态, 创建多个实例时, 会令到读取的控制混乱
        // public static System.Threading.ManualResetEvent mTcpListen_AutoSetEvent = new System.Threading.ManualResetEvent(false);
        public System.Threading.ManualResetEvent mTcpListen_AutoSetEvent { get; set; } = new System.Threading.ManualResetEvent(false);

        private bool mContinue { get; set; }

        byte[] buffOfNetworkStream;

        string r = string.Empty;

        /// <summary>
        /// 接收数据 (异步处理)
        /// </summary>
        /// <param name="client"></param>
        private void ReceiveAsync()
        {
            while (mContinue)
            {
                mTcpListen_AutoSetEvent.Reset();

                if (mTcpClient.Client.IsConnectedAdv() == false) { break; }

                try
                {
                    NetworkStream stream = mTcpClient.GetStream();
                    buffOfNetworkStream = new byte[Util.Web.TcpClientUtils.s_BufferSize];
                    if (mIsStandardReceive) // 标准接收方式
                    {
                        stream.BeginRead(buffOfNetworkStream, 0, buffOfNetworkStream.Length, ReadCallBack_For_StandardReceive, stream);
                    }
                    else // Howe 自定义接收方式
                    {
                        stream.BeginRead(buffOfNetworkStream, 0, buffOfNetworkStream.Length, ReadCallBack, stream);
                    }
                    mTcpListen_AutoSetEvent.WaitOne();
                }
                catch (Exception e)
                {
                    onStatusChange(msg: e.GetFullInfo(), consoleMsgType: Util.UIModel.ConsoleMsgType.ERROR);
                    mTcpListen_AutoSetEvent.WaitOne();
                }
            }
        }

        private System.IO.MemoryStream mMsContent { get; set; }

        // TODO 遇到很长的信息仍然会出现分开两次接收的情况
        /// <summary>
        /// 接受消息回调 ( Standard Receive )
        /// </summary>
        /// <param name="ar"></param>
        private void ReadCallBack_For_StandardReceive(IAsyncResult ar)
        {
            int totalBytesRead = 0; // 读取总长度 -- 用于累积超出 s_BufferSize 时
            int lastestBytesRead = 0; // 当前读取总长度

            NetworkStream networkStream;
            try
            {
                networkStream = (NetworkStream)ar.AsyncState;

                lastestBytesRead = networkStream.EndRead(ar);
                totalBytesRead = totalBytesRead + lastestBytesRead;

                if (mMsContent == null)
                {
                    mMsContent = new System.IO.MemoryStream();
                }

                // 首次获取写入内容
                mMsContent.Write
                (
                    buffOfNetworkStream,
                    0,
                    lastestBytesRead
                );

                if (networkStream.DataAvailable)
                {
                    return;
                }

                byte[] contentByteArr = mMsContent.GetBuffer();
                r = (mReceiveEncoding ?? Encoding.UTF8).GetString(contentByteArr, 0, contentByteArr.Length);

                // 由于无法提前知晓信息长度, 故需要处理多出来的 \0
                r = r.Trim('\0');

                if (r.IsNullOrWhiteSpace() == true && mTcpClient.Client.IsConnectedAdv() == false)
                {
                    throw new Exception("与服务器已断开连接（可能是服务端已停止服务）");
                }

                DateTime receiveDateTime = DateTime.Now;
                onStatusChange(msg: $"接收到信息: 信息长度{r.Length}", consoleMsgType: Util.UIModel.ConsoleMsgType.INFO, entryTime: receiveDateTime);
                onReceiveText(new TcpXxxEventArgs(r, mTcpClient.Client.RemoteEndPoint.ToString(), receiveDateTime));

                networkStream = null;

                mMsContent.Close();
                mMsContent = null;
            }
            catch (System.IO.IOException ioEx)
            {
                if (mContinue == false) // 用户点击了断开连接, 此时会进入本方法, 但由于稍后会 mTcpClient.Client.Close(), 导致执行
                {
                    // Do nothing
                }
                else
                {
                    // 1. 用户点击了断开连接, 此时会进入本方法, 但由于稍后会 mTcpClient.Client.Close(), 导致执行
                    // 2. 服务器断开了连接
                    mContinue = false;
                    onStatusChange(ioEx.GetFullInfo(), Util.UIModel.ConsoleMsgType.ERROR);
                }
            }
            catch (Exception e)
            {
                // 判断是否与服务器断开了连接
                if (mTcpClient.Client.IsConnectedAdv() == false)
                {
                    mContinue = false;
                    onStatusChange("与服务器已断开连接（可能是服务端已停止服务）", Util.UIModel.ConsoleMsgType.ERROR);
                }
                else
                {
                    onStatusChange(e.GetFullInfo(), Util.UIModel.ConsoleMsgType.ERROR);
                }
            }
            finally
            {
                mTcpListen_AutoSetEvent.Set();
            }
        }

        /// <summary>
        /// 接受消息回调 ( Howe 自定义接收 )
        /// 优点
        /// 1 接收信息头包含信息长度
        /// 2 接收信息有开始符、结束符
        /// </summary>
        /// <param name="ar"></param>
        private void ReadCallBack(IAsyncResult ar)
        {
            int totalBytesRead = 0; // 读取总长度 -- 用于累积超出 s_BufferSize 时
            int startCharIndex = -1;
            int endCharIndex = -1;

            int lastestBytesRead = 0; // 当前读取总长度

            NetworkStream networkStream;
            try
            {
                networkStream = (NetworkStream)ar.AsyncState;

                lastestBytesRead = networkStream.EndRead(ar);
                totalBytesRead = totalBytesRead + lastestBytesRead;

                // 定位 StartChar
                for (int i = 0; i < buffOfNetworkStream.Length; i++)
                {
                    if (Util.Web.TcpClientUtils.s_StartChar == Convert.ToChar(buffOfNetworkStream[i]))
                    {
                        startCharIndex = i;
                        break;
                    }
                }

                if (startCharIndex < 0)
                {
                    throw new Exception("缺少(Char)Start");
                }

                // 获取内容长度 ( int类型, 共 4 个字节 )
                int contentLength = BitConverter.ToInt32(buffOfNetworkStream, startCharIndex + 1); // 内容长度

                System.IO.MemoryStream msContent = new System.IO.MemoryStream();

                // 首次获取写入内容
                msContent.Write
                (
                    buffOfNetworkStream,
                    startCharIndex + 1 + 4, // (Char)Start 起始位置 + 1( (char)Start 1 个字节 ) + 4( 内容长度 4 个字节 )
                    lastestBytesRead - (startCharIndex + 1 + 4)
                );

                while (totalBytesRead <
                   1 + 4 + contentLength + 1) // 1( (char)Start 1 个字节 ) + 4( 内容长度 4 个字节 ) + contentLength ( 读取出来的长度信息 ) + 1( (char)End 1 个字节 )
                {
                    lastestBytesRead = networkStream.Read(buffOfNetworkStream, 0, Util.Web.TcpClientUtils.s_BufferSize); // 再次获取剩余的内容
                    totalBytesRead = totalBytesRead + lastestBytesRead;
                    msContent.Write(buffOfNetworkStream, 0, lastestBytesRead);
                }

                byte[] contentByteArr = msContent.GetBuffer();

                r = (mReceiveEncoding ?? Encoding.UTF8).GetString(contentByteArr, 0, contentByteArr.Length);

                // 定位 EndChar
                endCharIndex = r.IndexOf(Util.Web.TcpClientUtils.s_EndChar);
                if (endCharIndex < 0)
                {
                    throw new Exception("缺少(Char)End");
                }

                r = r.Substring(0, endCharIndex);

                DateTime receiveDateTime = DateTime.Now;
                onStatusChange(msg: $"接收到信息: 信息长度{r.Length}", consoleMsgType: Util.UIModel.ConsoleMsgType.INFO, entryTime: receiveDateTime);
                onReceiveText(new TcpXxxEventArgs(r, mTcpClient.Client.RemoteEndPoint.ToString(), receiveDateTime));

                networkStream = null;

                msContent.Close();
                msContent = null;
            }
            catch (System.IO.IOException ioEx)
            {
                if (mContinue == false) // 用户点击了断开连接, 此时会进入本方法, 但由于稍后会 mTcpClient.Client.Close(), 导致执行
                {
                    // Do nothing
                }
                else
                {
                    // 1. 用户点击了断开连接, 此时会进入本方法, 但由于稍后会 mTcpClient.Client.Close(), 导致执行                    
                    mContinue = false;
                    onStatusChange(ioEx.GetFullInfo(), Util.UIModel.ConsoleMsgType.ERROR);
                }
            }
            catch (Exception e)
            {
                // 判断是否与服务器断开了连接
                if (mTcpClient.Client.IsConnectedAdv() == false)
                {
                    mContinue = false;
                    onStatusChange("与服务器已断开连接（可能是服务端已停止服务）", Util.UIModel.ConsoleMsgType.ERROR);
                }
                else
                {
                    onStatusChange(e.GetFullInfo(), Util.UIModel.ConsoleMsgType.ERROR);
                }

            }
            finally
            {
                mTcpListen_AutoSetEvent.Set();
            }
        }

        private List<DateTime> mCharStartErrorList { get; set; }

        void handleIsShowSendContent(bool? isShowSendContent, string sendContent)
        {
            if (isShowSendContent.HasValue == true)
            {
                if (isShowSendContent.Value == true)
                {
                    onStatusChange($"Send:{sendContent}");
                }
                else
                {
                    onStatusChange($"StandardSend:信息长度{sendContent.Length}");
                }
            }
        }

        public void Send(string sendContent, Encoding encoding = null, bool? isShowSendContent = false)
        {
            if (this.IsConnectServer == false)
            {
                return;
            }

            if (encoding != null)
            {
                mTcpClient.Send(sendContent, encoding);
            }
            else 
            {
                mTcpClient.Send(sendContent, mSendEncoding ?? Encoding.UTF8); // 自定义扩展方法            
            }

            handleIsShowSendContent(isShowSendContent, sendContent);
        }

        public void Send(byte[] byteArr, Encoding encodingGetString = null, bool? isShowSendContent = false)
        {
            if (this.IsConnectServer == false)
            {
                return;
            }

            mTcpClient.Send(byteArr); // 自定义扩展方法

            if (isShowSendContent.HasValue)
            {
                string sendContent = string.Empty;

                if (encodingGetString != null)
                {
                    sendContent = encodingGetString.GetString(byteArr);
                }
                else 
                {
                    sendContent = (mSendEncoding ?? Encoding.UTF8).GetString(byteArr);                
                }

                handleIsShowSendContent(isShowSendContent, sendContent);
            }
        }

        public void StandardSend(string sendContent, Encoding encodingGetString = null, bool? isShowSendContent = false)
        {
            if (this.IsConnectServer == false)
            {
                return;
            }

            mTcpClient.StandardSend(sendContent, mSendEncoding ?? Encoding.UTF8);

            handleIsShowSendContent(isShowSendContent, sendContent);
        }

        public void StandardSend(byte[] byteArr, Encoding encodingGetString = null, bool? isShowSendContent = false)
        {
            if (this.IsConnectServer == false)
            {
                return;
            }

            mTcpClient.StandardSend(byteArr);

            if (isShowSendContent.HasValue)
            {
                string sendContent = string.Empty;
                if (encodingGetString != null)
                {
                    sendContent = encodingGetString.GetString(byteArr);
                }
                else
                {
                    sendContent = (mSendEncoding ?? Encoding.UTF8).GetString(byteArr);
                }

                handleIsShowSendContent(isShowSendContent, sendContent);
            }
        }

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

        #region 注册事件 - 客户端状态更新时间

        public EventHandler<TcpXxxStatusChangeEventArgs> StatusChange;

        private void onStatusChange(string msg, Util.UIModel.ConsoleMsgType consoleMsgType = Util.UIModel.ConsoleMsgType.INFO, DateTime? entryTime = null)
        {
            System.Diagnostics.Debug.WriteLine(msg);

            bool isConnect = mTcpClient != null;
            int linkClientListCount = 0;

            var args = new TcpXxxStatusChangeEventArgs(isConnect, linkClientListCount, consoleMsgType, msg, entryTime.HasValue ? entryTime.Value : DateTime.Now);
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
}
