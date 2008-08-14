using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace XiaoNei.ApiContainer.Feed {
	[XmlRoot("feed_publishTemplatizedAction_response", Namespace = "http://api.xiaonei.com/1.0/")]
	public class PublishTemplatizedActionContainer {
		[XmlText]
		public bool IsSuccess { get; set; }
	}
}
