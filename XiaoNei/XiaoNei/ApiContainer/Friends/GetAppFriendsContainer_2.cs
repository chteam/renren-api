using System.Collections.Generic;
using System.Xml.Serialization;
using XiaoNei.Model;

namespace XiaoNei.ApiContainer
{
    [XmlRoot("friends_getAppFriends_response", Namespace = "http://api.xiaonei.com/1.0/")]
    public  class GetAppFriendsContainer2
    {
        [XmlElement("app_friend", typeof(FriendWithUId))]
        public List<FriendWithUId> Friends { get; set; }
    }
}