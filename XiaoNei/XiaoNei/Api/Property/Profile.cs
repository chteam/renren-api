using System;
using System.Collections.Generic;

using System.Text;
using XiaoNei.ApiContainer.Profile;
using System.Web;

namespace XiaoNei.Api.Property {
	public class Profile  : ApiBase {
		public Profile(XiaoNeiApi api) : base(api) { }
		public string GetXNML(string uid,string format) {
			string xml = Api.Proc("xiaonei.profile.getXNML"
				, string.Format("uid={0}", uid.Trim())
				, format 
				);
			return Serializer.Load<GetXNML>(xml).Val;
		}
		public int SetXNML(string uid, string profile, string profile_action, string format) {
			string xml = Api.Proc("xiaonei.profile.setXNML"
				, string.Format("uid={0}&profile={1}&profile_action={2}", uid.Trim()
								,HttpContext.Current.Server.UrlEncode(profile)
								, HttpContext.Current.Server.UrlEncode(profile_action)
								)
				, format
				);
			return Serializer.Load<SetXNML>(xml).Val;
		}
	}
}
