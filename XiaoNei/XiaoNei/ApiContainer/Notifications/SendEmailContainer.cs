using System.Xml.Serialization;

namespace RenRen.ApiContainer {
	[XmlRoot("friends_get_response", Namespace = "http://api.renren.com/1.0/")]
	public class GetContainer {
		[XmlElement("uid", typeof(int))]
		public int[] UserIds { get; set; }
	}
}
