string st = string.Empty;

IList<string> fields = st.Split(';').ToList();
foreach (string field in fields)
    Console.WriteLine($"field : {field}");

Console.WriteLine("-----------------------------");


var strr = st.Split(";")[0];

string res = string.Empty;
var l = res?.Split("-").ToList();

foreach(var i in l)
{
    Console.WriteLine();
}


Console.WriteLine();

