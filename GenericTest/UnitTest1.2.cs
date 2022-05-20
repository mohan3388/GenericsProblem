using FindMaxNumber;
using NUnit.Framework;

namespace TestProgram
{
    public class Test2
    {
        [Test]
        public void Second_Value_Greater()
        {
            GenericMax number = new GenericMax();
            string val = number.FindMax("Apple", "Banana", "Peach");
            Assert.AreEqual(val, "Banana");
        }
    }
}