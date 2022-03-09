int[] num =new int[] { 10,10,10,10 };

double CalculateAverage(int[] num)
{
    int sum = 0;
    foreach (var item in num)
    {
        sum += item;
        
    }
    return sum/num.Length;
}

int x = 1;
Console.WriteLine(CalculateAverage(num));
Console.WriteLine(x++);


/*
 * C# have four loop :
  - for loop
  - while loop
  - do while loop
  - foreach loop
 */

object[] everyThing = new object[] { 1, "practice object type", 3.4 };

String printValue(object[] everyThing)
{
    string str=""; 
    foreach (var item in everyThing)
    {
        str += item.ToString()+" ";
    }

    return $"[{str}]";
}
Console.WriteLine("\n-----------------------------------------------\n");
Console.WriteLine(printValue(everyThing));