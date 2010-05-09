using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RenRen.ApiContainer;

namespace RenRen.Api
{
    public class Notifications : ApiBase
    {
        public Notifications(RenRenApi api) : base(api) { }
        #region send
        /*
          	to_ids  	string  	用户id的列表，单个或多个，可以是逗号分隔，如 8055,8066,8077 。
这些用户必须是当前登录者的好友或也安装了此应用。
请确保一次传入的用户id数少于20个。
如果要给当前用户发送通知，请指定此参数值为空串
	notification 	string 	通知的内容，可以是XNML类型的文本信息，支持的XNML有<xn:name/>和<a/>，
请注意：使用<xn:name/>标签的时候，其uid属性值只能是真实的用户id（阿拉伯数字）。
例如：hello,<xn:name uid="200032219" linked="true"/> ，去看看这部电影<a href="http://www.tudou.com/programs/view/Tzpw9PIj8zM/">狮子王</a>
         */

        /// <summary>
        /// 给当前登录者的好友或也安装了同样应用的用户发通知。
        /// </summary>
        /// <param name="toIds">用户id的列表，单个或多个，可以是逗号分隔，如 8055,8066,8077 。
        ///这些用户必须是当前登录者的好友或也安装了此应用。
        ///请确保一次传入的用户id数少于20个。
        ///如果要给当前用户发送通知，请指定此参数值为空串</param>
        /// <param name="notification">
        /// 通知的内容，可以是XNML类型的文本信息，支持的XNML有<xn:name/>和<a/>，
        ///请注意：使用<xn:name/>标签的时候，其uid属性值只能是真实的用户id（阿拉伯数字）。
        ///例如：hello,<xn:name uid="200032219" linked="true"/> ，去看看这部电影<a href="http://www.tudou.com/programs/view/Tzpw9PIj8zM/">狮子王</a>
        /// </param>
        /// <param name="format"></param>
        public void Send(string notification, string toIds, FormatType format)
        {
            var dict = CreateDictionary("notifications.send", true);
            dict.Add("to_ids", toIds);
            dict.Add("notification", notification);
            string result = Api.Proc(dict.ToQueryString(Api));
            Api.Load<SendContainer>(result);
        }
        public void Send(string notification, string toIds)
        {
            Send(notification, toIds, FormatType.Xml);
        }
        public void Send(string notification, params long[] id)
        {
            Send(
                notification,
                string.Join(",", id.Select(c => c.ToString()).ToArray()),
                FormatType.Xml);
        }

        #endregion
        #region Notifications.sendemail

        /*
         *     1.基本功能： 

可以给安装应用的用户发送电子邮件，用户可设置授权和拒绝接收来自应用的电子邮件或拒绝接收所有来自应用的邮件。应用必须通过审核，每周只能给每个用户发送一封邮件。开发者可以在应用后台编辑邮件模板（编辑属性），每个应用只允许自定义5个模板，每次修改都需要通过审核后方可再次发送。发送邮件后，用户在一天后才能接收到邮件。邮件将以打包形式发送给授权的用户。

    2.特殊标签和测试功能： 

针对开发者emial模板测试我们提供了测试端口，开发者可以即时地对email模板进行测试；同时引入两个关键词{Acceptor}, {FriendsName}：{Acceptor}为接受email的用户在校内网的姓名，在模板标题和内容中均可直接使用;{FriendsName} 为{Acceptor}的好友姓名，但需要针对每个邮件接收者（必须暗安装了应用）在参数body_data以json格式单独传递 FriendsId（用","隔开）。同时email模板支持xn:name和a标签。

    3.使用测试接口的条件： 

a.email模板没有通过审核；
b.用户在隐私设置中将邮件提醒对应项打开；
c.用户对单个应用的email没有屏蔽。
d.应用必须通过审核。

    4.使用正式接口的条件： 

a.email模板必须通过审核；
b.用户在隐私设置中将邮件提醒对应项打开；
c.用户对单个应用的email没有屏蔽。
d.应用必须通过审核。
e.email发送数量符合应用配额。
[编辑] 参数表 
         * 
      	recipients  	string  	用户id的列表，单个或多个，可以是逗号分隔，如 8055,8066,8077 。 这些用户必须安装了此应用。
	template_id 	int 	此应用的email模板号.在模板中你可以对邮件标题和邮件内容进行定义，内容可以是XNML类型的

文本信息，支持的XNML有<xn:name/>和<a/>，请注意：使用<xn:name/>标签的时候，其uid属性值只能是真实的用户id（阿拉伯数字）。例如：hello,<xn:name uid="200032219" linked="true"/>, 去看看这部电影<a href="http://apps.xiaonei.com/programs/view/Tzpw9PIj8zM/">狮子王</a>
	body_data 	String 	为 {FriendsName}提供用户好友id，为json格式：{"FriendsId":{"用户Id":"好友id串", "8066":"43423,23423,3423423", "8077":"3434"}}.当body_data格式不为{"FriendsId":{}}，或不符合json格式时将报错。 
     */
        public long[] SendEmail(int templateId, string recipients, string bodyData)
        {
            var dict = CreateDictionary("notifications.sendemail", true);
            dict.Add("template_id", templateId.ToString());
            dict.Add("recipients", recipients);
            dict.Add("body_data", bodyData);
            
            return Api.Proc<SendEmailContainer>(dict).UserIds;
        }

        #endregion

    }
}
