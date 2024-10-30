namespace GofDesignPattern.Interpreter
{
    /// <summary>
    /// <command> ::= <repeat command> | <primitive command>
    /// </summary>
    public class CommandNode : Node
    {
        private Node node;

        public override void Parse(Context context)
        {
            if (context.CurrentToken() == "repeat")
            {
                node = new RepeatCommandNode();
                node.Parse(context);
            }
            else
            {
                node = new PrimitiveCommandNode();
                node.Parse(context);
            }
        }

        public override string ToString()
        {
            return node.ToString();
        }
    }
}