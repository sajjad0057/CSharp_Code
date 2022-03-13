using AbstractClass;


// boxing : 

Vehicle v1 = new Bus();           // here v1 is the instance of Bus but v1 provide scope of Vehicle property just.
Vehicle v2 = new Airoplane();     // here v1 is the instance of Airoplane but v2 provide scope of Vehicle property just.

// here v1 can access just Vehicle abstract class members or property, But not access Bus all property. 
v1.Speed = 45.53;
v1.PassengerCount = 102;
v2.Speed = 234.56;

Console.WriteLine($"{v1}");
Console.WriteLine($"{v1.Speed} , {v1.PassengerCount} ---- {v2.Speed}");


// Explicit conversions
// Casting or unboxing : v1 back as  Bus  object and can access the bus property or Bus class scope.

Bus bus = (Bus)v1;
bus.StartHeadLight();

IMovable m = (IMovable)v1;

void MoveItem( IMovable item)
{
    item.Move();
    item.Stop();
}


// Hence Bus class Implement IMovable, so bus obeject can be IMovable instance .

MoveItem(bus);

bus.Stop();  // called from Bus Class , Coz Here Stop() is Bus class Method                                                                                                                                                                                                                                                                                                                                                                                                                        



