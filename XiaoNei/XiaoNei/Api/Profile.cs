using System;
using System.Collections.Generic;

using System.Text;
using XiaoNei.ApiContainer.Profile;
using System.Web;

namespace XiaoNei.Api {
	public class Profile  : ApiBase {
		public Profile(XiaoNeiApi api) : base(api) { }
		public string GetXNML(string uid,string format) {
		    var dict = CreateDictionary("xiaonei.profile.getXNML", true);
		    dict.Add("uid", uid);
			return Api.Proc<GetXNML>(dict).Val;
		}
		public int SetXNML(string uid, string profile, string profileAction, string format) {

			string xml = Api.Proc("xiaonei.profile.setXNML"
				, string.Format("uid={0}&profile={1}&profile_action={2}", uid.Trim()
								,HttpContext.Current.Server.UrlEncode(profile)
								, HttpContext.Current.Server.UrlEncode(profileAction)
								)
				, format
				);
			return Api.Proc<SetXNML>(xml).Val;
		}
	}
}
