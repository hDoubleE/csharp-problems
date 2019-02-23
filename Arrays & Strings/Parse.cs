using System;
using System.Text;

namespace DataStructures.BST
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = "1";
            string num2 = "-1";
            string num3 = "0";
            string num4 = "-4572";
            string num5 = "7283";

            int result = StringToInt(num5);
            Console.WriteLine(result);
        }

        /* 
        
        Define a method to convert String representation of a number "374" to an int 374.
        Do the same for int to string. 
        
        The value of an integer character is equal to the digit plus the value '0'.
        You subtract the char value '0' from a digit to get the number.
        In ASCII '0' = #48 '9' = #57, so 57 - 48 = 9 (the number).

        Loop left to right, every time you find a new digit, multiply value you've already read by 10, then add the value of new digit.
        ie. Horner's Rule.

        Start number at 0
        If the first char is '-'
            Set the IsNeg flag
            Start scanning with the next character
        Foreach character in string
            Multiply number by 10
            Add (digit character - '0') to number
        If IsNeg flag is set
            Negate number with - operator
            Return number         

        */

        public static int StringToInt(string s)
        {
            int number = 0;
            bool isNeg = false;
            int i = 0;

            if (s[0] == '-')
            {
                isNeg = true;
                i = 1;
            }

            while (i < s.Length)
            {
                number *= 10;
                number += s[i] - '0';
                i++;
            }

            if (isNeg)
            {
                number = -number;
            }
            return number;
        }

        /*
        You can convert integer values back to char digits by adding '0'.
        Modulo and divide number until there's nothing left. 

        732 / 10 = 73;
        732 % 10 = 2; reverse

        73 / 10 = 7;
        73 % 10 = 3; in 

        7 / 10 = 0;
        7 % 10 = 7; digits

        Write to buffer and reverse.
        Modulo will mess up negative numbers. So negate the number to positive and flag.
        
        Outline:

        If number is less than 0 
            Flag isNeg
            Negate number
        While number is != to 0
            Add '0' to number, % 10 and write to buffer
            Integer divide number by 10
        If isNeg
            Write '-' into buffer
        Write chars in buffer to output string in reverse order.

        */

        public static string IntToString(int num)
        {
            const int MAX_DIG = 10;
            int i = 0;
            bool isNeg = false;
            char[] temp = new char[MAX_DIG + 1];

            if (num < 0)
            {
                isNeg = true;
                num = -num;
            }
            do
            {
                temp[i] = (char)((num % 10) + '0');
                num /= 10;
                i++;
            }
            while (num != 0);

            StringBuilder sb = new StringBuilder();
            if (isNeg)
            {
                sb.Append('-');
            }

            while (i > 0)
            {
                sb.Append(temp[i]);
                i--;
            }
            
            return sb.ToString();
        }
    }
}
