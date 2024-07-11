using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Value type stores the value itself, whereas the reference type stores the address of the value where it is stored.

            // object(obj1) is a reference type and is stored in the heap.
            Object obj1 = new Object();

            // (myNumber) is a value type
            int myNumber = 15;

            // Here, the value of myNumber(which is 15) is automatically boxed into the object
            obj1 = myNumber;


            // Here, the boxed int value stored in obj1 is unboxed back to its original int type (x).
            int x = (int)obj1;

            Console.WriteLine("Value of object is: " + obj1);
            Console.WriteLine("Value of x is: " + x);
        }
    }
}
