// https://leetcode.com/problems/plus-one/
public static class Solution
{
    /*
     * Alg
     *      option 1
     *          we shouldn't convert to an int because it's too big
     *          need to look out for carryover
     *          if it's just a regular increment then take the last digit, increment it by one and put it back
     *          if it's with a carryover (when digits[len - 1] == 9), then we make it a 0 and increment the previous
     *              this could happen continously and we'll need to keep carrying over because the digits could be [9, 9, 9, 9] -> [1, 0, 0, 0, 0]
     */
    public static int[] PlusOne(int[] digits)
    {
        var len = digits.Length;

        // Base case
        if (digits[len - 1] != 9)
        {
            digits[len - 1] = digits[len - 1] + 1;
            return digits;
        }

        // Carryover
        // Option 1. Iterative
        // Option 2. Recursive
        var carryover = 0;
        var toAdd = 1;
        for (var i = len - 1; i >= 0; i--)
        {
            digits[i] = digits[i] + toAdd + carryover;

            if (digits[i] == 10)
            {
                digits[i] = 0;
                carryover = 1;
                toAdd = 0;
            }
            else
            {
                carryover = 0;
                toAdd = 0;
            }
        }

        // Since no leading 0's, we can assume that if digits[0] == 0,
        // then there must be a carryover of 1, and we must insert 1 at the beginning and grow the array by 1
        if (carryover == 1)
        {
            var digitsToReturn = new int[len + 1];
            digitsToReturn[0] = carryover;

            for (var j = 1; j < digitsToReturn.Length; j++)
            {
                digitsToReturn[j] = digits[j - 1];
            }

            return digitsToReturn;
        }

        return digits;
    }
}
