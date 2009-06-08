using System.Security.Cryptography;
using System.Text;

namespace CHSNS
{
    public static class Md5Extension
    {
        /// <summary>
        /// ���ַ�������MD5����
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ToMd5(this string str) {
            var data = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(str.Trim()));
            return data.ToHexUpperString();
            //FormsAuthentication.HashPasswordForStoringInConfigFile(str, "MD5");
        }
        public static string ToMd5Lower(this string str)
        {
            var data = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(str.Trim()));
            return data.ToHexLowerString();
            //FormsAuthentication.HashPasswordForStoringInConfigFile(str, "MD5");
        }
    }
}