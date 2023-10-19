using CheckToListOfDict;
using System.Text.Json;

IList<IDictionary<string, dynamic>> list1 = new List<IDictionary<string, dynamic>>
{
    new Dictionary<string, dynamic>
    {
        {"Id", "1"},
        {"Age", 30},
        {"IsStudent", false}
    },
    new Dictionary<string, dynamic>
    {
       {"Id", "2"},
       {"Age", 35},
       {"IsStudent", true}
    },
    new Dictionary<string, dynamic>
    {
       {"Id", "33"},
       {"Age", 45},
       {"IsStudent", true}
    },
    new Dictionary<string, dynamic>
    {
       {"Id", "4"},
       {"Age", 55},
       {"IsStudent", true}
    }
};

IList<IDictionary<string, dynamic>> list2 = new List<IDictionary<string, dynamic>>
{
    new Dictionary<string, dynamic>
    {
        {"Id", "1"},
        {"Age", 30},
        {"IsStudent", false}
    },
    new Dictionary<string, dynamic>
    {
       {"Id", "22"},
       {"Age", 35},
       {"IsStudent", true}
    },
    new Dictionary<string, dynamic>
    {
       {"Id", "3"},
       {"IsStudent", true}
    },
    new Dictionary<string, dynamic>
    {
       {"Id", "4"},
       {"IsStudent", true}
    }
};

// Intersect the two lists based on the "Id" key
var exceptDictionaries1 = list1.Except(list2, new DictionaryIdComparer()).ToList();

// Print the intersected dictionaries
//foreach (var dictionary in exceptDictionaries1)
//{
//    Console.WriteLine("Except Dictionary:");
//    foreach (var kvp in dictionary)
//    {
//        Console.WriteLine($"{kvp.Key}: {kvp.Value}");
//    }
//    Console.WriteLine();
//}




//new CheckListAndUpdateElement().CheckAndUpdate().TestMtdh();

Console.WriteLine("******************************************************************************************" +
    "*********************************************************************************************");

// Intersect the two lists based on the "Id" key
//var exceptDictionaries2 = list2.Except(list1, new DictionaryIdComparer()).ToList();

//exceptDictionaries1.AddRange(exceptDictionaries2);

//foreach (var dictionary in exceptDictionaries1)
//{
//    Console.WriteLine("Except Dictionary:");
//    foreach (var kvp in dictionary)
//    {
//        Console.WriteLine($"{kvp.Key}: {kvp.Value}");
//    }
//    Console.WriteLine();
//}

//var unmatchedDicts = list1.Where(dict1 =>
//    !list2.Any(dict2 =>
//        dict2.ContainsKey("Id") && dict2["Id"].ToString() == dict1["Id"].ToString()
//    )
//).ToList();

//// Print unmatched dictionaries
//Console.WriteLine("Unmatched dictionaries:");
//foreach (var dict in unmatchedDicts)
//{
//    foreach (var kvp in dict)
//    {
//        Console.WriteLine($"{kvp.Key}: {kvp.Value}");
//    }
//    Console.WriteLine();
//}

Console.WriteLine($"After list1.Count: {list1.Count}");
list1.Add(new Dictionary<string, dynamic>());
Console.WriteLine($"Before list1.Count: {list1.Count}");
Console.WriteLine($"list1::{JsonSerializer.Serialize(list1)}");

