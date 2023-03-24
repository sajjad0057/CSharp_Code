Console.WriteLine("Hello, World!");


int sum(int a, int b, int c= 0)
{
    return a + b + c;
}

Console.WriteLine(sum(1,3,4));



a();
void a()
{
    try
    {
        b();
    }catch(Exception e) 
    {
        throw e;   
    }
}
        

void b()
{
    try
    {
        int a = 1;
        int x = 0;

        int y = a / x;
    }
    catch (Exception e) 
    {
        throw e;
    }
}