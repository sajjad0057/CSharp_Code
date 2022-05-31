
using Indexers_Features;

Keyboard keyboard = new Keyboard();

keyboard.Keys.Add(new Key('A'));
keyboard.Keys.Add(new Key('B'));
keyboard.Keys.Add(new Key('C'));
keyboard.Keys.Add(new Key('D'));
keyboard.Keys.Add(new Key('E'));

keyboard.Keys.Add(new Key(96));


Console.WriteLine($"{keyboard['C'].KeyCharacter}");
Console.WriteLine($"{keyboard['E'].KeyCharacter}");
Console.WriteLine($"{keyboard[96].AsciiValue}");