using System;
using System.Collections.Generic;

using System.Text;
using System.Xml.Serialization;

namespace RenRen.ApiContainer {
	[XmlRoot("feed_publishTemplatizedAction_response", Namespace = "http://api.renren.com/1.0/")]
	public class PublishTemplatizedActionContainer {
		[XmlText]
		public bool IsSuccess { get; set; }
	}
}
