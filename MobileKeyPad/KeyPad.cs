using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileKeyPad
{
    public class InputKeyPad
    {
       public List<Key> KeyPad { get; set; }
    }

    public class Key
    {
        public char Character { get; set; }
        public int CharacterNumber { get; set; }
        public int CharacterOrder { get; set; }

        public Key(char character, int charDigit, int charOrder)
        {
            this.Character = character;
            this.CharacterNumber = charDigit;
            this.CharacterOrder = charOrder;
        }
    }
}
