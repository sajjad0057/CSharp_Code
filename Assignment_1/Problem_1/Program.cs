
// Give an interger number and rotate times n , (Like 199 4)

Console.WriteLine("Give an interger number and rotate times n , (Like 199 4) : ");

var input = Console.ReadLine().Split(" ");

int num = Convert.ToInt32(input[0]);
int n = Convert.ToInt32(input[1]);

if (n>=1 && n<=30)
{
    var inputToBinary = Convert.ToString(num, 2);

    //Console.WriteLine(inputToBinary);
    //Console.WriteLine(inputToBinary[2]);

    int len = 32;

    inputToBinary = inputToBinary.PadLeft(len, '0');

    Console.WriteLine($"32 bit binary value of {num} : ");

    Console.WriteLine(inputToBinary, 32);

    Console.WriteLine($"After {n} time rotations : ");
    for (int i = n; i < len; i++)
    {
        Console.Write(inputToBinary[i]);
    }

    for (int i = 0; i < n; i++)
    {
        Console.Write(inputToBinary[i]);
    }

}

