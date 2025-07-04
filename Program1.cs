using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayushi_BD
{
    internal class Program1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number 1 : ");
            int n1 = Convert.ToInt32(Console.ReadLine());   

            Console.WriteLine("Enter the number 2 : ");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Sum of two numbers is : " + (n1 + n2));
        }
    }
}
