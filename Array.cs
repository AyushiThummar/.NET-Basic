using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayushi_BD
{
    internal class Array
    {
        public static void Main(string[] args)
        {
            int[] a = new int[5] { 1, 2, 3, 4, 5 };
            // For -> Index wise iteration.
            for(int i=0; i<a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            // Foreach -> Element wise iteration.
            foreach(int i in a)
            {
                Console.WriteLine(i);
            }
        }
    }
}
