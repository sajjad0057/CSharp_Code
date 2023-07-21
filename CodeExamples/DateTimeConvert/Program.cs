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


//var strDateTime = "Fri, 21 Jul 2023 04:46:06 GMT";

var strDateTime = DateTime.UtcNow;
Console.WriteLine($"strDateTime : {Convert.ToDateTime(strDateTime).ToString("yyyy/MM/dd")}");

Console.WriteLine($"{Convert.ToDateTime(null)}");

Console.WriteLine();