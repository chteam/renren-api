using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data.Common;
using System.Data;

namespace XiaoNei {
	public class OleDbDataOpen : IDataOpen {
		OleDbConnection _Connection;
		OleDbCommand _Command;

		public DbCommand Command {
			get { return _Command; }
		}
		public OleDbDataOpen(string ConnectionString) {
			_Connection = new OleDbConnection(ConnectionString);
			_Command = new OleDbCommand();
		}
		#region 打开关闭数据库
		void Open(CommandType type, string text) {
			this.Command.Connection = _Connection;
			this.Command.CommandType = type;
			this.Command.CommandText = text;
			this.Command.Connection.Open();
		}
		void  IDataOpen.Open(string SQLtext) {
			Open(CommandType.Text, SQLtext);
		}

		public void Close() {
			this.Command.Parameters.Clear();
			Command.Connection.Close();
		}
		public DbDataAdapter GetAdapter() {
			//throw new Exception(Command.CommandText);
			return new OleDbDataAdapter(_Command);
		}


		public void AddWithValue(string key, object value) {
			_Command.Parameters.AddWithValue(key, value);
		}

		#endregion
	}
}
