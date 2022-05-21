using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class GenericProblem
    {
        public void MaxInt<T>(T[] arr)
        {
            foreach (T item in arr)
            {
                Console.WriteLine(item + " ");
            }
            Array.Sort(arr);
            Console.WriteLine("max element is " + arr[arr.Length - 1]);
        }
    }
}
