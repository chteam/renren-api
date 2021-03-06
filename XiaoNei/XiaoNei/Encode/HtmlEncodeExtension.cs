using System.Globalization;
using System.IO;
using System.Text;

namespace CHSNS
{
    public static class HtmlEncodeExtension
    {

        static public string UrlEncode(this string str)
        {
            return str == null ? null : Encoding.ASCII.GetString(UrlEncodeToBytes(str, Encoding.UTF8));
        }



        #region UrlEncode Helper





        public static byte[] UrlEncodeToBytes(string str, Encoding e)
        {
            if (str == null)
            {
                return null;
            }
            byte[] bytes = e.GetBytes(str);
            return UrlEncodeBytesToBytesInternal(bytes, 0, bytes.Length, false);
        }

        private static byte[] UrlEncodeBytesToBytesInternal(byte[] bytes, int offset, int count, bool alwaysCreateReturnValue)
        {
            int num = 0;
            int num2 = 0;
            for (int i = 0; i < count; i++)
            {
                char ch = (char)bytes[offset + i];
                if (ch == ' ')
                {
                    num++;
                }
                else if (!IsSafe(ch))
                {
                    num2++;
                }
            }
            if ((!alwaysCreateReturnValue && (num == 0)) && (num2 == 0))
            {
                return bytes;
            }
            byte[] buffer = new byte[count + (num2 * 2)];
            int num4 = 0;
            for (int j = 0; j < count; j++)
            {
                byte num6 = bytes[offset + j];
                char ch2 = (char)num6;
                if (IsSafe(ch2))
                {
                    buffer[num4++] = num6;
                }
                else if (ch2 == ' ')
                {
                    buffer[num4++] = 0x2b;
                }
                else
                {
                    buffer[num4++] = 0x25;
                    buffer[num4++] = (byte)IntToHex((num6 >> 4) & 15);
                    buffer[num4++] = (byte)IntToHex(num6 & 15);
                }
            }
            return buffer;
        }

        internal static bool IsSafe(char ch)
        {
            if ((((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z'))) || ((ch >= '0') && (ch <= '9')))
            {
                return true;
            }
            switch (ch)
            {
                case '\'':
                case '(':
                case ')':
                case '*':
                case '-':
                case '.':
                case '_':
                case '!':
                    return true;
            }
            return false;
        }

        internal static char IntToHex(int n)
        {
            if (n <= 9)
            {
                return (char)(n + 0x30);
            }
            return (char)((n - 10) + 0x61);
        }

        #endregion













        #region  html encode



        public static string HtmlEncode(this string s)
        {
            if (s == null)
            {
                return null;
            }
            var sb = new StringBuilder();
            var output = new StringWriter(sb);
            HtmlEncode(s, output);
            return sb.ToString();
        }



        static void HtmlEncode(string s, TextWriter output)
        {
            var length = s.Length;
            for (var i = 0; i < length; i++)
            {
                var ch = s[i];
                var ch2 = ch;
                if (ch2 != '"')
                {
                    switch (ch2)
                    {
                        case '<':
                            output.Write("&lt;");
                            goto Label_00AE;

                        case '=':
                            goto Label_0071;

                        case '>':
                            output.Write("&gt;");
                            goto Label_00AE;

                        case '&':
                            goto Label_0064;
                    }
                    goto Label_0071;
                }
                output.Write("&quot;");
                goto Label_00AE;
            Label_0064:
                output.Write("&amp;");
                goto Label_00AE;
            Label_0071:
                if ((ch >= '\x00a0') && (ch < 'Ā'))
                {
                    output.Write("&#" + ((int)ch).ToString(NumberFormatInfo.InvariantInfo) + ";");
                }
                else
                {
                    output.Write(ch);
                }
            Label_00AE:
                ;
            }
        }
        #endregion
    }
}