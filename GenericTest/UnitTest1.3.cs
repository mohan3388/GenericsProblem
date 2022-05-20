using FindMaxNumber;
using NUnit.Framework;

namespace TestProgram
{
    public class Test3
    {
        [Test]
        public void Third_Value_Greater()
        {
            GenericMax number = new GenericMax();
            int val = number.FindMax(20, 10, 40);
            Assert.AreEqual(val, 40);
        }
    }
}