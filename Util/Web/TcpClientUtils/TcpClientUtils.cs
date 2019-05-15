using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Util.Web
{
    public class TcpClientUtils
    {
        /// <summary>
        /// 大多数文件系统都配置为使用4096或8192的块大小。
        /// 理论上，如果配置缓冲区大小使得读取比磁盘块多几个字节，
        /// 则使用文件系统的操作可能效率极低（即，如果您将缓冲区配置为一次读取4100个字节，
        /// 每次读取将需要文件系统进行2次块读取。如果块已经在缓存中，
        /// 那么你最终会支付RAM的价格 - > L3 / L2缓存延迟。
        /// 如果你运气不好并且块还没有缓存，那么你也需要支付磁盘 - > RAM延迟的价格。
        /// </summary>
        public static int s_BufferSize
        {
            get
            {
                return 8192;
            }
        }

        public static char s_StartChar
        {
            get
            {
                return (char)0x02;
            }
        }

        public static char s_EndChar
        {
            get
            {
                return (char)0x03;
            }
        }

        /// <summary>
        /// 接收
        /// </summary>
        /// <param name="tcpClient"></param>
        /// <param name="encoding">默认UTF8</param>
        /// <returns></returns>
        public static string Receive(System.Net.Sockets.TcpClient tcpClient, System.Text.Encoding encoding = null)
        {
            string r = string.Empty;

            using (System.IO.MemoryStream msContent = new System.IO.MemoryStream())
            {
                int totalBytesRead = 0; // 读取总长度 -- 用于累积超出 s_BufferSize 时
                int startCharIndex = -1;
                int endCharIndex = -1;


                byte[] buffOfNetworkStream = new byte[s_BufferSize];
                int lastestBytesRead = 0; // 当前读取总长度

                System.Net.Sockets.NetworkStream networkStream = tcpClient.GetStream();

                lastestBytesRead = networkStream.Read(buffOfNetworkStream, 0, s_BufferSize);
                totalBytesRead = totalBytesRead + lastestBytesRead;

                // 定位 StartChar
                for (int i = 0; i < buffOfNetworkStream.Length; i++)
                {
                    if (s_StartChar == Convert.ToChar(buffOfNetworkStream[i]))
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

                if (encoding != null)
                {
                    r = encoding.GetString(contentByteArr, 0, contentByteArr.Length);
                }
                else
                {
                    r = Encoding.UTF8.GetString(contentByteArr, 0, contentByteArr.Length);
                }

                // 定位 EndChar
                endCharIndex = r.IndexOf(s_EndChar);
                if (endCharIndex < 0)
                {
                    throw new Exception("缺少(Char)End");
                }

                r = r.Substring(0, endCharIndex);

                // 释放
                networkStream = null;

                return r;
            }
        }

        /// <summary>
        /// 发送
        /// </summary>
        /// <param name="tcpClient"></param>
        /// <param name="toSend">发送内容</param>
        /// <param name="encoding">默认UTF-8</param>
        public static void Send(System.Net.Sockets.TcpClient tcpClient, string toSend, System.Text.Encoding encoding = null)
        {
            if (tcpClient == null)
            {
                return;
            }

            if (tcpClient.Connected == false)
            {
                return;
            }

            System.Net.Sockets.NetworkStream ns = tcpClient.GetStream();

            // 内容转换
            byte[] strBuffer = null;
            if (encoding != null)
            {
                strBuffer = encoding.GetBytes(toSend);
            }
            else
            {
                strBuffer = Encoding.UTF8.GetBytes(toSend);
            }

            // 发送
            TcpClientModel socketModel = new Util.Web.TcpClientModel(strBuffer);
            byte[] buffer = socketModel.ToByteArray();
            ns.Write(buffer, 0, buffer.Length);

            buffer = null;
        }
    }
}
