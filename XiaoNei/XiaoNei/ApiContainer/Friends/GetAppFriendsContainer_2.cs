using System.Collections.Generic;
using System.Xml.Serialization;

namespace XiaoNei.ApiContainer
{
    [XmlRoot("friends_getAppFriends_response", Namespace = "http://api.xiaonei.com/1.0/")]
    public  class GetAppFriendsContainer2
    {
        [XmlElement("app_friend", typeof(Friend))]
        public List<Friend> Friends { get; set; }
    }
}