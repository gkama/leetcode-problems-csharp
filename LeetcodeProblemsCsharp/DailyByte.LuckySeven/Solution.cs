/*
 * Given an integer, num, return its base seven representation as a string.
 * 
 * Ex: Given the following num...
 * num = 42, return “60”.
 * 
 * Ex: Given the following num...
 * num = 50, return "
 */

public static class Solution
{
    public static string LuckySeven(int num)
    {
        var luckySeven = new System.Text.StringBuilder();
        var remainder = num;

        while (remainder != 0)
        {
            if (remainder < 7)
            {
                luckySeven.Append(remainder);
                break;
            }

            var t = remainder / 7;

            luckySeven.Append(t);

            remainder = num % 7; 
        }

        return luckySeven.ToString();
    }

    public static void Examples()
    {
        var exs = new List<int>()
        {
            //42,
            50
        };

        foreach (var ex in exs)
        {
            Console.WriteLine($"{ex} -> {LuckySeven(ex)}");
        }
    }
}