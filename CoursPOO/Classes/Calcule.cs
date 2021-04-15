using System;
using System.Collections.Generic;
using System.Text;

namespace CoursPOO.Classes
{
    class Calcule
    {

        //public static void EditInt(ref int a)
        //{
        //    a += 10;
        //    Console.WriteLine(a);
        //}

        public static void EditInt(out int a)
        {
            a = 10;
            Console.WriteLine(a);
        }

        //public static void Addition(int a, int b)
        //{
        //    Console.WriteLine(a + b);
        //}

        public static void Addition(string message, params int[][] args)
        {
            int total = 0;
            foreach(int[] a in args)
            {
                foreach(int i in a)
                {
                    total += i;

                }
            }
            Console.WriteLine(message);
            Console.WriteLine(total);
        }
    }
}
