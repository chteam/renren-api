using System;
using System.Collections.Generic;

using System.Text;

namespace XiaoNei{
	public class ApiBase {
		public ApiBase(XiaoNeiApi api) {
			Api = api;
		}
		protected XiaoNeiApi Api { set; get; }
	}
}
