namespace GofDesignPattern.Builder
{
    public class Director
    {
        private readonly Builder builder;

        public Director(Builder builder)
        {
            this.builder = builder;
        }

        public void Construct()
        {
            this.builder.MakeTitle("Greeting");
            this.builder.MakeString("General greetings");
            this.builder.MakeItems(new string[] { "How are you?", "Hello.", "Hi." });
            this.builder.MakeString("Greetings according to the time of day");
            this.builder.MakeItems(new string[] { "Good morning.", "Good afternoon.", "Good evening." });
            this.builder.Close();
        }
    }
}
