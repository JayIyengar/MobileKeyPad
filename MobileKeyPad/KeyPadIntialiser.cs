using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileKeyPad
{
    public class KeyPadIntialiser : IKeyPadInitialiser
    {       

        public InputKeyPad Initialise()
        {
            InputKeyPad inputKeyPad = new InputKeyPad();
            inputKeyPad.KeyPad = new List<Key>();

            inputKeyPad.KeyPad.Add(new Key('a', 2, 1));
            inputKeyPad.KeyPad.Add(new Key('b', 2, 2));
            inputKeyPad.KeyPad.Add(new Key('c', 2, 3));
            inputKeyPad.KeyPad.Add(new Key('d', 3, 1));
            inputKeyPad.KeyPad.Add(new Key('e', 3, 2));
            inputKeyPad.KeyPad.Add(new Key('f', 3, 3));
            inputKeyPad.KeyPad.Add(new Key('g', 4, 1));
            inputKeyPad.KeyPad.Add(new Key('h', 4, 2));
            inputKeyPad.KeyPad.Add(new Key('i', 4, 3));
            inputKeyPad.KeyPad.Add(new Key('j', 5, 1));
            inputKeyPad.KeyPad.Add(new Key('k', 5, 2));
            inputKeyPad.KeyPad.Add(new Key('l', 5, 3));
            inputKeyPad.KeyPad.Add(new Key('m', 6, 1));
            inputKeyPad.KeyPad.Add(new Key('n', 6, 2));
            inputKeyPad.KeyPad.Add(new Key('o', 6, 3));
            inputKeyPad.KeyPad.Add(new Key('p', 7, 1));
            inputKeyPad.KeyPad.Add(new Key('q', 7, 2));
            inputKeyPad.KeyPad.Add(new Key('r', 7, 3));
            inputKeyPad.KeyPad.Add(new Key('s', 7, 4));
            inputKeyPad.KeyPad.Add(new Key('t', 8, 1));
            inputKeyPad.KeyPad.Add(new Key('u', 8, 2));
            inputKeyPad.KeyPad.Add(new Key('v', 8, 3));
            inputKeyPad.KeyPad.Add(new Key('w', 9, 1));
            inputKeyPad.KeyPad.Add(new Key('x', 9, 2));
            inputKeyPad.KeyPad.Add(new Key('y', 9, 3));
            inputKeyPad.KeyPad.Add(new Key('z', 9, 4));
            inputKeyPad.KeyPad.Add(new Key('*', 10, 1));
            inputKeyPad.KeyPad.Add(new Key(' ', 0, 1));
            inputKeyPad.KeyPad.Add(new Key('#', 11, 1));

            return inputKeyPad;
        }
    }
}
