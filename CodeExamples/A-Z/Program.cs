using A_Z;
using System.Text;
using System.Text.Json;

B b = new B();

b.Assss = new A[3];

Console.WriteLine(b.Assss);

C c = new C();

Console.WriteLine(c.Assss[0].Number);

string[] strArr = new string[3];

strArr[0] = "sajjad";

Console.WriteLine(JsonSerializer.Serialize(strArr));


string str = "SaJJadHossaIN";
var x = str.Substring(2, str.Length-2);
//var y = str.Skip(2).ToString();
Console.WriteLine(x.IsNormalized());
//Console.WriteLine(y);

Console.WriteLine((byte)'c');
Console.WriteLine();


