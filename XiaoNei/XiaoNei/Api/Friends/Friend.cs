﻿using System.Xml.Serialization;

namespace XiaoNei {
	public class Friend {
		[XmlElement("id")]
		public string ID { get; set; }
		[XmlElement("name")]
		public string Name { get; set; }
		[XmlElement("headurl")]
		public string HeadUrl { get; set; }
	}
}
