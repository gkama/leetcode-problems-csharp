// From DailyByte
public static class Solution
{
    public static string ReverString(string s)
    {
        if (string.IsNullOrWhiteSpace(s))
        {
            return s;
        }
        
        var size = s.Length;
        var sArray = s.ToCharArray();
        var mid = size / 2;

        var j = size - 1;
        for (var i = 0; i < mid; i++)
        {
            var temp = sArray[i];
            sArray[i] = sArray[j];
            sArray[j] = temp;
            j--;
        }

        return new string(sArray);
    }

    public static void PrintExamples()
    {
        var exs = new List<string>
        {
            "Cat",
            "The Daily Byte",
            "civic",
            "TEST"
        };

        foreach (var ex in exs)
        {
            Console.WriteLine($"{ex} -> {ReverString(ex)}");
        }
    }
}
