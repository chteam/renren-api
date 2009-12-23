using XiaoNei.ApiContainer;
using System.Linq;
namespace XiaoNei.Api {
	public class Users : ApiBase {
		public Users(XiaoNeiApi api) : base(api) { }
		#region getInfo
        /*
    uids  	string  	需要查询的用户的id。
	fields 	string 	返回的字段列表，可以指定返回那些字段，用逗号分隔。如：name,sex,hometown_location。
         */
        /// <summary>
		/// 得到用户信息，当对方设置了隐私权限，只能返回 name、sex、headurl等数据
		/// </summary>
		public User[] GetInfo(string uids, string fields, FormatType format) {
            var dict = CreateDictionary("users.getInfo", true);
            dict.Add("uids", uids);
            dict.Add("fields", fields);
			return Api.Proc<UserContainer>(dict).Users;
		}
        public User[] GetInfo(long[] uid, string[] fields, FormatType format)
        {
            return GetInfo(string.Join(",", uid.Select(c => c.ToString()).ToArray()), string.Join(",", fields), format);
		}
        public User[] GetInfo(long[] uids, string[] fields)
        {
			return GetInfo(string.Join(",", uids.Select(c=>c.ToString()).ToArray()), string.Join(",", fields));
		}
        public User[] GetInfo(string uids, string fields)
        {
			return GetInfo(uids, fields,  FormatType.Xml);
		}
        public User[] GetInfo(string uids, bool getAll)
        {
            return GetInfo(uids,
                           getAll
                               ? "name,sex,birthday,tinyurl,headurl,mainurl,hometown_location,work_history,university_history,hs_history,contact_info,books,movies,music"
                               : "");
        }
        public User GetInfo(long uid)
        {
		    return GetInfo(uid.ToString(), false).FirstOrDefault();
		}
        public User[] GetInfo(params long[] uids)
        {
			return GetInfo(string.Join(",", uids.Select(c=>c.ToString()).ToArray()),false);
		}
		#endregion

		#region getLoggedInUser
		/// <summary>
		/// 得到当前session的用户ID
		/// </summary>
		/// <returns></returns>
        public long GetLoggedInUser(FormatType format)
		{
		    //if (Api.HttpContext.Session["users.uid"] == null) {
            var dict = CreateDictionary("users.getLoggedInUser", true);

		    return  Api.Proc<LoggedInUserContainer>(dict).UserId;
		    //	}
		    //	return Api.HttpContext.Session["users.uid"].ToString();
		}

	    /// <summary>
        /// 得到当前session的用户ID
        /// </summary>
        /// <returns></returns>
		public long GetLoggedInUser() {
			return GetLoggedInUser(FormatType.Xml);
		}
		#endregion

        #region Users.hasAppPermission
        /*
         * ext_perm  	string  	用户可操作的功能,现阶段只能对email进行判定.email
         * optional 	
         * format 	string 	Response的格式。请指定为XML（缺省值）
         * session_key 	string 	登录用户的session key. 用于验证是否为当前用户发出的请求，如果出现Session Key过期的情况请参考关于session_key过期
         * uid 	long 	用户id
         */
        public bool HasAppPermission(string extPerm, long? uid,FormatType format)
        {
            var dict = CreateDictionary("users.hasAppPermission", true);
            dict.Add("ext_perm", extPerm);
            dict.AddNullable("uid", uid);

            return Api.Proc<HasAppPermissionContainer>(dict).Has;
        }
        public bool HasAppPermission(string extPerm, long? uid)
        {
            return HasAppPermission(extPerm, uid,FormatType.Xml);
        }

	    #endregion

        #region isAppAdded

        /// <summary>
		/// 判断用户（当前会话用户或者是一个指定ID的用户）是否已经添加了该应用
		/// </summary>
		/// <param name="uid"></param>
		/// <param name="format"></param>
		/// <returns></returns>
        public bool IsAppAdded(string uid, FormatType format)
        {
            var dict = CreateDictionary("users.isAppAdded", true);
            if (!string.IsNullOrEmpty(uid))
                dict.Add("uid", uid);
			return Api.Proc<IsAppAddedContainer>(dict).Val == 1;
		}
		public bool IsAppAdded(string uid) {
            return IsAppAdded(uid, FormatType.Xml);
		}
		public bool IsAppAdded() {
            return IsAppAdded(null, FormatType.Xml);
		}
		#endregion
	}
}
