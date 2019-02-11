using System;


namespace Converter
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter a number between 1 and 3999");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(Converter.ToNumeral(input));
        }
    }

    public static class Converter
    {
        public static string ToNumeral(int number)
        {
            string roman = string.Empty;

            if ((number < 0) || (number > 3999))
            {
                throw new ArgumentOutOfRangeException("Input value between 1 and 3999");
            }
            while (number > 1)
            {
                if (number >= 1000)
                {
                    return "M" + ToNumeral(number - 1000);
                }
                if (number >= 900)
                {
                    return "CM" + ToNumeral(number - 900);
                }
                if (number >= 500)
                {
                    return "D" + ToNumeral(number - 500);
                }
                if (number >= 400)
                {
                    return "CD" + ToNumeral(number - 400);
                }
                if (number >= 100)
                {
                    return "C" + ToNumeral(number - 100);
                }
                if (number >= 90)
                {
                    return "XC" + ToNumeral(number - 90);
                }
                if (number >= 50)
                {
                    return "L" + ToNumeral(number - 50);
                }
                if (number >= 40)
                {
                    return "XL" + ToNumeral(number - 40);
                }
                if (number >= 10)
                {
                    return "X" + ToNumeral(number - 10);
                }
                if (number >= 9)
                {
                    return "IX" + ToNumeral(number - 9);
                }
                if (number >= 5)
                {
                    return "V" + ToNumeral(number - 5);
                }
                if (number >= 4)
                {
                    return "IV" + ToNumeral(number - 4);
                }
                if (number >= 1)
                {
                    return "I" + ToNumeral(number - 1);
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Something bad happened");
                }
            }
            return String.Empty;
        }
    }
}

/* Call stack:

Given and input of 2673:

call ToNumeral(1673)
    call ToNumeral(673)
        call ToNumeral(173)
            call ToNumeral(73)
                call ToNumeral(23)
                    call ToNumeral(13)
                        call ToNumeral(3)
                            call ToNumeral(2)
                                call ToNumeral(1)
                                    call ToNumeral(0)
                                        return String.Empty
                                    return I
                                return II
                            return III
                        return XIII    
                    return XXIII                                                   
                return LXXIII
            return CLXXIII
        return DCLXXIII
    return MDCLXXIII
return MMDCLXXIII

*/
