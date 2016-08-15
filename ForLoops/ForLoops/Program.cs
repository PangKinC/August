using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sevenDwarves = { "Happy", "Doc", "Sleepy", "Dopey", "Bashful", "Sneezy", "Grumpy" };
            string[] dinner = new string[7];
            string[] drink = new string[7];
 
            for (int i = 0; i < dinner.Length; i++)
            {
                Console.WriteLine(sevenDwarves[i] + ", will be eating: ");
                dinner [i] = Console.ReadLine();
                //Console.WriteLine(sevenDwarves[i] + ", your " + dinner[i] + " is ready.");
            }

            Console.WriteLine("\n");

            for (int i = 0; i < drink.Length; i++)
            {
                Console.WriteLine(sevenDwarves[i] + ", will be drinking: ");
                drink[i] = Console.ReadLine();
            }

            Console.WriteLine("\n");

           for (int i = 0; i < sevenDwarves.Length; i++)
            {
                Console.WriteLine(sevenDwarves[i] + ", your " + dinner[i] + " and " + drink[i] + " is ready.");
            }

            Console.WriteLine("\n");
        }
    }
}
