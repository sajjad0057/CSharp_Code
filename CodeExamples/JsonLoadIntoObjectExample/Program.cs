using JsonLoadIntoObjectExample;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.Json;

string jsonData = "{\r\n    \"Address\": {\r\n        \"Street\": \"456 Elm Street\",\r\n        \"City\": \"Somewhereville\",\r\n        \"Country\": \"Canada\"\r\n    },\r\n    \"Person\": {\r\n        \"Name\": \"Alice Smith\",\r\n        \"Age\": 28,\r\n        \"Address\": {\r\n            \"Street\": \"123 Oak Avenue\",\r\n            \"City\": \"Anytown\",\r\n            \"Country\": \"USA\"\r\n        }\r\n    }\r\n}";

var personDetails = System.Text.Json.JsonSerializer.Deserialize<PersonDetails>(jsonData);

Console.WriteLine($"{System.Text.Json.JsonSerializer.Serialize(personDetails)}");


string jsonData2 = "{\r\n        \"Street\": \"456 Elm Street\",\r\n        \"City\": \"Somewhereville\",\r\n        \"Country\": \"Canada\"\r\n    }";

dynamic dynamicObj = System.Text.Json.JsonSerializer.Deserialize<dynamic>(jsonData2);

//IDictionary<string,string> keyValuePairs = (IDictionary<string,string>)dynamicObj;

Console.WriteLine();


Person p1 = new Person
{
    Name = "Foo",
    Age = 1,
};


Console.WriteLine($"Person - p1: {System.Text.Json.JsonSerializer.Serialize(p1)}");

Console.WriteLine();

Console.WriteLine("================================NewtonSoft Json====================================");


var jPerson = JObject.FromObject(p1);
var jPersonAddress = JObject.FromObject(p1.Address);
//var jPersonContact = JObject.FromObject(JArray.Parse(p1.Contacts.ToString()));

Console.WriteLine(jPerson.ContainsKey("Name") ? jPerson.ToString() : null);

var cc = JObject.Parse(jPerson["Address"].ToString());

Console.WriteLine();



string json = @"
        [
          {
            'productId': '12345',
            'productName': 'Wireless Mouse',
            'quantity': 2,
            'price': 25.99
          },
          {
            'productId': '67890',
            'productName': 'Mechanical Keyboard',
            'quantity': 1,
            'price': 79.99
          },
          {
            'productId': '24680',
            'productName': 'USB-C Charger',
            'quantity': 3,
            'price': 18.50
          }
        ]";


JArray cart = new JArray();

Console.WriteLine();


List<CartItem> carto = JsonConvert.DeserializeObject<List<CartItem>>(json);

foreach (var i in carto)
{
    JObject j = JObject.FromObject(i);
    cart.Add(j);
}


foreach (var item in cart)
{
    item["test"] = "test value";
    Console.WriteLine(item["productId"]);
    Console.WriteLine(item["test"]);
}



