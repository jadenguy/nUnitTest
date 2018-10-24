using NUnit.Framework;

namespace Tests
{
    public class Testing
    {
        [Test]
        [TestCase("x.")]
        [TestCase("y.")]
        public void Test1(string message)
        {
            Assert.Pass();
        }
    }
}