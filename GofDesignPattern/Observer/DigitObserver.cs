namespace GofDesignPattern.Observer
{
    /// <summary>
    /// 観察した数を「数字」で表示するクラス
    /// </summary>
    public class DigitObserver : IObserver
    {
        public void Update(NumberGenerator generator)
        {
            Console.WriteLine("DigitObserver:" + generator.GetNumber());

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
