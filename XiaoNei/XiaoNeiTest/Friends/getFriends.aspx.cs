using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RenRen;

public partial class Friends_getFriends : XPage {
	protected void Page_Load(object sender, EventArgs e) {

	}
	protected void Button1_Click(object sender, EventArgs e) {
		fs = Api.Friends.GetFriends();
	}
	public List<Friend> fs { get; set; }
}
