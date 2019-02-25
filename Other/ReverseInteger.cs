
public class Solution
{
    public int Reverse(int x)
    {
        int rev = 0;
        while (x != 0)
        {
            int pop = x % 10;
            x /= 10;

            if (rev > int.MaxValue / 10 || (rev == int.MaxValue / 10 && pop > 7))
            {
                return 0;
            }

            if (rev < int.MinValue / 10 || (rev == int.MinValue / 10 && pop < -8))
            {
                return 0;
            }

            rev = (rev * 10) + pop; // push
        }
        return rev;
    }
    public int Reverse(int x)
    {
        long res = 0;
        while (x != 0)
        {
            res = (x % 10) + (res * 10);
            if (res > Int32.MaxValue || res < Int32.MinValue) return 0;
            x /= 10;
        }
        return (int)res;
    }
}
