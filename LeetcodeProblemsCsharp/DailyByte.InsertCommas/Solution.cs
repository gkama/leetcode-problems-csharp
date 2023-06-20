using System.Text;

public static class Solution
{
    public static string InsertCommas(int n)
    {
        var nStr = n.ToString();
        var commaCount = 1;

        for (var i = nStr.Length - 1; i >= 0; i--)
        {
            if (commaCount == 3 && i != 0)
            {
                nStr = nStr.Insert(i, ",");
                commaCount = 1;
            }
            else
            {
                commaCount++;
            }
        }

        return nStr;
    }

    public static void Examples()
    {
        var exs = new List<int>
        {
            200000000, 5000, 100, 1000, 10000, 100000, 1000000, 10000000
        };

        foreach (var ex in exs)
        {
            Console.WriteLine($"N = {ex}, return '{InsertCommas(ex)}'");
        }
    }
}