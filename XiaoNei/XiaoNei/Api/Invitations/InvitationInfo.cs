using System;
using System.Xml.Serialization;

namespace XiaoNei {

	public class InvitationInfo {
		[XmlElement("inviter_uid")]
		public string InviterUID { get; set; }
		[XmlElement("invite_time")]
		public DateTime InviteTime { get; set; }
		[XmlElement("invitee_uid")]
		public string InviteeUID { get; set; }
		[XmlElement("install_time")]
		public DateTime InviteeTime { get; set; }
	}
}
