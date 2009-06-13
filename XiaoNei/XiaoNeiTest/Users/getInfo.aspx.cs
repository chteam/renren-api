using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using XiaoNei;
using XiaoNei.ApiContainer;

public partial class Users_getInfo : XPage {
	protected void Page_Load(object sender, EventArgs e) {

	}
	public IEnumerable<User> UserList { get; set; }
	protected void Button1_Click(object sender, EventArgs e) {
        UserContainer uc = Api.Users.GetInfo(TextBox1.Text, TextBox2.Text, DropDownList1.Text.ToFormatType());
        Literal1.Text = Api.Save(uc);
	}
}
