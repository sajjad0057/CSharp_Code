Console.WriteLine("Give One large number : ");

string s1 = Console.ReadLine();

Console.WriteLine("Give Another large number : ");

string s2 = Console.ReadLine();

//Console.WriteLine(s1[4].GetType());


int len = Math.Max(s1.Length, s2.Length);
s1 = s1.PadLeft(len, '0');
s2 = s2.PadLeft(len, '0');


//Console.WriteLine(s1);
//Console.WriteLine("=======================================");
//Console.WriteLine(s2);

int[] result = new int[len];

int carry = 0;
for (int i = len-1; i >= 0; i--)
{
    int a = s1[i]-'0';             // Convert ASCII value to integer value 
    int b = s2[i]-'0';             // Convert ASCII value to integer value 
    int sum = a + b + carry;
    if (sum >= 10)
    {
        carry = 1;
        result[i] = sum % 10;
    }
    else
    {
        carry = 0;
        result[i] = sum;
    }
}


Console.WriteLine("The Sum of that's two large number : ");

if(carry > 0)
{
    Console.Write(carry);
}
foreach (int i in result)
{
    Console.Write(i);
}




