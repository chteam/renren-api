using System.Xml.Serialization;

namespace RenRen {
	public class FriendInfo {
		[XmlElement("uid1")]
		public string Id1 { get; set; }
		[XmlElement("uid2")]
		public string Id2 { get; set; }
		[XmlElement("are_friends")]
		public bool AreFriends { get; set; }
	}
}
