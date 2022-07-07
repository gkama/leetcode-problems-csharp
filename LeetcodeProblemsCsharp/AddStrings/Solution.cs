// https://leetcode.com/problems/add-strings/
public static class Solution
{
    public static string AddStrings(string num1, string num2)
    {
        if (string.IsNullOrWhiteSpace(num1) && string.IsNullOrWhiteSpace(num2)) return null;
        if (string.IsNullOrWhiteSpace(num1)) return num2;
        if (string.IsNullOrWhiteSpace(num2)) return num1;

        // Start from end, add each digits and check for carryover
        //  start from the smaller number
        var carryOver = 0;

        var num1CharArray = num1.ToCharArray();
        var num2CharArray = num2.ToCharArray();

        // Keep 2 indexes
        var indexNum1 = num1CharArray.Length - 1;
        var indexNum2 = num2CharArray.Length - 1;

        // Bigger index for creating the array
        var sumIndex = indexNum1 >= indexNum2 ? indexNum1 : indexNum2;

        // Result
        var sum = new string[sumIndex + 1];

        // Start at the end and move forward
        while (indexNum1 >= 0 || indexNum2 >= 0)
        {
            var num1Digit = indexNum1 >= 0 ? (int)Char.GetNumericValue(num1CharArray[indexNum1]) : 0;
            var num2Digit = indexNum2 >= 0 ? (int)Char.GetNumericValue(num2CharArray[indexNum2]) : 0;
            var sumDigit = num1Digit + num2Digit + carryOver;

            if (sumDigit >= 10)
            {
                carryOver = 1;
                sumDigit = sumDigit - 10;
            }
            else
            {
                carryOver = 0;
            }

            sum[sumIndex] = sumDigit.ToString();

            Console.WriteLine($"{sum[sumIndex]}");

            sumIndex--;
            indexNum1--;
            indexNum2--;
        }

        // edge case of carryOver = 1

        return carryOver == 1 ? $"{carryOver}{string.Join("", sum)}" : string.Join("", sum);
    }
}