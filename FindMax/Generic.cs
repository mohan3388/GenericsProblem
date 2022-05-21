using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxNumber
{
  
        public class GenericMax<T> where T : IComparable<T>
        {
        public T first, second, third;
        public GenericMax(T first, T second, T third)
        {
            this.first = first;
            this.second = second;
            this.third = third;
        }
        public T FindMax()
        {


            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                Console.WriteLine("First Number is Greater");
                return first;
            }
            if (second.CompareTo(first) >= 0 && second.CompareTo(third) > 0)
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
