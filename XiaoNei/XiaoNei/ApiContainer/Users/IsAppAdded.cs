using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace XiaoNei  {
	[XmlRoot("users_isAppAdded_response", Namespace = "http://api.xiaonei.com/1.0/")]
	public class IsAppAdded {
		[XmlText]
		public int Val { get; set; }
	}
}
