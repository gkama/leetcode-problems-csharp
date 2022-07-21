// https://leetcode.com/problems/integer-to-roman/
public static class Solution
{
    public static string IntToRoman(int num)
    {
        // How many of each
        var combination = new Dictionary<int, int>();

        if (num >= 1000)
        {
            combination.Add(1000, num / 1000);
            num = num % 1000;
        }

        // 900
        if (num >= 900)
        {
            combination.Add(900, num / 900);
            num = num % 900;
        }


        if (num >= 500)
        {
            combination.Add(500, num / 500);
            num = num % 500;
        }

        // 400
        if (num >= 400)
        {
            combination.Add(400, num / 400);
            num = num % 400;
        }

        if (num >= 100)
        {
            combination.Add(100, num / 100);
            num = num % 100;
        }

        // 90
        if (num >= 90)
        {
            combination.Add(90, num / 90);
            num = num % 90;
        }

        if (num >= 50)
        {
            combination.Add(50, num / 50);
            num = num % 50;
        }

        // 40
        if (num >= 40)
        {
            combination.Add(40, num / 40);
            num = num % 40;
        }

        if (num >= 10)
        {
            combination.Add(10, num / 10);
            num = num % 10;
        }

        // 9
        if (num >= 9)
        {
            combination.Add(9, num / 9);
            num = num % 9;
        }

        if (num >= 5)
        {
            combination.Add(5, num / 5);
            num = num % 5;
        }

        // 4
        if (num >= 4)
        {
            combination.Add(4, num / 4);
            num = num % 4;
        }

        if (num < 4)
            combination.Add(1, num);

        Print(combination);

        var result = new System.Text.StringBuilder();

        foreach (var kv in combination)
        {
            for (var i = 0; i < kv.Value; i++)
                result.Append(GetRoman(kv.Key));
        }

        return result.ToString();
    }

    private static string GetRoman(int n)
    {
        switch (n)
        {
            case 1: return "I";
            case 4: return "IV";
            case 5: return "V";
            case 9: return "IX";
            case 10: return "X";
            case 40: return "XL";
            case 50: return "L";
            case 90: return "XC";
            case 100: return "C";
            case 400: return "CD";
            case 500: return "D";
            case 900: return "CM";
            case 1000: return "M";
            default: throw new NotImplementedException();
        }
    }

    private static void Print(Dictionary<int, int> combination)
    {
        foreach (var kv in combination)
        {
            Console.WriteLine($"{kv.Key} -> {kv.Value}");
        }
    }
}