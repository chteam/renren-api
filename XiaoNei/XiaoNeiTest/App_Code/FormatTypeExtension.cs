using System;
using RenRen;

static public class FormatTypeExtension
{
    public static FormatType ToFormatType(this string str)
    {
        return (FormatType) Enum.Parse(typeof (FormatType), str);
    }
}
