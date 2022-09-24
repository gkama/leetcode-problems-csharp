/*
 * This question is asked by Facebook. Given two integers x and y, return the hamming distance between the two numbers.
 * Note: The hamming distance between two numbers is the number of bit positions in which the bits differ.
 * 
 * Ex: Given the following integers x and y…
 * x = 2, y = 4, return 2.
 * 2 in binary is 0 0 1 0
 * 4 in binary is 0 1 0 0
 * therefore the number of positions in which the bits differ is two.
 */
public static class Solution
{
    public static int HammingDistance(int x, int y)
    {
        var xBinary = Convert.ToString(x, 2);
        var yBinary = Convert.ToString(y, 2);
        var xBinaryLength = xBinary.Length;
        var yBinaryLength = yBinary.Length;
        var hammingDistance = 0;

        var sizeToFillOut = Math.Max(xBinaryLength, yBinaryLength) + 1;
        var iteration = sizeToFillOut;

        xBinary = xBinary.PadLeft(sizeToFillOut, '0');
        yBinary = yBinary.PadLeft(sizeToFillOut, '0');

        for (var i = iteration - 1; i >= 0; i--)
        {
            if (xBinary[i] != yBinary[i]) hammingDistance++;
        }

        return hammingDistance;
    }

    public static void Examples()
    {
        var exs = new List<int[]>
        {
            new int[] { 2, 4 },
            new int[] { 156, 4 },
            new int[] { 2, 234 },
            new int[] { 136, 1367 },
        };

        foreach (var ex in exs)
        {
            Console.WriteLine($"{ex[0]}, {ex[1]} -> {HammingDistance(ex[0], ex[1])}");
        }
    }
}
