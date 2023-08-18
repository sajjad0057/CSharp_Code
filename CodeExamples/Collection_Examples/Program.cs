using Collection_Examples;
using System.Collections;
using System.Collections.ObjectModel;
using System.Text.Json;

Console.WriteLine("Example of List : ");

List<string> names = new List<string>();

names.Add("sajjad");
names.Add("nafiul");
names.Add("zahan");

List<int> ages = new List<int>();

ages.Add(25);
ages.Add(22);
ages.Add(23);

var age2 = ages.Take(1);




// we can also set generic as generic types : 


List<List<int>> listofAgesList = new List<List<int>>();
listofAgesList.Add(ages);




List<List<List<int>>> multiverse = new List<List<List<int>>>();
multiverse.Add(listofAgesList);

foreach (var listofages in multiverse)
{
    foreach (var agelist in listofages)
    {
        foreach (var age in agelist)
        {
            Console.WriteLine(age);
        }
    }
}



// we can also set tuple as generic types : 

List<(int year, int month)> records = new List<(int year, int month)>();

records.Add((2011, 11));
records.Add((2013, 3));
records.Add((2014, 5));




List<string> counts = new List<string>();
counts.Add("Dhaka");
counts.Add("Sylhet");
counts.Add("Khulna");
Console.WriteLine($"subString : {counts[2].Substring(3, 2)}");






// Dictionary  :


Dictionary<string,int> due = new Dictionary<string,int>();

due.Add("sajjad", 50);
due.Add("nefal", 53);
due.Add("arif", 45);

Console.WriteLine($"value of sajjad keys : {due["sajjad"]}");

//// We can also using index to accessing dictionary : -
///
Console.WriteLine($"accessing dictionary with index : {due.ElementAt(2).Key} : {due.ElementAt(2).Value}");

foreach (var key in due.Keys)
{
    if (due[key] < 50)
    {
        due.Remove(key);
    }
}





foreach (var key in due.Keys)
{
    Console.WriteLine($"{key} : {due[key]}");
}



// for get behave as set we can use HashSet :

/*
HashSet<T> calculate Hash value of a values ,and produce hash value,, HastSet does not contain same hash value ,
so, HashSet<T> Collections store just unique value . work like as set . 
 */

HashSet<int> vs = new HashSet<int>();   

vs.Add(1);
vs.Add(2);
vs.Add(3);
vs.Add(3);
vs.Add(4);
vs.Add(5);
vs.Add(6);
vs.Add(5);


Console.WriteLine("Example of HashSet : ");



foreach (var v in vs)
{
    Console.WriteLine(v);
}






// SortedList<k,V> storing sorted value by their keys .
// 
SortedList<string, int > person = new SortedList<string, int>();

person.Add("sajjad", 30);
person.Add("nefal", 25);
person.Add("mahdi", 27);
person.Add("zahan", 17);

foreach (var k in person.Keys)
{
    Console.WriteLine($"key : {k} ; value : {person[k]}");
}



// Stack 

Stack<int> items = new Stack<int>();
items.Push(20);
items.Push(30);
items.Push(40);

Console.WriteLine("stack example");

Console.WriteLine(items.Pop());
Console.WriteLine(items.Pop());
Console.WriteLine(items.Pop());




/*
 * Example of Non-generics collections : 
 
*/

Console.WriteLine("Example of Non-generics collections :");


ArrayList counts2 = new ArrayList();
counts2.Add(2);
counts2.Add(true);
counts2.Add("dhaka");

foreach (var v in counts2)
{
    Console.WriteLine(v);
}



IReadOnlyCollection<int> ints2 = new ReadOnlyCollection<int>(new List<int>{1,2,3,4,5});


Console.WriteLine($"Examples of IReadOnlyCollection , Count : {ints2.Count()} ");


Console.WriteLine("********************************************************************************************************");
Console.WriteLine("********************************************************************************************************");


IList<string> list = new List<string>();

Console.WriteLine(JsonSerializer.Serialize(list));

var list1 = new List<string> { "a", "b", "c" };

list = list.Concat(list1).ToList();

Console.WriteLine(JsonSerializer.Serialize(list));


var testObj = new List<Test>()
{
    new Test
    {
        Id = "d"
    },
    new Test
    {
        Id = "d"
    },
    new Test
    {
        Id = "d"
    },
    new Test
    {
        Id = "d"
    }
};



list = list.Concat(testObj.Select(x=>x.Id)).ToList();


Console.WriteLine(JsonSerializer.Serialize(list));

Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Checking Dict key and get match keys<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");

Dictionary<string, int> dictionary = new Dictionary<string, int>
        {
            { "key1", 10 },
            { "key2", 20 },
            { "key3", 30 },
            // Add more key-value pairs
        };

List<string> keysToCheck = new List<string> { "key1", "key" };

var keysInDictionary = keysToCheck.Intersect(dictionary.Keys);

foreach (string key in keysInDictionary)
{
    Console.WriteLine($"Dictionary contains key '{key}' with value {dictionary[key]}");
}

var keysNotInDictionary = keysToCheck.Except(dictionary.Keys);

foreach (string key in keysNotInDictionary)
{
    Console.WriteLine($"Dictionary does not contain key '{key}'");
}


var s = "sajj-ad";

var ss = s.Split(new char[] {';','-'}).ToList();

Console.WriteLine();

Console.WriteLine();