﻿
/*
 * You are given the list of prices of a particular stock. Each element in the array represents the price of the stock at a given second throughout the current day. Return the maximum profit you can make trading this stock.
 * Note: You may only ever buy and sell a single share of the stock, but you may make multiple transactions (i.e. buys and sells).
 * Ex: Given the following prices...
 * 
 * prices = [8, 3, 2, 4, 6, 4, 5], return 5.
 */
public static class Solution
{
    public static int MaximumProfitV1(int[] prices)
    {
        var maximumProfit = 0;
        var pricesLength = prices.Length;

        Recursive(0);

        void Recursive(int startingIndex = 0)
        {
            if (startingIndex >= pricesLength - 1) return;

            var sellingValue = 0;
            var sellingIndex = startingIndex;

            for (var i = startingIndex; i < pricesLength; i++)
            {
                for (var j = i + 1; j < pricesLength; j++)
                {
                    var iPrice = prices[i];
                    var jPrice = prices[j];
                    var diff = jPrice - iPrice;

                    if (diff > 0 && diff > sellingValue)
                    {
                        sellingValue = diff;
                        sellingIndex = j;
                    }

                    if (maximumProfit == 0 && sellingValue == 0 && i == pricesLength - 2 && j == pricesLength - 1) return;
                }
            }

            maximumProfit += sellingValue;

            if (sellingValue == 0) sellingIndex += 1;

            Recursive(sellingIndex);
        }

        return maximumProfit;
    }

    public static int MaximumProfitV2(int[] prices)
    {
        var maximumProfit = 0;
        var pricesAndLocations = new Dictionary<int, int>();

        for (var i = 0; i < prices.Length; i++) pricesAndLocations.Add(i, prices[i]);



        return maximumProfit;
    }

    public static void Examples()
    {
        var exs = new List<int[]>
        {
            new int[] { 8, 3, 2, 4, 6, 4, 5 },
            new int[] { 8, 9, 10, 11, 12, 13, 14 },
            new int[] { 14, 13, 12, 11, 10, 9, 8 },
            new int[] { 14, 13, 12, 11, 10, 14, 8 },
            new int[] { 1, 5, 1, 5, 1, 5, 1 }
        };

        foreach (var ex in exs)
        {
            Console.WriteLine($"[{string.Join(',', ex)}] -> {MaximumProfitV1(ex)}");
        }
    }
}
