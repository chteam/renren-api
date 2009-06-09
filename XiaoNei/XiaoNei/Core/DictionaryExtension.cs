using System;
using System.Collections.Generic;
using System.Text;
using CHSNS;
namespace XiaoNei
{
    static public class DictionaryExtension
    {
        public static void AddSignature(this IDictionary<string, string> dict,XiaoNeiApi api)
        {
            if (dict.ContainsKey("sig")) dict.Remove("sig");
            var sb = dict.ToJoinString();
            sb.Append(api.Secret);
            var md5 = sb.ToString().ToMd5Lower();
            dict.Add("sig", md5);
        }
        public static StringBuilder ToJoinString(this IDictionary<string, string> dict)
        {
            return dict.ToJoinString(null, null);
        }
        public static StringBuilder ToJoinString(this IDictionary<string, string> dict, string joinItem)
        {
            return dict.ToJoinString(null, joinItem);
        }
        public static StringBuilder ToJoinString(this IDictionary<string, string> dict,string joinKeyAndValue,string joinItem)
        {
            if (string.IsNullOrEmpty(joinKeyAndValue)) joinKeyAndValue = "=";
            if (string.IsNullOrEmpty(joinItem)) joinItem = "";
            var sb = new StringBuilder();
            foreach (var item in dict)
            {
                sb.AppendFormat("{0}{2}{1}{3}", item.Key, item.Value, joinKeyAndValue,joinItem);
            }
            return sb;
        }
        public static string ToQueryString(this IDictionary<string, string> dict,XiaoNeiApi api)
        {
            dict.AddSignature(api);
            return dict.ToJoinString("&").ToString();
        }
        public static void AddNullable(this IDictionary<string, string> dict,string key,int? value) 
        {
            if (value.HasValue)
                dict.Add(key, value.Value.ToString());
        }
        public static void AddNullable(this IDictionary<string, string> dict, string key, long? value)
        {
            if (value.HasValue)
                dict.Add(key, value.Value.ToString());
        }
    }
}