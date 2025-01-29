using System.Text.Json;
using System.Text.Json.Serialization;

namespace CheckToListOfDict
{
    public class CheckListAndUpdateElement
    {

        public IList<IDictionary<string, dynamic>> list1 = new List<IDictionary<string, dynamic>>
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


        public IList<IDictionary<string, dynamic>> list2 = new List<IDictionary<string, dynamic>>
        {
            new Dictionary<string, dynamic>
            {
                {"Id", "1"},
                {"Age", 30},
                {"IsStudent", false}
            },
            new Dictionary<string, dynamic>
            {
               {"Id", "4"},
               {"Age", 55},
               {"IsStudent", true}
            }
        };

        public CheckListAndUpdateElement() { }

        public CheckListAndUpdateElement CheckAndUpdate()
        {
            list1 = list1
                .Select(item1 =>
                {
                    var id1 = item1["Id"].ToString();
                    if (list2.Any(item2 => item2["Id"].ToString() == id1))
                    {
                        item1["Age"] = null;
                    }
                    return item1;
                })
                .ToList();

            Console.WriteLine($"list1 ->>> :: {JsonSerializer.Serialize(list1)}");

            return this;
        }

        public CheckListAndUpdateElement TestMtdh()
        {
            list1 = list1.Select(dict =>
            {
                dict["sss"] = "test";
                return dict;
            }).ToList();

            Console.WriteLine($"TestDict ->> :: {JsonSerializer.Serialize(list1)}");

            return this;
        }

    }
}
