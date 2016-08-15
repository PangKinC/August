using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            bool correct = false;
            //bool give = false;

            Console.WriteLine("Here is a riddle for you.");
            Console.WriteLine("A seven letter word containing thousand of letters?");

            while (correct == false) 
            {
                answer = Console.ReadLine().ToLower();

                if (answer == "mailbox")
                {
                    Console.WriteLine("That was the correct answer!");

                    Console.WriteLine("Here is another riddle for you.");
                    Console.WriteLine("You will always find me in the past, I can be created in the present, but the future can never taint me.");
                    Console.WriteLine("What am I?");

                    do
                    { 
                        answer = Console.ReadLine().ToLower();

                        if (answer == "history")
                        {
                            Console.WriteLine("That was the correct answer!");
                            correct = true;
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("That was not the correct answer.");
                            correct = false;
                        }

                    } while (correct == false);

                }

                else
                {
                    Console.WriteLine("That was not the correct answer.");
                    Console.WriteLine("Give up?");

                    if (answer == "yes")
                    {
                        Console.WriteLine("Try again next time!");
                        Environment.Exit(0);
                    }

                    else if (answer == "no")
                    {
                        Console.WriteLine("Please enter an answer again");
                        correct = false;
                    }
                }

            }
        }
    }
}
