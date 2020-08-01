using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Util
{
    public class CommonBll
    {

        /// <summary>
        /// 获取条件数组的Condtition : orAnd [columnName] IN ('1','2','3','4')
        /// </summary>
        /// <param name="orAnd">运算符</param>
        /// <param name="columnName">列名</param>
        /// <param name="stringList">字符串数组集合</param>
        /// <returns></returns>
        public static string GetConditionInArrayOfStrings(string orAnd, string columnName, IEnumerable<string> stringList)
        {
            string condition = string.Empty;
            condition = CommonBll.GetConditionInArrayOfStrings(stringList);
            if (!string.IsNullOrEmpty(condition))
            {
                condition = " " + orAnd + " " + columnName + " IN ( " + condition + " )";
            }
            return condition;
        }

        /// <summary>
        /// 获取条件数组的Condtition : '1','2','3','4'
        /// </summary>
        /// <param name="stringList">字符串数组集合</param>
        /// <returns></returns>
        public static string GetConditionInArrayOfStrings(IEnumerable<string> stringList, string split = ",")
        {
            string condition = string.Empty;
            if (stringList != null && stringList.Count() > 0)
            {
                foreach (string item in stringList)
                {
                    if (!string.IsNullOrEmpty(condition))
                    {
                        condition += split;
                    }
                    condition += "'" + item + "'";
                }
            }
            return condition;
        }

    }
}
