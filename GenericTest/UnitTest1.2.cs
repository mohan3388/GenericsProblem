using FindMaxNumber;
using NUnit.Framework;

namespace TestProgram
{
    public class Test2
    {
        [Test]
        public void Second_Value_Greater()
        {
            GenericMax<float> number = new GenericMax<float>(10.01f, 14.01f, 18.25f);
         
            float val = number.FindMax();
            Assert.AreEqual(val, 18.25f);
        }
    }
}