using System;
using System.Linq;

namespace Ayushi_BD
{
    internal class Array1
    {
        public static void Main(string[] args)
        {
            int[] a = { 1, 2, 8, 10, 12, 20, 21, 23, 25 };
            Console.WriteLine("Max number in array : " + a.Max());
            Console.WriteLine("Min number in array : " + a.Min());

            var reverse = a.Reverse();
            foreach (var i in reverse)
            {
                Console.Write(i + " ");
            }

            //Array.Sort(a);
            //Console.WriteLine("Sorted array : ");
            //foreach (int i in a)
            //{
            //    Console.Write(i + " ");
            //}
            Console.Read();
        }
    }
}
