using System.Collections.Generic;
using System.Xml.Serialization;

namespace RenRen.ApiContainer {
	[XmlRoot("friends_areFriends_response", Namespace = "http://api.renren.com/1.0/")]
	public class AreFriendsContainer {
		[XmlElement("friend_info", typeof(FriendInfo))]
		public List<FriendInfo> FriendInfos { get; set; }
	}
}
