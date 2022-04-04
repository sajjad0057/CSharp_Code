
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

