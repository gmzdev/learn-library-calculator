using CommonTypesLibrary;

namespace ParsingLibrary
{
    public interface IInputParserService
    {
        CommandTypes ParseCommand(string command);
    }
}