using System.Xml.Serialization;

namespace RenRen.ApiContainer
{
    [XmlRoot("users_getLoggedInUser_response", Namespace = "http://api.renren.com/1.0/")]
    public class LoggedInUserContainer {
        [XmlText(typeof(long))]
        public long UserId { get; set; }
    }
}