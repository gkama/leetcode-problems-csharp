using System.Text;

public static class Solution
{
    public static int RomanToInt(string s)
    {
        var romans = new List<string>();
        var ss = new StringBuilder(s);
        int cursor = 0;
        while (ss.Length > 0)
        { 
            if (ss.Length == 1)
            {
                romans.Add($"{ss[cursor]}");
                ss.Remove(cursor, 1);
            }
            else if (ss[cursor] == 'I' && (ss[cursor + 1] == 'V' || ss[cursor + 1] == 'X'))
            {
                romans.Add($"{ss[cursor]}{ss[cursor + 1]}");
                ss.Remove(cursor, 2);
            }
            else if (ss[cursor] == 'X' && (ss[cursor + 1] == 'L' || ss[cursor + 1] == 'C'))
            {
                romans.Add($"{ss[cursor]}{ss[cursor + 1]}");
                ss.Remove(cursor, 2);
            }
            else if (ss[cursor] == 'C' && (ss[cursor + 1] == 'D' || ss[cursor + 1] == 'M'))
            {
                romans.Add($"{ss[cursor]}{ss[cursor + 1]}");
                ss.Remove(cursor, 2);
            }
            else
            {
                romans.Add($"{ss[cursor]}");
                ss.Remove(cursor, 1);
            }
        }

        return romans.Sum(r => GetIntFromRoman(r));
    }

    private static int GetIntFromRoman(string roman)
    {
        return roman switch
        {
            "I" => 1,
            "V" => 5,
            "X" => 10,
            "L" => 50,
            "C" => 100,
            "D" => 500,
            "M" => 1000,
            "IV" => 4,
            "IX" => 9,
            "XL" => 40,
            "XC" => 90,
            "CD" => 400,
            "CM" => 900,
            _ => throw new NotImplementedException($"Not supported roman={roman}")
        };
    }
}