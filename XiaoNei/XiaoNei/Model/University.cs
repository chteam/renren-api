using System.Xml.Serialization;

namespace XiaoNei {
	/// <summary>
	/// 大学
	/// </summary>
	[XmlRoot("university_info")]
	public class University {
		/// <summary>
		/// 名称
		/// </summary>
		[XmlElement("name")]
		public string Name { get; set; }
		/// <summary>
		/// 入学年份
		/// </summary>
		[XmlElement("year")]
		public int SchoolYear { get; set; }
		/// <summary>
		/// 学院
		/// </summary>
		[XmlElement("department")]
		public string Department { get; set; }

	}
}
