using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxNumber
{
  
        public class GenericMax<T> where T : IComparable<T>
        {
            public T MaximumElement(T[] arr)
            {

                Array.Sort(arr);

                T Element = arr[arr.Length - 1];
                return Element;
            }
        
    }
}
