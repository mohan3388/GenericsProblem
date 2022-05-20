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
            float val = number.FindMax(40.3f, 20.59f, 10.31f);
            Assert.AreEqual(val, 40.3f);
        }
    }
}