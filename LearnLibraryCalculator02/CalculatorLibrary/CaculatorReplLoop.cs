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
        IInputParserService commandInputParser;
        ICalculator calculator;
        IInputService inputService;
        IOutputService outputService;

        public CalculatorReplLoop()
        {
            commandInputParser = new CommandInputParserService();
            calculator = new Calculator();
            inputService = new InputService();
            outputService = new OutputService();
        }

        public void Run()
        {
           
            while (true)
            {
                string command = inputService.ReadCommand();

                try
                {
                    CommandTypes commandType = commandInputParser.ParseCommand(command);

                    Arguments arguments = inputService.ReadArguments();

                    outputService.WriteResult(calculator.Calculate(commandType, arguments).ToString());
                }
                catch (Exception)
                {
                    Console.WriteLine("Mistake!");
                }
            }
        }
    }
}
