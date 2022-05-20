using FindMaxNumber;
using NUnit.Framework;

namespace TestProgram
{
    public class Test2
    {
        [Test]
        public void Second_Value_Greater()
        {
            GenericMax number = new GenericMax();
            int val = number.FindMax(20, 40, 10);
            Assert.AreEqual(val, 40);
        }
    }
}