using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxNumber
{
    public class GenericMax
    {

        public string FindMax(string first, string second, string third)
        {
            int length1 = first.Length;
            int length2 = second.Length;
            int length3 = third.Length;

            if (length1.CompareTo(length2) > 0 && length1.CompareTo(length3) > 0)
            {
                Console.WriteLine("First Number is Greater");
                return first;
            }
            if (length2.CompareTo(length1) >= 0 && length2.CompareTo(length3) > 0)
            {
                Console.WriteLine("Second Number is Greater");
                return second;
            }
            else
            {
                Console.Write("Greatest Number is third");
                return third;
            }
        }
    }
}
