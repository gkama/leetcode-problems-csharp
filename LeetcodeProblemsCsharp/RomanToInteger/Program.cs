var examples = new string[]
{
    "III",
    "LVIII",
    "MCMXCIV",
    "LIII",
    "CCLXIV",
    "DCCLXXIV",
    "DCVIII",
    "CDLII",
    "XXIV",
    "CCCLXXXII",
    "CVI",
    "LXIII",
    "CCXCII"
};

foreach (var example in examples)
{
    Console.WriteLine($"{example} = {Solution.RomanToInt(example)}");
}
