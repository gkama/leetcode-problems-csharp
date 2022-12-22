/*
 * (*)
 */
public static class Solution
{
    public static bool IsValidString(string? s)
    {
        if (string.IsNullOrWhiteSpace(s)) return false;
        if (s.Length <= 1) return false;
        if (s[0] == ')') return false;

        var stack = new Stack<char>();
        stack.Push(s[0]); // first one is either (

        for (var i = 1; i < s.Length; i++)
        {
            if (s[i] == ')')
            {
                var p = stack.Pop();
                if (p != '(') return false;
            }
            else
            { 
                stack.Push(s[i]);
            }
        }

        if (stack.Count > 0) return false;

        return true;
    }

    public static void Examples()
    {
        var exs = new List<string?>
        {
            null,           // false
            " ",            // false
            "",             // false
            ")(",           // false
            "()(())(",      // false
            "(())((())",    // false

            "(())",                 // true
            "()()",                 // true
            "(())()()((()))()(())"  // true
        };

        foreach (var ex in exs)
        {
            Console.WriteLine($"{ex} -> {IsValidString(ex)}");
        }
    }
}
