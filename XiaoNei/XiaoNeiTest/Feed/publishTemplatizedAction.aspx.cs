﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Feed_publishTemplatizedAction : XPage {
	protected void Page_Load(object sender, EventArgs e) {

	}
	protected void Button1_Click(object sender, EventArgs e) {
		Literal1.Text = Api.Feed.PublishTemplatizedAction(1, TextBox1.Text, TextBox2.Text).ToString();
	}
}
