using XiaoNei.ApiContainer.Feed;

namespace XiaoNei.Api.Property {
	public class Feed : ApiBase {
		public Feed(XiaoNeiApi api) : base(api) { }
		/// <summary>
		/// 给当前登录者的好友且安装了同样应用的用户发新鲜事。
		/// </summary>
		/// <param name="template_id">注册的Feed模板Id，必须是真正注册的Feed模板</param>
		/// <param name="title_data">此项为JSON格式的数组，如果你在定义新鲜事模板的“Feed标题”时，
///自定义了一些变量（如Feed标题：{actor}完成了问卷{title}得分{mark}），那么你必须在此项中为这些变量（{actor}是系统变量，不需要赋值）赋值，
///例如此项值为：{"title":"语文课","mark":"90"}，
///此项也支持XNML语法，目前仅支持<xn:name>和<a>标签</param>
		/// <param name="body_data">此项为JSON格式的数组，规则同title_data项</param>
		/// <param name="resource_id"> 	比如：发表Blog时要分发Feed，则此参数可以传入此Blog的id。此参数在展示Feed时会用到，用于去掉重复的Feed。缺省值是 0 </param>
		/// <param name="format">Response的格式。请指定为  XML  （缺省值），或  JSON</param>
		/// <returns></returns>
		public bool PublishTemplatizedAction(int template_id, string title_data, string body_data, int resource_id, string format) {
			string xml = Api.Proc("xiaonei.feed.publishTemplatizedAction"
			, string.Format("template_id={0}&title_data={1}&body_data={2}&resource_id={3}"
							, template_id
							, title_data
							, body_data
							, resource_id)
			, format
			);
			return Api.Load<PublishTemplatizedActionContainer>(xml).IsSuccess;
		}
		/// <summary>
		/// 给当前登录者的好友且安装了同样应用的用户发新鲜事。
		/// </summary>
		/// <param name="template_id">注册的Feed模板Id，必须是真正注册的Feed模板</param>
		/// <param name="title_data">此项为JSON格式的数组，如果你在定义新鲜事模板的“Feed标题”时，
		///自定义了一些变量（如Feed标题：{actor}完成了问卷{title}得分{mark}），那么你必须在此项中为这些变量（{actor}是系统变量，不需要赋值）赋值，
		///例如此项值为：{"title":"语文课","mark":"90"}，
		///此项也支持XNML语法，目前仅支持<xn:name>和<a>标签</param>
		/// <param name="body_data">此项为JSON格式的数组，规则同title_data项</param>
		/// <returns></returns>
		public bool PublishTemplatizedAction(int template_id, string title_data, string body_data) {
			return PublishTemplatizedAction(template_id, title_data, body_data, 0, "XML");
		}
	}
}
