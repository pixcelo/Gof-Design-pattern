using GofDesignPattern.ChainOfResponsibility;

namespace GofDesignPattern.Tests.ChainOfResponsibility
{
    public class ChainOfResponsibilityTests
    {
        [Fact]
        public void OkResolve()
        {
            // Arrange
            Support alice = new NoSupport("Alice");
            Support bob = new LimitSupport("Bob", 100);
            Support charlie = new SpecialSupport("Charlie", 429);
            Support diana = new LimitSupport("Diana", 200);
            Support elmo = new SpecialSupport("Elmo", 300);
            Support fred = new LimitSupport("Fred", 400);

            // 連鎖の形成
            alice.SetNext(bob)
                 .SetNext(charlie)
                 .SetNext(diana)
                 .SetNext(elmo)
                 .SetNext(fred);

            // Act
            for (int i = 0; i < 500; i++)
            {
                // 発生したトラブルの解決を試みる
                alice.SupportTrouble(new Trouble(i));
            }
        }
    }
}
