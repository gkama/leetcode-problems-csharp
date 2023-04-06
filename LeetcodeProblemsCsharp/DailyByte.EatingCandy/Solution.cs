/*
 * You are given a certain number of candies and an exchange rate. For every exchange number of candy wrappers that you trade in, you receive an additional candy. Return the maximum number of candies that you can eat.
 * Note: Each candy is wrapped in a candy wrapped.
 * 
 * Ex: Given the following candies and exchange…
 * candies = 3, exchange = 3, return 4 (each your three candies, exchange 3 wrappers, each additional candy).
 * 
 * Ex: Given the following candies and exchange…
 * candies = 3, exchange = 4, return 3.
 */
public static class Solution
{
    public static int MaximumCandies(int candies, int exchange)
    {
        if (exchange > candies) return candies;

        // How many times does exchange go into candies?
        var exchangeIntoCandies = candies / exchange;

        return candies + exchangeIntoCandies;
    }

    public static void Examples()
    {
        var exs = new List<Request>
        {
            new Request { Candies = 3, Exchange = 3 },
            new Request { Candies = 3, Exchange = 4 },
            new Request { Candies = 5, Exchange = 1 },
            new Request { Candies = 5, Exchange = 2 }
        };

        foreach (var ex in exs)
        {
            Console.WriteLine($"candies = {ex.Candies}, exchange = {ex.Exchange}, maximum candies = {MaximumCandies(ex.Candies, ex.Exchange)}");
        }
    }

    private class Request
    {
        public int Candies { get; init; }
        public int Exchange { get; init; }
    }
}