using Newtonsoft.Json;

public class YourClass
{
    public string Name { get; set; }
    public List<string> Items { get; set; }

<<<<<<< HEAD
// Received user defined intput by using Console.ReadLine() 
Console.WriteLine("Write Your name : \n");
var x =  Console.ReadLine();
Console.WriteLine($"\n----------------------\n" +
    $"Your name : {x}\n");


void PrintMyName(string name) => Console.WriteLine($"My Name is : {name}");


//return name;


for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Write your name : ");
    PrintMyName(Console.ReadLine());
=======
    public bool ShouldSerializeItems()
    {
        // Do not serialize the "Items" property if it is null or empty.
        return Items != null && Items.Count > 0;
    }
}

class Program
{
    static void Main()
    {
        YourClass obj = new YourClass
        {
  // This list will be ignored during serialization if empty.
        };

        JsonSerializerSettings settings = new JsonSerializerSettings
        {
            DefaultValueHandling = DefaultValueHandling.Ignore
        };

        string json = JsonConvert.SerializeObject(obj, Formatting.Indented, settings);

        Console.WriteLine(json);
    }
>>>>>>> 5f4983dae742a000cfcd1f58709856874091bab3
}