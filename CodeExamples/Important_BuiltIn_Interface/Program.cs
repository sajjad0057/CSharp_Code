
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


Console.WriteLine("====================================================================");

/*
 * 
The ICloneable interface enables you to provide a customized implementation that creates a copy of an existing object.

*/

Console.WriteLine("Practice IColoneable interface");


// here we can say bottle1 and his property is a prototype of WaterBottle Class . 

WaterBottle bottle1 = new WaterBottle(100,50,"blue");
bottle1.ReleaseWater(10);
bottle1.ReleaseWater(15);
bottle1.AddWater(20);

Console.WriteLine($"bottle1 :: Capacity : {bottle1.Capacity} ; WaterAmount : {bottle1.WaterAmount} ; Color : {bottle1.Color} ");


// copying bottle1 prototype we can create same as bottle1, another object from  that have same property, by this given way : 

WaterBottle bottle2 = bottle1.Copy();
WaterBottle bottle3 = bottle1.Copy();
WaterBottle bottle4 = bottle1.Copy();

Console.WriteLine($"bottle2 :: Capacity : {bottle2.Capacity} ; WaterAmount : {bottle2.WaterAmount} ; Color : {bottle2.Color} ");
Console.WriteLine($"bottle4 :: Capacity : {bottle4.Capacity} ; WaterAmount : {bottle4.WaterAmount} ; Color : {bottle4.Color} ");
