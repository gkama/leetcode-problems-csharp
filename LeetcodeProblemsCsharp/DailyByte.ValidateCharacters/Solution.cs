/*
 * This question is asked by Google. Given a string only containing the following characters (, ), {, }, [, and ] return whether or not the opening and closing characters are in a valid order.
 * 
 * Ex: Given the following strings...
 * "(){}[]", return true
 * "(({[]}))", return true
 * "{(})", return false
 */
public static class Solution
{
    public static bool IsValidCharacters(string s)
    {
        if (string.IsNullOrWhiteSpace(s)) return false;
        if (IsCloseParenthesis(s[0])) return false;

        var sArray = s.ToCharArray();

        // DS to store is stack
        var stack = new Stack<char>();

        for (var i = 0; i < sArray.Length; i++)
        {
            var value = sArray[i];

            if (IsOpenParenthesis(value))
            {
                stack.Push(value);
            }
            else
            {
                var next = stack.Pop();

                if (GetOpposite(next) != value) return false;
            }
        }

        return true;
    }

    private static bool IsOpenParenthesis(char c)
    {
        return c == '(' || c == '[' || c == '{';
    }

    private static bool IsCloseParenthesis(char c)
    {
        return c == ')' || c == ']' || c == '}';
    }

    private static char GetOpposite(char c)
    {
        switch (c)
        {
            case '(': return ')';
            case '[': return ']';
            case '{': return '}';
            case ')': return '(';
            case ']': return '[';
            case '}': return '{';
            default: throw new ApplicationException($"Not supported '{c}'");
        }
    }

    public static void Examples()
    {
        // With expected result
        var exs = new Dictionary<string, bool>
        {
            { "(){}[]", true },
            { "(({[]}))", true },
            { "()()()(([[{{}}]]))", true },
            { "{(})", false },
            { "}{(})", false }
        };

        foreach (var ex in exs)
        {
            Console.WriteLine($"{ex.Key} -> {IsValidCharacters(ex.Key)} (expected {ex.Value})");
        }
    }
}
