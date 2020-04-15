using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Net.Sockets
{
    public static class TcpClientExtension
    {
        /// <summary>
        /// 接收
        /// </summary>
        /// <param name="tcpClient"></param>
        /// <param name="encoding">默认UTF8</param>
        /// <returns></returns>
        public static string Receive(this System.Net.Sockets.TcpClient tcpClient, System.Text.Encoding encoding = null)
        {
            return Util.Web.TcpClientUtils.Receive(tcpClient, encoding);
        }

        /// <summary>
        /// 发送
        /// </summary>
        /// <param name="tcpClient"></param>
        /// <param name="toSend">发送内容</param>
        /// <param name="encoding">默认UTF-8</param>
        public static void Send(this System.Net.Sockets.TcpClient tcpClient, string toSend, System.Text.Encoding encoding = null)
        {
            Util.Web.TcpClientUtils.Send(tcpClient, toSend, encoding);
        }

        /// <summary>
        /// 标准接收
        /// </summary>
        /// <param name="tcpClient"></param>
        /// <param name="encoding">默认UTF8</param>
        /// <returns></returns>
        public static string StandardReceive(this System.Net.Sockets.TcpClient tcpClient, System.Text.Encoding encoding = null)
        {
            return Util.Web.TcpClientUtils.StandardReceive(tcpClient, encoding);
        }

        /// <summary>
        /// 标准发送
        /// </summary>
        /// <param name="tcpClient"></param>
        /// <param name="toSend">发送内容</param>
        /// <param name="encoding">默认UTF-8</param>
        public static void StandardSend(this System.Net.Sockets.TcpClient tcpClient, string toSend, System.Text.Encoding encoding = null)
        {
            Util.Web.TcpClientUtils.StandardSend(tcpClient, toSend, encoding);
        }

        /// <summary>
        /// 标准发送
        /// </summary>
        /// <param name="tcpClient"></param>
        /// <param name="toSend">发送内容</param>
        /// <param name="encoding">默认UTF-8</param>
        public static void StandardSend(this System.Net.Sockets.TcpClient tcpClient, byte[] byteArr)
        {
            Util.Web.TcpClientUtils.StandardSend(tcpClient, byteArr);
        }
    }
}
