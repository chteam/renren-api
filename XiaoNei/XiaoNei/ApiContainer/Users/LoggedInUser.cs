using System;
using System.Collections.Generic;

using System.Text;
using System.Xml.Serialization;
using System.Collections;

namespace XiaoNei {
	[XmlRoot("users_getLoggedInUser_response", Namespace = "http://api.xiaonei.com/1.0/")]
	public class LoggedInUser {
		[XmlText]
		public String UID { get; set; }
	}
}
