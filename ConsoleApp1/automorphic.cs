using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class automorphic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int n = Convert.ToInt32(Console.ReadLine());
            int sqr = n * n;
            if ((sqr % 10) == (n % 10))
            {
                Console.WriteLine("automorphic number");
            }
            else
                Console.WriteLine("not a automorphic number");
        }
    }
}
