using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;

namespace UnitTestProject
{
    [TestClass]
    public class ExcelUtils_Aspose_Tests
    {
        [TestInitialize]
        public void init()
        {
            Util.Excel.ExcelUtils_Aspose.InitializeAsposeCells();
        }

        [TestMethod]
        // [ExpectedException(typeof(Exception))]
        public void TestAsposeCellsHotPatch()
        {
            // Util.Excel.ExcelUtils_Aspose.InitializeAsposeCells();
            var msg = Util.Excel.ExcelUtils_Aspose.TestAsposeCellsHotPatch();
            Assert.AreEqual(msg, "");
        }
        
        [TestMethod]
        public void TestExcel2DataSetStepByStep_Without_ExcelReaderConfig()
        {
            var path = System.IO.Path.Combine(Environment.CurrentDirectory, "Util.Excel.Aspose", "Excel2DataSetTest.xlsx");
            var ds = new Util.Excel.ExcelUtils_Aspose().Excel2DataSetStepByStep(path);

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
        public void TestExcel2DataSetStepByStep_With_ExcelReaderConfig()
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


            var ds = new Util.Excel.ExcelUtils_Aspose().Excel2DataSetStepByStep(path, excelReaderConfig);

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
            Assert.AreEqual<string>("2018-12-06 17:30:26", Util.CommonDal.ReadDateTime(dr["读取时间"]).ToString("yyyy-MM-dd HH:mm:ss"));
            Assert.AreEqual<decimal>(32.123M, Util.CommonDal.ReadDecimal(dr["读取数值"].ToString()));

            dr = dt_Sheet2.Rows[1];
            Assert.AreEqual<string>(string.Empty, dr["读取空"].ToString());
            Assert.AreEqual<string>("=A3+2", dr["读取公式"].ToString());
            Assert.AreEqual<string>("2018-12-06 17:30:28", Util.CommonDal.ReadDateTime(dr["读取时间"]).ToString("yyyy-MM-dd HH:mm:ss"));
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
            Assert.AreEqual<string>("2018-12-06 17:30:26", Util.CommonDal.ReadDateTime(dr["读取时间"]).ToString("yyyy-MM-dd HH:mm:ss"));
            Assert.AreEqual<decimal>(32.123M, Util.CommonDal.ReadDecimal(dr["读取数值"].ToString()));

            dr = dt_Sheet3.Rows[1];
            Assert.AreEqual<string>(string.Empty, dr["读取空"].ToString());
            Assert.AreEqual<string>("=C5+2", dr["读取公式"].ToString());
            Assert.AreEqual<string>("2018-12-06 17:30:28", Util.CommonDal.ReadDateTime(dr["读取时间"]).ToString("yyyy-MM-dd HH:mm:ss"));
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

        [TestMethod]
        public void Test_Excel2DataTable_No1()
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
        public void Test_Excel2DataTable_No2()
        {
            // 测试总结 : 
            // 1) 采用转换列头时
            // 时间、日期、 时间日期 的转换都会转成 yyyy-M-D H:mm:ss 这个格式
            // 2) 不采用转换列头
            // 时间、日期、 时间日期 的转换与 AsString 的转换结果一致
            string path = System.IO.Path.Combine(Environment.CurrentDirectory, "Util.Excel.Aspose", "Aspose.xlsx");

            // **** 读取 Sheet1 ****
            var datatable = Util.Excel.ExcelUtils_Aspose.Excel2DataTable(path);

            Assert.AreEqual<string>("Sheet1", datatable.TableName);

            Assert.AreEqual<int>(2, datatable.Rows.Count);
            Assert.AreEqual<int>(4, datatable.Columns.Count);

            Assert.AreEqual<string>("54.08", datatable.Rows[0]["体重"].ToString());

            Assert.AreEqual<string>("45.08", datatable.Rows[1]["体重"].ToString());


            // **** 读取 Sheet2 ****
            datatable = Util.Excel.ExcelUtils_Aspose.Excel2DataTable(path, sheetIndex: 1);

            Assert.AreEqual<string>("工作簿2", datatable.TableName);

            Assert.AreEqual<int>(3, datatable.Rows.Count);
            Assert.AreEqual<int>(3, datatable.Columns.Count);

            Assert.AreEqual<string>("1899/12/31 9:32:00", datatable.Rows[0]["时间"].ToString()); // * 重要 *

            Assert.AreEqual<string>("2019/5/2 0:00:00", datatable.Rows[1]["日期"].ToString()); // * 重要 *

            Assert.AreEqual<string>("2019/9/9 9:31:49", datatable.Rows[2]["日期时间"].ToString()); // * 重要 *

            // **** 读取 Sheet2 **** 不转换第一行为列头
            datatable = Util.Excel.ExcelUtils_Aspose.Excel2DataTable
            (
                path: path,
                sheetIndex: 1,
                exportColumnName: false // * 重要 *
            );

            Assert.AreEqual<string>("工作簿2", datatable.TableName);

            Assert.AreEqual<int>(4, datatable.Rows.Count);
            Assert.AreEqual<int>(3, datatable.Columns.Count);

            Assert.AreEqual<string>("时间", datatable.Rows[0][0].ToString());
            Assert.AreEqual<string>("日期", datatable.Rows[0][1].ToString());
            Assert.AreEqual<string>("日期时间", datatable.Rows[0][2].ToString());

            Assert.AreEqual<string>("9:32", datatable.Rows[1][0].ToString()); // * 重要 *

            Assert.AreEqual<string>("2019/5/2", datatable.Rows[2][1].ToString()); // * 重要 *

            Assert.AreEqual<string>("2019/9/9 9:31", datatable.Rows[3][2].ToString()); // * 重要 *
        }

        [TestMethod]
        public void Test_Excel2DataTableAsString()
        {
            // 测试总结 : 读取日期时间的值 如同我们直接在Excel看到的内容, 会与实际点进去的 Value 的值由偏差
            // 例如 Sheet 2 的 C4 的值 表面的值是 2019/9/9 9:31 但实际点进去可以看到是 2019/9/9 9:31:49

            string path = System.IO.Path.Combine(Environment.CurrentDirectory, "Util.Excel.Aspose", "Aspose.xlsx");

            // **** 读取 Sheet1 ****
            var datatable = Util.Excel.ExcelUtils_Aspose.Excel2DataTableAsString(path);

            Assert.AreEqual<string>("Sheet1", datatable.TableName);

            Assert.AreEqual<int>(2, datatable.Rows.Count);
            Assert.AreEqual<int>(4, datatable.Columns.Count);

            Assert.AreEqual<string>("54.08", datatable.Rows[0]["体重"].ToString());

            Assert.AreEqual<string>("45.08", datatable.Rows[1]["体重"].ToString());


            // **** 读取 Sheet2 ****
            datatable = Util.Excel.ExcelUtils_Aspose.Excel2DataTableAsString(path, sheetIndex: 1);

            Assert.AreEqual<string>("工作簿2", datatable.TableName);

            Assert.AreEqual<int>(3, datatable.Rows.Count);
            Assert.AreEqual<int>(3, datatable.Columns.Count);

            Assert.AreEqual<string>("9:32", datatable.Rows[0]["时间"].ToString());

            Assert.AreEqual<string>("2019/5/2", datatable.Rows[1]["日期"].ToString());

            Assert.AreEqual<string>("2019/9/9 9:31", datatable.Rows[2]["日期时间"].ToString()); // * 重要 *


            // **** 读取 Sheet2 **** 不转换第一行为列头
            datatable = Util.Excel.ExcelUtils_Aspose.Excel2DataTableAsString
            (
                path: path,
                sheetIndex: 1,
                exportColumnName: false // * 重要 *
            );

            Assert.AreEqual<string>("工作簿2", datatable.TableName);

            Assert.AreEqual<int>(4, datatable.Rows.Count);
            Assert.AreEqual<int>(3, datatable.Columns.Count);

            Assert.AreEqual<string>("时间", datatable.Rows[0][0].ToString());
            Assert.AreEqual<string>("日期", datatable.Rows[0][1].ToString());
            Assert.AreEqual<string>("日期时间", datatable.Rows[0][2].ToString());

            Assert.AreEqual<string>("9:32", datatable.Rows[1][0].ToString());

            Assert.AreEqual<string>("2019/5/2", datatable.Rows[2][1].ToString());

            Assert.AreEqual<string>("2019/9/9 9:31", datatable.Rows[3][2].ToString()); // * 重要 *
        }

        [TestMethod]
        public void Test_DataSet2Excel()
        {
            DataSet ds = new DataSet();

            DataTable dt1 = new DataTable();
            dt1.TableName = "工作簿1";
            dt1.Columns.Add("姓名");
            dt1.Columns.Add("性别");
            dt1.Columns.Add("身高");
            dt1.Columns.Add("体重");

            DataRow dr0 = dt1.NewRow();
            dr0["姓名"] = "A";
            dr0["性别"] = "男";
            dr0["身高"] = 169;
            dr0["体重"] = 54.08;

            DataRow dr1 = dt1.NewRow();
            dr1["姓名"] = "B";
            dr1["性别"] = "女";
            dr1["身高"] = 161;
            dr1["体重"] = 45.08;

            dt1.Rows.Add(dr0);
            dt1.Rows.Add(dr1);

            ds.Tables.Add(dt1);

            DataTable dt2 = new DataTable();
            dt2.TableName = "工作簿2";
            dt2.Columns.Add("时间");
            dt2.Columns.Add("日期");
            dt2.Columns.Add("日期时间");

            dr0 = dt2.NewRow();
            dr1 = dt2.NewRow();
            DataRow dr2 = dt2.NewRow();

            dr0["时间"] = new TimeSpan(9, 32, 0);
            dr0["日期"] = new DateTime(2019, 4, 1);
            dr0["日期时间"] = new DateTime(2019, 4, 1, 9, 31, 11);

            dr1["时间"] = new TimeSpan(23, 40, 0);
            dr1["日期"] = new DateTime(2019, 5, 1);
            dr1["日期时间"] = new DateTime(2019, 4, 1, 9, 31, 12);

            dr2["时间"] = new TimeSpan(0, 21, 0);
            dr2["日期"] = new DateTime(2018, 9, 1);
            dr2["日期时间"] = new DateTime(2019, 4, 1, 9, 31, 13);

            dt2.Rows.Add(dr0);
            dt2.Rows.Add(dr1);
            dt2.Rows.Add(dr2);

            ds.Tables.Add(dt2);

            string path = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "测试 DataSet2Excel.xlsx");

            Util.Excel.ExcelUtils_Aspose.DataSet2Excel(path, ds);

            DataSet readResultDataSet = Util.Excel.ExcelUtils_Aspose.Excel2DataSet(path);

            for (int tableIndex = 0; tableIndex < ds.Tables.Count; tableIndex++)
            {
                DataTable sources = ds.Tables[tableIndex];
                DataTable target = readResultDataSet.Tables[tableIndex];

                for (int rowIndex = 0; rowIndex < sources.Rows.Count; rowIndex++)
                {
                    for (int columnIndex = 0; columnIndex < sources.Columns.Count; columnIndex++)
                    {
                        Assert.AreEqual(sources.Rows[rowIndex][columnIndex].ToString(), target.Rows[rowIndex][columnIndex].ToString());
                    }
                }
            }

        }

        [TestMethod]
        public void Test_DataSet2ExcelStepByStep()
        {
            DataSet ds = new DataSet();

            DataTable dt1 = new DataTable();
            dt1.TableName = "工作簿1";
            dt1.Columns.Add("姓名");
            dt1.Columns.Add("性别");
            dt1.Columns.Add("身高");
            dt1.Columns.Add("体重");

            DataRow dr0 = dt1.NewRow();
            dr0["姓名"] = "A";
            dr0["性别"] = "男";
            dr0["身高"] = 169;
            dr0["体重"] = 54.08;

            DataRow dr1 = dt1.NewRow();
            dr1["姓名"] = "B";
            dr1["性别"] = "女";
            dr1["身高"] = 161;
            dr1["体重"] = 45.08;

            dt1.Rows.Add(dr0);
            dt1.Rows.Add(dr1);

            ds.Tables.Add(dt1);

            DataTable dt2 = new DataTable();
            dt2.TableName = "工作簿2";
            dt2.Columns.Add("时间");
            dt2.Columns.Add("日期");
            dt2.Columns.Add("日期时间");

            dr0 = dt2.NewRow();
            dr1 = dt2.NewRow();
            DataRow dr2 = dt2.NewRow();

            dr0["时间"] = new TimeSpan(9, 32, 0);
            dr0["日期"] = new DateTime(2019, 4, 1);
            dr0["日期时间"] = new DateTime(2019, 4, 1, 9, 31, 11);

            dr1["时间"] = new TimeSpan(23, 40, 0);
            dr1["日期"] = new DateTime(2019, 5, 1);
            dr1["日期时间"] = new DateTime(2019, 4, 1, 9, 31, 12);

            dr2["时间"] = new TimeSpan(0, 21, 0);
            dr2["日期"] = new DateTime(2018, 9, 1);
            dr2["日期时间"] = new DateTime(2019, 4, 1, 9, 31, 13);

            dt2.Rows.Add(dr0);
            dt2.Rows.Add(dr1);
            dt2.Rows.Add(dr2);

            ds.Tables.Add(dt2);

            string path = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "测试 DataSet2ExcelStepByStep.xlsx");

            new Util.Excel.ExcelUtils_Aspose().DataSet2ExcelStepByStep(path, ds);

            DataSet readResultDataSet = Util.Excel.ExcelUtils_Aspose.Excel2DataSet(path);

            for (int tableIndex = 0; tableIndex < ds.Tables.Count; tableIndex++)
            {
                DataTable sources = ds.Tables[tableIndex];
                DataTable target = readResultDataSet.Tables[tableIndex];

                for (int rowIndex = 0; rowIndex < sources.Rows.Count; rowIndex++)
                {
                    for (int columnIndex = 0; columnIndex < sources.Columns.Count; columnIndex++)
                    {
                        Assert.AreEqual(sources.Rows[rowIndex][columnIndex].ToString(), target.Rows[rowIndex][columnIndex].ToString());
                    }
                }
            }
        }
    }
}
