using InterfacesLibrary;
using Microsoft.Practices.Unity.Configuration;
using System.Configuration;
using Unity;

namespace Application
{
    /*
     * Basic Calculator Program
     * 1. Change array of commands to enums. 
     *      - replace index based selection to enhance selection   
     *      - interchange of elements affects the existing index selection
     *      - create and enumeration of command types
     *      - create CommandInputParser class
     * 2. Refactor Calculation Operations
     *      - eliminate repitive calculation codes  
     *      - create a Calculator class
     * 3. Refactor Input Operations
     *      - organize Input related operations
     *      - create Input Service class
     * 4. Improvement
     *      - replace index based selection to enhance selection 
     *      - create Argument model class
     *      - refactor Output Operation
     *      - create Output Service class
     * 5. More Improvement
     *      - create REPL loop class
     *      - assigment improvements
     */

    class Program
    {
        static void Main(string[] args)
        { 
            UnityContainer container = new UnityContainer();

            UnityConfigurationSection configSection = ConfigurationManager.GetSection("unity") as UnityConfigurationSection;
            configSection.Containers.Default.Configure(container);

            ICalculatorReplLoop loop = container.Resolve<ICalculatorReplLoop>();
            loop.Run();
        }
    }
}