using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] num = new decimal[5];

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Number: " + num[i] + " has been saved.");
            }

            Console.WriteLine("\n");
            Console.WriteLine("Doing calculations ...");
            Console.WriteLine("Average of numbers inputted is: " + (num[0] + num[1] + num[2] + num[3] + num[4]) / num.Length + ".");
            Console.WriteLine("\n");

        }
    }
}
