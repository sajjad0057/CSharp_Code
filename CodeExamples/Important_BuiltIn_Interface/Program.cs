﻿
using Important_BuiltIn_Interface;

Box box = new Box(5);

box.Add("hello");
box.Add("world");
box.Add(4.3);

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



IEnumerable<object> something = new List<object>();

//Box b = (Box)something;   // if we use casting or Boxing / UnBoxing is this case throw an error 

Box b2 = something as Box;   // here b2 set  null value  , coz, something is not Box, But does not throw an Error . 