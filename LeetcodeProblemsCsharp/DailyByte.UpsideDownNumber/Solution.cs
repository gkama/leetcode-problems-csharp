/*
 * Given an string, num that represents the string form of an integer, return whether or not the number looks the same when turned upside-down.
 * 
 * Ex: Given the following num...
 * num = “0”, return true.
 * 
 * Ex: Given the following num...
 * num = “96”, return true.
 * 
 * Ex: Given the following num...
 * num = “003821”, return false.
 */

public static class Solution
{
    public static bool IsUpsideDown(string num)
    {
        /*
         * 0, 1 and 8 rotate to themselves
         * 2 and 5 rotate to each other
         * 6 and 9 rotate to each other
         */
        for (var i = 0; i < num.Length; i++)
        {
            // Look ahead
            if (i <= num.Length - 2)
            {
                if (num[i] == '6' && num[i + 1] == '9'
                    || num[i] == '9' && num[i + 1] == '6')
                {
                    i++;        // Skip the next digit
                    continue;
                }
                else if (num[i] == '2' && num[i + 1] == '5'
                    || num[i] == '5' && num[i + 1] == '2')
                {
                    i++;        // Skip the next digit
                    continue;
                }
            }

            if (num[i] == '0' || num[i] == '1' || num[i] == '8')
            {
                continue;
            }
            else
            {
                return false;
            }
        }

        return true;
    }

    public static void Examples()
    {
        var exs = new List<string>()
        {
            "0",        // True
            "96",       // True
            "69",       // True
            "25",       // True
            "52",       // True
            "003821",   // False
            "00255269", // True
        };

        foreach (var ex in exs)
        {
            Console.WriteLine($"{ex} -> {IsUpsideDown(ex)}");
        }
    }
}