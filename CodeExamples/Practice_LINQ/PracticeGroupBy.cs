using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_LINQ;

public class PracticeGroupBy
{
    public IList<IDictionary<string, dynamic>> myListOfDict = new List<IDictionary<string, dynamic>>();



    public Dictionary<string, dynamic> keyValuePairs1 = new Dictionary<string, dynamic>()
    {
        {"a",1},
        {"b",1}, {"c",1}, {"d",4}, {"e",5}, {"f",6}, {"g",7}, {"h",8}, {"i",8}, {"k",8}, {"l",8}
    };


    public Dictionary<string, dynamic> keyValuePairs2 = new Dictionary<string, dynamic>()
    {
        {"aa",11},
        {"bb",11}, {"c",11}, {"dd",44}, {"ee","111"}, {"ff",66}, {"gg",77}, {"hh",88}, {"ii",88}, {"kk",88}, {"ll",99}
    };

    public Dictionary<string, dynamic> keyValuePairs3 = new Dictionary<string, dynamic>()
    {
        {"aa",11},
        {"bb",11}, {"c",1}, {"dd",44}, {"ee",new DateTime(2023,08,02)}, {"ff",66}, {"gg",77}, {"hh",88}, {"ii",88}, {"kk",88}, {"ll",99}
    };

    public Dictionary<string, dynamic> keyValuePairs4 = new Dictionary<string, dynamic>()
    {
        {"aa",11},
        {"bb",11}, {"c",11}, {"dd",44}, {"ee",55}, {"ff","111"}, {"gg",77}, {"hh",88}, {"ii",new DateTime(2023,08,02)}, {"kk",88}, {"ll",99}
    };


    Dictionary<string, dynamic> keyValuePairs5 = new Dictionary<string, dynamic>()
    {
        {"aa",11},
        {"bb",11}, {"c",3}, {"dd",44}, {"ee",55}, {"ff",66}, {"gg",77}, {"hh",88}, {"ii",88}, {"kk",new DateTime(2023,08,02)}, {"ll",99}
    };


    public PracticeGroupBy()
    {
        myListOfDict.Add(keyValuePairs1);
        myListOfDict.Add(keyValuePairs2);
        myListOfDict.Add(keyValuePairs3);
        myListOfDict.Add(keyValuePairs4);
        myListOfDict.Add(keyValuePairs5);
    }

    public void TestClass()
    {
        var ret = myListOfDict.Where(x => x["c"].Equals(3));

        var res = myListOfDict.SelectMany(c => c).GroupBy(x => x.Value).ToList();

        // myListOfDict.SelectMany(c => c.GroupBy(x => x.Value).Select(x => x).ToList()).ToList();
        foreach (var r in res)
        {
            foreach (var kv in r)
            {
                Console.WriteLine($"{kv.Key} : {kv.Value}");
            }
        }
    }
}
