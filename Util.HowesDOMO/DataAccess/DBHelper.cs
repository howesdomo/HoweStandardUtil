using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace Util
{
    /// <summary>
	/// !!!! HoweStandardUtil 专用代码 !!!! 不能直接拷贝到 HoweUtil 项目中
	///
    /// V 1.0.3 - 2021-04-05 16:39:09
    /// 根据 Cyber 的读取SQLDataReader方式, 改写了 GetList T 方法, 
    /// 优点: 能够直接读取List T, 无需再从 DataSet 中转换成为所想要的结果
    /// 缺点: 若存储过程含有多个结果集, 目前只能获取第一个结果集
	///
    /// V 1.0.2 - 2020-12-30 15:04:36
    /// 增加参数 TimeSpan? cmdTimeoutSeconds = null 控制超时时长, 默认空值。
    /// cmdTimeoutSeconds 为 null 时 CommandTimeout 默认值为 30 秒
    /// 
    /// V 1.0.1 - 2020-9-29 16:03:41
    /// 改写 DBHelper 由原来只支持 SQLServer, 变为目前测试可以支持 SQLServer / Oracle / SQLite / MySQL 等数据库访问
    /// 1 增加主流数据库工厂属性, 具体项目应先注册需要使用到的数据库Factory
    /// 2 增加主流数据库连接字符串拼接工具方法
    /// 可以到 https://github.com/howesdomo/SQLManager 了解使用方式
    /// 
    /// V 1.0.0 - 2018-09-01 16:03:28
    /// 首次创建
    /// </summary>
    public class DBHelper
    {
        public static DbProviderFactory SQLServerFactory { get; set; }

        public static DbProviderFactory OracleFactory { get; set; }

        public static DbProviderFactory SQLiteFactory { get; set; }

        public static DbProviderFactory MySQLFactory { get; set; }

        public static DbProviderFactory GetDbProviderFactory(DbProvider dbProvider)
        {
            string n = string.Empty;
            switch (dbProvider)
            {
                case DbProvider.Oracle:
                    if (DBHelper.OracleFactory == null)
                    {
                        throw new Exception("DBHelper.OracleFactory is null");
                    }
                    return DBHelper.OracleFactory;
                case DbProvider.SQLite:
                    if (DBHelper.SQLiteFactory == null)
                    {
                        throw new Exception("DBHelper.SQLiteFactory is null");
                    }
                    return DBHelper.SQLiteFactory;

                case DbProvider.MySQL:
                    if (DBHelper.MySQLFactory == null)
                    {
                        throw new Exception("DBHelper.MySQLFactory is null");
                    }
                    return DBHelper.MySQLFactory;
                case DbProvider.SQLServer:
                    if (DBHelper.SQLServerFactory == null)
                    {
                        throw new Exception("DBHelper.SQLServerFactory is null");
                    }
                    return DBHelper.SQLServerFactory;
                default:
                    throw new Exception($"数据库类型不在支持列表中。（DBHelper.GetDbProviderFactory 发生错误，{dbProvider}）");

            }            
        }

        public static DataSet GetDataSet
        (
            DbProviderFactory factory,
            string connectionString,
            string commandText,
            List<object> paramsList,
            bool isBeginTransaction = false,
            bool isRollbackForTest = false,
            CommandType argCommandType = CommandType.StoredProcedure,
            TimeSpan? cmdTimeoutSeconds = null
        )
        {
            DataSet r = new DataSet();
            using (DbConnection conn = factory.CreateConnection())
            {
                conn.ConnectionString = connectionString;
                conn.Open();

                DbCommand cmd = null;
                DbTransaction tran = null;

                try
                {
                    if (isRollbackForTest == true || isBeginTransaction == true) // 开启测试回滚 或 开启事务
                    {
                        tran = conn.BeginTransaction();
                        cmd = tran.Connection.CreateCommand();
                        cmd.Transaction = tran;
                    }
                    else // 普通执行模式
                    {
                        cmd = conn.CreateCommand();
                    }

                    if (cmdTimeoutSeconds.HasValue)
                    {
                        cmd.CommandTimeout = (int)cmdTimeoutSeconds.Value.TotalSeconds;
                    }

                    cmd.CommandType = argCommandType;
                    cmd.CommandText = commandText;

                    if (paramsList != null && paramsList.Count > 0)
                    {
                        cmd.Parameters.AddRange(paramsList.ToArray());
                    }

                    using (DbDataAdapter adapter = factory.CreateDataAdapter())
                    {
                        adapter.SelectCommand = cmd;
                        adapter.Fill(r);
                    }

                    if (tran != null)
                    {
                        if (isRollbackForTest == false)
                        {
                            tran.Commit();
                        }
                        else // 实现测试回滚
                        {
                            tran.Rollback();
                        }

                        tran.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    if (tran != null)
                    {
                        tran.Rollback();
                    }

                    throw ex;
                }
            }

            return r;
        }


        public static DataSet GetDataSet
        (
            DbTransaction tran,
            string commandText,
            List<object> paramsList,
            CommandType argCommandType = CommandType.StoredProcedure,
            TimeSpan? cmdTimeoutSeconds = null
        )
        {
            DataSet r = new DataSet();

            DbCommand cmd = tran.Connection.CreateCommand();
            cmd.Transaction = tran;

            cmd.CommandType = argCommandType;
            cmd.CommandText = commandText;

            if (paramsList != null && paramsList.Count > 0)
            {
                cmd.Parameters.AddRange(paramsList.ToArray());
            }

            // Stopwatch sw = new Stopwatch();
            // sw.Start();
            // var f = DbProviderFactories.GetFactory(tran.Connection);
            // sw.Stop();
            // 经测试 System.Diagnostics.Stopwatch.Elapsed = 00:00:00.0000004	

            // 由于 4.0 没有 DbProviderFactories.GetFactory(DbConnection) 的重载
            DbProviderFactory factory = null;
            if (tran.Connection is System.Data.SqlClient.SqlConnection)
            {
                factory = GetDbProviderFactory(DbProvider.SQLServer);
            }
            else
            {
                var typeName = tran.Connection.GetType().Name;
                if (typeName.Contains("Lite"))
                {
                    factory = GetDbProviderFactory(DbProvider.SQLite);
                }
                else if (typeName.Contains("Oracle"))
                {
                    factory = GetDbProviderFactory(DbProvider.Oracle);
                }
                else if (typeName.Contains("MySQL"))
                {
                    factory = GetDbProviderFactory(DbProvider.MySQL);
                }
            }

            if (cmdTimeoutSeconds.HasValue)
            {
                cmd.CommandTimeout = (int)cmdTimeoutSeconds.Value.TotalSeconds;
            }

            // 由于 4.0 没有 DbProviderFactories.GetFactory(DbConnection) 的重载
            // using (DbDataAdapter adapter = DbProviderFactories.GetFactory(tran.Connection).CreateDataAdapter())
            using (DbDataAdapter adapter = factory.CreateDataAdapter())
            {
                adapter.SelectCommand = cmd;
                adapter.Fill(r);
            }

            return r;
        }

        #region GetList -- DBDataReader 直接读取 JArray, 最后转为 List<T>, 其缺点是只能获取一个结果集

        public static List<T> GetList<T>
        (
            DbProviderFactory factory,
            string connectionString,
            string commandText,
            List<object> paramsList,
            bool isBeginTransaction = false,
            bool isRollbackForTest = false,
            CommandType argCommandType = CommandType.StoredProcedure,
            TimeSpan? cmdTimeoutSeconds = null
        )
        {
            List<T> r = null;
            using (DbConnection conn = factory.CreateConnection())
            {
                conn.ConnectionString = connectionString;
                conn.Open();

                DbCommand cmd = null;
                DbTransaction tran = null;

                try
                {
                    if (isRollbackForTest == true || isBeginTransaction == true) // 开启测试回滚 或 开启事务
                    {
                        tran = conn.BeginTransaction();
                        cmd = tran.Connection.CreateCommand();
                        cmd.Transaction = tran;
                    }
                    else // 普通执行模式
                    {
                        cmd = conn.CreateCommand();
                    }

                    if (cmdTimeoutSeconds.HasValue)
                    {
                        cmd.CommandTimeout = (int)cmdTimeoutSeconds.Value.TotalSeconds;
                    }

                    cmd.CommandType = argCommandType;
                    cmd.CommandText = commandText;

                    if (paramsList != null && paramsList.Count > 0)
                    {
                        cmd.Parameters.AddRange(paramsList.ToArray());
                    }

                    using (DbDataReader reader = cmd.ExecuteReader())
                    {
                        r = GetList<T>(reader);
                    }

                    if (tran != null)
                    {
                        if (isRollbackForTest == false)
                        {
                            tran.Commit();
                        }
                        else // 实现测试回滚
                        {
                            tran.Rollback();
                        }

                        tran.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    if (tran != null)
                    {
                        tran.Rollback();
                    }

                    throw ex;
                }
            }

            return r;
        }

        public static List<T> GetList<T>
        (
            DbTransaction tran,
            string commandText,
            List<object> paramsList,
            CommandType argCommandType = CommandType.StoredProcedure,
            TimeSpan? cmdTimeoutSeconds = null
        )
        {
            DbCommand cmd = tran.Connection.CreateCommand();
            cmd.Transaction = tran;

            cmd.CommandType = argCommandType;
            cmd.CommandText = commandText;

            if (paramsList != null && paramsList.Count > 0)
            {
                cmd.Parameters.AddRange(paramsList.ToArray());
            }

            // Stopwatch sw = new Stopwatch();
            // sw.Start();
            // var f = DbProviderFactories.GetFactory(tran.Connection);
            // sw.Stop();
            // 经测试 System.Diagnostics.Stopwatch.Elapsed = 00:00:00.0000004	

            // 由于 4.0 没有 DbProviderFactories.GetFactory(DbConnection) 的重载
            DbProviderFactory factory = null;
            if (tran.Connection is System.Data.SqlClient.SqlConnection)
            {
                factory = GetDbProviderFactory(DbProvider.SQLServer);
            }
            else
            {
                var typeName = tran.Connection.GetType().Name;
                if (typeName.Contains("Lite"))
                {
                    factory = GetDbProviderFactory(DbProvider.SQLite);
                }
                else if (typeName.Contains("Oracle"))
                {
                    factory = GetDbProviderFactory(DbProvider.Oracle);
                }
                else if (typeName.Contains("MySQL"))
                {
                    factory = GetDbProviderFactory(DbProvider.MySQL);
                }
            }

            if (cmdTimeoutSeconds.HasValue)
            {
                cmd.CommandTimeout = (int)cmdTimeoutSeconds.Value.TotalSeconds;
            }

            using (DbDataReader reader = cmd.ExecuteReader())
            {
                return GetList<T>(reader);
            }
        }

        public static List<T> GetList<T>(DbDataReader dataReader)
        {
            // 列名
            var cols = new List<string>();
            for (int index = 0; index < dataReader.FieldCount; index++)
            {
                cols.Add(dataReader.GetName(index));
            }

            // 赋值
            Newtonsoft.Json.Linq.JArray jArray = new Newtonsoft.Json.Linq.JArray();
            while (dataReader.Read() == true)
            {
                var toAdd_JObject = new Newtonsoft.Json.Linq.JObject();

                foreach (string col in cols)
                {
                    if (dataReader[col] != DBNull.Value)
                    {
                        toAdd_JObject.Add(col, dataReader[col].ToString());
                    }
                    else
                    {
                        toAdd_JObject.Add(col, null);
                    }
                }

                jArray.Add(toAdd_JObject);
            }

            return jArray.ToObject<List<T>>();
        }

        #endregion


        #region SQL Server 连接字符串

        /// <summary>
        /// SQL Server 连接字符串
        /// </summary>
        /// <param name="serverAddress">数据库服务器地址, 可以填写 IP 或 网址</param>
        /// <param name="database">数据库</param>
        /// <param name="isIntergratedSecurity">启用 Windows 身份验证, 默认 false</param>
        /// <param name="serverInstance">数据库实例名称, 默认空值, 若是 SQLExpress 版本请填写 SQLExpress</param>
        /// <param name="serverPort">数据库服务端口, 默认 1433</param>
        /// <param name="userId">用户名</param>
        /// <param name="password">密码</param>
        /// <returns>SQL Server 连接字符串</returns>
        public static string SQLServerConnStr
        (
            string serverAddress,
            string database,
            bool isIntergratedSecurity = false,
            string serverInstance = "",
            string serverPort = "1433",
            string userId = "",
            string password = ""
        )
        {
            // Server = myServerName\myInstanceName,myPortNumber; Database = myDataBase; Integrated Security=true;;
            // Server = myServerName\myInstanceName,myPortNumber; Database = myDataBase; User Id = myUsername; Password = myPassword;

            StringBuilder sb = new StringBuilder();

            sb.Append("Server = ").Append(serverAddress);

            if (serverInstance.IsNullOrWhiteSpace() == false)
            {
                sb.Append("\\").Append(serverInstance);
            }

            sb.Append(",").Append(serverPort).Append(";");

            sb.Append(" Database = ").Append(database).Append(";");

            if (isIntergratedSecurity)
            {
                sb.Append(" Integrated Security = true;");
            }
            else
            {
                sb.Append(" User Id = ").Append(userId).Append(";");
                sb.Append(" Password = ").Append(password).Append(";");
            }

            return sb.ToString();
        }

        /// <summary>
        /// localdb 连接字符串
        /// </summary>
        /// <param name="serverInstance">默认值 MSSQLLocalDB</param>
        /// <returns>localdb 连接字符串</returns>
        public static string SQLLocalDBConnStr
        (
            string serverInstance = "MSSQLLocalDB"
        )
        {
            // 访问 localdb 连接字符串
            // (localdb)\localdbInstanceName; Integrated Security = true;
            // 
            // 查看本机 localdb 实例名称, 可以在 CMD 中运行 sqllocaldb.exe i
            // 
            // 实际例子:
            // Server = (localdb)\ProjectsV13; Integrated Security = true;

            return $@"Server = (localdb)\{serverInstance}; Integrated Security=true;";
        }

        #endregion

        #region SQLite 连接字符串

        /// <summary>
        /// 获取SQLite连接字符串
        /// </summary>
        /// <param name="dbFilePath">数据库文件名称(或路径)</param>
        /// <param name="version">数据库文件版本, 默认3。可选【2】【3】</param>
        /// <param name="isUseUTF16Encoding">使用 UTF16 编码</param>
        /// <param name="password">密码，默认空字符串</param>
        /// <param name="isReadOnly">只读连接，默认false</param>
        /// <param name="maxPoolSize">设置连接池大小，默认null</param>
        /// <param name="isFailIfMissing">默认false，默认情况下，如果数据库文件不存在，会自动创建一个新的，若设置为True，将不会创建，而是抛出异常信息</param>
        /// <returns></returns>
        public static string SQLiteConnStr
        (
            string dbFilePath,
            string version = "3",
            bool isUseUTF16Encoding = false,
            string password = "",
            bool isReadOnly = false,
            int? maxPoolSize = null,
            bool isFailIfMissing = false
        )
        {
            #region 参考资料

            // C#在不同情况下连接SQLite字符串格式
            // 1、Basic（基本的）
            // Data Source=filename;Version=3;

            // 2、Using UTF16（使用UTF16编码）
            // Data Source=filename;Version=3;UseUTF16Encoding=True;

            // 3、With password（带密码的）
            // Data Source=filename;Version=3;Password=myPassword;

            // 4、Using the pre 3.3x database format（使用3.3x前数据库格式）
            // Data Source=filename;Version=3;Legacy Format=True;

            // 5、Read only connection（只读连接）
            // Data Source=filename;Version=3;Read Only=True;

            // 6、With connection pooling（设置连接池）
            // Data Source=filename;Version=3;Pooling=False;Max Pool Size=100;

            // 7、Using DateTime.Ticks as datetime format（）
            // Data Source=filename;Version=3;DateTimeFormat=Ticks;

            // 8、Store GUID as text（把Guid作为文本存储，默认是Binary）
            // Data Source=filename;Version=3;BinaryGUID=False;

            // 如果把Guid作为文本存储需要更多的存储空间

            // 9、Specify cache size（指定Cache大小）
            // Data Source=filename;Version=3;Cache Size=2000;

            // Cache Size 单位是字节

            // 10、Specify page size（指定页大小）
            // Data Source=filename;Version=3;Page Size=1024;

            // Page Size 单位是字节

            // 11、Disable enlistment in distributed transactions
            // Data Source=filename;Version=3;Enlist=N;

            // 12、Disable create database behaviour（禁用创建数据库行为）
            // Data Source=filename;Version=3;FailIfMissing=True;

            // 默认情况下，如果数据库文件不存在，会自动创建一个新的，使用这个参数，将不会创建，而是抛出异常信息

            // 13、Limit the size of database（限制数据库大小）
            // Data Source=filename;Version=3;Max Page Count=5000;

            // The Max Page Count is measured in pages. This parameter limits the maximum number of pages of the database.

            // 14、Disable the Journal File （禁用日志回滚）
            // Data Source=filename;Version=3;Journal Mode=Off;

            // This one disables the rollback journal entirely.

            // 15、Persist the Journal File（持久）
            // Data Source=filename;Version=3;Journal Mode=Persist;

            #endregion

            StringBuilder sb = new StringBuilder();

            // ===== 基本必填 =====
            sb.Append("Data Source = ").Append(dbFilePath).Append(";").Append(" Version = ").Append(version).Append(";");

            // ===== 选填 =====
            // 使用UTF16编码
            if (isUseUTF16Encoding == true)
            {
                sb.Append(" UseUTF16Encoding = True;");
            }

            // 密码
            if (password.IsNullOrWhiteSpace() == false)
            {
                sb.Append(" Password = ").Append(password).Append(";");
            }

            // 只读连接
            if (isReadOnly == true)
            {
                sb.Append(" Read Only = True;");
            }

            // 设置连接池
            if (maxPoolSize.HasValue == true && maxPoolSize.Value > 0)
            {
                sb.Append(" Pooling = False; Max Pool Size = ").Append(maxPoolSize.Value).Append(";");
            }

            // 禁用创建数据库行为
            // 默认情况下，如果数据库文件不存在，会自动创建一个新的，若设置为True，将不会创建，而是抛出异常信息
            if (isFailIfMissing == true)
            {
                sb.Append(" FailIfMissing = True;");
            }

            return sb.ToString();
        }

        #endregion

        #region Oracle 连接字符串

        /// <summary>
        /// Oracle 连接字符串
        /// </summary>
        /// <param name="serverAddress">数据库服务器地址</param>
        /// <param name="isIntergratedSecurity">启用 Windows 身份验证, 默认 false</param>
        /// <param name="serverInstance">数据库实例名 ( ORACLE_SID )</param>
        /// <param name="serverPort">数据库服务端口, 默认 1521</param>
        /// <param name="userId">用户名, 常用管理员名称 sys, system</param>
        /// <param name="password">密码</param>
        /// <returns></returns>
        public static string OracleConnStr
        (
            string serverAddress,
            bool isIntergratedSecurity = false,
            string serverInstance = "orcl",
            string serverPort = "1521",
            string userId = "",
            string password = ""
        )
        {
            // Data Source = MyOracleDB; Integrated Security=yes ;
            // Data Source = 134.127.17.1:1521/ORA; USER ID = Barcode; PASSWORD = enpot;

            StringBuilder sb = new StringBuilder();

            sb.Append("Data Source = ").Append(serverAddress);

            sb.Append(":").Append(serverPort);

            if (serverInstance.IsNullOrWhiteSpace() == false)
            {
                sb.Append("/").Append(serverInstance);
            }

            sb.Append(";");

            if (isIntergratedSecurity)
            {
                // 但目前在 .18.215 的 Oracle 服务器中测试会报错, 提示 'Integrated Security' 是无效的连接字符串属性
                // 测试环境 : win7 + oracle 11.2 
                // oracle 连接库 : Oracle.ManagedDataAccess.dll
                sb.Append(" Integrated Security = yes;");
            }
            else
            {
                sb.Append(" User Id = ").Append(userId).Append(";");
                sb.Append(" Password = ").Append(password).Append(";");
            }

            return sb.ToString();
        }

        #endregion

        #region MySQL 连接字符串

        /// <summary>
        /// MySQL 连接字符串 
        /// </summary>
        /// <param name="serverAddress">数据库服务器地址</param>
        /// <param name="database">数据库, 大小写敏感</param>
        /// <param name="userId">用户名, 默认管理员名称 root</param>
        /// <param name="password">密码</param>
        /// <param name="serverPort">数据库服务端口, 默认 3306</param>
        /// <returns></returns>
        public static string MySQLConnStr
        (
            string serverAddress,
            string database,
            string userId,
            string password,
            string serverPort = "3306"
        )
        {
            // Server = myServerAddress; Port = 1234; Database = myDataBase; Uid = myUsername; Pwd = myPassword;

            StringBuilder sb = new StringBuilder();

            sb.Append("Server = ").Append(serverAddress).Append(";");
            sb.Append(" Port = ").Append(serverPort).Append(";");
            sb.Append(" Database = ").Append(database).Append(";");
            sb.Append(" Uid = ").Append(userId).Append(";");
            sb.Append(" Pwd = ").Append(password).Append(";");

            return sb.ToString();
        }

        #endregion

    }

    public enum DbProvider
    {
        SQLServer,
        SQLite,
        Oracle,
        MySQL
    }
}
