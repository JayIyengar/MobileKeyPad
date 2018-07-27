using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MobileKeyPad
{
    class Program
    {
        private InputKeyPad _inputKeyPad;
        private IKeyPadService _keyPadService;
        private IKeyPadInitialiser _keyPadIntialiser;

        public Program()
        {
            //var keyPad = new JsonKeyPadIntialiser().Initialise();

            _keyPadIntialiser = new KeyPadIntialiser();

            _inputKeyPad = _keyPadIntialiser.Initialise();            

            _keyPadService = new KeyPadService(_inputKeyPad);

        }

        static void Main(string[] args)
        {
            new Program().Run();
        }

        private string Run()
        {
            string userInput = string.Empty;

            Console.WriteLine("Please enter the word or sentence to calcuate input time:");

            userInput = Console.ReadLine();

            if(userInput == string.Empty)
            {
                return Run();
            }

            string keySequence = string.Empty;

            try
            {
                int totalMinimumTime = _keyPadService.CalculateTime(userInput, out keySequence);

                Console.WriteLine($"Total time: {totalMinimumTime}\nKey Sequence: \n{keySequence}");
               
            }
            catch
            {
                Console.WriteLine("KeyPad not setup correctly, please check");
            }

            return Run();

        }

       
    }
}
