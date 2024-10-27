namespace GofDesignPattern.Memento
{
    public class Gamer
    {
        private int money;
        private List<string> fruits = new List<string>();
        private Random random = new Random();

        private static string[] fruitsName = 
        {
            "Apple", "Grape", "Banana", "Orange"
        };

        public Gamer(int money)
        {
            this.money = money;
        }

        public int GetMoney()
        {
            return this.money;
        }

        public void Bet()
        {
            int dice = this.random.Next(6) + 1;
            if (dice == 1)
            {
                this.money += 100;
                Console.WriteLine("Money increased.");
            }
            else if (dice == 2)
            {
                this.money /= 2;
                Console.WriteLine("Money halved.");
            }
            else if (dice == 6)
            {
                string f = this.GetFruit();
                Console.WriteLine($"Received a fruit ({f}).");
                this.fruits.Add(f);
            }
            else
            {
                Console.WriteLine("Nothing happened.");
            }
        }

        /// <summary>
        /// スナップショットを取る
        /// </summary>
        /// <returns></returns>
        public Memento CreateMemento()
        {
            Memento m = new Memento(this.money);
            foreach (var f in this.fruits)
            {
                if (f.StartsWith("Delicious"))
                {
                    // フルーツはおいしいものだけ保存
                    m.AddFruit(f);
                }
            }
            return m;
        }

        /// <summary>
        /// Undoを行う
        /// </summary>
        /// <param name="memento"></param>
        public void RestoreMemento(Memento memento)
        {
            this.money = memento.GetMoney();
            this.fruits = memento.GetFruits();
        }

        public override string ToString()
        {
            return $"[money = {this.money}, fruits = {string.Join(", ", this.fruits)}]";
        }

        private string GetFruit()
        {
            string prefix = "";
            if (this.random.Next(2) == 1)
            {
                prefix = "Delicious";
            }
            return prefix + fruitsName[this.random.Next(fruitsName.Length)];
        }
    }
}
