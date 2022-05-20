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
            float val = number.FindMax(20.59f, 10.31f, 40.3f);
            Assert.AreEqual(val, 40.3f);
        }
    }
}