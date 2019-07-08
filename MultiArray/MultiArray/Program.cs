using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] monsters = new string[3, 4]; //creates 3 rows & 4 columns
            // 0 = name, 1 = color, 2 = location, 3 = body count
            // nessy, bigfoot, freddy

            monsters[0, 0] = "Nessy";
            monsters[0, 1] = "Dark Green";
            monsters[0, 2] = "Loch Ness";

            monsters[1, 0] = "Bigfoot";
            monsters[1, 1] = "Brown";
            monsters[1, 2] = "PA";

            monsters[2, 0] = "Freddy";
            monsters[2, 1] = "Red/Black";
            monsters[2, 2] = "Dreams";

            for (int i = 0; i < 3; i++)
            {
                NewMethod(monsters, i);
            }

            int greatestMonsterIndex = 0; //used to determine which monster has the highest kill value
            int maxKills = 0; //start at zero, if monster has more kills changes to that number
            bool tie = false;

            for (int i = 0; i < monsters.GetLength(0); i++)
            {
                int monsterKills = int.Parse(monsters[i, 3]); //convert string to int for kills

                if (monsterKills > maxKills) //compare each monster to see who has the greatest number
                {
                    maxKills = monsterKills; // changes highest kills to the monster with highest
                    greatestMonsterIndex = i;
                    tie = false;
                }
                else if (monsterKills == maxKills)
                {
                    tie = true;
                } 
            }

            if (maxKills == 0) //condition for when all monsters have 0 kills 
            {
                Console.WriteLine("Nobody got any kills! These monsters are pitiful.");
            }

            else
            {
                if (tie == true)
                {
                    for (int i = 0; i < monsters.GetLength(0); i++)
                    {
                        if (int.Parse(monsters[i, 3]) == maxKills)
                            Console.WriteLine("{0} has tied with {1} kills.", monsters[i, 0], maxKills);
                    }
                }
                if (tie == false)
                {
                    Console.WriteLine("{0} has the highest body count with {1} kills", monsters[greatestMonsterIndex, 0], maxKills);
                }
            }
            

            /*if (maxKills > 0)
            {

                //tie conditions
                if ((int.Parse(monsters[0, 3]) == int.Parse(monsters[1, 3])) && (int.Parse(monsters[0, 3]) > int.Parse(monsters[2, 3])))
                    Console.WriteLine("{0} and {1} have tied for the highest body count with {2} kills!", monsters[0, 0], monsters[1, 0], maxKills);

                if ((int.Parse(monsters[0, 3]) == int.Parse(monsters[2, 3])) && (int.Parse(monsters[0, 3]) > int.Parse(monsters[1, 3])))
                    Console.WriteLine("{0} and {1} have tied for the highest body count with {2} kills!", monsters[0, 0], monsters[2, 0], maxKills);

                if ((int.Parse(monsters[1, 3]) == int.Parse(monsters[2, 3])) && (int.Parse(monsters[1, 3]) > int.Parse(monsters[0, 3])))
                    Console.WriteLine("{0} and {1} have tied for the highest body count with {2} kills!", monsters[1, 0], monsters[2, 0], maxKills);

                if ((int.Parse(monsters[1, 3]) == int.Parse(monsters[2, 3])) && (int.Parse(monsters[1, 3]) == int.Parse(monsters[0, 3])))
                    Console.WriteLine("It's a three way tie with {0} kills!", maxKills);

                //single winner conditions
                if ((int.Parse(monsters[0, 3]) > int.Parse(monsters[1, 3])) && (int.Parse(monsters[0, 3]) > int.Parse(monsters[2, 3])))
                    Console.WriteLine("{0} has the highest body count with {1} kills!", monsters[greatestMonsterIndex, 0], maxKills);

                if ((int.Parse(monsters[1, 3]) > int.Parse(monsters[0, 3])) && (int.Parse(monsters[1, 3]) > int.Parse(monsters[2, 3])))
                    Console.WriteLine("{0} has the highest body count with {1} kills!", monsters[greatestMonsterIndex, 0], maxKills);

                if ((int.Parse(monsters[2, 3]) > int.Parse(monsters[0, 3])) && (int.Parse(monsters[2, 3]) > int.Parse(monsters[1, 3])))
                    Console.WriteLine("{0} has the highest body count with {1} kills!", monsters[greatestMonsterIndex, 0], maxKills);
            */

            Console.ReadKey();
        }

        private static void NewMethod(string[,] monsters, int i)
        {
            try
            {
                Console.WriteLine("How many people has {0} killed?", monsters[i, 0]);
                int.Parse(monsters[i, 3] = Console.ReadLine());
            }

            catch
            {
                bool submit = false;
                while (submit == false) // if submit = false, the loop will run
                {
                    try // try again if they enter a letter
                    {
                        Console.WriteLine("You must enter a number.");
                        int.Parse(monsters[i, 3] = Console.ReadLine());
                        submit = true; // they must have done it right, end loop
                    }
                    catch // they enter a letter twice, stays false
                    {
                        submit = false;
                    }
                }
            }
        }
    }
}
