// Write an efficient function to find the first nonrepeated character
// in a string. Example: "total", return: 'o'. "teeter", return 'r'.
// O(2n) -> O(n) 

/*
  First pass, build the character count Hash Table
    Foreach character
        If no value os stored in Hash Table
            Add to table and set to 1
            Otherwise, increment by 1
  Second pass, scan the string again
    Foreach character
        Return character if count is 1
    If no characters have 1, return null


 */
namespace NonDuplicate
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FirstNonDuplicateArray("total"));
            Console.WriteLine(FirstNonDuplicateDict("teeter"));
        }
        public static char FirstNonDuplicateArray(string s)
        {
            int[] arr = new int[255];
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                arr[c]++;
            }
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (arr[c] == 1)
                {
                    return c;
                }
            }
            return char.MaxValue; // char.MaxValue == ?
        }

        public static char FirstNonDuplicateDict(string s)
        {
            if (s == string.Empty)
            {
                return char.MaxValue;
            }

            Dictionary<char, int> table = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (!table.ContainsKey(s[i]))
                {
                    table[s[i]] = 1;
                }
                else
                {
                    table[s[i]] += 1;
                }
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (table[s[i]] == 1)
                {
                    return s[i];
                }
            }
            return char.MaxValue;
        }
    }
}


