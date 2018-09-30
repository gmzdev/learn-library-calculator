using CommonTypesLibrary;
using InterfacesLibrary;
using System;

namespace CalculatorLibrary
{
    public class CalculatorReplLoop : ICalculatorReplLoop
    {
        IInputParserService commandInputParser;
        ICalculator calculator;
        IInputService inputService;
        IOutputService outputService;

        public CalculatorReplLoop(IInputParserService commandInputParser,
            ICalculator calculator, IInputService inputService, IOutputService outputService)
        {
            this.commandInputParser = commandInputParser;
            this.calculator = calculator;
            this.inputService = inputService;
            this.outputService = outputService;
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
