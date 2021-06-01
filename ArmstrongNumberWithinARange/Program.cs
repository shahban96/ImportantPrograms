using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongNumberWithinARange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the range to find armstrong number");
            Console.WriteLine("enter the lower limit");
            int lower = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the upper limit");
            int upper = Convert.ToInt32(Console.ReadLine());

            int rem, sum, i, num;

            for (i = lower; i <= upper; i++)
            {
                sum = 0;
                num = i;
                while (num > 0)
                {
                    rem = num % 10;
                    sum = sum + rem * rem * rem;
                    num = num / 10;
                }
                if (sum == i)
                    Console.WriteLine("Armstrong number {0}", i);
            }

            Console.ReadLine();
        }
    }
}
