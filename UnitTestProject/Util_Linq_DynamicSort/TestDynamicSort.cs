using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace UnitTestProject.Util_Linq_DynamicSort
{
    [TestClass]
    public class TestDynamicSort
    {
        List<View.BuBuGao.Word> l { get; set; }

        [TestInitialize]
        public void init()
        {
            l = new List<View.BuBuGao.Word>();
            l.Add(new View.BuBuGao.Word() { ID = 1, Content = "1" });
            l.Add(new View.BuBuGao.Word() { ID = 2, Content = "2" });
            l.Add(new View.BuBuGao.Word() { ID = 3, Content = "11" });
            l.Add(new View.BuBuGao.Word() { ID = 4, Content = "111" });
            l.Add(new View.BuBuGao.Word() { ID = 5, Content = "12" });
        }

        [TestMethod]
        public void TestMethod1()
        {
            var r = l.SortBy(new List<DynamicSort>() { new DynamicSort("Content", SortDirection.Descending) {  Comparer = new Util_Comparer.MyStrLogicalComparer() } })
                     .ToList<View.BuBuGao.Word>();

            Assert.IsTrue(r[0] == l[3]);
            Assert.IsTrue(r[1] == l[4]);
            Assert.IsTrue(r[2] == l[2]);
            Assert.IsTrue(r[3] == l[1]);
            Assert.IsTrue(r[4] == l[0]);
        }
    }
}
