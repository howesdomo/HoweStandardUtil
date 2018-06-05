using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreUtil
{
    public class SQLiteUtils
    {
        readonly SQLiteAsyncConnection database;

        public SQLiteUtils(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
        }
    }
}
