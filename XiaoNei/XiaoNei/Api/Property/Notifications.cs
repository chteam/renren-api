using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XiaoNei.ApiContainer.Notifications;

namespace XiaoNei.Api.Property {
	public class Notifications : ApiBase {
		public Notifications(XiaoNeiApi api) : base(api) { }
		/// <summary>
		/// 给当前登录者的好友或也安装了同样应用的用户发通知。
		/// </summary>
		/// <param name="to_ids">用户id的列表，单个或多个，可以是逗号分隔，如 8055,8066,8077 。
		///这些用户必须是当前登录者的好友或也安装了此应用。
		///请确保一次传入的用户id数少于20个。
		///如果要给当前用户发送通知，请指定此参数值为空串</param>
		/// <param name="notification">
		/// 通知的内容，可以是XNML类型的文本信息，支持的XNML有<xn:name/>和<a/>，
		///请注意：使用<xn:name/>标签的时候，其uid属性值只能是真实的用户id（阿拉伯数字）。
		///例如：hello,<xn:name uid="200032219" linked="true"/> ，去看看这部电影<a href="http://www.tudou.com/programs/view/Tzpw9PIj8zM/">狮子王</a>
		/// </param>
		/// <param name="format"></param>
		public void send(string to_ids, string notification, string format) {
			string xml = Api.Proc("xiaonei.notifications.send"
						, string.Format("to_ids={0}&notification={1}"
										, to_ids
										, notification)
						, format
						);
			Serializer.Load<SendContainer>(xml);
		}
		public void send(string to_ids, string notification) {
			send(to_ids, notification, "XML");
		}
	}
}
