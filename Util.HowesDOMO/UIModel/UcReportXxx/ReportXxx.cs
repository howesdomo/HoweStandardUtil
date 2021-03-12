using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Util.UIModel
{
    /// <summary>
    /// 发送信息的报头 OR 终端
    /// 可以配合 WPFControl.dll 的 UcReportXxx 使用
    /// </summary>
    public class ReportXxx : System.ComponentModel.INotifyPropertyChanged
    {
        public ReportXxx(Encoding e)
        {
            this.Encoding = e;
            this.Value = string.Empty;
            this.DisplayName = "无";
            this.HexString = string.Empty;
        }

        public ReportXxx(Encoding e, string value)
        {
            this.Encoding = e;
            this.Value = value;
            this.DisplayName = this.Value.StringShowSpecialSymbol();
            this.HexString = this.Value.ToHexString(e, separator: "");
        }


        private string _Value;
        public string Value
        {
            get { return _Value; }
            set
            {
                _Value = value;
                this.OnPropertyChanged("Value");
            }
        }

        private Encoding _Encoding;
        [Newtonsoft.Json.JsonIgnore]
        public Encoding Encoding
        {
            get { return _Encoding; }
            set
            {
                _Encoding = value;
                this.OnPropertyChanged("Encoding");
            }
        }

        public int EncodingCodePage
        {
            get
            {
                int codePage = -1;
                if (Encoding != null)
                {
                    codePage = this.Encoding.CodePage;
                }
                return codePage;
            }
            set
            {
                this.Encoding = Encoding.GetEncoding(value);
            }
        }

        private string _DisplayName;
        public string DisplayName
        {
            get { return _DisplayName; }
            set
            {
                _DisplayName = value;
                this.OnPropertyChanged("DisplayName");
            }
        }


        private string _HexString;
        public string HexString
        {
            get { return _HexString; }
            set
            {
                _HexString = value;
                this.OnPropertyChanged("HexString");
            }
        }




        public void Update(string strValue)
        {
            this.Value = strValue;
            this.DisplayName = strValue;
            this.HexString = strValue.ToHexString(this.Encoding, separator: "");
        }

        public void UpdateByHexString(string hexValue)
        {
            byte[] byteArr = hexValue.HexString2ByteArray();

            string args = string.Empty;
            if (byteArr != null)
            {
                args = this.Encoding.GetString(byteArr);
            }

            this.Update(args);
        }

        public void UpdateEncoding(Encoding encoding)
        {
            this.Encoding = encoding;
            this.HexString = this.Value.ToHexString(this.Encoding, separator: "");
        }




        #region 获取 ReportHeadList 或者 ReportEndList

        public static List<ReportXxx> GetReportHeadList(Encoding encoding)
        {
            List<ReportXxx> l = new List<ReportXxx>();
            l.Add(new ReportXxx(encoding, string.Empty)
            {
                DisplayName = "无"
            });

            // STX 
            // ASCII 与 UTF8 : 0x02
            l.Add(new ReportXxx(encoding, char.ConvertFromUtf32(2)));

            // ESC 
            // ASCII 与 UTF8 : 0x1B
            l.Add(new ReportXxx(encoding, char.ConvertFromUtf32(27)));

            return l;
        }

        public static List<ReportXxx> GetReportEndList(Encoding encoding)
        {
            List<ReportXxx> l = new List<ReportXxx>();

            l.Add(new ReportXxx(encoding, string.Empty)
            {
                DisplayName = "无"
            });

            // CR 
            // ASCII 与 UTF8 : 0x0D 
            l.Add(new ReportXxx(encoding, char.ConvertFromUtf32(13)));

            // ETX 
            // ASCII 与 UTF8 : 0x03
            l.Add(new ReportXxx(encoding, char.ConvertFromUtf32(3)));

            // CR LF 
            // ASCII 与 UTF8 : 0x0D 0x0A
            l.Add(new ReportXxx(encoding, "\r\n"));

            return l;
        }

        #endregion

        #region INotifyPropertyChanged成员

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = "")
        {
            this.PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
