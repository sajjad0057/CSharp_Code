
using Indexers_Features;



Keyboard keyboard = new Keyboard();

keyboard.Keys.Add(new Key(97));
keyboard.Keys.Add(new Key(98));
keyboard.Keys.Add(new Key('C'));
keyboard.Keys.Add(new Key('D'));


Console.WriteLine(keyboard[97].AsciiValue);
Console.WriteLine(keyboard['C'].KeyCharacter);


Assembly assembly = new Assembly();

assembly.People.Add(new Person { Name = "sajjad hossain", age = 24 });
assembly.People.Add(new Person { Name = "Zahan", age = 23 });

Console.WriteLine(assembly["sajjad hossain"].Name);
Console.WriteLine(assembly["Zahan"].Name);
