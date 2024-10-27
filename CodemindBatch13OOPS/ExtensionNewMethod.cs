using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodemindBatch13OOPS
{
    public static class ExtensionNewMethod
    {
        public static void Test3(this ExtensionMethosOld1 o)
        {
            Console.WriteLine("Method three");
        }
    }
}
