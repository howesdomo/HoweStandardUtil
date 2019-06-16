using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodedUITest_Util
{
    [TestClass]
    public class DateTimeUtils_UnitTest
    {
        [TestMethod]
        public void DateTime2Timestamp_Test1()
        {
            // 格林威治时间 1970, 1, 1
            string timestamp_0 = Util.DateTimeUtils.DateTime2Timestamp(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc));
            // 等于 0
            Assert.AreEqual("0", timestamp_0);
        }

        [TestMethod]
        public void DateTime2Timestamp_Test2()
        {
            // 北京时间 1970, 1, 1
            string timestamp_0 = Util.DateTimeUtils.DateTime2Timestamp(new DateTime(1970, 1, 1, 0, 0, 0));
            // 60 * 60 * 8 * -1 ( 由于比格林威治时间早 )
            Assert.AreEqual("-28800", timestamp_0);
        }

        [TestMethod]
        public void Timestamp2DateTime_Test1()
        {
            DateTime dt0 = Util.DateTimeUtils.Timestamp2DateTime_UTC("0");
            // 等于 北京时间 1970-01-01 08:00
            var expect = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            Assert.AreEqual(expect, dt0);
        }

        [TestMethod]
        public void Timestamp2DateTime_Test2()
        {
            DateTime dt0 = Util.DateTimeUtils.Timestamp2DateTime_Local("0");
            // 等于 北京时间 1970-01-01 08:00
            var expect = new DateTime(1970, 1, 1, 8, 0, 0, DateTimeKind.Local);
            Assert.AreEqual(expect, dt0);
        }

    }
}
