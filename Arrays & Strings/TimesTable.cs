using System;
using System.Text;
using System.Collections.Generic;

// This program prints a grade school times table to degree of n.
// Really just playing with formatting the output. 
namespace Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintTable(12);
        }

        public static void PrintTable(int maxNum)
        {
            // Outer loop prints each line (1-12) in first column (vertical)
            for (int x = 1; x <= maxNum; x++)
            {
                // Inner loop computes and prints each number in line (horizontal)
                for (int y = 1; y <= maxNum; y++)
                {
                    // Left aligns (-) in a 3 character field (3).
                    Console.Write($"{x * y, -3}  ");
                }
                Console.WriteLine("\n");
            }
        }
    }
}