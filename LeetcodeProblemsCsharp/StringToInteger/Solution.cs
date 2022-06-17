// https://leetcode.com/problems/string-to-integer-atoi/
public static class Solution
{
    /*
    Alg
        1. TrimStart(' ')
        2. Check for '+' or '-'. If netiher than it's positive
        3. Keep reading until the next non-digit char or end of string
        4. Convert these digits into an integer
            if not digits, return 0
        5. Check if it's within the Int32 range
        6. Return it
    */
    public static int MyAtoi(string s)
    {
        if (string.IsNullOrWhiteSpace(s)) return 0;

        var digits = "1,2,3,4,5,6,7,8,9,0".Split(",");
        var sTrimmed = s.TrimStart(' ');
        Console.WriteLine(sTrimmed);
        var sTrimmedSign = sTrimmed[0];
        var isNegative = false;

        if (sTrimmedSign == '-')
        {
            isNegative = true;
        }

        // Check if after the sign, it's a valid number
        // the character after is a digit
        if (sTrimmed.Length >= 2)
        {
            if ((sTrimmed[0] == '-' || sTrimmed[0] == '+')
               && !digits.Contains(sTrimmed[1].ToString()))
            {
                Console.WriteLine("Not a real number");
                return 0;
            }
        }

        sTrimmed = sTrimmed.TrimStart('-');
        sTrimmed = sTrimmed.TrimStart('+');

        var sTrimmedLength = sTrimmed.Length;
        var sDigits = new List<int>();

        for (var i = 0; i < sTrimmedLength; i++)
        {
            var value = sTrimmed[i].ToString();
            Console.WriteLine(value);
            if (digits.Contains(value))
            {
                sDigits.Add(int.Parse(value));
            }
            else
            {
                break;
            }
        }

        if (sDigits.Count() < 1)
        {
            return 0;
        }

        var sDigitsStr = string.Join("", sDigits);
        Console.WriteLine(sDigitsStr);

        try
        {
            var parsedInt = int.Parse(sDigitsStr);
            return isNegative ? parsedInt * -1 : parsedInt;
        }
        catch (Exception)
        {
            if (isNegative)
            {
                return int.MinValue;
            }
            else
            {
                return int.MaxValue;
            }
        }
    }
}