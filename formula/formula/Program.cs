using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formula
{
    class Program
    {
        static void Main(string[] args)
        {
            float totalDamage = 0;
            float baseDamage = 100;
            float def = 1;
            float reduction;

            while (def != 0)
            {
                Console.Write("Defense: ");
                def = float.Parse(Console.ReadLine());

                totalDamage = baseDamage * (4000 + def) / (4000 + 10 * def);
                float magicDamage = baseDamage * (1000 + def) / (1000 + 10 * def);

                reduction = (1 - totalDamage / baseDamage) * 100;
                float magicReduction = (1 - magicDamage / baseDamage) * 100;

                Console.WriteLine("Damage Reduction: {0:0.##}%", reduction);
                Console.WriteLine("Magic Reduction: {0:0.##}%", magicReduction);
                Console.WriteLine();
            }



            Console.ReadKey();
        }
    }
}
