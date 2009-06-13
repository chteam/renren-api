using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page {
	protected void Page_Load(object sender, EventArgs e) {

	}
    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["xn_sig_api_key"] = TextBox1.Text;
        Session["xn_sig_session_key"] = TextBox2.Text;
        Session["secret"] = TextBox3.Text;
    }
}
