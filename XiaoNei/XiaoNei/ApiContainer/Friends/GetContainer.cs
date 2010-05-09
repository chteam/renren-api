using System.Xml.Serialization;

namespace RenRen.ApiContainer {
    [XmlRoot("notifications_sendEmail_response", Namespace = "http://api.renren.com/1.0/")]
    public class SendEmailContainer
    {
		[XmlElement("uid", typeof(long))]
		public long[] UserIds { get; set; }
	}
}
