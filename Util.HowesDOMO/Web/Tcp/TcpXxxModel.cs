using System;

namespace Util.Web
{
    /// <summary>
    /// V 1.0.1 - 2020-1-1 12:41:58
    /// 增加 EntryTime
    /// 
    /// V 1.0.0
    /// 首次创建
    /// </summary>
    public class TcpXxxEventArgs : EventArgs
    {
        public TcpXxxEventArgs(string msg)
        {
            this.Msg = msg;
        }

        public TcpXxxEventArgs(string msg, DateTime entryTime)
        {
            this.Msg = msg;
            this.EntryTime = entryTime;
        }

        public TcpXxxEventArgs(string msg, string from, DateTime entryTime)
        {
            this.Msg = msg;
            this.From = from;
            this.EntryTime = entryTime;
        }

        public string Msg { get; private set; }

        public DateTime EntryTime { get; private set; }

        public string From { get; private set; }
    }
}
