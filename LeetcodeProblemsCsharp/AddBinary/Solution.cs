public static class Solution
{
    public static string AddBinary(string a, string b)
    {
        /*
        Alg
            iterate through digits
            if 1 + 1 = 0, carryover 1
            if 1 + 0 = 1
            if 0 + 0 = 0
        */

        var indexA = a.Length - 1;
        var indexB = b.Length - 1;
        var sum = 0;
        var result = "";

        while (indexA >= 0 || indexB >= 0 || sum == 1)
        {
            if (indexA >= 0)
            {
                sum += a[indexA] - '0';
            }
            else
            {
                sum += 0;
            }

            if (indexB >= 0)
            {
                sum += b[indexB] - '0';
            }
            else
            {
                sum += 0;
            }

            result = (char)(sum % 2 + '0') + result;

            sum /= 2;

            indexA--;
            indexB--;
        }

        return result;
    }
}
