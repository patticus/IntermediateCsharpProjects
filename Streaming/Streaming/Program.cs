using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Streaming
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter writer;
            writer = new StreamWriter("test.txt");
            writer.WriteLine(@"    =/\                 /\=");
            writer.WriteLine(@"    / \'._   (\_/)   _.'/ \");
            writer.WriteLine(@"   / .''._'--(o.o)--'_.''. \");
            writer.WriteLine(@"  /.' _/ |`'=/ ' \= '`| \_`.\");
            writer.WriteLine(@" /` .' `\;-,'\___/',-;/` '. '\");
            writer.WriteLine(@"/.-'       `\(-V-)/`       `-.\");
            writer.WriteLine(@"`            '   '            `");
            writer.Close();

            StreamWriter writer2;
            writer2 = new StreamWriter("test2.txt");
            writer2.WriteLine("How in the world?");
            writer2.WriteLine("Sunshine on my nutsack");
            writer2.Close();

            Console.WriteLine("Would you like to enter a file path? [Y/N]");
            string pathExists = Console.ReadLine();
            string filePath = "Test.txt";

            if (pathExists.ToUpper() == "Y")
            {
                Console.WriteLine("enter a file path");
                filePath = Console.ReadLine();
            }
                

            //loads in the file to be read
            StreamReader reader = new StreamReader(filePath);
            //gets the number of lines in the file
            int numberOfLines = File.ReadAllLines(filePath).Count();
            //creates an array to hold each line of file
            string[] line = new string[numberOfLines];
            //loop through each line and store in the array
            for (int i = 0; i < numberOfLines; i++)
            {
                line[i] = reader.ReadLine();
            }
            while (reader.EndOfStream == false)

            reader.Close();

            Console.WriteLine("There are {0} lines in the file. Which line would you like to read?", numberOfLines);

            int lineChoice;

            try
            {
                lineChoice = int.Parse(Console.ReadLine());
            }
            catch
            {
                lineChoice = 0;
            }

            if (lineChoice <= 0 || lineChoice > numberOfLines)
            {
                for (int i = 0; i < numberOfLines; i++)
                {
                    Console.WriteLine(line[i]);
                }
            }
            else
            {
                Console.WriteLine(line[lineChoice-1]);
            }

            Console.ReadKey();
        }
    }
}
