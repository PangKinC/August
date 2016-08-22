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
            Console.WriteLine("EX = Exit Program" + "\n");

            string userInput;
            string keyInput;
            string valueInput;
            string value = "";
            //string key = "";

            Dictionary<string, string> languages = new Dictionary<string, string>()
            {
                { "JavaScript", "For all your Phone Development needs!" },
                { "Python", "If you want ease of readability!" },
                { "C#", "For a very strongly typed and highly object-orientated language!" }

            };

            bool exit = false;

            do
            {
                userInput = Console.ReadLine().ToLower();

                switch (userInput)
                {
                    case "ck":
                        Console.WriteLine("\n" + "Please type in the key of the programming language your trying to locate." + "\n");
                        keyInput = Console.ReadLine();

                        if (languages.ContainsKey(keyInput))
                        {
                            Console.WriteLine("\n" + keyInput + " was found inside the dictionary!");
                        }

                        else
                        {
                            Console.WriteLine("\n" + keyInput + " was not found in the dictionary.");
                        }
                        break;

                    case "cv":
                        Console.WriteLine("\n" + "Please type in the value of the programming language your trying to locate." + "\n");
                        valueInput = Console.ReadLine();

                        if (languages.ContainsValue(valueInput))
                        {
                            Console.WriteLine("\n" + valueInput + " was found inside the dictionary!");     
                        }

                        else
                        {
                            Console.WriteLine("\n" + valueInput + " was not found in the dictionary.");
                        }
                        break;

                    case "sv":
                        Console.WriteLine("\n" + "Please type in the key of the programming language value your trying to locate." + "\n");
                        keyInput = Console.ReadLine();

                        if (languages.TryGetValue(keyInput, out value))
                        {
                            Console.WriteLine("\n" + keyInput + " key was found inside the dictionary! with the following value: " + "\n" + "{0}", value);
                        }
                        else
                        {
                            Console.WriteLine("\n" + keyInput + " key did not match any values in the dictionary." + "\n");
                        }
                        break;

                    case "co":
                        Console.WriteLine("\n" + "Current number of items in the dictionary is: " + languages.Count);
                        break;

                    case "ad":
                        Console.WriteLine("\n" + "Please type in a key to identify your programming language by." + "\n");
                        keyInput = Console.ReadLine();

                        Console.WriteLine("\n" + "Please type in the value AKA description of the programming language your trying to add." + "\n");
                        valueInput = Console.ReadLine();

                        languages.Add(keyInput, valueInput);
                        Console.WriteLine("\n" + keyInput + ": " + valueInput + " was successfully added to the dictionary!" + "\n");
                        break;

                    case "ed":
                        Console.WriteLine("\n" + "Please type the key of the programming language your trying to change." + "\n");
                        keyInput = Console.ReadLine();

                        if (languages.ContainsKey(keyInput))
                        {
                            Console.WriteLine("\n" + "The entry was found in the dictionary! Please type in the new value for it." + "\n");
                            valueInput = Console.ReadLine();
                            languages[keyInput] = valueInput;

                            if (languages.TryGetValue(keyInput, out valueInput))
                            {
                                Console.WriteLine("\n" + keyInput + " was changed with following value: {0}", valueInput + "\n");
                            }
                            
                        }
                        else
                        {
                            Console.WriteLine("\n" + "There was no such key for any programming languages, mayhaps you want to considering adding one?" + "\n");
                        }

                        break;

                    case "rd":
                        Console.WriteLine("\n" + "Please type the key of the programming language your trying to remove from the dictionary." + "\n");
                        keyInput = Console.ReadLine();

                        if (languages.ContainsKey(keyInput))
                        {
                            Console.WriteLine("\n" + "The key matched with an entry in the dictionary! Really want to delete? Y / N?" + "\n");
                            valueInput = Console.ReadLine().ToLower();

                            if (valueInput == "y") {
                                languages.Remove(keyInput);
                                Console.WriteLine("\n" + keyInput + "was removed from your dictionary.");
                            }
                            else { break; }
                        }

                        else
                        {
                            Console.WriteLine("\n" + "That key was not matched with any entries found in the dictionary." + "\n");
                        }

                        break;

                    case "ex":
                        exit = true;
                        Environment.Exit(0);
                        break;

                    default:
                        break;

                }

                Console.WriteLine("\n" + "Please enter another command: AD, ED, RD, CK, CV, SV, CO or EX" + "\n");

            } while (exit == false);

        }
    }
}
