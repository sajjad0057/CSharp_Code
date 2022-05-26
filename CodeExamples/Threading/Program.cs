using System.Diagnostics;
using Threading;


/*
Provides a set of methods and properties that you can use to accurately measure
elapsed time. 
*/

Stopwatch stopwatch = new Stopwatch();


stopwatch.Start();

PrimeGenerator primeGernerator = new PrimeGenerator();

var r1 = primeGernerator.Generate(0, 10000000);

var r2 = primeGernerator.Generate(10000, 10000000);


stopwatch.Stop();

Console.WriteLine($"Taking Time : {stopwatch.Elapsed}");