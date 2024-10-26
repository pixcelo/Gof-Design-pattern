namespace GofDesignPattern.Visitor
{
    /// <summary>
    /// データ構造を巡回するVisitorの具象クラス
    /// </summary>
    /// <remarks>
    /// Acceptするクラスによって振る舞いが変わるようにオーバーロードで実装
    /// </remarks>
    public class ListVisitor : Visitor
    {
        /// <summary>
        /// 現在注目しているディレクトリ名
        /// </summary>
        private string currentDir = "";

        public override void Visit(File file)
        {
            Console.WriteLine($"{this.currentDir}/{file}");
        }

        public override void Visit(Directory directory)
        {
            Console.WriteLine($"{this.currentDir}/{directory}");
            string saveDir = this.currentDir;
            this.currentDir = $"{this.currentDir}/{directory.GetName()}";
            foreach (Entry entry in directory)
            {
                entry.Accept(this);
            }
            this.currentDir = saveDir;
        }
    }
}
