using FindMaxNumber;
using NUnit.Framework;

namespace TestProgram
{
    public class Test2
    {
        [Test]
        public void Second_Value_Greater()
        {
            GenericMax<float> number = new GenericMax<float>();
            float[] arr = { 10.01f, 14.01f, 18.25f, 20.02f, 29.01f };
            float val = number.FindMax(arr);
            Assert.AreEqual(val, 29.01f);
        }
    }
}