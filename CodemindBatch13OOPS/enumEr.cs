using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodemindBatch13OOPS
{
    public enum Days
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
    }
    internal class enumEr
    {
        public static void Main()
        {
            Days today = Days.Sunday;

            switch (today)
            {
                case Days.Sunday:
                    Console.WriteLine("Today is Sunday");
                    break;
                case Days.Monday:
                    Console.WriteLine("Today is Monday");
                    break;
                case Days.Tuesday:
                    Console.WriteLine("Today is Tuesday");
                    break;
                case Days.Wednesday:
                    Console.WriteLine("Today is Wednesday");
                    break;
                case Days.Thursday:
                    Console.WriteLine("Today is Thursday");
                    break;
                case Days.Friday:
                    Console.WriteLine("Today is Friday");
                    break;
                case Days.Saturday:
                    Console.WriteLine("Today is Saturday");
                    break;
            }
            //show iis it weekoff or weekday
            if (today == Days.Sunday || today == Days.Saturday)
            {
                Console.WriteLine("Today is weekoff");

            }
            else
            {
                Console.WriteLine("Today is weekDay");
            }
        }

    }
}


