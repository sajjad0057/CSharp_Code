using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers_Features
{
    public class Keyboard
    {
        public List<Key> keys;

        public Key this[char keyChar]
        {
            get
            {
                foreach (var key in keys)
                {
                    if (key.KeyCharacter == keyChar)
                    {
                        return key;
                    }
                }
                return null;
            }

            set
            {
               for (var i = 0; i < keys.Count; i++)
               {
                    if (keys[i].KeyCharacter == keyChar)
                    {
                        keys[i] = value;
                    }
               }


            }
        }

        //// overload indexer typed 
        public Key this[int keyCode]
        {
            get
            {
                foreach (var key in keys)
                {
                    if (key.AsciiValue == keyCode)
                    {
                        return key;
                    }
                }
                return null;
            }

            set
            {
                for (var i = 0; i < keys.Count; i++)
                {
                    if (keys[i].AsciiValue == keyCode)
                    {
                        keys[i] = value;
                    }
                }


            }
        }

    }
}


