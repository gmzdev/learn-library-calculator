using CommonTypesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingLibrary
{
    public class CommandInputParserService : IInputParserService
    {
        public CommandTypes ParseCommand(string command)
        {
            return (CommandTypes)Enum.Parse(typeof(CommandTypes), command);
        }
    }
}
