using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapWithout3rdVar
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

            //a = a + b;
            //b = a - b;
            //a = a - b;

            a = a * b;
            b = a / b;
            a = a / b;

            Console.WriteLine("Swapped numbers are a {0} & b {1} ", a, b);
            Console.ReadKey();
        }
    }
}
