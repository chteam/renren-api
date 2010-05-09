using System;
using System.Collections.Generic;

using System.Text;
using System.Xml.Serialization;

namespace RenRen.ApiContainer.Profile {

	[XmlRoot("profile_getXNML_response", Namespace = "http://api.renren.com/1.0/")]
	public class GetXNML {
		[XmlText]
		public String Val { get; set; }
	}
}
