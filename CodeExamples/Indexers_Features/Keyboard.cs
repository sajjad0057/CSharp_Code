using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers_Features
{
    public class Keyboard
    {
        public List<Key> Keys;

        public Keyboard()
        {
            Keys = new List<Key>();
        }

        public Key this[char keyChar]
        {
            get
            {
                foreach (var key in Keys)
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
               for (var i = 0; i < Keys.Count; i++)
               {
                    if (Keys[i].KeyCharacter == keyChar)
                    {
                        Keys[i] = value;
                    }
               }


            }
        }

        //// overload indexer typed 
        public Key this[int keyCode]
        {
            get
            {
                foreach (var key in Keys)
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
                for (var i = 0; i < Keys.Count; i++)
                {
                    if (Keys[i].AsciiValue == keyCode)
                    {
                        Keys[i] = value;
                    }
                }


            }
        }

    }
}


