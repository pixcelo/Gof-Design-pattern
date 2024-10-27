using GofDesignPattern.Memento;

namespace GofDesignPattern.Tests.Memento
{
    public class MementoTests
    {
        [Fact]
        public void MementoTest()
        {
            // Arrange
            Gamer gamer = new Gamer(100); // 最初の所持金は100
            var memento = gamer.CreateMemento(); // 最初の状態を保存しておく

            // Act
            for (var i = 0; i < 100; i++)
            {
                Console.WriteLine("=== " + i); // 回数表示
                Console.WriteLine("Current state:" + gamer); // 現在の主人公の状態を表示

                gamer.Bet(); // ゲームを進める

                Console.WriteLine("Current money; " + gamer.GetMoney() + "yen.");

                // Mementoの取り扱いの決定
                if (gamer.GetMoney() > memento.GetMoney())
                {
                    Console.WriteLine("Money has increased significantly, so let's save the current state.");
                    memento = gamer.CreateMemento();
                }
                else if (gamer.GetMoney() < memento.GetMoney() / 2)
                {
                    Console.WriteLine("Money has decreased significantly, so let's restore the previous state.");
                    gamer.RestoreMemento(memento);
                }

                // 時間待ち
                try
                {
                    Thread.Sleep(100);
                }
                catch (ThreadInterruptedException e)
                {
                }
                Console.WriteLine("");
            }
        }
    }
}
