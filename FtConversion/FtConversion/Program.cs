using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FtConversion
{
    class Program
    {
        static string Converter (int a, string b)
        {
            string myConversion;
            if (b == "ft")
            {
                a *= 12;
                myConversion = a + " in";
            }
            else
            {
                a /= 12;
                myConversion = a + " ft";
            }
            return myConversion;
            
        }
        static void Main(string[] args)
        {
            int measurement = int.Parse(Console.ReadLine());
            string unit = Console.ReadLine();
            Console.WriteLine(Converter(measurement, unit));
        }
    }
}
