namespace GofDesignPattern.Interpreter
{
    /// <summary>
    ///  <program> ::= program <command list>
    /// </summary>
    public class ProgramNode : Node
    {
        private Node commandListNode;

        public override void Parse(Context context)
        {
            context.SkipToken("program");
            this.commandListNode = new CommandListNode();
            this.commandListNode.Parse(context);
        }

        public override string ToString()
        {
            return $"[program {this.commandListNode}]";
        }
    }
}
