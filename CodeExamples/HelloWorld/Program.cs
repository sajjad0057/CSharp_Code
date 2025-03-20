
using System.Text.Json;
using HelloWorld;

var startTime  = DateTime.Now;
Console.WriteLine(startTime.ToString());
//await Task.Delay(10000);
var endTime = DateTime.Now;
Console.WriteLine(endTime.ToString());
var diff = endTime - startTime;
Console.WriteLine($"Diff between startTime and endTime : {diff.TotalMilliseconds}");


Console.WriteLine("................................");

Hello hello = new Hello();

Console.WriteLine(hello);


Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
int? res = null;

List<int> list = new (){1,2,3,4,5};

Console.WriteLine($"List<int> : {JsonSerializer.Serialize(list)}");


string str = "{\n  \"id\": \"acct_1BId6RLXHc95GG1E\",\n  \"object\": \"account\",\n  \"business_logo\": null,\n  \"business_name\": null,\n  \"business_url\": null,\n  \"charges_enabled\": false,\n  \"country\": \"DE\",\n  \"default_currency\": \"eur\",\n  \"details_submitted\": false,\n  \"display_name\": null,\n  \"email\": \"ich@hmreimers.de\",\n  \"metadata\": {},\n  \"payouts_enabled\": false,\n  \"statement_descriptor\": \"\",\n  \"support_email\": null,\n  \"support_phone\": null,\n  \"timezone\": \"Europe/Berlin\",\n  \"type\": \"standard\"\n}\n";

object obj = JsonSerializer.Deserialize<object>(str);

Console.WriteLine($"str object : {JsonSerializer.Serialize(obj)}");


Dictionary<string, string> dict = 
    new Dictionary<string, string>() { { "n1", "nsss" }, { "n2", "nxxx" } };


Console.WriteLine($"dict n1 : {dict.GetValueOrDefault("n1")}");
Console.WriteLine($"dict n11 : {dict.GetValueOrDefault("n11")}");




