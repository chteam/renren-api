using System.Xml.Serialization;

namespace RenRen.ApiContainer {
	[XmlRoot("friends_getAppUsers_response", Namespace = "http://api.renren.com/1.0/")]
	public class GetAppUsersContainer {
		[XmlElement("uid", typeof(int))]
		public int[] UserIds { get; set; }
	}
}
