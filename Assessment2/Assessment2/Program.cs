using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring the variables that will be used in the program.
            bool exit = false;
            bool add = true;
            bool isNumber = false;

            string userInput = "";
            string numberInput = "";

            double numberOutput = 0;
            double avgCalc = 0;
            double result = 0;

            double middle = 0;
            double firstNo = 0;
            double secondNo = 0;

            // List is the core data structure we will be using and manpulating.
            List<double> numbers = new List<double>();

            // We use a dictionary for a one of the functions in the program, which is to find the mode.
            // We can use the key of the dictionary to keep track of a value count.
            Dictionary<double, double> repeat = new Dictionary<double, double>();

            // Block of write lines to the console, introduces what the program does and the commands available.
            Console.WriteLine("Hello, this program allows you to manipulate a list of number in various ways. \n" );
            Console.WriteLine("A = Add or Average Numbers");
            Console.WriteLine("S = Sum of Numbers");
            Console.WriteLine("M = Median of Numbers");
            Console.WriteLine("O = Mode of Numbers");
            Console.WriteLine("T = Sort Numbers");
            Console.WriteLine("L = List Numbers");
            Console.WriteLine("E = Exit Program" + "\n");

            // Starts a do while loop which is ongoing until condition of exit being true is met.
            do
            {
                // Takes in the user input, turns the string into lowercase.
                userInput = Console.ReadLine().ToLower();
                
                // Starts some switch statements, different cases being whatever the user has typed above.
                // And if it matches the commands which was displayed at the start of the program.
                switch(userInput)
                {
                    // Case a takes you to the function which adds numbers then averages at the end.
                    case "a":

                        // Starts another do while loop, which is ongoing until condition add is false is met.
                        do
                        {
                            // Asks whether the user wnats to add a number, with if statements for either y (yes) or n (no).
                            Console.WriteLine("\n" + "Would you like to add a number to the list?");
                            Console.WriteLine("Type Y for Yes, N for No.");

                            // Takes in the user input, turns the string into lowercase.
                            userInput = Console.ReadLine().ToLower();

                            // If the user input was yes, or y in this case... 
                            if (userInput == "y") {
                                // Tells the user to input a number on the console, then push enter
                                Console.WriteLine("\n" + "Please enter a number then push enter.");

                                // Similar to convert function, but we use try parse instead.
                                // It takes in the users input, and tries parses out a double as output.
                                numberInput = Console.ReadLine();
                                isNumber = double.TryParse(numberInput, out numberOutput);

                                if (isNumber == true) {
                                    // If no errors were found, we add the new number to our list of numbers.
                                    Console.WriteLine("\n" + "Thank you, adding your number to the list .... ");
                                    numbers.Add(numberOutput);
                                }

                                else { Console.WriteLine("\n" + "Please enter an actual number value."); }
                            }

                            // Else if the user input was a n or no, we make add equal to false to end the do while loop.
                            else if (userInput == "n") { add = false; }
                            // If user types anything but a Y or N, a prompt will appear.
                            else { Console.WriteLine("\n" + "Please type in a Y or N."); }

                        } while (add == true);

                        // Tells the user that there numbers average is being calculated.
                        Console.WriteLine("\n" + "Thank you, the average of your list is: ");

                        // Uses a for loop to iterate through the list of numbers, and adds the numbers inside to avgCalc.
                        for (int i = 0; i < numbers.Count(); i++) { avgCalc += numbers[i]; }
                        // We assign to result, avgCalc divded by numbers.Count (amount of numbers in list) to get average.
                        result = avgCalc / numbers.Count();

                        // Writes to the console the result of the calculations.
                        Console.WriteLine(result);
                         
                        // Ends the a case statement
                        break;
                    
                    // For case s, we get the total sum of all the numbers currently in the list.
                    case "s":

                        // Lets the user know that the sum is being calculated by adding to result through for loop iteration
                        Console.WriteLine("\n" + "Thank you, calculating the sum of your numbers now ... ");
                        for(int i = 0; i < numbers.Count(); i++) { result += numbers[i]; }

                        // Writes to the console the total sum.
                        Console.WriteLine("\n" + "Sum has been calculated to be a total of: {0}.", result);

                        break;

                    // For case m, we try to find the median number out of the list.
                    case "m":

                        // First we have to make sure the list is ordered, so we sort it.
                        Console.WriteLine("\n" + "Thank you, we will select the median after sorting the list ... ");     
                        numbers.Sort();

                        // This checks whether count when divided by 2 has a remainder of 0, aka if it's even.
                        if (numbers.Count() % 2 != 0)
                        {
                            // If it's not even (odd) we assign to result the count of the list divided by 2, which rounds up.
                            // to an odd number (which is the median in odd numbered list) then shows the result on screen.
                            result = numbers[numbers.Count / 2];
                            Console.WriteLine("\n" + "The median number in the list is equal to {0}.", result);
                        }

                        // Else if the remainder does end up being 0, it would be a even numbered list.
                        else
                        {
                            // We set to the middle, the length or count of the list divided by 2.
                            middle = numbers.Count() / 2;
                            // Assign to the first number since we will be adding and dividing it by the end: middle.
                            firstNo = numbers[(int)middle];
                            // Assign to the sceond number middle - 1.
                            secondNo = numbers[(int)middle - 1];
                            // Adds the two numbers together then divides by 2 to return the median of a even numbered list.
                            // Then shows the result on the console.
                            result = (firstNo + secondNo) / 2;
                            Console.WriteLine("\n" + "The median number in the list is equal to {0}.", result);
                        }

                        break;
                   
                    // For case o, we get the mode of the list, which means finding the value that appears most throughout.
                    case "o":
                        
                        // Using a foreach loop, look through our list numbers
                        foreach (double value in numbers) { 
                            // If it find the number in the list more then once, it increments the value by 1.
                            if (repeat.ContainsKey(value)) {
                                repeat[value]++;
                            }
                            // Else if it doesn't find the number, value is set to 1.
                            else {
                                repeat.Add(value, 1);
                            }
                        }

                        // Using some lambda expressions, we set a variable mostrepeats by the value that appeared most.
                        // Starting in descending order.
                        var mostRepeats = repeat.OrderByDescending(x => x.Value).First();

                        // Finally we display to the console with string formatting, with {0} showing which number appeared most. And {1} being the amount of times it appears in the list.

                        Console.WriteLine("\n" + "The mode of the list is {0}, appearing {1} times throughout.", mostRepeats.Key, mostRepeats.Value);
                       
                        break;

                    /// Case s sorts through the list so that numbers are ordered properly then displays them on the screen.
                    case "t":

                        // Tells user list is being sort, then calls the Sort() method in list to sort the numbers inside.
                        Console.WriteLine("\n" + "Sorting through the list of numbers ... ");
                        numbers.Sort();

                        // Shows the user the list of numbers via iterating and writing lines with a for loop.
                        Console.WriteLine("\n" + "Thank you, your list of number is now as follows: " + "\n");
                        for (int i = 0; i < numbers.Count(); i++) { Console.WriteLine(numbers[i]); }

                        // Ends the s case statement
                        break;
                    
                    // Case l simply displays on the console our current list of numbers.
                    case "l":

                        // Shows on the screen below text and list of numbers via for loop iteration.
                        Console.WriteLine("\n" + "Thank you, here is your list of numbers: " + "\n");
                        for (int i = 0; i < numbers.Count(); i++) { Console.WriteLine(numbers[i]); }

                        // Ends the l case statement.
                        break;
                    
                    // Finally case e is for when the user is done and wants to exit the program.
                    case "e":

                        // Sets the boolean exit to true so that the while loop ends.
                        exit = true;
                        // Exits our current program via below method
                        Environment.Exit(0);
                        // Ends the e case statement.
                        break;
                }

                // At the end of the case chosen, we show this block of text to prompt the user for another command.
                Console.WriteLine("\n" + "Please type another command from the following then push enter.");
                Console.WriteLine("A for Add or Average, S for Sum, M for Median, O for Mode.");
                Console.WriteLine("T for Sort, L for List, E for Exit.");

                // We have to set these two variables back to 0 incase the user wants to call the same function over and over.
                result = 0;
                avgCalc = 0;

            } while (exit == false);
        }
    }
}
