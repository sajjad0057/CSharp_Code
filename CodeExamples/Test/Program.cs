using System.Diagnostics;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text.Json;
using Test;

IEnumerable<string> xx = new List<string>();

Console.WriteLine(JsonSerializer.Serialize(xx.ToArray<string>()));

IEnumerable<KeyValuePair<string, string>> yy = new List<KeyValuePair<string, string>>();



Coupon c = new ();

Console.WriteLine($"c : {JsonSerializer.Serialize(c)}");


string text = "{\"y\":36,\"x2\":650,\"y2\":213,\"w\":589,\"h\":177,\"dw\":709,\"dh\":269}";

var dict = JsonSerializer.Deserialize<IDictionary<string,int>>(text);

dict = new Dictionary<string, int> { { "x", 1 } };
dict.Add("x1", 2);

Console.WriteLine(JsonSerializer.Serialize(dict));


var listOfDict = new List<IDictionary<string, int>>
{
    new Dictionary<string, int> { { "Apple", 1 }, { "Banana", 2 } },
    new Dictionary<string, int> { { "Carrot", 3 }, { "Dates", 4 } }
};

Console.WriteLine(JsonSerializer.Serialize(listOfDict));



var test = new Coupon();

object result = new
{
    x = 1,
    y = 2,
    z = 3
};


if (true)
{
    Console.WriteLine("sajjad true");
}
else if (true)
{
    Console.WriteLine("true 2");
}
if (true)
{
    Console.WriteLine("true 3");
}
else
{
    Console.WriteLine("true 4");
}



Coupon? x()
{
    Coupon? coupon = new();

    return coupon;
}


Console.WriteLine($"Coupon : {JsonSerializer.Serialize(x())}");

var assembly = Assembly.GetExecutingAssembly();

Console.WriteLine($"assembly : {assembly}");

