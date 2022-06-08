var exs = new Dictionary<string, string>
{
    { "hello", "ll" },
    { "aaaaa", "bba" },
    { "abcabc", "abc" },
    { "aaabb", "bb" }
};


foreach (var ex in exs)
{
    var res = Solution.StrStr(ex.Key, ex.Value);

    Console.WriteLine($"{ex.Value} in {ex.Key} -> {res}");
}