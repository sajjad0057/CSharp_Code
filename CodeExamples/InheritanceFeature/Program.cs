using InheritanceFeature;
using InheritanceFeature.Example;



//Product p1 =  new Product();
//OR Boxing Electronics object in Product :

Product p1 = new Electronics();   

p1.Price = 200;

Console.WriteLine(p1.CalculateDiscount(25));



// Unboxing P1 Object from Product to Electronis  :
Electronics p2 = (Electronics)p1;

Console.WriteLine(p2.CalculateDiscount(25));


///// Example of sealed class or Property /////

Console.WriteLine("=============================================================");
Console.WriteLine("Example of sealed class or method");
Console.WriteLine("=============================================================");

A a = new A();

a.Name();

B b = new B();

b.Name();

C c = new C();
c.Name();
c.Mname();



Console.WriteLine("************************************************************");
Console.WriteLine("Creating a Generic Vehicle:");
Vehicle vehicle = new Vehicle();
vehicle.DisplayInfo();
vehicle.Accelerate();
vehicle.Accelerate(20);

Console.WriteLine("\nCreating a Car:");
Car car = new Car("Toyota", 80, 5);
car.DisplayInfo();
car.Accelerate();
car.Accelerate(30);

Console.WriteLine("\nCreating a Bike:");
Bike bike = new Bike("Yamaha", 60, true);
bike.DisplayInfo();
bike.Accelerate();
bike.Accelerate(15);

Console.WriteLine("\nDemonstrating Polymorphism:");
Vehicle v1 = new Car("Honda", 100, 4);
Vehicle v2 = new Bike("Ducati", 120, true);
v1.DisplayInfo();  // Calls Car's overridden method
v2.DisplayInfo();  // Calls Bike's overridden method




