using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A = Add Book");
            Console.WriteLine("D = Delete Book");
            Console.WriteLine("S = Search Book");
            Console.WriteLine("L = List Books");
            Console.WriteLine("O = Sort Books");
            Console.WriteLine("E = Exit Program");

            string userInput;
            string bookInput;
            List<string> book = new List<string>();

            book.Add("Harry Potter");
            book.Add("Game of Thrones");
            book.Add("Hunger Games");

            bool exit = false;

            do
            {
                userInput = Console.ReadLine().ToLower();

                switch (userInput)
                {
                    case "a":
                        Console.WriteLine("Please type in the title of the book.");
                        bookInput = Console.ReadLine();
                        book.Add(bookInput);
                        Console.WriteLine("The book: " + bookInput + " has been added!");
                        break;

                    case "l":
                        Console.WriteLine("Here are your list of books: ");
                        foreach (string s in book)
                        {
                            Console.WriteLine(s);
                        }

                        break;

                    case "d":
                        Console.WriteLine("Type in the name of the book you want to delete.");
                        bookInput = Console.ReadLine();
                        book.Remove(bookInput);
                        Console.WriteLine(bookInput + " was deleted from you list of books");
                        break;

                    case "o":
                        Console.WriteLine("Sorting the books...");
                        book.Sort();
                        Console.WriteLine("Your order of books is now:");
                        foreach (string s in book)
                        {
                            Console.WriteLine(s);
                        }
                        break;

                    case "s":
                        Console.WriteLine("Type in the name of the book you want to search");
                        bookInput = Console.ReadLine();

                        foreach (string s in book)
                        {
                            if (s.Contains(bookInput))
                            {
                                Console.WriteLine("Book: " + bookInput + " was found in the list of books!");
                            }
                        }
                        break;

                    case "e":
                        exit = true;
                        Environment.Exit(0);
                        break;

                    default:
                        break;
                }

                Console.WriteLine("Please enter another command: A, D, S, L, O or E");    

            } while (exit == false);
  
        }
    }
}

