using System.Xml.Serialization;

namespace XiaoNei.ApiContainer {
	[XmlRoot("friends_get_response", Namespace = "http://api.xiaonei.com/1.0/")]
	public class GetContainer {
		[XmlElement("uid", typeof(int))]
		public int[] UserIds { get; set; }
	}
}
