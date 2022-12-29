/*
 * Given a string, s, that represents a Roman numeral, return its associated integer value.
 * Note: You may assume that each string represents a valid Roman numeral and its value will not exceed one thousand.
 * Ex: Given the following string s...
 * s = "DCLII", return 652.
 * Ex: Given the following string s...
 * s = "VIII", return 8.
 */

public static class Solution
{
    public static int FromRomanNumerals(string s)
    {
        if (string.IsNullOrWhiteSpace(s)) return 0;

        var num = 0;

        for (var i = 0; i < s.Length; i++)
        {
            // Look ahead if IV, IX, etc.
            if (s[i] == 'I' 
                && i != s.Length - 1
                && (s[i + 1] == 'X' 
                    || s[i + 1] == 'V'))
            {
                num += ToInt($"{s[i]}{s[i + 1]}");
                i++;
            }
            else
            {
                num += ToInt(s[i].ToString());
            }

        }

        return num;
    }

    private static int ToInt(string s) => s switch
    {
        "I" => 1,
        "IV" => 4,
        "V" => 5,
        "VI" => 6,
        "IX" => 9,
        "X" => 10,
        "L" => 50,
        "C" => 100,
        "D" => 500,
        "M" => 1000,
        _ => 0
    };

    public static void Examples()
    {
        var exs = new List<string>
            {
                "DCLII",
                "VIII",
                "IV",
                "XIV",
                "MDCLIX"
            };

        foreach (var ex in exs)
        {
            Console.WriteLine($"{ex} -> {FromRomanNumerals(ex)}");
        }
    }
}
