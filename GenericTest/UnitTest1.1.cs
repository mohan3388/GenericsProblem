using FindMaxNumber;
using NUnit.Framework;

namespace TestProgram
{
    public class Tests
    {
        [Test]
        public void First_Value_Greater()
        {
            GenericMax number = new GenericMax();
            string val = number.FindMax("Banana", "Apple", "Peach");
            Assert.AreEqual(val, "Banana");
        }
    }
}