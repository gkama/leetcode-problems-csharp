var exs = new int[]
{
    121,
    123,
    -121,
    10,
    101,
    -1,
    8,
    1001
};

foreach (var ex in exs)
{
    Console.WriteLine($"{ex} = {Solution.IsPalindrome(ex)}");
}