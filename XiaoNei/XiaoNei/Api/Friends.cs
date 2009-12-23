using System.Collections.Generic;
using XiaoNei.ApiContainer;


namespace XiaoNei.Api {
	public class Friends: ApiBase {
		public Friends(XiaoNeiApi api) : base(api) { }
		#region get
        /*
         * required  	
         * api_key  	string  	申请应用时分配的api_key，调用接口时候代表应用的唯一身份。
	method 	string 	xiaonei.friends.get
	call_id 	float 	当前调用请求队列号，建议使用当前系统时间的毫秒值。
	sig 	string 	它是由当前请求参数和secretKey的一个MD5值, 有关签名如何认证的文档，请查看校内REST如何认证你的应用，
	v 	string 	API的版本号，请设置成1.0
	session_key 	string 	登录用户的session key. 用于验证是否为当前用户发出的请求，如果出现Session Key过期的情况请参考关于session_key过期
optional 	format 	string 	Response的格式,XML或者JSON，缺省值为XML。
	page 	int 	分页，默认为0
	count 	int 	返回每页个数，默认为500
         */
        /// <summary>
		/// 得到当前登录用户的好友列表，得到的只是含有好友uid的列表。
		/// </summary>
		/// <param name="pageSize"></param>
		/// <param name="format"></param>
		/// <param name="page"></param>
		/// <returns></returns>
        public int[] Get(int? page, int? pageSize, FormatType format)
        {
            var dict = CreateDictionary("friends.get", true);

            dict.AddNullable("page", page);
            dict.AddNullable("count", pageSize);
            return Api.Proc<GetContainer>(dict).UserIds;
        }

		public int[] Get() {
	        return Get(null, null, FormatType.Xml);
		}
        public int[] Get(int page)
        {
            return Get(page, null, FormatType.Xml);
        }
		#endregion
        #region getFriends
        /*
         required  	api_key  	string  	申请应用时分配的api_key，调用接口时候代表应用的唯一身份。
	method 	string 	xiaonei.friends.getFriends
	call_id 	float 	当前调用请求队列号，建议使用当前系统时间的毫秒值。
	sig 	string 	它是由当前请求参数和secretKey的一个MD5值, 有关签名如何认证的文档，请查看校内REST如何认证你的应用，
	v 	string 	API的版本号，请设置成1.0
	session_key 	string 	登录用户的session key. 用于验证是否为当前用户发出的请求，如果出现Session Key过期的情况请参考关于session_key过期
optional 	format 	string 	Response的格式,XML或者JSON，缺省值为XML。
	page 	int 	分页，默认为0
	count 	int 	返回每页个数，默认为500
         */
        public List<Friend> GetFriends(int? page, int? pageSize, FormatType format)
        {
            var dict = CreateDictionary("friends.getFriends", true);

            dict.AddNullable("page", page);
            dict.AddNullable("count", pageSize);
         
            return Api.Proc<GetFriendsContainer>(dict).Friends;
        }

        public List<Friend> GetFriends()
        {
            return GetFriends(null, null, FormatType.Xml);
        }
        public List<Friend> GetFriends(int page)
        {
            return GetFriends(page, null, FormatType.Xml);
        }
        public List<Friend> GetFriends(int page,int pageSize)
        {
            return GetFriends(page, pageSize, FormatType.Xml);
        }
		#endregion
		#region areFriends
        /*
         * required  	
         * api_key  	string  	申请应用时分配的api_key，调用接口时候代表应用的唯一身份。
	method 	string 	xiaonei.friends.areFriends
	call_id 	float 	当前调用请求队列号，建议使用当前系统时间的毫秒值。
	sig 	string 	它是由当前请求参数和secretKey的一个MD5值, 有关签名如何认证的文档，请查看校内REST如何认证你的应用，
	v 	string 	API的版本号，请设置成1.0
	session_key 	string 	登录用户的session key. 用于验证是否为当前用户发出的请求，如果出现Session Key过期的情况请参考关于session_key过期
	uids1 	string 	第一组用户的ID，每个ID之间以逗号分隔
	uids2 	sting 	第二组用户的ID，每个ID之间以逗号分隔
optional 	format 	string 	Response的格式,XML或者JSON，缺省值为XML。
         */
        /// <summary>
		/// 判断两组用户是否互为好友关系，比较的两组用户数必须相等
		/// 
/// </summary>
/// <param name="userIds2"></param>
/// <param name="format"></param>
/// <param name="userIds1"></param>
/// <returns></returns>
		public List<FriendInfo> AreFriends(string userIds1, string userIds2, FormatType format) {
            var dict = CreateDictionary("friends.areFriends", true);
            dict.Add("uids1", userIds1);
            dict.Add("uids2", userIds2);
            return Api.Proc<AreFriendsContainer>(dict).FriendInfos;
		}

        public List<FriendInfo> AreFriends(string userIds1, string userIds2)
		{
            
		    return AreFriends(userIds1, userIds2, FormatType.Xml);
		}

	    #endregion
		#region getAppUsers
        /*
         
         */
        public int[] GetAppUsers(FormatType format) {
            var dict = CreateDictionary("friends.getAppUsers", true);
            string xml = Api.Proc(dict.ToQueryString(Api));
			return Api.Load<GetAppUsersContainer>(xml).UserIds;
		}

		public int[] GetAppUsers() {
			return GetAppUsers(FormatType.Xml);
		}
		#endregion
        #region getAppFriends
        /*
         required  	api_key  	string  	申请应用时分配的api_key，调用接口时候代表应用的唯一身份。
	method 	string 	xiaonei.friends.getAppFriends
	call_id 	float 	当前调用请求队列号，建议使用当前系统时间的毫秒值。
	sig 	string 	它是由当前请求参数和secretKey的一个MD5值, 有关签名如何认证的文档，请查看校内REST如何认证你的应用，
	v 	string 	API的版本号，请设置成1.0
	session_key 	string 	登录用户的session key. 用于验证是否为当前用户发出的请求，如果出现Session Key过期的情况请参考关于session_key过期
optional 	format 	string 	Response的格式,XML或者JSON，缺省值为XML。
         */
        public int[] GetAppFriends(FormatType format)
        {
            var dict = CreateDictionary("friends.getAppFriends", true);
            return Api.Proc<GetAppFriendsContainer>(dict).UserIds;
        }

        public int[] GetAppFriends()
        {
            return GetAppUsers(FormatType.Xml);
        }

        public List<FriendWithUId> GetAppFriends(string fields, FormatType format)
        {
            var dict = CreateDictionary("friends.getAppFriends", true);
            dict.Add("fields", fields ?? "uid,name,tinyurl,headurl");
            return Api.Proc<GetAppFriendsContainer2>(dict).Friends;
        }
        public List<FriendWithUId> GetAppFriends(string fields)
        {
            return GetAppFriends(fields,FormatType.Xml);
        }
        #endregion
    }
}
