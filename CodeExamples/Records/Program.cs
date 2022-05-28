
using Records;


Console.WriteLine("In The Case of Class - ");
Console.WriteLine("-----------------------------------------------------------------");

Product2 product2 = new Product2("camera",2000);

Product2 product21 = new Product2("camera", 2000);


/// <summary>
/// here, class object  compare memory address , Since class object create defferent memory location . 
/// </summary>
Console.WriteLine($"Is product2 is equal to product21 : {product2 == product21}");

Console.WriteLine("-----------------------------------------------------------------");

/// <summary>
///  here , record object compare value or property , not reference type or memory address 
/// </summary>

Console.WriteLine("In The Case of Record - ");

Console.WriteLine("-----------------------------------------------------------------");

Product1 product1 = new Product1("camera", 2000);
Product1 product11 = new Product1("camera", 2000);


Console.WriteLine($"Is product1 is equal to product11 : {product1 == product11}");

Console.WriteLine("-----------------------------------------------------------------");