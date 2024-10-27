namespace GofDesignPattern.Observer
{
    /// <summary>
    /// 観察した数を「*****」のような簡易グラフで表示するクラス
    /// </summary>
    public class GraphObserver : IObserver
    {
        public void Update(NumberGenerator generator)
        {
            int count = generator.GetNumber();
            for (int i = 0; i < count; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");

            try
            {
                Thread.Sleep(100);
            }
            catch (ThreadInterruptedException e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
