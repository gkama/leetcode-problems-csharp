/*
 * You are typing on a broken keyboard trying to spell your friend’s name. Since the keyboard is broken, sometimes when you press a key the key is typed one or more times.
 * Given a string typed and a string name return whether or not you’ve successfully typed your friend’s name even though certain keys might be repeated.
 * Note: Both strings will only contain lowercase alphabetical characters.
 * 
 * Ex: Given the following typed and name…
 * typed = "kkevin", name = "kevin", return true.
 * 
 * Ex: Given the following typed and name…
 * typed = "timmm", name = "timmy", return false.
 */
using System.Text;

public static class Solution
{
    public static bool CanBeTypedV1(string typed, string name)
    {
        if (string.IsNullOrWhiteSpace(typed)) return false;
        if (string.IsNullOrWhiteSpace(name)) return false;

        // Remove duplicates in typed
        var j = 0;
        var twice = 0;
        var typedWithoutDuplicates = new StringBuilder();
        typedWithoutDuplicates.Append(name[0]);

        for (var i = 0; i < typed.Length; i++)
        {
            if (typedWithoutDuplicates[j] != typed[i] && twice != 2)
            {
                typedWithoutDuplicates.Append(typed[i]);
                j++;
            }
            else if (typedWithoutDuplicates[j] == typed[i] && twice == 2)
            {
                typedWithoutDuplicates.Append(typed[i]);
                j++;
                twice = 0;
            }
            else if (typedWithoutDuplicates[j] != typed[i])
            {
                twice++;
            }
        }

        return typedWithoutDuplicates.ToString() == name;
    }

    public static void Examples()
    {
        var exs = new Dictionary<string, string>()
        {
            { "kkevin", "kevin" },
            { "kkeevviin", "kevin" },
            { "timmm", "timmy" },
            { "timmmmy", "timmy" },
        };

        foreach (var ex in exs)
        {
            Console.WriteLine($"typed = '{ex.Key}', name = '{ex.Value}' return {CanBeTypedV1(ex.Key, ex.Value)}");
        }
    }
}