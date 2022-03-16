#region Example 1 - Increment/Decrement operator
Console.WriteLine($"Increment or Decrement Operator\n" +
    $"--------------------------------------------------\n");
int i = 3;
Console.WriteLine(i); // output: 3
Console.WriteLine(i++); // output: 3
Console.WriteLine(i); // output: 4
double a = 1.5;
Console.WriteLine(a); // output: 1.5
Console.WriteLine(++a); // output: 2.5
Console.WriteLine(a); // output: 2.5
int i2 = 3;
Console.WriteLine(i2); // output: 3
Console.WriteLine(i2--); // output: 3
Console.WriteLine(i2); // output: 2
double a2 = 1.5;
Console.WriteLine(a2); // output: 1.5
Console.WriteLine(--a2); // output: 0.5
Console.WriteLine(a2); // output: 0.5
Console.WriteLine($"\n" +
    $"End Increment or Decrement Operator\n" +
    $"--------------------------------------------------\n");
#endregion
#region Example 2 - Unary plus and minus operators
Console.WriteLine($"Unary Plus and Minus Operators\n" +
    $"--------------------------------------------------\n");

Console.WriteLine(+4); // output: 4
Console.WriteLine(-4); // output: -4
Console.WriteLine(-(-4)); // output: 4

Console.WriteLine($"\n" +
    $"End Unary Plus and Minus Operators\n" +
    $"---------------------------------------------------\n");

#endregion
#region Example 3 - Math operators
Console.WriteLine($"Math Operators\n" +
    $"--------------------------------------------------\n");


Console.WriteLine(5 * 2); // output: 10
Console.WriteLine(0.5 * 2.5); // output: 1.25
Console.WriteLine("----------------> "+ 0.3256m * 25.125654m); // output:  8.1809129424
Console.WriteLine(13 / 5); // output: 2
Console.WriteLine(-13 / 5); // output: -2
Console.WriteLine(13 / -5); // output: -2

Console.WriteLine(-13 / -5); // output: 2
Console.WriteLine("When two numbers are float : "+16.8f / 4.1f); // output: 4.097561
Console.WriteLine("When two numbers are double : "+16.8d / 4.1d); // output: 4.09756097560976
Console.WriteLine("When two numbers are decimal : "+16.8m / 4.1m); // output:4.09756097560975609756097560


Console.WriteLine(5 % 4); // output: 1
Console.WriteLine(5 % -4); // output: 1
Console.WriteLine(-5 % 4); // output: -1
Console.WriteLine(-5 % -4); // output: -1
Console.WriteLine(-5.2f % 2.0f); // output: -1.2
Console.WriteLine(5.9 % 3.1); // output: 2.8
Console.WriteLine(5.9m % 3.1m); // output: 2.8
Console.WriteLine(5 + 4); // output: 9
Console.WriteLine(5 + 4.3); // output: 9.3
Console.WriteLine(5.1m + 4.2m); // output: 9.3
Console.WriteLine(47 - 3); // output: 44
Console.WriteLine(5 - 4.3); // output: 0.7
Console.WriteLine(7.5m - 2.3m); // output: 5.2
int x = 5;
x += 9;
Console.WriteLine(x); // output: 14
x -= 4;
Console.WriteLine(x); // output: 10
x *= 2;
Console.WriteLine(x); // output: 20
x /= 4;
Console.WriteLine(x); // output: 5
x %= 3;
Console.WriteLine(x); // output: 2

Console.WriteLine($"\n" +
    $"End Math Operators\n" +
    $"--------------------------------------------------\n");
#endregion

#region Pointer related Operators and sizeOf Operator


Console.WriteLine($"\n" +
    $"Pointer related Operators and sizeof Operator\n" +
    $"---------------------------------------------------\n");
/*
Any operation with pointers must requires an unsafe context. 
The code that contains unsafe blocks must be compiled with 
the AllowUnsafeBlocks compiler option.

Also,
The sizeof operator requires an unsafe context

The sizeof operator returns the number of bytes occupied by a variable of a given type.
*/

unsafe
{
    int number = 27;
    int* pointerToNumber = &number;

    Console.WriteLine($"Value of the variable: {number}");
    Console.WriteLine($"Address of the variable: {(long)pointerToNumber:X}");
    Console.WriteLine($"Number of bytes occupied by variable typed int: {sizeof(int)}");
}


Console.WriteLine($"\n" +
    $"End Pointer related Operators and sizeof Operator\n" +
    $"---------------------------------------------------\n");
#endregion



#region Example 4 - Bitwise complement operator ~

Console.WriteLine($"Bitwise complement Operators\n" +
    $"--------------------------------------------------\n");

// The octal number should be prefix with 0.
// The hexa-decimal number should be prefix with 0X or 0x.
// The binary number should be prefix with 0b.


uint hex = 0xa;
Console.WriteLine(Convert.ToString(hex,16));
Console.WriteLine(Convert.ToString(hex,10));

uint t = 0b_0000_1111_0000_1111_0000_1111_0000_1100;
uint b = ~t;
Console.WriteLine(Convert.ToString(b, toBase:2));
// Output:
// 11110000111100001111000011110011
#endregion
#region Example 5 Shift operators

uint m = 0b_1100_1001_0000_0000_0000_0000_0001_0001;
Console.WriteLine($"Before: {Convert.ToString(m, toBase:2)}");
uint y = m >> 4;
Console.WriteLine($" After: {Convert.ToString(y, toBase:2)}");
// Output:
// Before: 11001001000000000000000000010001
// After:  10010000000000000000000100010000

uint j = 0b_1111_0000_0000_0000_0001_0001_1111_0000;
uint k = j >> 4;
Console.WriteLine("===================================================");

//using string formating : 

Console.WriteLine($"Before: {Convert.ToString(j, toBase: 2),32}");   
Console.WriteLine($" After: {Convert.ToString(k, toBase: 2),32}");

Console.WriteLine("===================================================");

uint n = 0b_1001;
Console.WriteLine($"Before: {Convert.ToString(n, toBase:2)}");

uint n2 = n >> 2;
Console.WriteLine($"After : {Convert.ToString(n2, toBase:2),4}");

// Output:
// Before: 1001
// After: 10

var num = 27;
Console.WriteLine($"{num << 3}");  // here 27*2*2*2
Console.WriteLine($"{num >> 3}");  // here 27/2/2/2


Console.WriteLine($"\n" +
    $"End Bitwise complement Operators\n" +
    $"--------------------------------------------------\n");


#endregion

#region Example 6 Logical Operators
Console.WriteLine($"Logical Operators\n" +
    $"--------------------------------------------------\n");


uint a1 = 0b_1111_1000;
uint b1 = 0b_1001_1101;
uint c1 = a1 & b1;
Console.WriteLine(Convert.ToString(c1, toBase: 2));
// Output:
// 10011000
uint p = 0b_1111_1000;
uint q = 0b_1001_1101;

uint r = p | q;
Console.WriteLine(Convert.ToString(r, toBase: 2));
// Output:
// 11111101
uint w = 0b_1111_1000;
uint v = 0b_0001_1100;
uint z = w ^ v;
Console.WriteLine(Convert.ToString(z, toBase: 2));
// Output:
// 11100100

Console.WriteLine($"\n" +
    $"End Bitwise complement Operators\n" +
    $"--------------------------------------------------\n");

#endregion


#region example of Ternary Operator & Lambda Expression

Console.WriteLine("\nExample of Ternary Operator & Lambda Expression :");


/*
 Ternary Operator :
    condition ? consequent : alternative  

Lambda Expression :
    (input-parameters) = > expression
    (input-parameters) = > { sequence - of - statement }
 */



string GetWeatherDisplay(double tempInCelsius) => tempInCelsius < 20.0 ? "Cold." : "Perfect!";

Console.WriteLine(GetWeatherDisplay(15));  // output: Cold.
Console.WriteLine(GetWeatherDisplay(27));  // output: Perfect!


Console.WriteLine("\nEnd Example of Ternary Operator & Lambda Expression \n" +
    "--------------------------------------------------\n");


#endregion



//Operator Overloading
//using System;
//public readonly struct Fraction
//{
//    private readonly int num;
//    private readonly int den;
//    public Fraction(int numerator, int denominator)
//    {
//        if (denominator == 0)
//        {
//            throw new ArgumentException("Denominator cannot be zero.",

//            nameof(denominator));
//        }
//        num = numerator;
//        den = denominator;
//    }
//    public static Fraction operator +(Fraction a) => a;
//    public static Fraction operator -(Fraction a) => new Fraction(-a.num,
//    a.den);
//    public static Fraction operator +(Fraction a, Fraction b)
//    => new Fraction(a.num * b.den + b.num * a.den, a.den * b.den);

//    public static Fraction operator -(Fraction a, Fraction b)
//    => a + (-b);
//    public static Fraction operator *(Fraction a, Fraction b)
//    => new Fraction(a.num * b.num, a.den * b.den);
//    public static Fraction operator /(Fraction a, Fraction b)
//    {
//        if (b.num == 0)
//        {
//            throw new DivideByZeroException();
//        }
//        return new Fraction(a.num * b.den, a.den * b.num);
//    }
//    public override string ToString() => $"{num} / {den}";
//}
//public static class OperatorOverloading
//{
//    public static void Main()
//    {
//        var a = new Fraction(5, 4);
//        var b = new Fraction(1, 2);
//        Console.WriteLine(-a); // output: -5 / 4
//        Console.WriteLine(a + b); // output: 14 / 8
//        Console.WriteLine(a - b); // output: 6 / 8
//        Console.WriteLine(a * b); // output: 5 / 8
//        Console.WriteLine(a / b); // output: 10 / 4
//    }
//}
