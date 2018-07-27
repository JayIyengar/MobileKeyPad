using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileKeyPad
{
    public interface IKeyPadInitialiser
    {
        InputKeyPad Initialise();
    }
}
