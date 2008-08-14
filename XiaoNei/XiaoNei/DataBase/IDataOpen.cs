using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data;

namespace XiaoNei {
	public interface IDataOpen {
		DbCommand Command { get; }
		void Open(string SQLtext);
		void Close();
		DbDataAdapter GetAdapter();
		void AddWithValue(string key,object value);
	}
}
