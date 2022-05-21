
using  Delegate_Examples;



//// here , Delegate_Ex.SomeMethod passes just type of y . 

Delegate_Ex.SomeMethod y = Sum;

int res = y(2,3);
Console.WriteLine($"Result : {res}");

int Sum(int a, int b)
{
    return a + b;
}