using Generics_Examples;






Coordinate<int,double> intCoordinate = new Coordinate<int,double>();

intCoordinate.X = 12;
intCoordinate.Y = 13.0;

intCoordinate.DoSomething<decimal, string>(2.4, 5, "Sajjad");


Coordinate<double,string> doubleCoordinate = new Coordinate<double,string> { X = 5.5, Y = "sajjad" }; // object initializer . 

Console.WriteLine($"intCoordinate.X : {intCoordinate.X} ; intCoordinate.Y : {intCoordinate.Y}");
Console.WriteLine($"doubleCoordinate.X : {doubleCoordinate.X} ; doubleCoordinate.Y : {doubleCoordinate.Y}");
