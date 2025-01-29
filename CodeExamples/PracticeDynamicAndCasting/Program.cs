dynamic dObj = new Student
{
    Id = 1,
    Name = "sajjad",
    Age = 26
};

Student s = dObj;

Console.WriteLine();


string numString = "fghfh";
int x;
Int32.TryParse(numString, out x);
Console.WriteLine($"{x}");

byte xByte = (byte)x;

Console.WriteLine((int)(xByte+1));
Console.WriteLine();

