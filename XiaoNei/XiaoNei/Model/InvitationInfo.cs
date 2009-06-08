using System;
using System.Xml.Serialization;

namespace XiaoNei {

	public class InvitationInfo {
		[XmlElement("inviter_uid")]
		public string InviterUid { get; set; }
		[XmlElement("invite_time")]
		public DateTime InviteTime { get; set; }
		[XmlElement("invitee_uid")]
		public string InviteeUid { get; set; }
		[XmlElement("install_time")]
		public DateTime InstallTime { get; set; }
	}
}
