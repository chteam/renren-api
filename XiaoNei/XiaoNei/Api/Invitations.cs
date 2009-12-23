using System;
using System.Collections.Generic;

using System.Text;
using XiaoNei.ApiContainer;


namespace XiaoNei.Api
{
	public class Invitations : ApiBase
	{
		public Invitations(XiaoNeiApi api) : base(api) { }

		#region getOsInfo
		/// <summary>
		/// invite_ids  	string  	
		///站外邀请id，可以是一个或多个邀请id，多个邀请id之间用逗号分隔，
		///例如：3f3a77d7ad7f67,9d8f9s7af98d87,8d09fa4a6b87c958。
		///如果在App属性资料中填写了“安装后跳转地址 ”，
		///则当一个来自于站外邀请的用户安装了App后，
		///我们会在“安装后跳转地址”的url后面追加上一个惨数：
		///invite_id=xxxxxx，你可以获得到这个invite_id的参数值，
		///调用此接口，你将可以知道此次安装的用户来自于那个用户的邀请等相关信息。
		///你也可以记录下每次安装后传来的这个参数值，日后再调用此接口时批量传入invite_id值。
		///你填写的“安装后跳转地址”可能是这种形式：http://apps.xiaonei.com/helloworld/weclome.php 
		///我们追加参数后的形式可能是：http://apps.xiaonei.com/helloworld/weclome.php?invite_id=df7s3d89876dsa9d87fd
		/// </summary>
		/// <param name="inviteIds"></param>
		/// <param name="format"></param>
		/// <returns></returns>
		public List<InvitationInfo> GetOsInfo(string inviteIds, string format)
		{
			var dict = CreateDictionary("invitations.getOsInfo", true);
			dict.Add("invite_ids", inviteIds);
			return Api.Proc<GetOsInfoContainer>(dict).InvitationInfos;
		}
		/// <summary>
		/// invite_ids  	string  	
		///站外邀请id，可以是一个或多个邀请id，多个邀请id之间用逗号分隔，
		///例如：3f3a77d7ad7f67,9d8f9s7af98d87,8d09fa4a6b87c958。
		///如果在App属性资料中填写了“安装后跳转地址 ”，
		///则当一个来自于站外邀请的用户安装了App后，
		///我们会在“安装后跳转地址”的url后面追加上一个惨数：
		///invite_id=xxxxxx，你可以获得到这个invite_id的参数值，
		///调用此接口，你将可以知道此次安装的用户来自于那个用户的邀请等相关信息。
		///你也可以记录下每次安装后传来的这个参数值，日后再调用此接口时批量传入invite_id值。
		///你填写的“安装后跳转地址”可能是这种形式：http://apps.xiaonei.com/helloworld/weclome.php 
		///我们追加参数后的形式可能是：http://apps.xiaonei.com/helloworld/weclome.php?invite_id=df7s3d89876dsa9d87fd
		/// </summary>
		/// <param name="inviteIds"></param>
		/// <returns></returns>
		public List<InvitationInfo> GetOsInfo(string inviteIds)
		{
			return GetOsInfo(inviteIds, "XML");
		}
		#endregion
		#region getUserOsInviteCnt
		//uids  	string  	需要查询的用户的id，以逗号（例如：66271，66272）分割。请注意每次请不要超过100个用户。

		/// <summary>
		/// 获取用户发送站外邀请的详细信息（包括发送邀请信数量、星级用户数等）。最多每次只接受100个用户ID。
		/// </summary>
		/// <returns></returns>
		public List<OsInviteCnt> GetUserOsInviteCnt(FormatType format)
		{
			var dict = CreateDictionary("invitations.getUserOsInviteCnt", true);

			return Api.Proc<GetUserOsInviteCntContainer>(dict).OsInviteCnts;
		}
		/// <summary>
		/// 获取用户发送站外邀请的详细信息（包括发送邀请信数量、星级用户数等）。最多每次只接受100个用户ID。
		/// </summary>
		/// <returns></returns>
		public List<OsInviteCnt> GetUserOsInviteCnt()
		{
			return GetUserOsInviteCnt(FormatType.Xml);
		}

		#endregion
	}
}
