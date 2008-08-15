using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Users_isAppAdded : XPage {
	protected void Page_Load(object sender, EventArgs e) {

	}
	protected void Button1_Click(object sender, EventArgs e) {
		Literal1.Text = "否";
		if (Api.Users.IsAppAdded(TextBox1.Text)) {
			Literal1.Text = "是";
		}
	}
}
