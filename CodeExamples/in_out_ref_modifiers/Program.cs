// See https://aka.ms/new-console-template for more information
using in_out_ref_modifiers;
using System.Text.Json;
using System.Text.Json.Nodes;

Console.WriteLine("Hello, World!");




int x = 5;

int func(in int x)
{
    return x;
}

Console.WriteLine($"Example for in modifier : {func(in x)}");


int m;

Console.WriteLine($"Example of out modifier : {func1(out m)}");

int func1(out int m)
{
    m = 5*5;

    return m;
}

Console.WriteLine();


Person person1 = new Person
{
    Id = 1,
    Name = "Foo",
};

Console.WriteLine(JsonSerializer.Serialize(person1));

void func2(ref Person m)
{
    m.Id = 2;
    m.Name = "Bar";
}

func2(ref person1);

Console.WriteLine(JsonSerializer.Serialize(person1));

Console.WriteLine();