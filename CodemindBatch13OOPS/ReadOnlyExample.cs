using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodemindBatch13OOPS
{

    public class ReadonlyEx
    {
        public readonly int initialint;
        public static readonly double pi;

        public ReadonlyEx(int firstvalue)
        {
            initialint = firstvalue;
            initialint = 20;
        }
        static ReadonlyEx()
        {
            pi = 3.14265;
        }
        public void print()
        {
            Console.WriteLine($"The value of initial variable is {initialint}");
            Console.WriteLine($"The value pi is = {pi}");
        }
    }
        public class ReadOnlyExample
        {
            public static void Main()
            {
                ReadonlyEx obj = new ReadonlyEx(10);
                obj.print();

            }
        }
}

