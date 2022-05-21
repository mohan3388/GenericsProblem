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
            int[] arr = { 2, 5, 6, 8, 12, 20 };
            int val = number.FindMax(arr);
            Assert.AreEqual(val, 20);
        }
    }

   
}