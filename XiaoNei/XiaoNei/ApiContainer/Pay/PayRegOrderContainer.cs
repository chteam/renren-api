using System.Xml.Serialization;

namespace XiaoNei.ApiContainer
{
    [XmlRoot("pay_regOrder_response", Namespace = "http://api.renren.com/1.0/")]
    public class PayRegOrderContainer
	{
        [XmlElement("token",typeof(string))]
        public string Token { get; set; }
    }
}