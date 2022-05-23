

/*
 * 
int Sum(int a, int b)
{
    return a + b;
} 

*/

//// Eqivalent Lambda Method :



int Sum(int a, int b) => a + b;


int res = Sum(5,6);




void Print(int a) => Console.WriteLine(a);


////Console.WriteLine(res);

Print(res);