using System;
using System.Collections.Generic;

using System.Text;

namespace XiaoNei {
	public class XMasterPage : System.Web.UI.MasterPage, IXHandler {
		public XiaoNeiApi Api { get; set; }
		public bool IsDebug { get; set; }
		public String UserID {
			get {
				return Api.Users.GetLoggedInUser();
			}
		}
		protected override void OnInit(EventArgs e) {
			this.IsDebug = false;
			base.OnInit(e);
			XiaoNeiApi.Init(this);
		}

	}
}
