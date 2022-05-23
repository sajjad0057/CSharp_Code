

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



//// Declareing Anonymous Function need to delegate / Func<> / Action<>


Func<int, int> Square = x => x * x;

// here : [type]  [variable_name]  = [Anonymous Function]

Console.WriteLine(Square(5));


Action<int> test=(int a)=>
{
    Console.WriteLine($"{a}+1 = {a+1}");
    Console.WriteLine($"{a}+2 = {a+2}");

};

test(3);