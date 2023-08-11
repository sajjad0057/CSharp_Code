var f = "12 - Front End";
var y = " 12 - Front End;05 - Right Side-Far Rear;02 - Right Side-Near Front";

foreach(var i in f.Split(';').ToList())
{
    Console.WriteLine(i);
}


foreach (var i in y.Split(';').ToList())
{
    Console.WriteLine(i);
}