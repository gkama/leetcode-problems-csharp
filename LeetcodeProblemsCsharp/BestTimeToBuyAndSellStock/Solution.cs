// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
public static class Solution
{
    /*
     * Alg
     *      keep track of lowest with each iteration
     *      check if current - lowest is bigger than profit
     *      if so, set profit to prices[i] - lowest
     *          essentially, keep track of profit
     *      once ran, O(n), return profit
     */
    public static int MaxProfit(int[] prices)
    {
        var lowest = int.MaxValue;
        var profit = 0;

        for (var i = 0; i < prices.Length; i++)
        {
            if (prices[i] < lowest)
            {
                lowest = prices[i];
            }
            else if (prices[i] - lowest > profit)
            {
                profit = prices[i] - lowest;
            }
        }

        return profit;
    }
}
