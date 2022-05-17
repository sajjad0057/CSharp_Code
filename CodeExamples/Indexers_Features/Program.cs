
using Indexers_Features;

Keyboard keyboard = new Keyboard();

keyboard.keys[0] = new Key();

Key key = keyboard.keys[0];

Key key1 = keyboard['c'];

keyboard['c'] = new Key();

Key key3 = keyboard[96];

keyboard[96] = new Key();


