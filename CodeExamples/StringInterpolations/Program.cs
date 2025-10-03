using System.Dynamic;
using System.Runtime.Serialization.Json;
using System.Text.Json;
using StringInterpolations;


Console.WriteLine("if want to exists press X");
while (true)
{
    Console.WriteLine("Put bank account : ");
    string bank_account_no = Console.ReadLine();

    if(bank_account_no.Equals("X"))
        break;
    string modified_bank_account_no = StringInterpolation.MaskMiddlePart1(bank_account_no);
    Console.WriteLine(modified_bank_account_no);

}

Console.WriteLine("Range Operator in c#");
Console.WriteLine("sajjad"[..]);


string str = string.Empty;

dynamic ex = new ExpandoObject();

str = "1";
ex.a1 = str;
str = "2";
ex.b1 = str;
str = "3";
ex.c1 = str;
str = "4";
ex.d1 = str;
str = "5";
ex.e1 = str;
Console.WriteLine($"ex : {JsonSerializer.Serialize(ex)}");

Console.WriteLine();








    



