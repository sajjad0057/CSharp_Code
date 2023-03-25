// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!");


Queue<string> myQ = new Queue<string>();
myQ.Enqueue("1");
myQ.Enqueue("2");
myQ.Enqueue("3");
myQ.Enqueue("4");
myQ.Enqueue("5");
myQ.Enqueue("6");
myQ.Enqueue("7");
myQ.Enqueue("8");
myQ.Enqueue("9");
myQ.Enqueue("10");
myQ.Enqueue("11");
myQ.Enqueue("12");

while (myQ.Count > 0)
{
    Console.WriteLine(myQ.Dequeue());
}


IEnumerable<string> list = new List<string>() { "a","b","c","d","e","f","g"};


Queue<IList<string>> q = new Queue<IList<string>>();


//for(int i = 0; i < list.Count(); i = +3)
//{
//    for(int j = 0;)
//}


//List<string> myList = new List<string> { "apple", "banana", "orange", "grape", "peach", "pear", "kiwi" };

//int batchSize = 3;

//List<List<string>> batches = myList
//    .Select((value, index) => new { Index = index, Value = value })
//    .GroupBy(x => x.Index / batchSize)
//    .Select(x => x.Select(v => v.Value).ToList())
//    .ToList();


Console.WriteLine();




List<string> myList = new List<string> { "apple", "banana", "orange", "grape", "peach", "pear", "kiwi" };
int batchSize = 3;

Queue<List<string>> batchQueue = new Queue<List<string>>();

myList.Select((value, index) => new { Index = index, Value = value })
      .GroupBy(x => x.Index / batchSize)
      .Select(x => x.Select(v => v.Value).ToList())
      .ToList()
      .ForEach(batch => batchQueue.Enqueue(batch));


Console.WriteLine();

