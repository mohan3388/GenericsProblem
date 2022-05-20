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
            string[] arr = { "Banana", "Mango", "Apple", "Graps", "Pineapple" };
            string val = number.MaximumElement(arr);
            Assert.AreEqual(val, "Pineapple");
        }
    }
}