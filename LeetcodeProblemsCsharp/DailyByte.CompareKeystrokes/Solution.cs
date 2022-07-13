/*
 * This question is asked by Amazon. Given two strings s and t, which represents a sequence of keystrokes, where # denotes a backspace, return whether or not the sequences produce the same result.
 * 
 * Ex: Given the following strings...
 * s = "ABC#", t = "CD##AB", return true
 * s = "como#pur#ter", t = "computer", return true
 * s = "cof#dim#ng", t = "code", return false
 */
public static class Solution
{
    public static bool CompareKeystrokes(string s, string t)
    {
        // Keep 2 stacks and pop everytime you see a #
        // Once you have exhausted the 2 string arrays, check if they are equal by combining the stacks
        var sStack = new Stack<string>();
        var tStack = new Stack<string>();

        // s
        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] != '#') sStack.Push(s[i].ToString());
            else sStack.Pop();
        }

        // t
        for (var i = 0; i < t.Length; i++)
        {
            if (t[i] != '#') tStack.Push(t[i].ToString());
            else tStack.Pop();
        }

        // Create strings back up from the stacks
        var sStringBuilder = new System.Text.StringBuilder();
        var tStringBuilder = new System.Text.StringBuilder();

        // s stack
        while (sStack.Count() != 0)
        {
            sStringBuilder.Append(sStack.Pop());
        }

        // t stack
        while (tStack.Count() != 0)
        {
            tStringBuilder.Append(tStack.Pop());
        }

        return sStringBuilder.ToString() == tStringBuilder.ToString();
    }

    public static void Examples()
    {
        var exs = new Dictionary<string, string>
        {
            { "ABC#", "CD##AB" },
            { "como#pur#ter", "computer" },
            { "cof#dim#ng", "code" },
            { "abc##aa#", "aa##aa" }
        };

        foreach (var ex in exs)
        {
            Console.WriteLine($"{ex.Key} and {ex.Value} -> {CompareKeystrokes(ex.Key, ex.Value)}");
        }
    }
}
