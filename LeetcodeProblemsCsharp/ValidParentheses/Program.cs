var exs = new List<string>
{
    "()",
    "()[]{}",
    "(]",
    "()[]{",
    "()[]((",
    "[][][][][][",
    "[][][][][][]",
    "{[]}"
};


foreach (var ex in exs)
{
    Console.WriteLine($"{ex} -> {Solution.IsValid(ex)}");
}