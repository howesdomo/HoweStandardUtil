using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
    public class ExceptionInfo
    {
        public ExceptionInfo()
        {

        }

        public ExceptionInfo(Exception ex)
        {
            this.Message = ex.Message;
            this.StackTrace = ex.StackTrace;
            this.FullInfo = ex.GetInfo();
            this.EntryTime = DateTime.Now;
            this.UploadMediaFiles = new List<string>();
        }

        public string Message { get; set; }

        public string StackTrace { get; set; }

        public string FullInfo { get; set; }

        public DateTime EntryTime { get; set; }

        public string DeviceInfo_Json { get; set; }

        public string UserInfo_Json { get; set; }

        public List<string> UploadMediaFiles { get; set; }

    }
}
