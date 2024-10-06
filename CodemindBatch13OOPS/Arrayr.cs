using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodemindBatch13OOPS
{
    internal class Arrayr
    {
        public static void Main()
        {
            //declearation of array
            string[] Mobile = new string[4];

            //Assigning values to array
            Mobile[0] = "APPLE";
            Mobile[1] = "Onepluse";
            Mobile[2] = "Redmi";
            Mobile[3] = "Samsung";

            ////////accessing values of an array
            for (int i = 0; i < Mobile.Length; i++)
            {
                Console.WriteLine(Mobile[i]);

            }
            //////initialization of multidimentional array
            int[,] matrix = new int[,]
            {
                //assigning values of multi di array
                { 1,2,3},
                { 4,5,6},
                { 5,7,8}

            };
            //accessing values of multi di array
            Console.WriteLine("Elements of multi dimen array");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            //initialization jaggaed array
            int[][] jaggedAr = new int[][]
            {
                new int[] {1,5,3},
                new int[] {2,6,3,7},
                new int[] {4,2,3 }
            };
            //accessing values of jagged array
            for(int i=0; i<jaggedAr.Length; i++)
            {
                for(int j=0; j < jaggedAr[i].Length; j++)
                {
                    Console.Write(jaggedAr[i][j]+ "");
                }
                Console.WriteLine() ;
            }


        }
    }
}
