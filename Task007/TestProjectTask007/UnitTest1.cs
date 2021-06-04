using NUnit.Framework;
using Task007;

namespace TestProjectTask007
{
    public class Tests
    {

        [Test]
        public void Test123()
        {
            Assert.AreEqual(Task007.Program.Reverse(123), 321);
        }

        [Test]
        public void TestMinus123()
        {
            Assert.AreEqual(Task007.Program.Reverse(-123), -321);
        }

        [Test]
        public void Test120()
        {
            Assert.AreEqual(Task007.Program.Reverse(120), 21);
        }

        [Test]
        public void Test0()
        {
            Assert.AreEqual(Task007.Program.Reverse(0), 0);
        }

        [Test]
        public void TestNegative()
        {
            Assert.AreEqual(Task007.Program.Reverse(-2147483648), 0);
        }
        
    }
}