using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Donald Trump, Hillary Clinton, Bernie Sanders, Ted Cruz, Ben Carson are all running to be the next US President.");
            Console.WriteLine("Who do you think will win?");

            string nextPresident; 

            do
            {
                nextPresident = Console.ReadLine().ToLower();

                switch (nextPresident)
                {
                    case "donald":
                    case "trump":
                    case "donald trump":
                        Console.WriteLine("Boooooooo!!!");
                        break;

                    case "hillary":
                    case "clinton":
                    case "hillary clinton":
                        Console.WriteLine("Test 1");
                        break;

                    case "bernie":
                    case "sanders":
                    case "bernie sanders":
                        Console.WriteLine("Test 2");
                        break;

                    case "ted":
                    case "cruz":
                    case "ted cruz":
                        Console.WriteLine("Test 3");
                        break;

                    case "ben":
                    case "carson":
                    case "ben carson":
                        Console.WriteLine("Test 4");
                        break;

                    default:
                        Console.WriteLine("Please enter a name from above list.");
                        break;
                }
            } while (nextPresident != "");
        }
    }
}
