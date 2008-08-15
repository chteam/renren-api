using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Invitations_getOsInfo : XPage {
	protected void Page_Load(object sender, EventArgs e) {

	}
	protected void Button1_Click(object sender, EventArgs e) {
		Api.Invitations.GetOsInfo(TextBox1.Text, "Xml");
	}
}
