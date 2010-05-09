using System.Xml.Serialization;

namespace RenRen {
	/// <summary>
	/// 地区
	/// </summary>
	public class Area {
		[XmlElement("country")]
		public string Country { get; set; }
		[XmlElement("province")]
		public string Province { get; set; }
		[XmlElement("city")]
		public string City { get; set; }
	}
}
