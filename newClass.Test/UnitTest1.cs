using NUnit.Framework;

namespace Tests
{
    public class Testing
    {
        [Test]
        [TestCase("x.")]
        [TestCase("y.")]
        // [TestCase("this complicates things greatly")]
        public void Test1(string message)
        {
            Assert.Pass();
        }
        [TestCase(1.1f)]
        public void Test2(float number)
        {
            Assert.Pass();
        }
    }
}