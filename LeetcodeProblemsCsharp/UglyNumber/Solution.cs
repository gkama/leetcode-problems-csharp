// https://leetcode.com/problems/ugly-number/description/
public static class Solution
{
    public static bool IsUgly(int n)
    {
        if (n < 1) return false;

        while (n > 1)
        {
            if (n % 2 == 0) n = n / 2;
            else if (n % 3 == 0) n = n / 3;
            else if (n % 5 == 0) n = n / 5;
            else return false;
        }
        return true;
    }

    public static void Examples()
    {
        var exs = new List<int>
        {
            6, 1, 14, 234
        };

        foreach (var ex in exs)
        {
            Console.WriteLine($"{ex} = {IsUgly(ex)}");
        }
    }
}