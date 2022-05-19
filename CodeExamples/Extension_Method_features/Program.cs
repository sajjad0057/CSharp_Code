using Extension_Method_features;

List<int> list = new List<int>();

list.Add(1);
list.Add(2);
list.Add(3);
list.Add(4);
list.Add(5);
list.Add(6);


(List<int> a , List<int> b) result = list.Split<int>();


Console.WriteLine("First Part of the List : ");

foreach (int i in result.a)
{
    Console.WriteLine(i);
}

Console.WriteLine("Second Part of the List : ");

foreach(int i in result.b)
{
    Console.WriteLine(i);
}



string test = "my name Is Sajjad Hossain";

int noOfVowel = test.countVowel();

Console.WriteLine("No of vowel : ");

Console.WriteLine(noOfVowel);