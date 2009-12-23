using XiaoNei.ApiContainer.Profile;

namespace XiaoNei.Api {
	public class Profile  : ApiBase {
		public Profile(XiaoNeiApi api) : base(api) { }
		public string GetXNML(string uid,FormatType format) {
		    var dict = CreateDictionary("profile.getXNML", true);
		    dict.Add("uid", uid);
			return Api.Proc<GetXNML>(dict).Val;
		}
        public int SetXNML(string uid, string profile, FormatType format)
        {
		    var dict = CreateDictionary("profile.setXNML", true);
		    dict.Add("uid", uid);
            dict.Add("profile", profile);
			return Api.Proc<SetXNML>(dict).Val;
		}
	}
}
