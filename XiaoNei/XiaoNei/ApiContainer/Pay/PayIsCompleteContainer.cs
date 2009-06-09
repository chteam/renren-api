using System.Xml.Serialization;

namespace XiaoNei.ApiContainer
{
    [XmlRoot("pay_isCompleted_response", Namespace = "http://api.xiaonei.com/1.0/")]
    internal class PayIsCompleteContainer
    {
        [XmlText(typeof(bool))]
        public bool Result { get; set; }
    }
}