using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace XiaoNei.ApiContainer.Invitations {
	[XmlRoot("invitations_getOsInfo_response", Namespace = "http://api.xiaonei.com/1.0/")]
	public class GetOsInfoContainer {
		[XmlElement("os_invitation_info", typeof(InvitationInfo))]
		public List<InvitationInfo> InvitationInfos { get; set; }
	}
}
