public static class Solution
{
    public static int HammingDistance(int x, int y)
    {
        var xBinary = Convert.ToString(x, 2);
        var yBinary = Convert.ToString(y, 2);
        var xBinaryLength = xBinary.Length;
        var yBinaryLength = yBinary.Length;
        var maxLength = Math.Max(xBinaryLength, yBinaryLength) + 1;

        xBinary = xBinary.PadLeft(maxLength, '0');
        yBinary = yBinary.PadLeft(maxLength, '0');

        Console.WriteLine(xBinary);
        Console.WriteLine(yBinary);

        var hammingDistance = 0;

        for (var i = 0; i < xBinary.Length; i++)
        {
            if (xBinary[i] != yBinary[i])
            {
                hammingDistance += 1;
            }
        }

        return hammingDistance;
    }

    public static void Examples()
    {
        var exs = new List<int[]>()
        {
            new [] { 3, 1 },
            new [] { 1, 4 }
        };

        foreach (var ex in exs)
        {
            Console.WriteLine($"x = {ex[0]}, y = {ex[1]} -> {HammingDistance(ex[0], ex[1])}");
        }
    }
}