using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using XiaoNei;

public partial class Friends_areFriends : XPage {
	protected void Page_Load(object sender, EventArgs e) {

	}
	protected void Button1_Click(object sender, EventArgs e) {
		fis = Api.Friends.AreFriends(TextBox1.Text, TextBox2.Text);
	}
	public List<FriendInfo> fis { get; set; }
}
