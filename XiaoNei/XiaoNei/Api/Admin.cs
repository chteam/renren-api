using XiaoNei.ApiContainer.Admin;

namespace XiaoNei.Api
{
    public class Admin : ApiBase
    {
        public Admin(XiaoNeiApi api) : base(api) { }

        /// <summary>
        /// 获取一个应用当天可以发送的通知的配额
        /// <example>
        ///required api_key string 申请应用时分配的api_key，调用接口时候代表应用的唯一身份。 
        ///method string xiaonei.admin.getAllocation 
        ///call_id float 当前调用请求队列号，建议使用当前系统时间的毫秒值。 
        ///sig string 它是由当前请求参数和secretKey的一个MD5值, 有关签名如何认证的文档，请查看校内REST如何认证你的应用， 
        ///v  	string  	API的版本号，请设置成1.0
        ///optional 	format 	string 	Response的格式,XML或者JSON，缺省值为XML。
        /// </example>
        /// </summary>
        /// <returns></returns>
        public AllocationContainer Allocation(FormatType format)
        {
            var dict = CreateDictionary("xiaonei.admin.getAllocation");
            //add format
            return Api.Proc<AllocationContainer>(dict);
        }
        public AllocationContainer Allocation()
        {
            return Allocation(FormatType.Xml);
        }
    }
}