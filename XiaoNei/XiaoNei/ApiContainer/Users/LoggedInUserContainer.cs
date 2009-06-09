using System.Xml.Serialization;

namespace XiaoNei.ApiContainer
{
    [XmlRoot("users_getLoggedInUser_response", Namespace = "http://api.xiaonei.com/1.0/")]
    public class LoggedInUserContainer {
        [XmlText(typeof(long))]
        public long UserId { get; set; }
    }
}