using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite Operating System?");
            string os = Console.ReadLine().ToLower();

            switch (os)
            {
                case "linux" :
                    Console.WriteLine("You're pretty cool");
                    break;
                case "windows":
                    Console.WriteLine("You're alright I guess");
                    break;
                case "mac":
                    Console.WriteLine("Hello beautiful");
                    break;
                default:
                    Console.WriteLine("That's not an operating system");
                    break;
            }
        }
    }
}
