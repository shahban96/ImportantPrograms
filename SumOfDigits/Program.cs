using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to sum the digits");
            int n = Convert.ToInt32(Console.ReadLine());
            int quot, rem, sum = 0;

            quot = n;
            while (quot != 0)
            {
                rem = quot % 10;
                sum = sum + rem;
                quot = quot / 10;
            }

            Console.WriteLine("Sum of digits are {0} ",sum);
            Console.ReadLine();
        }
    }
}
