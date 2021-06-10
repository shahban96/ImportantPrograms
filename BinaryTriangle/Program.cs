using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, lastint = 0, i, j;
            Console.WriteLine("enter the limit");
            m = int.Parse(Console.ReadLine());

            for (i = 1; i <= m; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    if (lastint == 1)
                    {
                        Console.Write("0");
                        lastint = 0;
                    }
                    else if (lastint == 0)
                    {
                        Console.Write("1");
                        lastint = 1;
                    }
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}
