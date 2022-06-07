var exs = new List<string[]>
{
    new string [] { "flower", "flow", "flight" },
    new string [] { "flower", "flow", "flowe" },
    new string [] { "dog", "racecar", "car" },
    new string [] { },
    new string [] { "dog" },
    new string [] { "abcde", "bbcde", "cbcde" },
    new string [] { "abcd", "abcd", "abcd" },
    new string [] { "flower", "flow", "flight", "flower", "flow", "flight", "flower", "flow", "flight", "flower", "flow", "flight" },
};


foreach (var ex in exs)
{
    Console.WriteLine($"{string.Join(", ", ex)} -> {Solution.LongestCommonPrefix(ex)}");
}