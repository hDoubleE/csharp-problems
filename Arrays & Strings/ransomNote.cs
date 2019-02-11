// Ransom Note: Given two arrays of strings a ransom note and a magazine, 
// check if ransom note can be created using words in magazine.
// Runtime: O(n+m), Space Complexity: O(n).

class Solution {
    static void checkMagazine(string[] magazine, string[] note) {
        // Check edge case, magazine has fewer words than note.
        if (magazine.Length < note.Length)
        {
            Console.WriteLine("No")
        }
        Dictionary<string, int> table = new Dictionary<string, int>();
        
        // Populate table with key as word in note and value as frequency.
        // O(n)

        for (int i = 0; i < note.Length; i++)
        {
            if(!table.ContainsKey(note[i]))
            {
                table[note[i]] = 1;
            }
            else
            {
                table[note[i]] += 1;
            }
        }

        // Loop magazine. If word in magazine exists in table as key:
        // Decrement table value. If value is 0, remove item from table.
        // O(m)

        for (int i = 0; i < magazine.Length; i++)
        {
            if (table.ContainsKey(magazine[i]))
            {
                table[magazine[i]] -= 1;
            }
            if (table.ContainsKey(magazine[i]) && table[magazine[i]] == 0)
            {
                table.Remove(magazine[i]);
            }
        }

        // If table is empty, return Yes. Else, return No.
        // O(1)

        if (table.Count == 0)
        {
            Console.WriteLine("Yes");
        }
        else {
            Console.WriteLine("No");
        }
    }
}