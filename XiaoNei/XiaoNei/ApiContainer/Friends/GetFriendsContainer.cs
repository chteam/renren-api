using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Collections;

namespace XiaoNei.ApiContainer.Friends {
	[XmlRoot("friends_getFriends_response", Namespace = "http://api.xiaonei.com/1.0/")]
	public class GetFriendsContainer {
		[XmlElement("friend", typeof(Friend))]
		public List<Friend> Friends { get; set; }
	}
}
