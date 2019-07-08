using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static int TestMethod(int i)
        {
            i = i++;
            Console.WriteLine("i is {0}", i);
            return i;
        }
        static void Main(string[] args)
        {
            TestMethod(99);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
