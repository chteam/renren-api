using System.Xml.Serialization;

namespace RenRen
{
    public class OsInviteCnt
    {
        /*
         * <uid>27740660</uid>  
         * <os_invite_total>1111</os_invite_total>  
         * <star_user_total>111</star_user_total> 
         */
        [XmlElement("uid", typeof(long))]
        public long UserId { get; set; }
        [XmlElement("os_invite_total", typeof(int))]
        public int OsInviteTotal { get; set; }
        [XmlElement("star_user_total", typeof(int))]
        public int StarUserTotal { get; set; }
    }
}