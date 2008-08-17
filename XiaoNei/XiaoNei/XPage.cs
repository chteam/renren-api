using System;
using XiaoNei;

public class XPage : System.Web.UI.Page, IXHandler {
	public XiaoNeiApi Api { get; set; }
	public bool IsDebug { get; set; }
	public String UserID {
		get {
			return Api.Users.GetLoggedInUser();
		}
	}
	protected override void OnInit(EventArgs e) {
		base.OnInit(e);
		XiaoNeiApi.Init(this);
	}
}
