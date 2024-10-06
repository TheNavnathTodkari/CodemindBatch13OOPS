using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodemindBatch13OOPS
{
    internal class controlStatementss
    {
        public static void Main()
        {
            int num = 0;
            if (num > 0)
            {
                Console.WriteLine("Number is Positive");
            }
            if (num < 0)
            {

                Console.WriteLine("Number is Negative");
            }
            else
            {
                Console.WriteLine("Number is zero");
            }
            //If else if statement
            if (num > 0)
            {
                Console.WriteLine("Number is positive");

            }
            else if (num < 0)
            {
                Console.WriteLine("Number is negative");
            }
            else
            {
                Console.WriteLine("Number is zero");
            }
            int Day = 4;
            switch (Day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wed");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;

            }
            //looping statements
            //for loop
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Iteration" + i);
            }
            //while loop;enter control statement;
            int n = 0;
            while (n > 5)
            {
                Console.WriteLine("Iteration in while loop:" + n);
                n++;
            }
            //do while loop ; exit control loop
            int x = 0;
            do
            {
                Console.WriteLine("Iteration in do while loop:" + x);
                x++;
            } while (x > 5);
            //for each
            String[] fruits = { "Mango", "banana", "kivi", "Apple", "Orange" };
            foreach (String fruit in fruits)
            {
                Console.WriteLine("fruit name:" + fruit);

            }
            //contine statement;
            for(int j=0; j<7; j++)
            {
                if (j == 3)
                {
                    continue;
                }
                Console.WriteLine("Iteration:"+j);
            }
            //go to statement
            int count = 0;
            startloop:
            if (count < 5)
            {
                Console.WriteLine("Iteration number in go to "+ count);
                count++;
                goto startloop;
            }
            //break statement
            int num1 = 2;
            switch (num1)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                    case 2:
                    Console.WriteLine("Two");
                    goto case 3;
                    case 3:
                    Console.WriteLine("Three");
                        break;
                    default:
                    Console.WriteLine("Invalid input");
                    break ;

            }
        }
        //if else if statement
    }

}
