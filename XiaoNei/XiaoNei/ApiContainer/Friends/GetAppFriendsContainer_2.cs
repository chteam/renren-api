using System.Collections.Generic;
using System.Xml.Serialization;

namespace RenRen.ApiContainer
{
    [XmlRoot("friends_getAppFriends_response", Namespace = "http://api.renren.com/1.0/")]
    public  class GetAppFriendsContainer2
    {
        [XmlElement("app_friend", typeof(FriendWithUId))]
        public List<FriendWithUId> Friends { get; set; }
    }
}