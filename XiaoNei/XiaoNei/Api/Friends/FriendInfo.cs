using System.Xml.Serialization;

namespace XiaoNei {
	public class FriendInfo {
		[XmlElement("uid1")]
		public string ID1 { get; set; }
		[XmlElement("uid2")]
		public string ID2 { get; set; }
		[XmlElement("are_friends")]
		public bool areFriends { get; set; }
	}
}
