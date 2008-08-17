using System;
using System.Collections.Generic;

using System.Text;
using System.Web;

namespace XiaoNei.Api.Property {
	public class Users : ApiBase {
		public Users(XiaoNeiApi api) : base(api) { }
		#region getInfo
		/// <summary>
		/// 得到用户信息，当对方设置了隐私权限，只能返回 name、sex、headurl等数据
		/// </summary>
		public UserContainer GetInfo(string uid, string fields, string format) {
			string xml=Api.Proc("xiaonei.users.getInfo"
				,string.Format("uids={0}&fields={1}", uid.Trim(), fields.Trim())
				, format
				);
			return Api.Load<UserContainer>(xml);
		}
		public UserContainer GetInfo(string[] uid, string[] fields, string format) {
			return GetInfo(string.Join(",", uid), string.Join(",", fields), format);
		}
		public UserContainer GetInfo(string[] uid, string[] fields) {
			return GetInfo(string.Join(",", uid), string.Join(",", fields));
		}
		public UserContainer GetInfo(string  uid, string  fields) {
			return GetInfo(uid, fields, "");
		}
		public UserContainer GetInfo(string uid) {
			return GetInfo(uid
				, "name,sex,birthday,tinyurl,headurl,mainurl,hometown_location,work_history,university_history,hs_history,contact_info,books,movies,music"
, "");
		}
		public UserContainer GetInfo(string[] uid) {
			return GetInfo(string.Join(",", uid));
		}
		#endregion
		#region getLoggedInUser
		/// <summary>
		/// 得到当前session的用户ID
		/// </summary>
		/// <returns></returns>
		public string GetLoggedInUser(string format) {
			if (HttpContext.Current.Session["xiaonei.users.uid"] == null) {
				string xml = Api.Proc("xiaonei.users.getLoggedInUser"
				, string.Empty
				, format
				);

				HttpContext.Current.Session["xiaonei.users.uid"] = Api.Load<LoggedInUser>(xml).UID;
			}
			return HttpContext.Current.Session["xiaonei.users.uid"].ToString();
		}
		public string GetLoggedInUser() {
			return GetLoggedInUser("XML");
		}
		#endregion

		#region isAppAdded

		/// <summary>
		/// 判断用户（当前会话用户或者是一个指定ID的用户）是否已经添加了该应用
		/// </summary>
		/// <param name="uid"></param>
		/// <returns></returns>
		public bool IsAppAdded(string uid, string format) {
			string xml = Api.Proc("xiaonei.users.isAppAdded"
				, string.Format("uid={0}", uid.Trim())
				, format
				);
			return Api.Load<IsAppAdded>(xml).Val == 1;
		}
		public bool IsAppAdded(string uid) {
			return IsAppAdded(uid,"XML");
		}
		public bool isAppAdded() {
			return IsAppAdded("", "XML");
		}
		#endregion
	}
}
