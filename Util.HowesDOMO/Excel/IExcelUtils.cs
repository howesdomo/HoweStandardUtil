using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util.Excel
{
    public interface IExcelUtils
    {

        #region WorkSheet2List

        List<T> WorkSheet2List<T>(string path,
                                    List<PropertyColumn> objectProps,
                                    int worksheetIndex = 0,
                                    bool isContainLieDingYi = true,
                                    int lieDingYi_RowIndex = 0, int lieDingYi_ColumnIndex = 0,
                                    bool ignoreRepeatColumnName = false)
            where T : class, new();

        void WorkSheet2ListAsync<T>(
            Action<Task<List<T>>> actionHandler,
            string path,
            List<PropertyColumn> objectProps,
            int worksheetIndex = 0,
            bool isContainLieDingYi = true,
            int lieDingYi_RowIndex = 0,
            int lieDingYi_ColumnIndex = 0,
            bool ignoreRepeatColumnName = false)
            where T : class, new();
        
        #endregion



    }
}
