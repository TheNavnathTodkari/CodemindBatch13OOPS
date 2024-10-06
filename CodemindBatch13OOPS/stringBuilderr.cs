using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodemindBatch13OOPS
{
    class stringBuilderr
    {
        public static void Main()
        {
            string firstname = "Navnath";
            string Lastname = "Todkari";
            string str= firstname + Lastname;
            Console.WriteLine(str);
            Console.ReadLine();
            //string builder
            StringBuilder sb = new StringBuilder();
            sb.Append("Navnath");
            sb.Append("Todkari");
            string result= sb.ToString();
            Console.WriteLine(result.ToString());


        }
    }
}
