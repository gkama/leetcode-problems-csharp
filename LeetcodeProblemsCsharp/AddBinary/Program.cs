var exs = new Dictionary<string, string>
{
    { "11", "1" },
    { "1010", "1011" },
};

foreach (var ex in exs)
{
    Console.WriteLine($"{ex.Key} + {ex.Value} -> {Solution.AddBinary(ex.Key, ex.Value)}");
}