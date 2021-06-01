using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberBetweenARange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the range to find prime numbers between");
            Console.WriteLine("enter the lower limit");
            int lower = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the upper limit");
            int upper = Convert.ToInt32(Console.ReadLine());

            int flag;

            for (int i = lower; i <= upper; i++)
            {
                flag = 0;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        flag = 1;
                        break;                     
                    }
                }

                if (flag == 0 && i != 1)
                {
                    Console.Write("{0} ",i);
                }
            }
            Console.ReadKey();
        }
    }
}
