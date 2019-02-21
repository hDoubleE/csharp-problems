// Write a function that deletes character from a mutable ASCII string.
// Function should take two argument, string and remove.
// Input: My mother is a real cool lady, vowels: aeiou
// Output: My mthr s rl cl ldy.

/*
    Iterate through remove, setting each value in array to true.
    Iterate through string, with a source and a destination index,
    copying each character only if its value in lookup array is false.
    Set the length of str to account for chars removed.
 */

// My mother is a real cool lady.
// My mthr s rl cl ldy.

using System;
using System.Text;

namespace DataStructures.BST
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder s = new StringBuilder("My mother is a cool lady.");
            Console.WriteLine(s);
            string vowels = "aeiou";
            RemoveChars(s, vowels);
            Console.WriteLine(s);

        }

        public static void RemoveChars(StringBuilder str, string remove)
        {
            bool[] flags = new bool[128]; // Assumes ASCII
            int destination = 0;

            // Set flags at chars to be removed.
            foreach (char i in remove)
            {
                flags[i] = true;
                // a: true
            }

            // Loop through all the characters in string.
            for (int i = 0; i < str.Length; i++)
            {
                if (!flags[str[i]])
                {
                    str[destination] = str[i]; 
                    destination++;
                }
            }
            // (start index, number of chars to remove)
            str.Remove(destination, str.Length - destination);
            return;
        }
    }
}
