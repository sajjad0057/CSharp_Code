
using OperatorOverloading;

Fraction f1 = new Fraction(3, 7);
Fraction f2 = new Fraction(4, 9);

Console.WriteLine(f1);
Console.WriteLine(f2);

Fraction f3 = f1 + f2;
Console.WriteLine(f3.ToString());

Fraction f4 = new Fraction(-3,1);
Console.WriteLine(f4);

Fraction f5 = new Fraction(0,5);
Console.WriteLine(f5 / f4);
