// See https://aka.ms/new-console-template for more information
//Print using Console.WriteLine()
Console.WriteLine("Hello, World!\n");


// Received user defined intput by using Console.ReadLine() 
Console.WriteLine("Write Your name : \n");
var x =  Console.ReadLine();
Console.WriteLine($"\n----------------------\n" +
    $"Your name : {x}\n");


void PrintMyName(string name) => Console.WriteLine($"My Name is : {name}");


//return name;


for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Write your name : ");
    PrintMyName(Console.ReadLine());
}