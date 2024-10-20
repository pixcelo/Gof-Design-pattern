using GofDesignPattern.Singleton;

namespace GofDesignPattern.Tests.Singleton
{
    public class SingletonClassTests
    {
        /// <summary>
        /// 同じインスタンスが取得できることを確認
        /// </summary>
        [Fact]
        public void OkSingleton()
        {
            // Act
            var singleton1 = SingletonClass.GetInstance();
            var singleton2 = SingletonClass.GetInstance();

            // new できないことを確認
            //var single = new SingletonClass();

            // Assert
            Assert.Same(singleton1, singleton2);
        }
    }
}
