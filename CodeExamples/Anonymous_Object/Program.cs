
using Anonymous_Object;

/*
 Example of anonymous functions : 
 */

var o = new { Name = "sajjad", Address = "Rangpur" };



// or 

object  a = new { Name = "sajjad1", Address = "Pabna" };

dynamic x = a;

Console.WriteLine($"Name : {o.Name} ; Address : {o.Address}");

Console.WriteLine($"Name : {x.Name} ; Address : {x.Address}");



/*
 Object initializers :
 By using object initalizers , we - assign values to any accessible fields or properties of an object at creation
 time without having to invoke a constructor followed by lines of assignment statements.

Example given below : 

 */



Cat cat = new Cat { Age = 10, Name = "Fluffy" };
Cat sameCat = new Cat("Fluffy") { Age = 10 };  // initialize methods here at a time . 

Console.WriteLine(cat.Name);
Console.WriteLine(sameCat.Age);

