using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace XiaoNei  {
	[XmlRoot("profile_setXNML_response", Namespace = "http://api.renren.com/1.0/")]
	public class SetXNML {
		[XmlText]
		public int Val { get; set; }
	}
}
