using System;
using XiaoNei;

static public class FormatTypeExtension
{
    public static FormatType ToFormatType(this string str)
    {
        return (FormatType) Enum.Parse(typeof (FormatType), str);
    }
}
