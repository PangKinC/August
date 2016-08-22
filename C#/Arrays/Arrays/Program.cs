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
            /*decimal[] num = new decimal[5];

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Number: " + num[i] + " has been saved.");
            }

            Console.WriteLine("\n");
            Console.WriteLine("Doing calculations ...");
            Console.WriteLine("Average of numbers inputted is: " + (num[0] + num[1] + num[2] + num[3] + num[4]) / num.Length + ".");
            Console.WriteLine("\n");*/

            int[,] num = new int[5, 5] {
                { 1, 2, 3, 4, 5 },
                { 6, 7, 8, 9, 10 },
                { 11, 12, 13, 14, 15 },
                { 16, 17, 18, 19, 20 },
                { 21, 22, 23, 24, 25 }
            };

            int rowSum = 0;
            int columnSum = 0;
            int totalSum = 0;

            for (int i = 0; i < num.GetLength(0); i++) {
                rowSum = 0;
                for (int j = 0; j < num.GetLength(1); j++) {
                    rowSum += num[i, j];
                }

                Console.Write(rowSum + " ");
            }

            Console.WriteLine("\n");

            for (int i = 0; i < num.GetLength(0); i++) {
                columnSum = 0;    
                for (int j = 0; j < num.GetLength(1); j++) {
                    columnSum += num[j, i];
                }

                Console.Write(columnSum + " ");
            }

            Console.WriteLine("\n");

            for (int i = 0; i < num.GetLength(0); i++) {
                //totalSum = 0;
                for (int j = 0; j < num.GetLength(1); j++) {
                    totalSum = 0;
                    rowSum += num[i, i];
                    columnSum += num[j, j];
                    totalSum = num[i, j] + num[j, i];
                }
            }
            
            Console.WriteLine(totalSum + "\n");

        }
    }
}
