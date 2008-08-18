using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace XiaoNei {
	public class SqlDataOpen : IDataOpen {
		SqlConnection _Connection;
		SqlCommand _Command;

		public DbCommand Command {
			get { return _Command; }
		}
		public SqlDataOpen(string ConnectionString) {
			_Connection = new SqlConnection(ConnectionString);
			_Command = new SqlCommand();
		}
		#region 打开关闭数据库
		void Open(CommandType type, string text) {
			this.Command.Connection = _Connection;
			this.Command.CommandType = type;
			this.Command.CommandText = text.Trim();
			if (_Connection.State != ConnectionState.Open)
				this.Command.Connection.Open();
		}
		void  IDataOpen.Open(string SQLtext) {
			Open(CommandType.Text, SQLtext);
		}

		public void Close() {
			this.Command.Parameters.Clear();
		}
		public DbDataAdapter GetAdapter() {
			return new SqlDataAdapter(_Command);
		}


		public void AddWithValue(string key, object value) {
			_Command.Parameters.AddWithValue(key, value);
		}



		public void Dispose() {
			if (_Connection.State != ConnectionState.Closed)
				Command.Connection.Close();
			Command.Dispose();
			_Connection.Dispose();
		}

		#endregion
	}
}
