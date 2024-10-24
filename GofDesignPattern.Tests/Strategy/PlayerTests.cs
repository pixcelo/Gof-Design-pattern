using GofDesignPattern.Strategy;

namespace GofDesignPattern.Tests.Strategy
{
    public class PlayerTests
    {
        [Fact]
        public void PlayerTest()
        {
            // Arrange
            Player player1 = new Player("Tom", new WinningStrategy(314));
            Player player2 = new Player("Ken", new ProbStrategy(15));

            // Act
            for (int i = 0; i < 1000; i++)
            {
                Hand nextHand1 = new Hand(player1.NextHands());
                Hand nextHand2 = new Hand(player2.NextHands());
                if (nextHand1.IsStrongerThan(nextHand2))
                {
                    Console.WriteLine($"Winner: {player1}");
                    player1.Win();
                    player2.Lose();
                }
                else if (nextHand2.IsStrongerThan(nextHand1))
                {
                    Console.WriteLine($"Winner: {player2}");
                    player1.Lose();
                    player2.Win();
                }
                else
                {
                    Console.WriteLine("Even...");
                    player1.Even();
                    player2.Even();
                }
            }

            Console.WriteLine("Total result:");
            Console.WriteLine(player1);
            Console.WriteLine(player2);
        }
    }
}
