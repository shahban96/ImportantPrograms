using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the length for fibonacci series");
            int n = Convert.ToInt32(Console.ReadLine());

            int first = 0, second = 1;
            int next = first + second;
            Console.Write(first+" ");
            Console.Write(second+" ");

            for (int i = 0; i < n; i++)
            {
                Console.Write(next+" ");
                first = second;
                second = next;
                next = first + second;
            }
            Console.ReadKey();
        }
    }
}
