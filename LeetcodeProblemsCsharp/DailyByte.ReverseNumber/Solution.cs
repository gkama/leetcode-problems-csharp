/*
 * This question is asked by Apple. Given a 32 bit signed integer, reverse it and return the result.
 * Note: You may assume that the reversed integer will always fit within the bounds of the integer data type.
 * 
 * Ex: Given the following integer num…
 * num = 550, return 55
 * 
 * Ex: Given the following integer num…
 * num = -37, return -73
 */
public static class Solution
{
    public static int ReverseNumber(int num)
    {
        var isNegative = num < 0;
        var reversedInt = new System.Text.StringBuilder();
        var absNum = Math.Abs(num);
        var absNumStr = absNum.ToString();

        for (var i = absNumStr.Length - 1; i >= 0; i--)
        {
            reversedInt.Append(absNumStr[i]);
        }

        return Convert.ToInt32(reversedInt.ToString()) * (isNegative ? -1 : 1);
    }

    public static void Examples()
    {
        var exs = new List<int>
        {
            550,
            55,
            -37,
            -110,
            0101
        };

        foreach (var ex in exs)
        {
            Console.WriteLine($"{ex} -> {ReverseNumber(ex)}");
        }
    }
}
