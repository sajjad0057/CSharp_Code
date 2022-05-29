using System;
using Async_Examples;

public class Program
{
    public static void Main(string[] args)
    {
        AsyncTest asyncTest = new AsyncTest();

        asyncTest.PrintEvenAsync();
        asyncTest.PrintOddAsync();

        Console.ReadKey();

    }
}







