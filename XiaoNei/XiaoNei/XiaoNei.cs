using System;
using System.Text;
using System.Web;
using XiaoNei.Api.Property;
using System.Collections.Generic;

namespace XiaoNei {
	public class XiaoNeiApi {

		public XiaoNeiApi(string apikey, string secret) {
			Cache = new Dictionary<string, string>();
			ApiKey = apikey;
			Secret = secret;
			PostData = string.Format("api_key={0}&session_key={1}&v={2}&call_id=.&sig=.&", ApiKey, Secret, Version);
		}
	
		public string Version = "1.0";
		public string ApiKey { get; set; }
		public string Secret { get; set; }
		string ApiUrl = "http://api.xiaonei.com/restserver.do";

		public String PostData { get; set; }
		#region QueryData
		string _queryData = null;
		public string QueryData {
			get {
				if (_queryData == null)
					_queryData = string.Format(
						"xn_sig_session_key={0}&xn_sig_api_key={1}"
						, Secret, ApiKey
						);
				return _queryData;
			}
		}
		#endregion
		Dictionary<string, string> Cache { get; set; }
		public string Proc(string method, string param, string format) {
			string key = string.Format("{0}{1}{2}", method, param, format);
			if (!this.Cache.ContainsKey(key)) {

				HttpProc proc = new HttpProc(ApiUrl);
				proc.strPostdata = string.Format("{0}method={1}&format={3}&{2}", PostData, method, param, format);
				proc.encoding = Encoding.UTF8;
				string ret = proc.Proc();
				Cache.Add(key, ret);
			}
			if (Cache[key].Contains("error_response"))
				throw new Exception("Api调用返回错误");
			return Cache[key];
		}
		#region XiaoNeiApi
		Users _users =null;
		public Users Users {
			get {
				if (_users == null)
					_users = new Users(this);
				return _users;
			}
		}
		Profile _profile = null;
		public Profile Profile {
			get {
				if (_profile == null)
					_profile = new Profile(this);
				return _profile;
			}
		}
		Friends _friends = null;
		public Friends Friends {
			get {
				if (_friends == null)
					_friends = new Friends(this);
				return _friends;
			}
		}
		Feed _feed = null;
		public Feed Feed {
			get {
				if (_feed == null)
					_feed = new Feed(this);
				return _feed;
			}
		}
		Notifications _notifications = null;
		public Notifications Notifications {
			get {
				if (_notifications == null)
					_notifications = new Notifications(this);
				return _notifications;
			}
		}
		Invitations _Invitations = null;
		public Invitations Invitations {
			get {
				if (_Invitations == null)
					_Invitations = new Invitations(this);
				return _Invitations;
			}
		}
		#endregion

		#region init 
		public static void Init(IXHandler ih) {
			try {
				string secret = HttpContext.Current.Request.QueryString["xn_sig_session_key"].ToString();
				secret = HttpContext.Current.Server.UrlEncode(secret);
				string apiKey = HttpContext.Current.Request.QueryString["xn_sig_api_key"];
				ih.Api = new XiaoNeiApi(apiKey, secret);
			} catch {
				HttpContext.Current.Response.Write("本程序为校内网应用程序，请登录后再使用");
				HttpContext.Current.Response.End();
			}
		}
		#endregion
	}
}
