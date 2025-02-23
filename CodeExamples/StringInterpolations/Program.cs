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



    



