using System.Xml.Serialization;

namespace XiaoNei.ApiContainer
{
    [XmlRoot("users_getInfo_response", Namespace = "http://api.renren.com/1.0/")]
    public class UserContainer  {
        [XmlElement("user", typeof(User))]
        public User[] Users { get; set; }
    }
}