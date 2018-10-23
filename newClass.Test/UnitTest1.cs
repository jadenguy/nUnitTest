using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [TestCase("x.")]
        public void Test2(string message)
        {
            Assert.Pass();
        }
    }
}