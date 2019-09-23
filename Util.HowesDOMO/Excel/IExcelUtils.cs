using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util.Excel
{
    /// <summary>
    /// 1.0.1 - 2019-9-23 09:11:17 
    /// 接口增加 Excel DataSet 互转方法
    /// </summary>
    public interface IExcelUtils
    {
        #region WorkSheet2List

        List<T> WorkSheet2List<T>(string path,
                                    List<PropertyColumn> objectProps,
                                    int worksheetIndex = 0,
                                    bool isContainColumnHeader = true,
                                    int startCellRowIndex = 0, int startCellColumnIndex = 0,
                                    bool ignoreRepeatColumnHeaderName = false)
            where T : class, new();

        void WorkSheet2ListAsync<T>(
            Action<Task<List<T>>> actionHandler,
            string path,
            List<PropertyColumn> objectProps,
            int worksheetIndex = 0,
            bool isContainColumnHeader = true,
            int startCellRowIndex = 0, int startCellColumnIndex = 0,
            bool ignoreRepeatColumnHeaderName = false)
            where T : class, new();

        #endregion

        System.Data.DataSet Excel2DataSetStepByStep(string path, ExcelReaderConfig config = null);

        void DataSet2ExcelStepByStep(string path, System.Data.DataSet dataSet, bool[] showColumnNameArray = null, int[,] positionArray = null);
    }
}
