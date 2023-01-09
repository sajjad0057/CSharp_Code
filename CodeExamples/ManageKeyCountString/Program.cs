using ManageKeyCountString;
using System.Text.Json;

string keyCounts = "[{\"Key\":\"Others\",\"Counts\":10},{ \"Key\":\"s\",\"Counts\":1},{ \"Key\":\"o\",\"Counts\":2},{ \"Key\":\"n\",\"Counts\":4},{ \"Key\":\"g\",\"Counts\":1},{ \"Key\":\"j\",\"Counts\":5},{ \"Key\":\"h\",\"Counts\":3},{ \"Key\":\"k\",\"Counts\":3},{ \"Key\":\"l\",\"Counts\":1},{ \"Key\":\"i\",\"Counts\":1},{ \"Key\":\"b\",\"Counts\":1},{ \"Key\":\"v\",\"Counts\":1},{ \"Key\":\"c\",\"Counts\":1},{ \"Key\":\"u\",\"Counts\":2}]";

//Console.WriteLine(keyCounts);

var ListOfKeyCounts = JsonSerializer.Deserialize<IList<KeysCount>>(keyCounts);

foreach(var item in ListOfKeyCounts)
{
    Console.WriteLine($"{item.Key} : {item.Counts}");
}