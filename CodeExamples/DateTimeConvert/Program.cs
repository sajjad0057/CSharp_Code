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
