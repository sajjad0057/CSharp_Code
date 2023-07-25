using DateTimeConvert;
using System.Globalization;

Clock c = new Clock();
Console.WriteLine(c.Convert("01:00 pm"));

DateTime dateTime = DateTime.UtcNow;

Console.WriteLine($"DateTime.UtcNow : {dateTime}");

var expariedTime = dateTime.AddHours(1.96);

Console.WriteLine($"dateTime.AddHours(1.96) : {expariedTime}");

var stringTime = DateTime.UtcNow.ToString();

Console.WriteLine($"Test : {DateTime.Parse(stringTime)}");
Console.WriteLine();


var strDateTime = "Sun, 23 Jul 2023 17:26:19 -0700";

var t = strDateTime.Substring(0, 31);

string format = "ddd, dd MMM yyyy HH:mm:ss zzz";
//var strDateTime = DateTime.UtcNow;
Console.WriteLine($"strDateTime : {Convert.ToDateTime(t)}");

Console.WriteLine($"{Convert.ToDateTime(null)}");

Console.WriteLine();