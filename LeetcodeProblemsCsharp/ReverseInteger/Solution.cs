// https://leetcode.com/problems/reverse-integer/
public static class Solution
{
    /*
    Alg
        check for int.MinValue and int.Max value
            if outside the bounds return 0
        check if it's negative, the just add it to the end
        if it's starts with 0, ignore that one and any subsequent ones
            trim (0's)
    */
    public static int Reverse(int x)
    {
        var xStr = x.ToString();
        var xStrLength = xStr.Length;

        if (xStrLength == 1) return x;

        // Check if it's negative
        // if so, remove the - sign and add it add the end
        var isNegative = x < 0;
        if (isNegative)
        {
            xStr = xStr.TrimStart('-');
        }

        var xStrTrimmed = xStr.TrimEnd('0');
        var xStrTrimmedLength = xStrTrimmed.Length;

        var xReversedArray = new int[xStrTrimmedLength];

        var j = 0;
        for (var i = xStrTrimmedLength - 1; i >= 0; i--)
        {
            xReversedArray[j] = int.Parse(xStrTrimmed[i].ToString());
            j++;
        }

        var xReversedStr = string.Join("", xReversedArray);
        Console.WriteLine(xReversedStr);

        try
        {
            var xReversed = Convert.ToInt32(xReversedStr);

            return isNegative ? xReversed * -1 : xReversed;
        }
        catch (Exception e)
        {
            return 0;
        };
    }
}