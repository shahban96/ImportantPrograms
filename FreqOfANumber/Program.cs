using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreqOfANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the length of a number");
            int m = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[m];

            int count = 0;

            for (int i = 0; i < m; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (var item in arr)
            {
                if(item == 1)
                {
                    count++;
                }
            }

            Console.WriteLine("freq of 1 is {0}",count);
            Console.ReadLine();
        }
    }
}
