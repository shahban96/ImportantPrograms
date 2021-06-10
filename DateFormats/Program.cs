using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateFormats
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime date = new DateTime(2021,6,10);

            DateTime date = DateTime.Now;

            Console.WriteLine("date formats are");
            Console.WriteLine(date);
            Console.WriteLine(date.ToString("MMMM dd, yyyy"));
            Console.WriteLine(date.ToString("yyyy dd MMMM"));
            Console.WriteLine(date.ToString("dd-MMMM-yyyy"));
            Console.WriteLine(date.ToString("M/d/yy"));
            Console.WriteLine(date.ToString("MM/dd/yyyy"));
            Console.WriteLine(date.ToString("yy/MM/dd"));
            Console.WriteLine(date.ToString("MM/dd/yy"));

            Console.ReadKey();
        }
    }
}
