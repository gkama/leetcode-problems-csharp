var exs = new List<string>
{
    "a ",
    "Hello World",
    "   fly me   to   the moon  ",
    "luffy is still joyboy",
    "     ",
    " ",
    "                 fly me         "
};

foreach (var ex in exs)
{
    Console.WriteLine($"{ex} -> {Solution.LengthOfLastWord2(ex)}");
}