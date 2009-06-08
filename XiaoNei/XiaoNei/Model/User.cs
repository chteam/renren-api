using System;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace XiaoNei {
	[XmlRoot("user")]
	public class User {
		[XmlElement("uid")]
		public string UserId{get;set;}
		[XmlElement("name")]
		public string Name { get; set; }
		[XmlElement("sex")]
		public SexType Sex { set; get; }
		[XmlElement("birthday")]
		public DateTime Birthday { get; set; }
		[XmlElement("tinyurl")]
		public string TinyUrl { get; set; }
		[XmlElement("headurl")]
		public string HeadUrl { get; set; }
		[XmlElement("mainurl")]
		public string MainUrl { get; set; }
		[XmlElement("hometown_location")]
		public Area HomeTown { get; set; }

		[XmlArray("work_history")]
		[XmlArrayItem("work_info")]
		public List<Work> Work { set; get; }
		[XmlArray("university_history")]
		[XmlArrayItem("university_info")]
		public List<University> University { set; get; }
		[XmlArray("hs_history")]
		[XmlArrayItem("hs_info")]
		public List<HighSchool> HighSchool { set; get; }
	}
}
