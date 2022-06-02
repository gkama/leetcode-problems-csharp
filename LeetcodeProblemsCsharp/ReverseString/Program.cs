var examples = new string[]
{
    "abcdefg"
};

foreach (var example in examples)
{
    Console.WriteLine($"{example} = {Solution.ReverseStr(example, 2)}");
}
