using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is a comment
            //Console.WriteLine("Hello, world!");
            Random random = new Random();
            int score = random.Next(1, 100);
            bool correct = false;
    
            Console.WriteLine("Try guess the number I'm thinking");

            do
            {
                int response = Convert.ToInt32(Console.ReadLine());

                if (response == score)
                {
                    Console.WriteLine("That was the right number!");
                    correct = true;
                }
                else if (response < score)
                {
                    Console.WriteLine("Number is bigger then value you typed, please try again.");
                }
                else
                {
                    Console.WriteLine("Number is smaller then the value you typed, please try again.");
                }
            } while (correct == false);
        }
    }
}
