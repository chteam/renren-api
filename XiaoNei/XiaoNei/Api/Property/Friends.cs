using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XiaoNei.ApiContainer.Friends;

namespace XiaoNei.Api.Property {
	public class Friends: ApiBase {
		public Friends(XiaoNeiApi api) : base(api) { }
		#region get
		/// <summary>
		/// 得到当前登录用户的好友列表，得到的只是含有好友uid的列表。
		/// </summary>
		/// <param name="format"></param>
		/// <returns></returns>
		public int[] get(string format) {
			string xml = Api.Proc("xiaonei.friends.get"
				, ""
				, format
				);
			return Serializer.Load<GetContainer>(xml).UIDs;
		}
		/// <summary>
		/// 得到当前登录用户的好友列表，得到的只是含有好友uid的列表。
		/// </summary>
		/// <returns></returns>
		public int[] get() {
			return get("XML");
		}
		#endregion
		#region getFriends
		/// <summary>
		/// 得到当前登录用户的好友列表
		/// </summary>
		/// <param name="format"></param>
		/// <returns></returns>
		public List<Friend> getFriends(string format) {
			string xml = Api.Proc("xiaonei.friends.getFriends"
				, ""
				, format
				);
			return Serializer.Load<GetFriendsContainer>(xml).Friends;
		}
		/// <summary>
		/// 得到当前登录用户的好友列表
		/// </summary>
		/// <returns></returns>
		public List<Friend> getFriends() {
			return getFriends("XML");
		}
		#endregion
		#region areFriends
/// <summary>
		/// 判断两组用户是否互为好友关系，比较的两组用户数必须相等
/// </summary>
/// <param name="uid1"></param>
/// <param name="uid2"></param>
/// <param name="format"></param>
/// <returns></returns>
		public List<FriendInfo> areFriends(string uids1, string uids2, string format) {
			string xml = Api.Proc("xiaonei.friends.areFriends"
				, string.Format("uids1={0}&uids2={1}", uids1.Trim(), uids2.Trim())
				, format
				);
			return Serializer.Load<areFriendsContainer>(xml).FriendInfos;
		}
		/// <summary>
		/// 判断两组用户是否互为好友关系，比较的两组用户数必须相等
		/// </summary>
		/// <param name="uid1"></param>
		/// <param name="uid2"></param>
		/// <returns></returns>
		public List<FriendInfo> areFriends(string uids1, string uids2) {
			return areFriends(uids1, uids2, "XML");
		}
		#endregion
		#region getAppUsers
		public int[] getAppUsers(string format) {
			string xml = Api.Proc("xiaonei.friends.getAppUsers"
				, ""
				, format
				);
			return Serializer.Load<GetAppUsersContainer>(xml).UIDs;
		}

		public int[] getAppUsers() {
			return getAppUsers("XML");
		}
		#endregion
	}
}
