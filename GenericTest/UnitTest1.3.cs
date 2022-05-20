using FindMaxNumber;
using NUnit.Framework;

namespace TestProgram
{
    public class Test3
    {
        [Test]
        public void Third_Value_Greater()
        {
            GenericMax number = new GenericMax();
            string val = number.FindMax("Apple", "Peach", "Banana");
            Assert.AreEqual(val, "Banana");
        }
    }
}