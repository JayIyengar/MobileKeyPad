using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MobileKeyPad
{
    public class JsonKeyPadIntialiser : IKeyPadInitialiser
    {
        public InputKeyPad Initialise()
        {
          string keyPadData =  ReadJsonFile();

          return JsonConvert.DeserializeObject(keyPadData,typeof(InputKeyPad)) as InputKeyPad;

        }

        private string ReadJsonFile()
        {
            try
            {
                return File.ReadAllText("./KeyPad.json");
            }
            catch(Exception ex)
            {
                return "";
            }
        }
    }
}
