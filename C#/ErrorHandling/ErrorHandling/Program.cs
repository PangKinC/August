using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int numOne = 0;
            int numTwo = 0;
            int[] arrayTest = { 1, 2, 3, 4 };
            double numThree = 0;
            string userInput = "";

            Console.WriteLine("Enter your first value.");
            numOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second value.");
            numTwo = Convert.ToInt32(Console.ReadLine());

            try { result = numOne / numTwo; }
            catch (DivideByZeroException e) { Console.WriteLine(e.ToString()); }
            finally { Console.WriteLine("{0} divided by {1} equals {2}.", numOne, numTwo, result); }

            Console.WriteLine("\n");

            try {
                for(int i = -1; i < arrayTest.Length; i++) {
                    numOne += i;
                    Console.WriteLine(i);
                }
            }
            catch(IndexOutOfRangeException e) { Console.WriteLine(e.ToString()); }
            finally { Console.WriteLine("{0} index's was out of bound.", arrayTest); }

            Console.WriteLine("\n");

            Console.WriteLine("Please enter a number value.");
            userInput = Console.ReadLine();

            try { numThree = Convert.ToDouble(userInput); }
            catch (System.FormatException e) { Console.WriteLine(e.ToString()); }
            finally { Console.WriteLine("{0} that you inputted was not a number.", userInput); }

            Console.WriteLine("\n");    
            Console.WriteLine("Moving on...");

        }
    }
}
