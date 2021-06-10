using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.readData();
            obj.leapYear();

            Console.ReadKey();
        }

        int n;
        public void readData()
        {
            Console.WriteLine("enter the year in four digits");
            n = Convert.ToInt32(Console.ReadLine());
        }

        public void leapYear()
        {
            if ((n % 4 == 0 && n % 100 != 0) || n % 400 == 0)
                Console.WriteLine("leap year");
            else
                Console.WriteLine("not a leap year");
        }
    }
}
