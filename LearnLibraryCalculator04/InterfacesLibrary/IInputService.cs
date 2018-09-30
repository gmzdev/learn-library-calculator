using CommonTypesLibrary;

namespace InputOutputLibrary
{
    public interface IInputService
    {
        Arguments ReadArguments();
        string ReadCommand();
    }
}