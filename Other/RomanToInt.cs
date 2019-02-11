using System;

/*
 *  Key:
 *  M = 1000
 *  D = 500
 *  C = 100
 *  L = 50
 *  X = 10
 *  V = 5
 *  I = 1
 * 
 *  Special Cases:
 *  CM = 900
 *  CD = 400
 *  XC = 90
 *  XL = 40
 *  IX = 9
 *  IV = 4
 */

namespace RomanNumeralConverter
{
    public class Program
    {
        static void Main()
        {
            Converter convert = new Converter();
            Console.Write("Enter Roman Numeral: ");
            string number = Console.ReadLine();
         
            Console.WriteLine(convert.RomanToInt(number));
        }
    }

    public class Converter
    {
        internal int RomanToInt(string romanString)
        {
            if (romanString == String.Empty || romanString.Length > 14)
            {
                throw new ArgumentException("Input must be valid roman numeral.");
            }

            int result = 0;
            string k = romanString.ToUpper();

            // Loop string input and convert each numeral.
            foreach (char c in k)
            {
                result += convertSymbol(c);
            }

            // Handle special cases involving 4s and 9s. 
            if (k.Contains("CM") || k.Contains("CD"))
            {
                result -= 200;
            }
            if (k.Contains("XC") || k.Contains("XL"))
            {
                result -= 20;
            }
            if (k.Contains("IX") || k.Contains("IV"))
            {
                result -= 2;
            }
            if ((result == 0) || (result > 3999))
            {
                throw new ArgumentOutOfRangeException("Input must be valid roman numeral.");
            }
            return result;
        }

        internal int convertSymbol(char c)
        {
            if (c == 'M') return 1000;
            if (c == 'D') return 500;
            if (c == 'C') return 100;
            if (c == 'L') return 50;
            if (c == 'X') return 10;
            if (c == 'V') return 5;
            if (c == 'I') return 1;

            else return 0;
        }
    }
}
