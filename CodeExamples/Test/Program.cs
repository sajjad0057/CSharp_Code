using Test;

string inputString = "Value21";


MyEnum enumValue;

if (Enum.IsDefined(typeof(MyEnum), inputString) && Enum.TryParse(inputString, out enumValue))
{
    // The string exists in the enum
    Console.WriteLine($"{inputString} is a valid value in MyEnum.");
}
else
{
    // The string does not exist in the enum
    Console.WriteLine($"{inputString} is not a valid value in MyEnum.");
}

Console.WriteLine();
