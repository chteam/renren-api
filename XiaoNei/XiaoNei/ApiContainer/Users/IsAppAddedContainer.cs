﻿using System;
using System.Collections.Generic;

using System.Text;
using System.Xml.Serialization;

namespace XiaoNei.ApiContainer
{
    [XmlRoot("users_isAppAdded_response", Namespace = "http://api.xiaonei.com/1.0/")]
    public class IsAppAddedContainer {
        [XmlText]
        public int Val { get; set; }
    }
}