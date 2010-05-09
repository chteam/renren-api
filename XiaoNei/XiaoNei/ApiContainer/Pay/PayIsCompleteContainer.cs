using System.Xml.Serialization;

namespace RenRen.ApiContainer
{
    [XmlRoot("pay_isCompleted_response", Namespace = "http://api.renren.com/1.0/")]
    internal class PayIsCompleteContainer
    {
        [XmlText(typeof(bool))]
        public bool Result { get; set; }
    }
}