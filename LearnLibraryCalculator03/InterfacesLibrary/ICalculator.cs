using CommonTypesLibrary;

namespace CalculatorLibrary
{
    public interface ICalculator
    {
        int Add(Arguments arguments);
        int Calculate(CommandTypes commandType, Arguments arguments);
        int Div(Arguments arguments);
        int Mul(Arguments arguments);
        int Sub(Arguments arguments);
    }
}