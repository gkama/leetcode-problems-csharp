// https://leetcode.com/problems/reverse-string/
public static class Solution
{
    /*
    Alg
        start 0 to middle
            if length is even, right in the middle
            if length is odd, middle - 1 (still length / 2 because of int division)
        swap elements from both sides
        increment / decrement both sides
    */
    public static void ReverseString(char[] s)
    {
        if (s == null) return;

        var sLength = s.Length;

        if (sLength == 1) return;

        var mid = sLength % 2 == 0
            ? sLength / 2
            : (sLength - 1) / 2;
        var j = sLength - 1;

        for (var i = 0; i < mid; i++)
        {
            var temp = s[i];
            s[i] = s[j];
            s[j] = temp;
            j--;
        }
    }
}