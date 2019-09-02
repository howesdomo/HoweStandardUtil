using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Util.Web
{
    public class TcpClientModel
    {
        public TcpClientModel()
        {

        }
        public TcpClientModel(byte[] c)
        {
            this.Content = c;
        }

        private int ContentLength
        {
            get
            {
                return Content == null ? 0 : Content.Length;
            }
        }

        public byte[] Content { get; set; }

        public byte[] ToByteArray()
        {
            using (System.IO.MemoryStream memoryStream = new System.IO.MemoryStream()) // 创建内存流
            {
                using (System.IO.BinaryWriter binaryWriter = new System.IO.BinaryWriter(memoryStream)) // 以二进制写入器往这个流里写内容
                {
                    binaryWriter.Write(Util.Web.TcpClientUtils.s_StartChar); // 写入开始符，占1个字节
                    binaryWriter.Write(ContentLength); // 写入实际消息长度，占4个字节

                    if (ContentLength > 0)
                    {
                        binaryWriter.Write(Content); // 写入实际消息内容
                    }

                    binaryWriter.Write(Util.Web.TcpClientUtils.s_EndChar); // 写入结束符，占1个字节
                }

                return memoryStream.ToArray();
            }
        }

    }
}
