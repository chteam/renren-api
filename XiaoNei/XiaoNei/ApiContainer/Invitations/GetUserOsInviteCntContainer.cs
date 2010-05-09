using System.Collections.Generic;
using System.Xml.Serialization;

namespace RenRen.ApiContainer
{
    [XmlRoot("invitations_getUserOsInviteCnt_response", Namespace = "http://api.renren.com/1.0/")]
    public class GetUserOsInviteCntContainer
    {
        [XmlElement("os_invite_cnt", typeof(OsInviteCnt))]
        public List<OsInviteCnt> OsInviteCnts { get; set; }
    }
}