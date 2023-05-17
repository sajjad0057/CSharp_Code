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



Console.WriteLine("===========================================================================");

Temperature temperature = new Temperature(0);

try
{
    temperature.showTemp();
}
catch(TempIsZeroException e)
{
    Console.WriteLine(e.Message);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
finally
{
    Console.WriteLine("Practice User define Exception Handling - ");
}

Console.WriteLine("===============================================================");

int[] someNums = new int[]{ 1, 4, 5, 0, 7, 3, 0, 9 };

foreach (int num in someNums)
{
    try
    {
        Console.WriteLine($"Result 20 / {num} = {20/num}");
    }
    catch(DivideByZeroException ex )
    {
        Console.WriteLine($"Result 20 / {num} = Zero can not be divisor");
    }
    catch(Exception ex)
    {
        Console.WriteLine($"{ex.Message}");
    }
}
