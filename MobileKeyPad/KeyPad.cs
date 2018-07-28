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
        public string CharacterKey { get; set; }
        public int CharacterOrder { get; set; }

        public Key(char character, string charKey, int charOrder)
        {
            this.Character = character;
            this.CharacterKey = charKey;
            this.CharacterOrder = charOrder;
        }
    }
}
