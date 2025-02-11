using CSharp12_New;

Console.WriteLine("---------------------c# 12 new--------------------");

Person person = new ("sajjad", "student");

if(person is { Title : "student" })
{
    Console.WriteLine($"Person Name : {person.Name}; Title : {person.Title}");
}
else
{
    Console.WriteLine("Person Title does not exists");
}
