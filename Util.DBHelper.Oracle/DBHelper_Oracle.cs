using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

using Oracle.ManagedDataAccess.Client;

namespace Util
{
	/// <summary>
	/// V1 - 2020-3-6 15:44:21
	/// 首次创建
	/// </summary>
	public class DBHelper_Oracle
	{
		public static System.Data.DataSet GetDataSet(string connectionString,
					string commandText,
					List<OracleParameter> paramsList,
					bool isRollbackForTest = false,
					CommandType argCommandType = CommandType.StoredProcedure
					)
		{
			DataSet r = new DataSet();
			using (OracleConnection conn = new OracleConnection(connectionString))
			{
				conn.Open();
				Oracle.ManagedDataAccess.Client.OracleCommand cmd = null;
				Oracle.ManagedDataAccess.Client.OracleTransaction tran = null;

				if (isRollbackForTest == true) // 实现测试回滚
				{
					tran = conn.BeginTransaction();
					cmd = tran.Connection.CreateCommand();
					cmd.Transaction = tran;
				}
				else // 普通执行模式
				{
					cmd = conn.CreateCommand();
				}

				cmd.CommandType = argCommandType;
				cmd.CommandText = commandText;

				if (paramsList != null && paramsList.Count > 0)
				{
					cmd.Parameters.AddRange(paramsList.ToArray());
				}

				OracleDataAdapter sda = new OracleDataAdapter(cmd);
				sda.Fill(r);

				// 实现测试回滚
				if (isRollbackForTest == true)
				{
					tran.Rollback();
				}
			}

			return r;
		}


		// 使用事务时使用
		public static DataSet GetDataSet(
			Oracle.ManagedDataAccess.Client.OracleTransaction tran,
			string commandText,
			List<OracleParameter> paramsList,
			CommandType argCommandType = CommandType.StoredProcedure)
		{
			DataSet r = new DataSet();

			Oracle.ManagedDataAccess.Client.OracleCommand cmd = tran.Connection.CreateCommand();
			cmd.Transaction = tran;

			cmd.CommandType = argCommandType;
			cmd.CommandText = commandText;

			if (paramsList != null && paramsList.Count > 0)
			{
				cmd.Parameters.AddRange(paramsList.ToArray());
			}

			OracleDataAdapter sda = new OracleDataAdapter(cmd);
			sda.Fill(r);

			return r;
		}
	}
}
