using FindMaxNumber;
using NUnit.Framework;

namespace TestProgram
{
    public class Test3
    {
        [Test]
        public void Third_Value_Greater()
        {
            GenericMax<string> number = new GenericMax<string>();
            string[] arr = { "Graps", "orange", "Apple", "Peach", "Banana" };

            string val = number.FindMax(arr);
            Assert.AreEqual(val, "Banana");
        }
    }
}