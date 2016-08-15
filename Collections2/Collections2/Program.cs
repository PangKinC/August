using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("AD - Add Dictionary Entry");
            Console.WriteLine("ED - Edit Dictionary Entry");
            Console.WriteLine("RD - Remove Dictionary Entry");
            Console.WriteLine("CK = Check Key");
            Console.WriteLine("CV = Check Value");
            Console.WriteLine("SV = Search Value");
            Console.WriteLine("CO = Count List");
            Console.WriteLine("E = Exit Program");

            string userInput;
            string keyInput;
            string valueInput;
            string value = "";

            Dictionary<string, string> languages = new Dictionary<string, string>();

            languages.Add("JavaScript", "For all your Phone Development needs!");
            languages.Add("Python", "If you want ease of readability!");
            languages.Add("C#", "For a very strongly typed and highly object-orientated language!");

            bool exit = false;

            do
            {
                userInput = Console.ReadLine().ToLower();

                switch (userInput)
                {
                    case "ck":
                        Console.WriteLine("Please type in the key of the programming language your trying to locate.");
                        keyInput = Console.ReadLine();

                        if (languages.ContainsKey(keyInput))
                        {
                            Console.WriteLine(keyInput + " was found inside the dictionary!");
                        }

                        else
                        {
                            Console.WriteLine(keyInput + " was not found.");
                        }
                        break;

                    case "cv":
                        Console.WriteLine("Please type in the value of the programming language your trying to locate.");
                        valueInput = Console.ReadLine();

                        if (languages.ContainsValue(valueInput))
                        {
                            Console.WriteLine(valueInput + " was found inside the dictionary!"); // Ask about matching with key!
                        }

                        else
                        {
                            Console.WriteLine(valueInput + " was not found.");
                        }
                        break;

                    case "sv":
                        Console.WriteLine("Please type in the key of the programming language value your trying to locate.");
                        keyInput = Console.ReadLine();

                        if (languages.TryGetValue(keyInput, out value))
                        {
                            Console.WriteLine(keyInput + " key was found, with the following value: {0}", value);
                        }
                        else
                        {
                            Console.WriteLine(keyInput + " key did not match any values in the dictionary.");
                        }
                        break;

                    case "co":
                        Console.WriteLine("Current number of items in the dictionary is: " + languages.Count);
                        break;

                    case "ad":
                        Console.WriteLine("Please type in a key to identify your programming language by.");
                        keyInput = Console.ReadLine();

                        Console.WriteLine("Please type in the value AKA description of the programming language your trying to add.");
                        valueInput = Console.ReadLine();

                        languages.Add(keyInput, valueInput);
                        Console.WriteLine(keyInput + ": " + valueInput + " was successfully added to the dictionary!");
                        break;

                    case "ed":
                        Console.WriteLine("Please type the key of the programming language your trying to change.");
                        keyInput = Console.ReadLine();

                        if (languages.ContainsKey(keyInput))
                        {
                            Console.WriteLine("The entry was found in the dictionary! Please type in the new value for it.");
                            valueInput = Console.ReadLine();
                            languages[keyInput] = valueInput;    
                        }
                        else
                        {
                            Console.WriteLine("There was no such key for any programming languages, mayhaps you want to considering adding one?");
                        }

                        break;

                    case "rd":
                        Console.WriteLine("Please type the key of the programming language your trying to remove from the dictionary.");
                        keyInput = Console.ReadLine();

                        if (languages.ContainsKey(keyInput))
                        {
                            Console.WriteLine("The key matched with an entry in the dictionary! Really want to delete? Y / N?");
                            valueInput = Console.ReadLine().ToLower();

                            if (valueInput == "y") {
                                languages.Remove(keyInput);
                            }
                            else { break; }
                        }

                        else
                        {
                            Console.WriteLine("That key was not matched with any entries found in the dictionary.");
                        }

                        break;

                    case "e":
                        exit = true;
                        Environment.Exit(0);
                        break;

                    default:
                        break;

                }

                Console.WriteLine("Please enter another command: AD, ED, RD, CK, CV, SV, CO or E");

            } while (exit == false);

        }
    }
}
