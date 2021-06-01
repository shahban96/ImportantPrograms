using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to check a palindrome");
            int n = Convert.ToInt32(Console.ReadLine());
            int quot, rem, res = 0;

            quot = n;
            while (quot != 0)
            {
                rem = quot % 10;
                res = res * 10 + rem;
                quot = quot / 10;
            }

            Console.WriteLine(res);

            if (n == res)
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("not");            
            Console.ReadLine();
        }
    }
}
