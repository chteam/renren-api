using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace XiaoNei  {
	[XmlRoot("profile_setXNML_response", Namespace = "http://api.xiaonei.com/1.0/")]
	public class SetXNML {
		[XmlText]
		public int Val { get; set; }
	}
}
