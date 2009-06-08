using System.Xml.Serialization;

namespace XiaoNei {
	[XmlRoot("work_info")]
	public class Work {
		[XmlElement("company_name")]
		public string Company { get; set; }
		[XmlElement("description")]
		public string Description { get; set; }
		[XmlElement("start_date")]
		public string BeginDate { get; set; }
		[XmlElement("end_date")]
		public string EndDate { get; set; }
	}
}
