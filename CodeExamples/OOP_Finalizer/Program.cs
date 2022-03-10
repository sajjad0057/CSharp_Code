using OOP_Finalizer;
using System;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Clock clock = new Clock();

Console.WriteLine($"{clock.currentTime}");

GC.Collect();  // Gurbase collector , 

Console.WriteLine(clock.currentTime);



