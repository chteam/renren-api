using System;
using System.Collections.Generic;
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
		/// <param name="api"></param>
		/// <param name="str">XML字符串</param>
		/// <returns></returns>
		static public T Load<T>(this XiaoNeiApi api, string str) {
			try {
				var ms = new XmlSerializer(typeof(T), "http://api.xiaonei.com/1.0/");
				var xr = XmlReader.Create(new StringReader(str));
				//xr.NamespaceURI = "http://api.xiaonei.com/1.0/";
				return (T)(ms.Deserialize(xr));
			} catch {
				if (api.Handler.IsDebug)
                    throw new ResponseException(str);
				else
					throw new ResponseException("错误的响应值");
			}
		}
        static public T Proc<T>(this XiaoNeiApi api,IDictionary<string,string> dict)
        {
            var result = api.Proc(dict);
            return api.Load<T>(result);
        }
		public static string Save<T>(this XiaoNeiApi api, T obj) {
			var ms = new XmlSerializer(typeof(T), "http://api.xiaonei.com/1.0/");
            using (var myWriter = new StringWriter())
            {
                ms.Serialize(myWriter, obj);
                return myWriter.GetStringBuilder().ToString();
            }
		}
	}
}
