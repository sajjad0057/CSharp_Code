using AbstractClass;


Vehicle v1 = new Bus();
Vehicle v2 = new Airoplane();

// here v1 can access just Vehicle abstract class members or property, But not access Bus all property. 
v1.Speed = 45.53;
v2.Speed = 234.56;

Console.WriteLine($"{v1.Speed} ---- {v2.Speed}");

