
using  Delegate_Examples;



//// here , Delegate_Ex.SomeMethod passes just type of y . 

Delegate_Ex.SomeMethod y = Sum;

int res = y(2,3);
Console.WriteLine($"Result : {res}");

int Sum(int a, int b)
{
    return a + b;
}




int[] arr = new int[] { 1,3, 2, 8,  9, 7, 10, 6, 5 };

BubbleSort<int>.Sort(arr, CompareValue);


int CompareValue(int a , int b)
{
    if (a > b)
        return 1;
    else if (a < b)
        return -1;
    return 0;
}


Console.WriteLine("Sorting Result : ");

foreach (int a in arr)
{
    Console.Write($"{a} , ");
}