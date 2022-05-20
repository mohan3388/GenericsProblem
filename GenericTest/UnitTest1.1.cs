using FindMaxNumber;
using NUnit.Framework;

namespace TestProgram
{
    public class Tests
    {
        [Test]
        public void First_Value_Greater()
        {
            GenericMax<int> number = new GenericMax<int>();
            int[] arr = { 10, 14, 18, 22, 30 };
            int val = number.MaximumElement(arr);
            Assert.AreEqual(val, 30);
        }
    }

   
}