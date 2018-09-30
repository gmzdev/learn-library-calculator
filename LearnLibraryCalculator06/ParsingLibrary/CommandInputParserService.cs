using CommonTypesLibrary;
using InterfacesLibrary;
using System;

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
