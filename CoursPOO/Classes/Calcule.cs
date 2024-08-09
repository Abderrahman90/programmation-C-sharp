using System;
using System.Collections.Generic;
using System.Text;

namespace CoursPOO.Classes
{
    class Calcule
    {
        public delegate int DelegateCalcule(int a, int b);
        public delegate int DelegateMultiParams(params int[] args);
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

        public static void Addition(string message, params int[] args)
        {
            int total = 0;
            foreach(int a in args)
            {
                total += a;
            }
            Console.WriteLine(message);
            Console.WriteLine(total);
        }

        public static int Soustraction(int a, int b)
        {
            return a - b;
        }

        public static int Soustraction(params int[] args)
        {
            int result = args[0];
            for(int i = 1; i < args.Length; i++)
            {
                result -= args[i];
            }
            return result;
        }
        //public static void Calculer(int a, int b, DelegateCalcule methode)
        //{
        //    int resultat = methode(a, b);
        //    Console.WriteLine(resultat);
        //}
        public static void Calculer(int a, int b, Func<int, int, int> methode)
        {
            int resultat = methode(a, b);
            Console.WriteLine(resultat);
        }
        //public static void Calculer(DelegateMultiParams methode, params int[] args)
        //{
        //    int resultat = methode(args);
        //    Console.WriteLine(resultat);
        //}
        public static void Calculer(Action<object> methodeAffichage, Func<int[], int> methodeCalcule, params int[] args)
        {
            int resultat = methodeCalcule(args);
            methodeAffichage(resultat);
        }
    }
}
