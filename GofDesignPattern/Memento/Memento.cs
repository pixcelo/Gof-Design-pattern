namespace GofDesignPattern.Memento
{
    /// <summary>
    /// Mementoクラス
    /// </summary>
    /// <remarks>
    /// 別ライブラリから内部変更できないようにInternal指定
    /// ※カプセル化の破壊を防ぐため
    /// </remarks>
    public class Memento
    {
        private int money;
        private List<string> fruits;

        public int GetMoney()
        {
            return this.money;
        }

        internal Memento(int money)
        {
            this.money = money;
            this.fruits = new List<string>();
        }

        internal void AddFruit(string fruit)
        {
            this.fruits.Add(fruit);
        }

        internal List<string> GetFruits()
        {
            return this.fruits;
        }
    }
}
