using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Value type stores the value itself, whereas the reference type stores the address of the value where it is stored.

            // object(obj1) is a reference type and is stored in the heap.
            Object obj1 = new Object();

            // (myNumber) is a value type
            int myNumber = 20;

            // Here, the value of myNumber(which is 100) is automatically boxed into the object
            obj1 = myNumber;

            myNumber = 100;


            //  It also shows that changing the original value of the value type (myNumber) does not affect the boxed value (obj1), as they are stored in different parts of memory (stack & heap).
            Console.WriteLine("value type value of mynumber is: " + myNumber);
            Console.WriteLine("reference type value of obj1 is: " + obj1);
        }
    }
}
