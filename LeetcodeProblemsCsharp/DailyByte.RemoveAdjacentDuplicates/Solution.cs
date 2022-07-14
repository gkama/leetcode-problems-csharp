/*
 * This question is asked by Facebook. Given a string s containing only lowercase letters, continuously remove adjacent characters that are the same and return the result.
 * 
 * Ex: Given the following strings...
 * s = "abccba", return ""
 * s = "foobar", return "fbar"
 * s = "abccbefggfe", return "a"
 */
public class Solution
{
    public static string? RemoveAdjacentDuplicates(string s)
    {
        if (string.IsNullOrWhiteSpace(s)) return null;

        return RemoveAdjacentDuplicatesV1(s);
    }

    // O(n)
    private static string? RemoveAdjacentDuplicatesV1(string s)
    {
        var stack = new Stack<string>();

        for (var i = 0; i < s.Length; i++)
        {
            var value = s[i].ToString();

            if (stack.Count() > 0 && stack.Peek() == value)
            {
                stack.Pop();
            }
            else
            {
                stack.Push(value);
            }
        }

        // Create string from stack
        var resultArray = new string[stack.Count()];
        var resultArrayIndex = 0;
        var result = new System.Text.StringBuilder();

        while (stack.Count() > 0)
        {
            resultArray[resultArrayIndex] = stack.Pop();
            resultArrayIndex++;
        }

        Array.Reverse(resultArray);

        // Compile string from array
        for (var j = 0; j < resultArray.Length; j++)
        {
            result.Append(resultArray[j]);
        }

        return result.ToString();
    }

    // O(2n)
    // Doesn't work?
    private static string? RemoveAdjacentDuplicatesV2(string s)
    {
        var dict = new Dictionary<string, int>();

        for (var i = 0; i < s.Length; i++)
        {
            var value = s[i].ToString();

            if (dict.ContainsKey(value)) dict[value] += 1;
            else dict.Add(value, 1);
        }

        // If odd, add it
        var result = new System.Text.StringBuilder();

        foreach (var kv in dict)
        {
            if (kv.Value % 2 == 1) result.Append(kv.Key);
        }

        return result.ToString();
    }

    public static void Examples()
    {
        var exs = new List<string>
        {
            "abccba",
            "foobar",
            "abccbefggfe",
            "abcabba",
            "abcabccbacba"
        };

        foreach (var ex in exs)
        {
            Console.WriteLine($"{ex} -> {RemoveAdjacentDuplicates(ex)}");
        }
    }
}
