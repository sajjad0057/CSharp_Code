using System.Collections;
using System.Linq;

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