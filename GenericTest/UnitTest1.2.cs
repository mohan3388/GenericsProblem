using FindMaxNumber;
using NUnit.Framework;

namespace TestProgram
{
    public class Test2
    {
        [Test]
        public void Second_Value_Greater()
        {
            GenericMax<float> number = new GenericMax<float>(8.5f,10.2f,15.04f);
            float val = number.FindMax();
            Assert.AreEqual(val, 15.04f);
        }
    }
}