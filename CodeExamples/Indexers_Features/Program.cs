
using Indexers_Features;

Keyboard keyboard = new Keyboard();

//keyboard.keys[0] = new Key();

//Key key = keyboard.keys[0];

Key key1 = keyboard['c'];

keyboard['c'] = new Key('c');

Key key3 = keyboard[96];

keyboard[96] = new Key(96);

//keyboard.keys.Add(key1);
//keyboard.keys.Add(key3);

Console.WriteLine($"{keyboard.keys['c']}");