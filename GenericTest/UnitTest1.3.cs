using FindMaxNumber;
using NUnit.Framework;

namespace TestProgram
{
    public class Test3
    {
        [Test]
        public void Third_Value_Greater()
        {
            GenericMax<string> number = new GenericMax<string>("Apple", "Peach", "Banana");
            string val = number.FindMax();
            Assert.AreEqual(val, "Banana");
        }
    }
}