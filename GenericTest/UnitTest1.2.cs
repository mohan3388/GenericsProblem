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
            float val = number.FindMax(20.59f, 40.3f, 10.31f);
            Assert.AreEqual(val, 40.3f);
        }
    }
}