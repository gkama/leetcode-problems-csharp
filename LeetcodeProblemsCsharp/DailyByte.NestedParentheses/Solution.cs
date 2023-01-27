/*
 * Given a string, s, that contains a valid set of parentheses, return the maximum depth of the parentheses seen at any point of the string.
 * Note: For example, “abc”, “()”, and “(()), have depths of zero, one, and two respectively.
 * 
 * Ex: Give the following string s…
 * s = "The(Daily)Byte", return 1.
 * 
 * Ex: Give the following string s…
 * s = ""The(Daily)Byte((Dot)Dev)"", return 2.
 */

public static class Solution
{
    public static int NestedParentheses(string s)
    {
        var stack = new Stack<char>();
        var highest = 0;

        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
            {
                stack.Push(s[i]);
            }
            else if (s[i] == ')')
            {
                highest = Math.Max(stack.Count(), highest);
                stack.Pop();
            }
        }

        return highest;
    }


    public static void Examples()
    {
        var exs = new List<string>
        {
            "The(Daily)Byte",
            "The(Daily)Byte((Dot)Dev)",
            "The(Daily(Byte((Dot)Dev)))",
            "The(Daily(Byte((Dot)Dev))("
        };

        foreach (var ex in exs)
        {
            Console.WriteLine($"{ex} -> {NestedParentheses(ex)}");
        }
    }
}