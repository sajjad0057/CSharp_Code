using FuncAction_Examples;

int[] arr = new int[] { 1, 3, 2, 8, 9, 7, 10, 6, 5 };

int CompareValue(int a, int b)
{
    if (a > b)
        return 1;
    else if (a < b)
        return -1;
    return 0;
}


//// BubbleSort<int>.Sort(arr, CompareValue);





//// Also we can write :
///
Func<int, int, int> y = CompareValue;

BubbleSort<int>.Sort(arr, y);


Console.WriteLine("Sorting Result : ");

void Print(int[] array)
{
    foreach (int a in array)
    {
        Console.Write($"{a} , ");
    }
}

Action<int[]> z = Print;

z(arr);