using LINQ_Examples;
using System.Collections;
using System.Linq;
using System.Text.Json;

string[] names = new string[] { "dkaha", "sylhet", "chittagong" };


var result = (from n in names
              where n.Length > 5 
              select n);


foreach (var name in result)
{
    Console.WriteLine(name);
}


IList<string> list = new List<string> {"aaa","bbb","ccc","ddd","eee"};

Console.WriteLine(list.LastOrDefault());

IList<string> stringList = new List<string>
        {
            "apple",
            "banana",
            "orange",
            "grape",
            "kiwi",
            "pineapple"
        };

IList<string> searchStrings = new List<string>
{
    "apple",
    "banana",
    "strawberry"
};

IList<string> foundStrings = SearchStringsInList(stringList, searchStrings);

if (foundStrings.Count > 0)
{
    Console.WriteLine("Found the following strings:");
    foreach (string foundString in foundStrings)
    {
        Console.WriteLine(foundString);
    }
}
else
{
    Console.WriteLine("No matching strings found.");
}
    

List<string> SearchStringsInList(IList<string> stringList, IList<string> searchStrings)
{
    // Use LINQ to filter the stringList and find matching strings
    List<string> foundStrings = stringList.Where(str => searchStrings.Contains(str)).ToList();

    return foundStrings;
}




Console.WriteLine("-------------------------------------------------------------------------------------");


IList<Test> listOfDict = new List<Test>();


var test1 = new Test();
test1.Item = new Dictionary<string, dynamic>() { { "s1", "q" }, { "s2", 2 } };

var test2 = new Test();
test2.Item = new Dictionary<string, dynamic>() { { "s1", "g" }, { "s2", 22 } };

var test3 = new Test();
test3.Item = new Dictionary<string, dynamic>() { { "s1", "N" }, { "s2", 222 } };

var test4 = new Test();
test4.Item = new Dictionary<string, dynamic>() { { "s1", "111" }, { "s2", 2222 } };

var test5 = new Test();
test5.Item = new Dictionary<string, dynamic>() { { "s1", "1" }, { "s2", 22222 } };


listOfDict.Add(test1);
listOfDict.Add(test2);
listOfDict.Add(test3);
listOfDict.Add(test4);
listOfDict.Add(test5);

var teptString = "111,1,13423,56,5346,3,34235,23423,43";

teptString.Split(',');

var res = listOfDict.Where(i => teptString.Contains(i.Item["s1"])).ToList();

Console.WriteLine(JsonSerializer.Serialize(res));


Console.WriteLine("=================================================================");

IList<Test> listOfDict1 = new List<Test>();

listOfDict1[0] = test1;

Console.WriteLine();



