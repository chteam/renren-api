using System;
using System.Xml.Serialization;

namespace RenRen {
	
	public class InvitationInfo {
		/// <summary>
		/// 邀请人Id
		/// </summary>
		[XmlElement("inviter_uid")]
		public string InviterUid { get; set; }
		/// <summary>
		/// 邀请时间
		/// </summary>
		[XmlElement("invite_time")]
		public DateTime InviteTime { get; set; }
		/// <summary>
		/// 被邀请人Id
		/// </summary>
		[XmlElement("invitee_uid")]
		public string InviteeUid { get; set; }
		/// <summary>
		/// 安装时间
		/// </summary>
		[XmlElement("install_time")]
		public DateTime InstallTime { get; set; }
	}
}
