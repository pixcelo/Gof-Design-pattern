namespace GofDesignPattern.Observer
{
    public class RandomNumberGenerator : NumberGenerator
    {
        private Random random = new Random();
        private int number;

        public override int GetNumber()
        {
            return this.number;
        }

        public override void Execute()
        {
            for (int i = 0; i < 20; i++)
            {
                this.number = random.Next(50);
                base.NotifyObservers();
            }
        }
    }
}
