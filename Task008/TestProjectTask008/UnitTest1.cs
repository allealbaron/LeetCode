using NUnit.Framework;
using Task008;

namespace TestProjectTask008
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(Program.MyAtoi("42"), 42);
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(Program.MyAtoi("      -42"), -42);
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual(Program.MyAtoi("4193 with words"), 4193);
        }

        [Test]
        public void Test4()
        {
            Assert.AreEqual(Program.MyAtoi("words and 987"), 0);
        }

        [Test]
        public void Test5()
        {
            Assert.AreEqual(Program.MyAtoi("-91283472332"), -2147483648);
        }

    }
}