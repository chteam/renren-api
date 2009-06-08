using System.Text;

namespace CHSNS {
    internal static class BytesExtension {

        /// <summary>
        /// ��byte����תΪ��д�ַ���
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        internal static string ToHexUpperString(this byte[] data) {//����ת��
            var codes = new StringBuilder();
            for (var i = 0; i < data.Length; ++i) {
                codes.Append(data[i].ToString("x2"));
            }
            return codes.ToString().ToUpper();
        }        
        /// <summary>
        /// ��byte����תΪСд�ַ���
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        internal static string ToHexLowerString(this byte[] data) {//����ת��
            var codes = new StringBuilder();
            for (var i = 0; i < data.Length; ++i) {
                codes.Append(data[i].ToString("x2"));
            }
            return codes.ToString().ToLower();
        }
    }
}