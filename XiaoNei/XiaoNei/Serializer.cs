using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.Xml;

namespace XiaoNei {
	public class Serializer {
		/// <summary>
		/// 从配置文件反序列化
		/// </summary>
		/// <typeparam name="T">反序列化的目标类型</typeparam>
		/// <param name="str">XML字符串</param>
		/// <returns></returns>
		static public T Load<T>(string str)  {
			XmlSerializer ms = new XmlSerializer(typeof(T), "http://api.xiaonei.com/1.0/");
			XmlReader xr = XmlReader.Create(new StringReader(str));
			//xr.NamespaceURI = "http://api.xiaonei.com/1.0/";
			return (T)(ms.Deserialize(xr));
		}
		public static string Save<T>(T obj) {
			XmlSerializer ms = new XmlSerializer(typeof(T), "http://api.xiaonei.com/1.0/");
			StringWriter myWriter = new StringWriter();
			ms.Serialize(myWriter, obj);
			myWriter.Close();
			return myWriter.GetStringBuilder().ToString();
		}
	}
}
