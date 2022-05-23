using System.Linq;

string[] names = new string[] { "dkaha", "sylhet", "chittagong" };


var result = (from n in names
              where n.Length > 5 
              select n);


foreach (var name in result)
{
    Console.WriteLine(name);
}

