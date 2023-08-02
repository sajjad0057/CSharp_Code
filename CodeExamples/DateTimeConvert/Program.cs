using DateTimeConvert;

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


string testtttt = "Tue, 25 Jul 2023 08:13:56 GMT";
//var strDateTime = DateTime.UtcNow;
Console.WriteLine($"strDateTime testtttt:{Convert.ToDateTime(testtttt)}");

Console.WriteLine($"{Convert.ToDateTime(null)}");

var x = "ama r";


Console.WriteLine($"xLength: {x.Length}");