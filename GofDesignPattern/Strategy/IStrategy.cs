namespace GofDesignPattern.Strategy
{
    public interface IStrategy
    {
        Hands NextHand();

        void Study(bool win);
    }
}
