using System;
using System.Collections.Generic;

using System.Text;
using System.Xml.Serialization;

namespace XiaoNei.ApiContainer.Friends {
	[XmlRoot("friends_areFriends_response", Namespace = "http://api.xiaonei.com/1.0/")]
	public class areFriendsContainer {
		[XmlElement("friend_info", typeof(FriendInfo))]
		public List<FriendInfo> FriendInfos { get; set; }
	}
}
