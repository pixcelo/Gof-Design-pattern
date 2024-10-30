namespace GofDesignPattern.Interpreter
{
    /// <summary>
    /// <command list> ::= <command>* end
    /// </summary>
    public class CommandListNode : Node
    {
        private List<Node> list = new List<Node>();

        public override void Parse(Context context)
        {
            while (true)
            {
                if (context.CurrentToken() is null)
                {
                    throw new ParseException("Error: Missing 'end'");
                }
                else if (context.CurrentToken() == "end")
                {
                    context.SkipToken("end");
                    break;
                }
                else
                {
                    Node commandNode = new CommandNode();
                    commandNode.Parse(context);
                    list.Add(commandNode);
                }
            }
        }

        public override string ToString()
        {
            return $"{string.Join(", ", this.list)}";
        }
    }
}