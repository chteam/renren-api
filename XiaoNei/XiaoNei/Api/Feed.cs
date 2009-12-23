using XiaoNei.ApiContainer;

namespace XiaoNei.Api
{
    public class Feed : ApiBase
    {
        public Feed(XiaoNeiApi api) : base(api) { }
        /*required  	
         * api_key  	string  	申请应用时分配的api_key，调用接口时候代表应用的唯一身份。
         * method 	string 	xiaonei.feed.publishTemplatizedAction
         * call_id 	float 	当前调用请求队列号，建议使用当前系统时间的毫秒值。
         * sig 	string 	它是由当前请求参数和secretKey的一个MD5值, 有关签名如何认证的文档，请查看校内REST如何认证你的应用，
         * v 	string 	API的版本号，请设置成1.0
         * session_key 	string 	登录用户的session key. 用于验证是否为当前用户发出的请求，如果出现Session Key过期的情况请参考关于session_key过期
         * template_id 	int 	注册的Feed模板Id，必须是真正注册的Feed模板，可以参考“注册Feed模板”
         * title_data 	sting 	此项为JSON格式的数组，如果你在定义新鲜事模板的“Feed标题”时，
         * 自定义了一些变量（如Feed标题：{actor}完成了问卷{title}得分{mark}），那么你必须在此项中为这些变量（{actor}是系统变量，不需要赋值）赋值，
         * 例如此项值为：{"title":"语文课","mark":"90"}，
         * 此项也支持XNML语法，目前仅支持<xn:name>和<a>标签
         * body_data 	int 	此项为JSON格式的数组，规则同title_data项
         * optional 	
         * format 	string 	Response的格式,XML或者JSON，缺省值为XML
         */



        /// <summary>
        /// 给当前登录者的好友且安装了同样应用的用户发新鲜事。
        /// </summary>
        /// <param name="templateId">注册的Feed模板Id，必须是真正注册的Feed模板</param>
        /// <param name="titleData">此项为JSON格式的数组，如果你在定义新鲜事模板的“Feed标题”时，
        ///自定义了一些变量（如Feed标题：{actor}完成了问卷{title}得分{mark}），那么你必须在此项中为这些变量（{actor}是系统变量，不需要赋值）赋值，
        ///例如此项值为：{"title":"语文课","mark":"90"}，
        ///此项也支持XNML语法，目前仅支持<xn:name>和<a>标签</param>
        /// <param name="bodyData">此项为JSON格式的数组，规则同title_data项</param>
        /// <param name="format">Response的格式。请指定为  XML  （缺省值），或  JSON</param>
        /// <returns></returns>
        public bool PublishTemplatizedAction(int templateId, string titleData, string bodyData, FormatType format)
        {
            var dict = CreateDictionary("feed.publishTemplatizedAction",true);
            dict.Add("template_id", templateId.ToString());
            dict.Add("title_data", titleData);
            dict.Add("body_data", bodyData);
            //add format
            return Api.Proc<PublishTemplatizedActionContainer>(dict).IsSuccess;
        }
        /// <summary>
        /// 给当前登录者的好友且安装了同样应用的用户发新鲜事。
        /// </summary>
        /// <param name="templateId">注册的Feed模板Id，必须是真正注册的Feed模板</param>
        /// <param name="titleData">此项为JSON格式的数组，如果你在定义新鲜事模板的“Feed标题”时，
        ///自定义了一些变量（如Feed标题：{actor}完成了问卷{title}得分{mark}），那么你必须在此项中为这些变量（{actor}是系统变量，不需要赋值）赋值，
        ///例如此项值为：{"title":"语文课","mark":"90"}，
        ///此项也支持XNML语法，目前仅支持<xn:name>和<a>标签</param>
        /// <param name="bodyData">此项为JSON格式的数组，规则同title_data项</param>
        /// <returns></returns>
        public bool PublishTemplatizedAction(int templateId, string titleData, string bodyData)
        {
            return PublishTemplatizedAction(templateId, titleData, bodyData, FormatType.Xml);
        }
    }
}
