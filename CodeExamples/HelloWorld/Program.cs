using Newtonsoft.Json;

public class YourClass
{
    public string Name { get; set; }
    public List<string> Items { get; set; }

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
}