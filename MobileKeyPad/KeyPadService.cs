using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileKeyPad
{
    public class KeyPadService : IKeyPadService
    {
        const int PRESS_KEY_DURATION = 100;
        const int CONSECUTIVE_PRESS_KEY_DURATION = 500;

        private InputKeyPad _inputKeyPad;

        public KeyPadService(InputKeyPad inputKeyPad)
        {
            _inputKeyPad = inputKeyPad;
        }

        public int CalculateTime(string userInput, out string keySequence)
        {
            int totalMinimunTime = 0;
            keySequence = string.Empty;
            char lastCharcter = '\0';

            int sequenceNumber = 1;

            foreach (char currentCharcter in userInput.ToCharArray())
            { 
                var key = _inputKeyPad.KeyPad.Where(k => k.Character == char.ToLower(currentCharcter)).FirstOrDefault();

                try
                {

                    if (lastCharcter == currentCharcter)
                    {
                        totalMinimunTime += CONSECUTIVE_PRESS_KEY_DURATION;
                    }

                    keySequence = keySequence + (sequenceNumber++).ToString() + ".Press Key - " + key.CharacterNumber.ToString() + " - "
                                + key.CharacterOrder.ToString() + " Time(s)." + "\n";

                    totalMinimunTime += key.CharacterOrder * PRESS_KEY_DURATION;

                    lastCharcter = currentCharcter;
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }

            return totalMinimunTime;
        }

    }
}
