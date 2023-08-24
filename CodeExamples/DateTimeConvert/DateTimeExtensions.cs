using System.Globalization;

namespace DateTimeConvert;

public static class DateTimeExtensions
{
    public static DateTime FormatCustom(this DateTime dateTime, string format)
    {
        string formattedString = dateTime.ToString(format);
        DateTime formattedDateTime = DateTime.ParseExact(formattedString, format, CultureInfo.InvariantCulture);
        return formattedDateTime;
    }
}
