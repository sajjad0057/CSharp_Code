


public struct Coordinate<T,Q>    // here T, Q data type  , passed as parameter . 
{
    public T X { get; set; }
    public  Q Y { get; set; }


    // using generic typed in methods

    public T DoSomething(Q q)  // parameter type Q , that Passes in Struct 
    {
        throw new NotImplementedException();

        // return type T .
    }

}


public class TestCode
{
    public static void Main(string[] args)
    {
        Coordinate<int,double> intCoordinate = new Coordinate<int,double>();

        intCoordinate.X = 12;
        intCoordinate.Y = 13.0;

        Coordinate<double,string> doubleCoordinate = new Coordinate<double,string> { X = 5.5, Y = "sajjad" }; // object initializer . 
    }
}