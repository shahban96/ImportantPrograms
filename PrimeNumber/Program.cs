using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number to check prime or not");
            int n = Convert.ToInt32(Console.ReadLine());

            int flag = 0;

            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    flag = 1;
                    break;
                }

            }
            if (n == 0 || n == 1)  
                Console.WriteLine("Nor prime nor composite");
            else if(flag == 1)
                Console.WriteLine("composite");
            else
                Console.WriteLine("prime");

            Console.ReadKey();
        }
    }
}
