using System;
using System.Collections.Generic;

using System.Text;
using System.Xml.Serialization;
using System.Collections;

namespace XiaoNei {
	[XmlRoot("users_getInfo_response", Namespace = "http://api.xiaonei.com/1.0/")]
	public class UserContainer  {
		[XmlElement("user", typeof(User))]
		public ArrayList Users { get; set; }
	}
}
