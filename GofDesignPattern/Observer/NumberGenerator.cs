namespace GofDesignPattern.Observer
{
    public abstract class NumberGenerator
    {
        private readonly List<IObserver> observers = new List<IObserver>();

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void DeleteObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        /// <summary>
        /// observerへ通知する
        /// </summary>
        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(this);
            }
        }

        /// <summary>
        /// 数を取得する
        /// </summary>
        /// <returns></returns>
        public abstract int GetNumber();

        /// <summary>
        /// 数を生成する
        /// </summary>
        public abstract void Execute();
    }
}
