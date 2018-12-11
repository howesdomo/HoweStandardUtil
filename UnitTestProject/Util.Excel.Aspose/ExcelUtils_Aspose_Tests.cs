using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;

namespace UnitTestProject
{
    [TestClass]
    public class ExcelUtils_Aspose_Tests
    {
        [TestMethod]
        public void Excel2DataTable()
        {
            string path = System.IO.Path.Combine(Environment.CurrentDirectory, "Util.Excel.Aspose", "Excel2DataSetTest.xlsx");

            // ********** 首行不为列名测试 ********** exportColumnName: false
            DataTable dt = Util.Excel.ExcelUtils_Aspose.Excel2DataTable(path: path, sheetIndex: 1, exportColumnName: false);

            // 含有 2 个 Column
            Assert.AreEqual<int>(2, dt.Columns.Count);

            // Test Column Name
            Assert.AreEqual<string>("Column1", dt.Columns[0].ColumnName);
            Assert.AreEqual<string>("Column2", dt.Columns[1].ColumnName);

            // 读取信息
            int expectedNumber = 2;

            DataRow dr = dt.Rows[0];
            string tmp = dr[0].ToString();
            Assert.AreEqual<string>("A", tmp);

            tmp = dr[1].ToString();
            Assert.AreEqual<string>("B", tmp);







            // ********** 首行为列名测试 ********** exportColumnName: true
            dt = Util.Excel.ExcelUtils_Aspose.Excel2DataTable(path: path, sheetIndex: 1, exportColumnName: true);

            // 含有 2 个 Column
            Assert.AreEqual<int>(2, dt.Columns.Count);

            // Test Column Name
            Assert.AreEqual<string>("A", dt.Columns[0].ColumnName);
            Assert.AreEqual<string>("B", dt.Columns[1].ColumnName);

            // 读取信息
            expectedNumber = 2;

            dr = dt.Rows[0];
            tmp = dr[0].ToString();
            Assert.AreEqual<int>(expectedNumber, Convert.ToInt32(tmp));

            tmp = dr[1].ToString();
            Assert.AreEqual<int>(expectedNumber, Convert.ToInt32(tmp));
        }

        [TestMethod]
        public void Excel2DataSetTest()
        {
            var path = System.IO.Path.Combine(Environment.CurrentDirectory, "Util.Excel.Aspose", "Excel2DataSetTest.xlsx");
            var ds = Util.Excel.ExcelUtils_Aspose.Excel2DataSet(path);

            // 含有 3 个 Sheet
            Assert.AreEqual<int>(3, ds.Tables.Count);

            // 读取信息
            int expectedNumber = 1;
            foreach (DataTable dt in ds.Tables)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    string tmp = dr[0].ToString();
                    Assert.AreEqual<int>(expectedNumber++, Convert.ToInt32(tmp));
                }
            }
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestAsposeCellsHotPatch()
        {
            Util.Excel.ExcelUtils_Aspose.InitializeAsposeCells(); // HotPatch 暂时只能适用于 8.6.3
            // 当前dll版本号过高

            var path = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Aspose.xlsx");
            var msg = Util.Excel.ExcelUtils_Aspose.TestAsposeCellsHotPatch();

            Assert.AreEqual(msg, "");
        }

        [TestMethod]
        public void TestExcel2DataSetWithExcelReaderConfig()
        {
            var path = System.IO.Path.Combine(Environment.CurrentDirectory, "Util.Excel.Aspose", "Excel2DataSetWithExcelReaderConfig.xlsx");
            var ds = Util.Excel.ExcelUtils_Aspose.Excel2DataSet(path, null);

            // 含有 3 个 Sheet
            Assert.AreEqual<int>(4, ds.Tables.Count);

            // 读取信息
            DataTable dt = ds.Tables[0];

            DataRow dr = dt.Rows[0];
            Assert.AreEqual("1", dr[0]);

        }

        [TestMethod]
        public void TestExcel2DataSetWithExcelReaderConfigV2()
        {
            var path = System.IO.Path.Combine(Environment.CurrentDirectory, "Util.Excel.Aspose", "Excel2DataSetWithExcelReaderConfig.xlsx");

            var excelReaderConfig = new Util.Excel.ExcelReaderConfig();
            excelReaderConfig.Config = new System.Collections.Generic.List<Util.Excel.SheetReadConfig>();

            // 读取Sheet2
            var cellReadRuleDict_2 = new System.Collections.Generic.Dictionary<int, Util.Excel.CellType>();
            cellReadRuleDict_2.Add(0, Util.Excel.CellType.Blank);
            cellReadRuleDict_2.Add(1, Util.Excel.CellType.Formula);
            cellReadRuleDict_2.Add(2, Util.Excel.CellType.DateTime);

            var toAdd_2 = new Util.Excel.SheetReadConfig()
            {
                SheetName = "Sheet2",
                CellReadRule = cellReadRuleDict_2
            };

            excelReaderConfig.Config.Add(toAdd_2);


            // 读取sheetIndex=2的工作表
            var cellReadRuleDict_3 = new System.Collections.Generic.Dictionary<int, Util.Excel.CellType>();
            cellReadRuleDict_3.Add(2, Util.Excel.CellType.Blank);
            cellReadRuleDict_3.Add(3, Util.Excel.CellType.Formula);
            cellReadRuleDict_3.Add(4, Util.Excel.CellType.DateTime);


            var toAdd_3 = new Util.Excel.SheetReadConfig()
            {
                SheetIndex = 2,
                StartCellRowIndex = 2,
                StartCellColumnIndex = 2,
                CellReadRule = cellReadRuleDict_3
            };

            excelReaderConfig.Config.Add(toAdd_3);

            var toAdd_4 = new Util.Excel.SheetReadConfig()
            {
                SheetIndex = 3,
                IsContainColumnHeader = false
            };

            excelReaderConfig.Config.Add(toAdd_4);


            var ds = Util.Excel.ExcelUtils_Aspose.Excel2DataSet(path, excelReaderConfig);

            // 由于加上读取配置, 故ds只有 3 个 Sheet
            Assert.AreEqual<int>(3, ds.Tables.Count);

            // 测试 Sheet2
            DataTable dt_Sheet2 = ds.Tables[0];
            Assert.AreEqual<string>("读取空", dt_Sheet2.Columns[0].ColumnName);
            Assert.AreEqual<string>("读取公式", dt_Sheet2.Columns[1].ColumnName);
            Assert.AreEqual<string>("读取时间", dt_Sheet2.Columns[2].ColumnName);
            Assert.AreEqual<string>("读取数值", dt_Sheet2.Columns[3].ColumnName);

            DataRow dr = dt_Sheet2.Rows[0];
            Assert.AreEqual<string>(string.Empty, dr["读取空"].ToString());
            Assert.AreEqual<string>("=A2+2", dr["读取公式"].ToString());
            Assert.AreEqual<string>("2018-12-06 17:30:26", Util.CommonDal.ReadDateTimeWithNoNullable(dr["读取时间"]).ToString("yyyy-MM-dd HH:mm:ss"));
            Assert.AreEqual<decimal>(32.123M, Util.CommonDal.ReadDecimal(dr["读取数值"].ToString()));

            dr = dt_Sheet2.Rows[1];
            Assert.AreEqual<string>(string.Empty, dr["读取空"].ToString());
            Assert.AreEqual<string>("=A3+2", dr["读取公式"].ToString());
            Assert.AreEqual<string>("2018-12-06 17:30:28", Util.CommonDal.ReadDateTimeWithNoNullable(dr["读取时间"]).ToString("yyyy-MM-dd HH:mm:ss"));
            Assert.AreEqual<decimal>(123.456M, Util.CommonDal.ReadDecimal(dr["读取数值"].ToString()));


            // 测试 Sheet3
            DataTable dt_Sheet3 = ds.Tables[1];
            Assert.AreEqual<string>("读取空", dt_Sheet3.Columns[0].ColumnName);
            Assert.AreEqual<string>("读取公式", dt_Sheet3.Columns[1].ColumnName);
            Assert.AreEqual<string>("读取时间", dt_Sheet3.Columns[2].ColumnName);
            Assert.AreEqual<string>("读取数值", dt_Sheet3.Columns[3].ColumnName);

            dr = dt_Sheet3.Rows[0];
            Assert.AreEqual<string>(string.Empty, dr["读取空"].ToString());
            Assert.AreEqual<string>("=C4+2", dr["读取公式"].ToString());
            Assert.AreEqual<string>("2018-12-06 17:30:26", Util.CommonDal.ReadDateTimeWithNoNullable(dr["读取时间"]).ToString("yyyy-MM-dd HH:mm:ss"));
            Assert.AreEqual<decimal>(32.123M, Util.CommonDal.ReadDecimal(dr["读取数值"].ToString()));

            dr = dt_Sheet3.Rows[1];
            Assert.AreEqual<string>(string.Empty, dr["读取空"].ToString());
            Assert.AreEqual<string>("=C5+2", dr["读取公式"].ToString());
            Assert.AreEqual<string>("2018-12-06 17:30:28", Util.CommonDal.ReadDateTimeWithNoNullable(dr["读取时间"]).ToString("yyyy-MM-dd HH:mm:ss"));
            Assert.AreEqual<decimal>(123.456M, Util.CommonDal.ReadDecimal(dr["读取数值"].ToString()));

            // 测试 Sheet4 - 测试200格空行仍然能读取信息
            DataTable dt_Sheet4 = ds.Tables[2];
            Assert.AreEqual<int>(2, dt_Sheet4.Rows.Count);


            Assert.AreEqual<string>("Column1", dt_Sheet4.Columns[0].ColumnName);
            Assert.AreEqual<string>("Column2", dt_Sheet4.Columns[1].ColumnName);


            dr = dt_Sheet4.Rows[0];
            Assert.AreEqual<int>(300, Util.CommonDal.ReadInt(dr["ExcelRowNumber"])); // 测试Excel行号
            Assert.AreEqual<string>("300A", Util.CommonDal.ReadString(dr["Column1"]));
            Assert.AreEqual<string>("300B", Util.CommonDal.ReadString(dr["Column2"]));

            dr = dt_Sheet4.Rows[1];
            Assert.AreEqual<int>(304, Util.CommonDal.ReadInt(dr["ExcelRowNumber"])); // 测试Excel行号
            Assert.AreEqual<string>("300", Util.CommonDal.ReadString(dr["Column1"]));
            Assert.AreEqual<string>("301", Util.CommonDal.ReadString(dr["Column2"]));
        }

    }
}
