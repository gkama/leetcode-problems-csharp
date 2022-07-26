// https://leetcode.com/problems/fizz-buzz/

public static class Solution
{
    public static IList<string> FizzBuzz(int n)
    {
        var res = new List<string>();

        for (var i = 1; i <= n; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
                res.Add("FizzBuzz");
            else if (i % 3 == 0)
                res.Add("Fizz");
            else if (i % 5 == 0)
                res.Add("Buzz");
            else
                res.Add(i.ToString());
        }

        return res;
    }
}
