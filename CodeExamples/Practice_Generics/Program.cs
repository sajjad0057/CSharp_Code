
using Practice_Generics;

#region  practice generics datatype
//public class GenericClassName<T, Q>
//{
//    public T X { get; set; }
//    public Q Y { get; set; }

//    // using generic type in methods

//    public T DoSomething<A, B>(Q q, A a, B b)
//    {
//        if (b is true)
//            return X;
//        else
//            return default(T);    // default return the default value of dataType . 
//    }
//}



//public class TestCode
//{
//    public static void Main(string[] args)
//    {
//        GenericClassName<int, string> obj = new GenericClassName<int, string> { X = 500, Y = "sajjad" };
//        var res = obj.DoSomething<double, bool>("sajjad", 2.3, true);
//        Console.WriteLine($"X : {obj.X} ; Y : {obj.Y} ; res : {res}");
//    }
//}

#endregion



#region Practice Generic Types with Interface and work with Constrain 

using Practice_Generics;

//Container<IItem> container = new Container<IItem>(10);    // doesn't use it efficient here . Cz it's generalized . 

Container<A> container2 = new Container<A>(2);

container2.AddItem(new A(1, 2, 3, 4));
container2.AddItem(new A(2, 3, 4, 5));

foreach (var items in container2.AllItems())
{
    //Console.WriteLine(items?.GetType());
    Console.WriteLine($"Width : {items.Width} ; Length : {items.Length} ; Height : {items.Height} ; Weight : {items.Weight}");
}




/*
We use generic for using specific or specialized entity , ex -  here we use Apple or Banana intancle in container class . 
if we to use generalized Then , here we don't need generics , we can do just implement IItem interface and 
Initate object from interface .  
 */

#endregion




