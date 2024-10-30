namespace GofDesignPattern.Interpreter
{
    /// <summary>
    /// <primitive command> ::= go | right | left
    /// </summary>
    public class PrimitiveCommandNode : Node
    {
        private string name;

        public override void Parse(Context context)
        {
            this.name = context.CurrentToken();
            context.SkipToken(this.name);
            if (this.name is null)
            {
                throw new ParseException("Error: Missing <primitive command>");
            }
            else if (this.name != "go" && this.name != "right" && this.name != "left")
            {
                throw new ParseException($"Error Unknown <primitive command>: '{this.name}'");
            }
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}