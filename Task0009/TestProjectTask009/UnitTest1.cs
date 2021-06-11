using NUnit.Framework;
using Task009;

namespace TestProjectTask009
{
    public class Tests
    {

        [Test]
        public void Test121()
        {
            Assert.AreEqual(Task009.Program.IsPalindrome(121), true);
        }

        [Test]
        public void TestMinus121()
        {
            Assert.AreEqual(Task009.Program.IsPalindrome(-121), false);
        }

        [Test]
        public void Test10()
        {
            Assert.AreEqual(Task009.Program.IsPalindrome(10), false);
        }

        [Test]
        public void TestMinus101()
        {
            Assert.AreEqual(Task009.Program.IsPalindrome(-101), false);
        }
    }
}