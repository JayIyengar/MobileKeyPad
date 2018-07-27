using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileKeyPad
{
    public interface IKeyPadService
    {
        int CalculateTime(string userInput, out string keySequence);
    }
}
