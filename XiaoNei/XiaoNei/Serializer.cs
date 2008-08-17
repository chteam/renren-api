using System;
using System.IO;
using System.Web;
using System.Xml;
using System.Xml.Serialization;

namespace XiaoNei {
	public static class Serializer {
		/// <summary>
		/// 从配置文件反序列化
		/// </summary>
		/// <typeparam name="T">反序列化的目标类型</typeparam>
		/// <param name="str">XML字符串</param>
		/// <returns></returns>
		static public T Load<T>(this XiaoNeiApi Api, string str) {
			try {
				XmlSerializer ms = new XmlSerializer(typeof(T), "http://api.xiaonei.com/1.0/");
				XmlReader xr = XmlReader.Create(new StringReader(str));
				//xr.NamespaceURI = "http://api.xiaonei.com/1.0/";
				return (T)(ms.Deserialize(xr));
			} catch {
				if (Api.Handler.IsDebug)
					throw new Exception(HttpContext.Current.Server.HtmlEncode(str));
				else
					throw new Exception("错误的响应值");
			}
		}
		public static string Save<T>(this XiaoNeiApi Api, T obj) {
			XmlSerializer ms = new XmlSerializer(typeof(T), "http://api.xiaonei.com/1.0/");
			StringWriter myWriter = new StringWriter();
			ms.Serialize(myWriter, obj);
			myWriter.Close();
			return myWriter.GetStringBuilder().ToString();
		}
	}
}
