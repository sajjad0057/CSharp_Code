using System;

namespace Test;
using System.Threading.Tasks;

public class Coordinate<T,Q>    // here T, Q data type  , passed as parameter . 
{
    public T X { get; set; }
    public  Q Y { get; set; }


    // using generic typed in methods

    public void DoSomething<A,B>(Q q, A a , B b)  // parameter type Q , that Passes in Struct 
    {
        Console.WriteLine($"q : {q.GetType()} ; a : {a.GetType()} ; b : {b.GetType()}");


    }

}


public class TestCode
{
    public static void Main(string[] args)
    {
        Coordinate<int,double> intCoordinate = new Coordinate<int,double>();

        intCoordinate.X = 12;
        intCoordinate.Y = 13.0;

        intCoordinate.DoSomething<decimal, string>(2.4, 5, "Sajjad");


        Coordinate<double,string> doubleCoordinate = new Coordinate<double,string> { X = 5.5, Y = "sajjad" }; // object initializer . 


    }
}