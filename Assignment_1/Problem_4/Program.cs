
Console.WriteLine("Give Integer Numbers : ");

int num = int.Parse(Console.ReadLine());

//a. Reverse the order of the number

Console.Write($"Reverse Order of {num} is : ");




// Methods for reversing number : 

int reverseNumber(int num)
{
    int rnum = 0;

    while (num > 0)
    {
        rnum = rnum * 10 + num % 10;
        num = num / 10;

    }
    return rnum;
}



int rn = reverseNumber(num);
Console.Write(rn);
// b. Then split the odd position number and even position numbers.

string x = rn.ToString();

//Console.WriteLine(x.GetType().Name);

int i = 1;
string odd = "";
string even = "";

foreach (char c in x)
{
    if (i % 2 == 1)
        odd += c;
    else
        even += c;

    i++;
    
}
Console.WriteLine();
Console.WriteLine($"The Odd position Number : {odd} ");
Console.WriteLine($"The Even position Number : {even} ");



// c. Then reverse the odd position number and reverse the even position numbers.


int oddNum = int.Parse(odd);
int evenNum = int.Parse(even);

int rOdd = reverseNumber(oddNum);
int rEven = reverseNumber(evenNum);


Console.WriteLine($"Reverse of the Odd Position Number : {rOdd}");
Console.WriteLine($"Reverse of the Even Position Number : {rEven}");


// d. Print the 2 sets of numbers in two separate lines separated by comma.

Console.WriteLine($"Number of 2  sets  : {{{odd},{rOdd}}} ,");

Console.WriteLine($"{{{even},{rEven}}}");


