using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

// Sample JSON data
string json = @"{
    'name': 'John Doe',
    'age': 30,
    'address': {
        'city': 'New York',
        'zipCode': '10001'
    },
    'languages': ['English', 'French', 'Spanish']
}";

// Step 1: Deserialize JSON data
var jsonObject = JsonConvert.DeserializeObject<JObject>(json);

// Step 2: Access JSON fields using JSON path
string? name = jsonObject.SelectToken("$.name")?.ToString();
int age = jsonObject.SelectToken("$.age")?.Value<int>() ?? 0;
string city = jsonObject.SelectToken("$.address.city")?.ToString();
string firstLanguage = jsonObject.SelectToken("$.languages[0]")?.ToString();

name = (string?)jsonObject["$.name"];

// Display the results
Console.WriteLine($"Name: {name}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"City: {city}");
Console.WriteLine($"First Language: {firstLanguage}");
