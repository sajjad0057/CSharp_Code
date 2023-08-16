using A_Z;
using System.Text.Json;

B b = new B();

b.Assss = new A[3];

Console.WriteLine(b.Assss);

C c = new C();

Console.WriteLine(c.Assss[0].Number);

string[] strArr = new string[3];

strArr[0] = "sajjad";

Console.WriteLine(JsonSerializer.Serialize(strArr));



