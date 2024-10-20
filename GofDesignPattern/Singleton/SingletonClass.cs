namespace GofDesignPattern.Singleton
{
    public class SingletonClass
    {
        private readonly static SingletonClass singleton = new SingletonClass();

        private SingletonClass()
        {
            // new でインスタンスを生成できないようにするために private でコンストラクタを定義
        }

        public static SingletonClass GetInstance()
        {
            return singleton;
        }
    }
}
