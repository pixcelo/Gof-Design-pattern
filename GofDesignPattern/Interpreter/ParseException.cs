
namespace GofDesignPattern.Interpreter
{
    [Serializable]
    internal class ParseException : Exception
    {
        public ParseException(string? message) : base(message)
        {
        }
    }
}