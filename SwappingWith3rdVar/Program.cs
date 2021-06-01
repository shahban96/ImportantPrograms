using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwappingWith3rdVar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the numbers to swap");
            Console.WriteLine("enter first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a = {0} ", a);
            Console.WriteLine("enter second number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b = {0} ", b);
            int c;

            c = a;
            a = b;
            b = c;

            Console.WriteLine("Swapped numbers are a {0} & b {1} ", a, b);
            Console.ReadKey();
        }
    }
}
