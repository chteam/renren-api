using System;
using System.Runtime.InteropServices;
using System.Text;

namespace XiaoNei
{
    [Serializable, StructLayout(LayoutKind.Sequential)]
    public class KeyValueItem
    {
        public KeyValueItem(string key, string value)
        {
            Key = key;
            Value = value;
        }

        public string Key { get; private set; }
        public string Value { get; private set; }
        public override string ToString()
        {
            var builder = new StringBuilder();
            if (Key != null)
            {
                builder.Append(Key);
            }
            builder.Append("=");
            if (Value != null)
            {
                builder.Append(Value);
            }
            return builder.ToString();
        }
    }
}


