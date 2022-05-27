using Reflection;
using System.Reflection;

Test1 test1 = new Test1();

test1.Id = 5;
test1.Title = "Something";
test1.Address = "Dhaka";



Copier copier = new Copier();

Test2 test2 = copier.Copy<Test2>(test1);

Console.WriteLine($"test1.Id : {test1.Id}");

Console.WriteLine($"test1.Name : {test1.Title}");



//// After Using Refelction Feature here we set test2 object  Property as test1 object  Property  
///

Console.WriteLine("After Using Refelction Feature here we set test2 object Property as test1 object Property - ");

Console.WriteLine($"test2.Id : {test2.Id}");

Console.WriteLine($"test2.Name : {test2.Title}");

Console.WriteLine();
Console.WriteLine("==========================================================================================================");
Console.WriteLine("Another Examples : ");


Product product = new Product { Title = "Mouse 1v2" , Price = 500, Description = "A long Description "};

Electronics electronics = copier.Copy<Electronics>(product);


void PrintObject(object obj)
{
    Type type = obj.GetType();
    PropertyInfo[] properties = type.GetProperties();
    
    foreach (var property in properties)
    {
        Console.WriteLine($"{property.Name} : {property.GetValue(obj)}");
    }
}

Console.WriteLine($"{product.GetType().Name} : ");
PrintObject(product);


//// After Using Refelction Feature here we set electronics object  Property as product object Property -

Console.WriteLine("After Using Refelction Feature here we set electronics object Property as product object Property - ");

Console.WriteLine($"{electronics.GetType().Name} : ");
PrintObject(electronics);





