
using HelloWorld;

var startTime  = DateTime.Now;
Console.WriteLine(startTime.ToString());
//await Task.Delay(10000);
var endTime = DateTime.Now;
Console.WriteLine(endTime.ToString());
var diff = endTime - startTime;
Console.WriteLine($"Diff between startTime and endTime : {diff.TotalMilliseconds}");


Console.WriteLine("................................");

Hello hello = new Hello();

Console.WriteLine(hello);