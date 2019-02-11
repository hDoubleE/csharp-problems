// Design an algorithm that takes an array of integers (prices) and an integer (units of money). 
// The array represent prices of various items, the integer is the money you have. 
// Return the maximum number of items you can purchase from array. 

// If input 

using System;

namespace Purchase
{
    public class Program
    {
        static void Main()
        {
            int[] prices = { 12, 43, 5, 76, 42, 6 };
            int wallet = 92;
            Console.WriteLine(Transaction.Purchase(prices, wallet));
        }
    }

    public class Transaction
    {
        public static int Purchase(int[] prices, int m)
        {
            Array.Sort(prices);
            int count = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] <= m)
                {
                    count++;
                    m -= prices[i];
                }
            }
            return count;
        }
    }
}