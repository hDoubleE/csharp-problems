using System;

namespace Problems
{
    public class Program
    {
        static void Main()
        {
            
        }
        static int minimumSwaps(int[] arr)
        {
            int swaps = 0;
            int i = 0;
            while (i < arr.Length)
            {
                if (!ValueMatchIndex(arr, i))
                {
                    ++swaps;
                    SwapValueToMatchIndex(arr, i, arr[i] - 1);
                }
                else
                {
                    ++i;
                }
            }
            return swaps;
        }
        static bool ValueMatchIndex(int[] arr, int i)
        {
            return arr[i] == i + 1;
        }
        static void SwapValueToMatchIndex(
            int[] arr, int wrongIndex, int correctIndex)
        {
            int temp = arr[wrongIndex];
            arr[wrongIndex] = arr[correctIndex];
            arr[correctIndex] = temp;
        }
    }
}