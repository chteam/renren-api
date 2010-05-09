using System;
using System.Collections.Generic;

using System.Text;
using System.Xml.Serialization;

namespace RenRen.ApiContainer
{
    [XmlRoot("users_isAppAdded_response", Namespace = "http://api.renren.com/1.0/")]
    public class IsAppAddedContainer {
        [XmlText]
        public int Val { get; set; }
    }
}