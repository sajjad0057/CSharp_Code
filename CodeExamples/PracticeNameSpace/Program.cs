

//using PracticeNameSpace;
//using TestOOP;
//using  PracticeNameSpace.SubModule;


// Aliasing Namespace :
using PracticeNameSpace;
using TestOOP;
using SubProduct = PracticeNameSpace.SubModule.Product;



/*
 
In C# 10 , if does not set any namespace ,then the compiler set projectname as namespace 
automatically . 


 */

PracticeNameSpace.Product p = new PracticeNameSpace.Product();
p.Name = "sajjad";
Console.WriteLine(p.Name);

TestOOP.Product pt = new TestOOP.Product();
pt.Name = "zahan";
Console.WriteLine(pt.Name);


// Using aliasing namespace in below :

SubProduct ps = new SubProduct();
ps.Name = "nefal";
Console.WriteLine(ps.Name);