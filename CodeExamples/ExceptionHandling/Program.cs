using ExceptionHandling;





Console.WriteLine("Practice Exception Handling : ");
Console.WriteLine("---------------------------------------------------------------------");




int x = 4;

int y = 0;


//try
//{
//    int z = x / y;
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//    Console.WriteLine("Divided By Zero Does Not Possible -");
//}




try
{
    var z = new Divide().Calculate(x, y);

    Console.WriteLine($"{x} / {y} = {z} ");

}catch(DivideByZeroException e)
{
    Console.WriteLine(e.Message);

    Console.WriteLine("Divided By Zero Does Not Possible -");
}
catch(InvalidInputException e)
{
    Console.WriteLine(e.Message);
    
}
catch(Exception e)
{
    Console.WriteLine($"An Exception Occur : Something is wrong");
}
finally
{
    Console.WriteLine("---------------------------------------------------");
    Console.WriteLine("We Practice Exception Handling . ");
};