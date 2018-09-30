using CommonTypesLibrary;
using InputOutputLibrary;
using ParsingLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLibrary
{
    public class CalculatorReplLoop
    {
        public IInputParserService CommandInputParser { get; set; }
        public ICalculator Calculator { get; set; }
        public IInputService InputService { get; set; }
        public IOutputService OutputService { get; set; }

        public CalculatorReplLoop()
        {
            CommandInputParser = new CommandInputParserService();
            Calculator = new Calculator();
            InputService = new InputService();
            OutputService = new ConsoleOutputService();
        }

        public void Run()
        {
           
            while (true)
            {
                string command = InputService.ReadCommand();

                try
                {
                    CommandTypes commandType = CommandInputParser.ParseCommand(command);

                    Arguments arguments = InputService.ReadArguments();

                    OutputService.WriteResult(Calculator.Calculate(commandType, arguments).ToString());
                }
                catch (Exception)
                {
                    Console.WriteLine("Mistake!");
                }
            }
        }
    }
}
