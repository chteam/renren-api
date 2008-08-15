using System;
using System.Collections.Generic;

using System.Text;
using System.Xml.Serialization;

namespace XiaoNei.ApiContainer.Friends {
	[XmlRoot("friends_getAppUsers_response", Namespace = "http://api.xiaonei.com/1.0/")]
	public class GetAppUsersContainer {
		[XmlElement("uid", typeof(int))]
		public int[] UIDs { get; set; }
	}
}
