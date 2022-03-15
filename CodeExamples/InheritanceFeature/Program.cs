using InheritanceFeature;



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


