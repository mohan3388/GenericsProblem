using FindMaxNumber;
using NUnit.Framework;

namespace TestProgram
{
    public class Tests
    {
        [Test]
        public void First_Value_Greater()
        {
            GenericMax number = new GenericMax();
            int val = number.FindMax(40, 20, 10);
            Assert.AreEqual(val, 40);
        }
    }
}