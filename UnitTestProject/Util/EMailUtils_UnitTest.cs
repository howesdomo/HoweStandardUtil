using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject.Util
{
    class EMailUtils_UnitTest
    {
        [TestMethod]

        public void TestSendEMail()
        {          
            string pa = Console.ReadLine(); 
            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient();

            smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
            smtp.EnableSsl = false;
            smtp.Host = "smtp.qiye.163.com";
            smtp.Port = 25;
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = new System.Net.NetworkCredential("howe@enpot.com.cn", pa);

            List<string> receive = new List<string>()
            {
                "howe@enpot.com.cn"
            };

            System.Net.Mail.MailPriority mailPriority = System.Net.Mail.MailPriority.Normal;

            string subject = "Xamarin.Forms 发送邮件测试";
            string content = $"发送邮件测试{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}";
            mailPriority = System.Net.Mail.MailPriority.Normal;

            List<string> attachmentPathList = new List<string>();
            //new Util.EMailUtils().SendEMail
            //(
            //    sender: "howe@enpot.com.cn",
            //    smtp: smtp,
            //    receiverList: receive,
            //    subject: subject,
            //    content: content,
            //    attachmentPathList: attachmentPathList,
            //    mailPriority: mailPriority
            //);
        }
    }
}
