using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateToken
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "shahban@gmail.com";
            string str1 = str.Split('@').Last();
            string str2 = str.Split('@')[0];
            Console.WriteLine(str1 + " " + str2);

            string token = string.Empty;
            Random rd = new Random();
            int value = rd.Next(100000);
            string random = value.ToString("00000");
            token = str2 + "-" + random;
            Console.WriteLine(token);

            Console.ReadKey();
        }
    }
}
