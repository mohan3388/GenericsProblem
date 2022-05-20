using FindMaxNumber;
using NUnit.Framework;

namespace TestProgram
{
    public class Tests
    {
        [Test]
        public void First_Value_Greater()
        {
            GenericMax<int> number = new GenericMax<int>(8,10,12);
            int val = number.FindMax();
            Assert.AreEqual(val, 12);
        }
    }
}