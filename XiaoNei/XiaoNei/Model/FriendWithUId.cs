using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace XiaoNei
{
    public  class FriendWithUId
    {

        [XmlElement("uid", typeof(long))]
        public long Id { get; set; }
        [XmlElement("name")]
        public string Name { get; set; }
        [XmlElement("headurl")]
        public string HeadUrl { get; set; }
        [XmlElement("tinyurl")]
        public string TinyUrl { get; set; }

    }
}