using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    // Defined a public class so we use the different calculation methods.
    public class Operators
    {
        // Addition method takes two numbers, adds them up then returns result.
        public static double Addition(double numOne, double numTwo)
        {
            double result = numOne + numTwo;
            return result;
        }

        // Subtraction method takes two numbers, subtracts them then returns result.
        public static double Subtraction(double numOne, double numTwo)
        {
            double result = numOne - numTwo;
            return result;
        }

        // Multiplication method takes two numbers, multiplies them then returns result.
        public static double Multiplication(double numOne, double numTwo)
        {
            double result = numOne * numTwo;
            return result;
        }

        // Division method takes two numbers, divides them then returns result.
        public static double Division(double numOne, double numTwo)
        {
            double result;

            // If statement check to see if the second value is a 0, if not returns normal result.
            if (numTwo != 0) {
                result = numOne / numTwo;
            }
            
            // If the second value is 0, returns the result as 0.
            else {
                result = 0;
            }

            return result;
        }

    }

    // Our normal program class.
    class Program
    {
        static void Main(string[] args)
        {
            // Defines the variables we will be using here.
            double numOne = 0;
            double numTwo = 0;
            double result = 0;

            string userInput = "";
            string sign = "";
            string textCheck = "";

            string exitCheck = "";
            bool exit = false;

            // Our simple description of what the program does.
            Console.WriteLine("Simple calculator that takes in two user inputted values along with a operand to perform calculations.");

            // First do while loop, this checks whether exit is still false so the program keeps running.
            do
            {
                // The first do while loop of the actual program, it will carry on until the input isn't an empty string.
                do
                {
                    textCheck = "";
                    // Takes user input.
                    Console.WriteLine("\n" + "Please enter the first value.");
                    userInput = Console.ReadLine();

                    // Simple try catch block, ensures the input is a number and not anything else.
                    try
                    {
                        numOne = Convert.ToDouble(userInput);
                    }
                    catch (System.FormatException e)
                    {
                        textCheck = "\n" + "Please enter an actual number.";
                        Console.WriteLine(e.ToString() + "\n" + textCheck + "\n");
                    }
                } while (textCheck != "");

                // The second do while loop of the actual program, this carries on until sign isn't empty and is an operand.
                do
                {
                    // Takes user input
                    Console.WriteLine("\n" + "Please choose from: +, -, * or /.");
                    sign = Console.ReadLine();

                    // Ensures that the input has to be a +, -, * or a /.
                    if ((sign != "+") && (sign != "-") && (sign != "*") && (sign != "/"))
                    {
                        sign = "";
                    }

                } while (sign == "");

                //The final do while loop of the actual program, it will carry on until the input isn't an empty string.       
                do
                {
                    textCheck = "";
                    // Takes user input.
                    Console.WriteLine("\n" + "Please enter the second value.");
                    userInput = Console.ReadLine();

                    // Simple try catch block, ensures the input is a number and not anything else.
                    try
                    {
                        numTwo = Convert.ToDouble(userInput);
                    }
                    catch (System.FormatException e)
                    {
                        textCheck = "\n" + "Please enter an actual number.";
                        Console.WriteLine(e.ToString() + "\n" + textCheck + "\n");
                    }
                } while (textCheck != "");

                // Switch statements to perform actual calculations depending on operand chosen.
                switch (sign)
                {
                    // Calls addition method
                    case "+":
                        result = Operators.Addition(numOne, numTwo);
                        break;
                    // Calls subtraction method
                    case "-":
                        result = Operators.Subtraction(numOne, numTwo);
                        break;
                    // Calls multiplication method
                    case "*":
                        result = Operators.Multiplication(numOne, numTwo);
                        break;
                    // Calls division method
                    case "/":
                        result = Operators.Division(numOne, numTwo);
                        break;
                    // This shouldn't be called, but is here to be a just incase back up message.
                    default:
                        result = 0;
                        textCheck = "\n" + "Could not do calculations, please choose an actual operand.";
                        break;
                }

                // Because textCheck hasn't been blank to get to this point, we now call for the results with a simple if else statement.
                if (textCheck == "")
                {
                    // Using a formatted string to place the arguments into respective numbers after string ends.
                    Console.WriteLine("\n" + "{0} {1} {2} = {3}", numOne, sign, numTwo, result);
                }

                else
                {
                    // If textcheck is somehow empty, we return the default message we placed.
                    Console.WriteLine("{0}", textCheck);
                }

                // At this point, program confirms whether user wants to exit or continues looping.
                Console.WriteLine("\n" + "Do you want to exit? If yes, press E.");
                Console.WriteLine("Otherwise, press any other key." + "\n");

                // Takes user input
                exitCheck = Console.ReadLine().ToLower();

                // Simple check to see whether the input was character E or e, if so program ends.
                if (exitCheck == "e")
                {
                    exit = true;
                    Environment.Exit(0);
                    break;
                }

              // Otherwise continues looping.
            } while (exit == false);

        }
    }
}
