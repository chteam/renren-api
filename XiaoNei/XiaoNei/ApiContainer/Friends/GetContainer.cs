using System.Xml.Serialization;

namespace XiaoNei.ApiContainer {
    [XmlRoot("notifications_sendEmail_response", Namespace = "http://api.xiaonei.com/1.0/")]
    public class SendEmailContainer
    {
		[XmlElement("uid", typeof(long))]
		public long[] UserIds { get; set; }
	}
}
