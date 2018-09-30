using InterfacesLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace InputOutputLibrary
{
    public class ConsoleOutputService : IOutputService
    {
        public void WriteResult(string result) {
            Console.WriteLine("Result: " + result);
        }
    }
}
