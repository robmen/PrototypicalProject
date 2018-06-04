using Example.Api;
using Xunit;

namespace ExampleTests
{
    public class ExampleApiFixture
    {
        [Fact]
        public void TestGreeting()
        {
            var api = new ExampleApi();
            Assert.Equal("Hello, World.", api.Greeting());
        }
    }
}
