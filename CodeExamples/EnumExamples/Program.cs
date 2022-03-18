using EnumExamples;

/*
 
An enumeration type (or enum type) is a value type defined by a set of named constants of the underlying 
integral numeric type. To define an enumeration type, use the enum keyword and specify the names of enum members:

example :

enum Season
{
    Spring,
    Summer,
    Autumn,
    Winter
}

*/

PaymentStatus paymentStatus = PaymentStatus.partial;

if (paymentStatus == PaymentStatus.complete)
{
    Console.WriteLine("execution complete !");
}
else if (paymentStatus == PaymentStatus.partial)
{
    Console.WriteLine("execution partial !");
}
else if (paymentStatus == PaymentStatus.cancel)
{
    Console.WriteLine("execution canceled !");
}

int x = (int)paymentStatus;
Console.WriteLine(x);

