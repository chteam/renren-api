using System.Collections.Generic;
using System.Xml.Serialization;
namespace XiaoNei.ApiContainer {
	[XmlRoot("invitations_getOsInfo_response", Namespace = "http://api.renren.com/1.0/")]
	public class GetOsInfoContainer {
		[XmlElement("os_invitation_info", typeof(InvitationInfo))]
		public List<InvitationInfo> InvitationInfos { get; set; }
	}
}
