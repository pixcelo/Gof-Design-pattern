namespace GofDesignPattern.Interpreter
{
    /// <summary>
    /// <repeat command> ::= repeat <number> <command list>
    /// </summary>
    public class RepeatCommandNode : Node
    {
        private int number;
        private Node commandListNode;

        public override void Parse(Context context)
        {
            context.SkipToken("repeat");
            this.number = context.CurrentNumber();
            context.NextToken();
            this.commandListNode = new CommandListNode();
            this.commandListNode.Parse(context);
        }

        public override string ToString()
        {
            return $"[repeat {this.number} {this.commandListNode}]";
        }
    }
}