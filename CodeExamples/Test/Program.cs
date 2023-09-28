﻿using System.Linq;
using Test;

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
       {"Id", "3"},
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
       {"Id", "222"},
       {"Age", 35},
       {"IsStudent", true}
    },
    new Dictionary<string, dynamic>
    {
       {"Id", "3"},
       {"Age", 45},
       {"IsStudent", true}
    },
    new Dictionary<string, dynamic>
    {
       {"Id", "44"},
       {"Age", 55},
       {"IsStudent", true}
    }
};

// Intersect the two lists based on the "Id" key
var intersectedDictionaries = list1.Except(list2, new DictionaryIdComparer()).ToList();

// Print the intersected dictionaries
foreach (var dictionary in intersectedDictionaries)
{
    Console.WriteLine("Intersected Dictionary:");
    foreach (var kvp in dictionary)
    {
        Console.WriteLine($"{kvp.Key}: {kvp.Value}");
    }
    Console.WriteLine();
}