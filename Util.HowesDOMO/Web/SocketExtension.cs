namespace System.Net.Sockets
{
    /// <summary>
    /// V 1.0.0 - 2019-10-15 10:56:20
    /// 编写 IsConnectedAdv 扩展方法来代替 IsConnected 属性
    /// </summary>
    public static class SocketExtension
    {
        /// <summary>
        /// 代替 Connected 属性, 由于测试发现 Socket 的 Connected 属性在连接断开时仍是 true, ( 测试环境 Xamarin.Forms + Android )
        /// 故写此方法来检测连接状态
        /// 
        /// 在 .net framework 4.0 测试 TcpClient 的 Connected 能正确的反应连接是否正常
        /// </summary>
        /// <param name="socket"></param>
        /// <returns></returns>
        public static bool IsConnectedAdv(this Socket socket)
        {
            // SelectRead
            // 1.如果已调用Listen并且有挂起的连接，则为true。
            // 2.如果有数据可供读取，则为true。
            // 3.如果连接已关闭、重置或终止，则返回true。

            // SelectWrite
            // 1.如果正在处理Connect并且连接已成功，则为true。
            // 2.如果可以发送数据，则返回true。

            // SelectError
            // 1.如果正在处理不阻止的Connect，并且连接已失败，则为true。
            // 2.如果OutOfBandInline未设置，并且带外数据可用，则为true。

            bool r;
            try
            {
                bool r1 = socket.Poll(microSeconds: 1, mode: SelectMode.SelectRead);
                bool r2 = socket.Available == 0; // 若 Socket 存在待接收的数据, 则 Available > 0
                r = !(r1 && r2);
            }
            catch (SocketException)
            {
                r = false;
            }
            return r;
        }
    }
}
