using System.Diagnostics;
using Threading;

/*
Provides a set of methods and properties that you can use to accurately measure
elapsed time. 
*/




/*

Stopwatch stopwatch = new Stopwatch();


stopwatch.Start();

PrimeGenerator primeGernerator = new PrimeGenerator();

//var r1 = primeGernerator.Generate(0, 10000000);

//var r2 = primeGernerator.Generate(10000, 10000000);

// // Using Thread : 

Thread t1 = new Thread(() => primeGernerator.Generate(0, 10000000));

Thread t2 = new Thread(() => primeGernerator.Generate(10000, 10000000));

t1.Priority = ThreadPriority.Highest;
t2.Priority = ThreadPriority.Highest;

t1.Start();
t2.Start();


stopwatch.Stop();

Console.WriteLine($"Taking Time : {stopwatch.Elapsed}");


*/




Thread t1 = new Thread(() => PrintOdd(100));

Thread t2 = new Thread(() => PrintEven(100));

t1.Priority = ThreadPriority.Highest;
t2.Priority = ThreadPriority.Highest;


t1.Start();
t2.Start();


void PrintOdd(int x)
{
    for (int i = 0; i < x; i++)
    {
        if(i % 2 == 1)
        {
            Console.WriteLine($"{i} is Odd Number . ");
            Thread.Sleep(100);
        }
        else
        {
            continue;
        }
            
    }
}

void PrintEven(int x)
{
    for (int j = 0;j < x; j++)
    {
        if( j % 2 == 0 )
        {
            Console.WriteLine($"{j} is Even Number . ");
            Thread.Sleep(100);
        }
        else
        {
            continue;
        }

    }
}

