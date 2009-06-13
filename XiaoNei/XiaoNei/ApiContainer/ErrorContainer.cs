using System.Xml.Serialization;

namespace XiaoNei.ApiContainer
{
    [XmlRoot("error_response",Namespace="")]
    public class ErrorContainer
    {
        [XmlElement("error_code",typeof(int))]
        public int Code { get; set; }
        [XmlElement("error_msg", typeof(string))]
        public string Message { get; set; }

        [XmlElement("request_args")]
        public object ErrorArgs { get; set; }
    }
}