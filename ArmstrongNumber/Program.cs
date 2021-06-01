using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to find armstrong number");
            int n = Convert.ToInt32(Console.ReadLine());
            int quot, rem, sum = 0;

            quot = n;
            while (quot != 0)
            {
                rem = quot % 10;
                sum = sum + rem * rem * rem;
                quot = quot / 10;
            }

            if (sum == n)
                Console.WriteLine("Armstrong number");
            else
                Console.WriteLine("Not");
            Console.ReadLine();
        }
    }
}
