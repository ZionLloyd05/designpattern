namespace DesignPatterns.Tests
{
    public class CreationalPatternTest
    {
        [Fact]
        public void Signleton_Should_Return_Sam_Instance_when_Created()
        {
            var firstInstance = SingletonPattern.Singleton.Create();
            var secondInstance = SingletonPattern.Singleton.Create();

            Assert.Same(firstInstance, secondInstance);
        }
    }
}