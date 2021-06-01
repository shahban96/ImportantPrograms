using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to find factorial");
            int n = Convert.ToInt32(Console.ReadLine());
            int fact = 1;

            if (n == 0)
                Console.WriteLine("factorial is {0} ", fact);
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    fact = fact * i;
                }
                Console.WriteLine("factorial is {0} ", fact);
            }

            Console.ReadKey();
        }
    }
}
