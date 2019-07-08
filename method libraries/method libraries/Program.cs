using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_libraries
{
    class Program // Put comments on 6 lines 
    {
        static string ReadString(string prompt) // method readString contains one paramater of the string prompt
        {
            string result;
            do
            {
                Console.Write(prompt);
                result = Console.ReadLine();
            } while (result == ""); // do loop to prompt the user, will repeat until the user types in anything other than blank
            return result;
        }

        static int ReadInt(string prompt, int low, int high) // method ReadInt contains three paramaters - one string and two ints
        {
            int result;

            do
            {
                string intString = ReadString(prompt);
                result = int.Parse(intString);
            } while ((result < low) || (result > high)); // do loop prompts the user for age and only accepts numbers between 0 and 100

            return result;
        }

        public static void Main(string[] args)
        {
            string name;
            name = ReadString("Enter your name: "); // passing argument of "enter your name" within the ReadString method
            Console.WriteLine("Name: " + name);

            int age;
            age = ReadInt("Enter your age: ", 0, 100); // passing arguments for string and two ints for the ReadInt method
            Console.WriteLine("Age: " + age);
        }
    }
}
