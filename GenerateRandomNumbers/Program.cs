using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateRandomNumbers
{
    class Program
    {
        static Random ran = new Random();

        public static void Randomfunc()
        {
            int m = ran.Next();
            Console.Write(m);
            Console.ReadLine();
        }

        static void Main(string[] args)
        {

            Console.WriteLine("enter the limit to generate random numbers");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("random numbers are");
            for (int i = 1; i <= 10; i++)
            {
                Randomfunc();
            }
        }
    }
}
