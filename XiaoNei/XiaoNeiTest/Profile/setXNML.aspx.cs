using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Profile_setXNML : XPage {
	protected void Page_Load(object sender, EventArgs e) {

	}
	protected void Button1_Click(object sender, EventArgs e) {
	Literal1.Text=	Api.Profile.SetXNML(TextBox3.Text, TextBox1.Text, TextBox2.Text, "XML").ToString();
	}
}
