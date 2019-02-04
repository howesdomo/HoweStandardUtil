using SQLite;
using System;

namespace Util.Data
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
