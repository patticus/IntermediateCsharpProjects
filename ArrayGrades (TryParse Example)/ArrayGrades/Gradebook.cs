using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayGrades
{
    class Gradebook
    {
        static void EnterGrades()
        {
            int gradesAmount;

            Console.Write("Please enter the total number of grades to enter: ");
            //int gradesAmount = int.Parse(Console.ReadLine());

            while (!int.TryParse(Console.ReadLine(), out gradesAmount))
            {
                Console.Write("Please enter a number, not a letter: ");

            }
            while (gradesAmount == 0)
            {
                Console.Write("Zero is not an option. Please enter the total number of grades: ");
                gradesAmount = int.Parse(Console.ReadLine());
            }


            double total = 0;

            double[] grades = new double[gradesAmount];
            //create array to store grades with decimal values
            for (int i = 0; i < gradesAmount; i++)
            {
                Console.Write("Please enter Grade {0}: ", i + 1);
                grades[i] = double.Parse(Console.ReadLine());

                total += grades[i];
            }

            Console.WriteLine("Average: {0}", total / gradesAmount);

            Console.Write("Would you like to view one of your previously entered grades? [Y/N] ");
            string viewGrades = Console.ReadLine();

            while (viewGrades.ToUpper() == "Y")
            {
                Console.Write("Which grade number 1 through {0} would you like to view? ", gradesAmount);
                int whichGrade = int.Parse(Console.ReadLine());

                Console.WriteLine("Grade {0}: {1}", whichGrade, grades[whichGrade - 1]);

                Console.Write("Would you like to view one of your previously entered grades? [Y/N] ");
                viewGrades = Console.ReadLine();
            }

            if (viewGrades.ToUpper() == "N")
            {
                Console.WriteLine("Thanks.");
            }
        }
    }
}
