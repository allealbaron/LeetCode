using NUnit.Framework;
using Task258;

namespace TestProjectTask258
{
    public class Tests
    {

        [Test]
        public void Test1()
        {
            Assert.AreEqual(Task258.Program.AddDigits(38), 2);
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(Task258.Program.AddDigits(0), 0);
        }

    }
}