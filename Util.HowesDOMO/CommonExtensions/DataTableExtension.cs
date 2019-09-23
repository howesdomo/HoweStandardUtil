namespace System.Data
{
    public static class DataTableExtension
    {
        /// <summary>
        /// DataTable 转 字符串二维数组
        /// </summary>
        /// <param name="dt">待转换的 DataTable</param>
        /// <param name="isContainColumnName">是否转换 ColumnsName 到首行</param>
        /// <returns></returns>
        public static string[,] ToString2DArray(this DataTable dt, bool isContainColumnName = true)
        {
            int columnsCount = dt.Columns.Count;
            int rowsCount = dt.Rows.Count;
            int currentRowIndex = 0;

            string[,] r = null;

            if (isContainColumnName == false)
            {
                r = new string[rowsCount, columnsCount];
            }
            else
            {
                r = new string[rowsCount + 1, columnsCount];

                for (int i = 0; i < columnsCount; i++)
                {
                    r[0, i] = dt.Columns[i].ToString();
                }

                currentRowIndex = currentRowIndex + 1;
            }

            for (int rowIndex = 0; rowIndex < rowsCount; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < columnsCount; columnIndex++)
                {
                    r[(rowIndex + currentRowIndex), columnIndex] = dt.Rows[rowIndex][columnIndex].ToString();
                }
            }

            return r;
        }
    }
}
