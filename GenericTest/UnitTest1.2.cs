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
            float[] arr = { 10.01f, 14.01f, 18.25f, 22.02f, 30.74f };
            float val = number.MaximumElement(arr);
            Assert.AreEqual(val, 30.74f);
        }
    }
}