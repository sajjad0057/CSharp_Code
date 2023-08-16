using JsonLoadIntoObjectExample;
using System.Text.Json;

string jsonData = "{\r\n    \"Address\": {\r\n        \"Street\": \"456 Elm Street\",\r\n        \"City\": \"Somewhereville\",\r\n        \"Country\": \"Canada\"\r\n    },\r\n    \"Person\": {\r\n        \"Name\": \"Alice Smith\",\r\n        \"Age\": 28,\r\n        \"Address\": {\r\n            \"Street\": \"123 Oak Avenue\",\r\n            \"City\": \"Anytown\",\r\n            \"Country\": \"USA\"\r\n        }\r\n    }\r\n}";

var personDetails = JsonSerializer.Deserialize<PersonDetails>(jsonData);

Console.WriteLine($"{JsonSerializer.Serialize(personDetails)}");


string jsonData2 = "{\r\n        \"Street\": \"456 Elm Street\",\r\n        \"City\": \"Somewhereville\",\r\n        \"Country\": \"Canada\"\r\n    }";

dynamic dynamicObj = JsonSerializer.Deserialize<dynamic>(jsonData2);

IDictionary<string,string> keyValuePairs = (IDictionary<string,string>)dynamicObj;

Console.WriteLine();