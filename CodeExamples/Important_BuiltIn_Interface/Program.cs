
using Important_BuiltIn_Interface;

Box box = new Box();

box._items = new object[5];

box._items[0] = "hello";
box._items[1] = "world";
box._items[2] = 42.3;

foreach (var item in box)
{
    Console.WriteLine(item);
}


/*
 * Hierarchy of Importance Interface implementations :
 * 
// IEnumerable
// ICollection : IEnumerable
// IList : ICollectio

 */


Console.WriteLine("try to understand hierarchy of interface implementations : \n");

DoSomething(box);

/*
here we pass all collections and All that class are implemented IEnumerable<T> interface ,
cz- all are implements IEnumerable<T> interface 
 */

void DoSomething(IEnumerable<object> items)
{
    foreach (var item in items)
    {
        Console.WriteLine(item);
    }
}

DoSomething(new HashSet<object> { 1, 2, 3, 4, 3, 4, 5 });

Console.WriteLine("========================================================================");

DoAthoterThing(new HashSet<object> { 1,2,3,4,3,4,5});  // using  collection initalizer . 

/*
Here we does not pass Box class object or another class that's are not implemented ICollection<T> interface,  
Box or another class does not implement ICollection interface. 
*/

void DoAthoterThing(ICollection<object> collection)  
{
    foreach (var item in collection)
    {
        Console.WriteLine(item);
    }
}



