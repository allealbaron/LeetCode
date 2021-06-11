using NUnit.Framework;

namespace TestProjectTask0012
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
            string romanNumber = "III";
            int integerNumber = 3;
            Assert.AreEqual(Task0012.Program.IntToRoman(integerNumber), romanNumber);
        }

        [Test]
        public void Test2()
        {
            string romanNumber = "IV";
            int integerNumber = 4;
            Assert.AreEqual(Task0012.Program.IntToRoman(integerNumber), romanNumber);
        }

        [Test]
        public void Test3()
        {
            string romanNumber = "IX";
            int integerNumber = 9;
            Assert.AreEqual(Task0012.Program.IntToRoman(integerNumber), romanNumber);
        }

        [Test]
        public void Test4()
        {
            string romanNumber = "LVIII";
            int integerNumber = 58;
            Assert.AreEqual(Task0012.Program.IntToRoman(integerNumber), romanNumber);
        }

        [Test]
        public void Test5()
        {
            string romanNumber = "MCMXCIV";
            int integerNumber = 1994;
            Assert.AreEqual(Task0012.Program.IntToRoman(integerNumber), romanNumber);
        }

    }
}