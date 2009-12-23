﻿using System.Xml.Serialization;

namespace XiaoNei.ApiContainer {
    [XmlRoot("friends_getAppFriends_response", Namespace = "http://api.xiaonei.com/1.0/")]
    public class GetAppFriendsContainer
    {
		[XmlElement("uid", typeof(int))]
		public int[] UserIds { get; set; }
	}
}