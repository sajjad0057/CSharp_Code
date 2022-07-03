using System;
using Async_Examples;

public class Program
{
    public static async Task Main(string[] args)
    {
        AsyncTest asyncTest = new AsyncTest();

        await asyncTest.PrintEvenAsync();
        await asyncTest.PrintOddAsync();

        Console.ReadKey();

    }
}







