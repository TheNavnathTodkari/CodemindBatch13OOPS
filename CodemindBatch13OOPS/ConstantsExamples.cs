using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodemindBatch13OOPS
{

    public class constats
    {
        //normal variable 
        public int num = 10;
        public const double pi = 3.14928;
        public string AppName = "MY application";

        public void DisplayConst()
        {
            Console.WriteLine($"The value of pi is{pi}");
            Console.WriteLine($"The application name is {AppName}");

        }


    }
    internal class ConstantsExamples
    {
        public static void Main()
        {
            constats obj = new constats();
            obj.DisplayConst();
        }
    }
}
