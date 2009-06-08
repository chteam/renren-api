using System.Collections.Generic;
using System.Xml.Serialization;

namespace XiaoNei.ApiContainer {
	[XmlRoot("friends_getFriends_response", Namespace = "http://api.xiaonei.com/1.0/")]
	public class GetFriendsContainer {
		[XmlElement("friend", typeof(Friend))]
		public List<Friend> Friends { get; set; }
	}
}
