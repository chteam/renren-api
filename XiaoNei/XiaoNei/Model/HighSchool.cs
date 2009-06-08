using System.Xml.Serialization;

namespace XiaoNei {
	[XmlRoot("hs_info")]
	public class HighSchool {
		/// <summary>
		/// 名称
		/// </summary>
		[XmlElement("name")]
		public string Name { get; set; }
		/// <summary>
		/// 入学年份
		/// </summary>
		[XmlElement("grad_year")]
		public int SchoolYear { get; set; }
	}
}

