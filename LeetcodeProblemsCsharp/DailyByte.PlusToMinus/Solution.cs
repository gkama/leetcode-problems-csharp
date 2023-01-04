/*
 * You are playing a game with a friend. In this game you’re given a string s and you and your friend take turns making moves. 
 * A move consists of flipping two consecutive + signs into - signs. Given a string s, return a list containing all possible states of s after you’ve made the first move.
 * 
 * Ex: Given the following string s...
 * s = “++”, return [“—-“].
 * 
 * Ex: Given the following string s...
 * s = “++++”, return ["--++","+--+","++--"].
 */

public static class Solution
{
    public static List<string> PlusToMinus(string s)
    {
        var plusToMinusArray = new List<string>();

        if (string.IsNullOrWhiteSpace(s)) return plusToMinusArray;

        for (var i = 1; i < s.Length; i++)
        {

        }

        return plusToMinusArray;
    }
}