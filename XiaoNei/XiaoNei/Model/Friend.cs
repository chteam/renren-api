using System.Xml.Serialization;

namespace XiaoNei {
	public class Friend {
		[XmlElement("id",typeof(long))]
		public long Id { get; set; }
		[XmlElement("name")]
		public string Name { get; set; }
		[XmlElement("headurl")]
		public string HeadUrl { get; set; }
        [XmlElement("tinyurl")]
		public string TinyUrl { get; set; }
        
	}
}
