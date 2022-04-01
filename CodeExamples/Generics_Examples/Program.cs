using Generics_Examples;






Coordinate<int,double> intCoordinate = new Coordinate<int,double>();

intCoordinate.X = 12;
intCoordinate.Y = 13.0;
intCoordinate.Z = false;

intCoordinate.DoSomething<decimal, string>(2.4, 5, "Sajjad");


Coordinate<double,string> doubleCoordinate = new Coordinate<double,string> { X = 5.5, Y = "sajjad" }; // object initializer . 

Console.WriteLine($"intCoordinate.X : {intCoordinate.X} ; intCoordinate.Y : {intCoordinate.Y} ; intCoordinate.Z :{intCoordinate.Z} ");

Console.WriteLine($"doubleCoordinate.X : {doubleCoordinate.X} ; doubleCoordinate.Y : {doubleCoordinate.Y} ; doubleCoordinate.Z : {doubleCoordinate.Z } ");



Console.WriteLine("======================================================================>");

Console.WriteLine("Practice set constrains as a interface : ");

Console.WriteLine("======================================================================>");

Container<IItem> container = new Container<IItem>();


// we can pass Apple class as generic types here coz, Apple class implemented  IItem interface 

Container<Apple> container2 = new Container<Apple>();

container2.AddItem(new Apple());

Container<Banana> container3 = new Container<Banana>();

container3.AddItem(new Banana());
container3.AddItem(new Banana());
Console.WriteLine("Check _items values for container3 objects : ");
foreach (var item in container3._items)
{
    Console.WriteLine(item?.GetType());
}

/*
We use generic for using specific or specialized entity , ex -  here we use Apple or Banana intancle in container class . 
if we to use generalized Then , here we don't need generics , we can do just implement IItem interface and 
Initate object from interface . 
 
 */