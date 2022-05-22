using FuncAction_Examples;

int[] arr = new int[] { 1, 3, 2, 8, 9, 7, 10, 6, 5 };

BubbleSort<int>.Sort(arr, CompareValue);


int CompareValue(int a, int b)
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


//// Also we can write :
///
Func<int, int, int> y = CompareValue;