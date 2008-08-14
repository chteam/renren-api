using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XiaoNei.ApiContainer.Invitations;

namespace XiaoNei.Api.Property {
	public class Invitations : ApiBase {
		public Invitations(XiaoNeiApi api) : base(api) { }

		public List<InvitationInfo> getOsInfo(string invite_ids, string format) {
			string xml = Api.Proc("xiaonei.invitations.getOutsite "
			, string.Format("invite_ids={0}",invite_ids)
			, format
			);
			return Serializer.Load<GetOsInfoContainer>(xml).InvitationInfos;
		}
		public List<InvitationInfo> getOsInfo(string invite_ids) {
			return getOsInfo(invite_ids, "XML");
		}
	}
}
