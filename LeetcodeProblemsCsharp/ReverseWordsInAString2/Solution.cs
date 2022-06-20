// https://leetcode.com/problems/reverse-words-in-a-string-iii/
public static class Solution
{
    /*
    Alg
        split s into array by .Split(' ')
        iterate through each word
        and reverse each one
        helper method to reverse a string
        put the array back together with string.join(' ')
    */
    public static string ReverseWords(string s)
    {
        var sSplit = s.Split(' ');

        for (var i = 0; i < sSplit.Length; i++)
        {
            sSplit[i] = ReverseString(sSplit[i]);
        }

        return string.Join(' ', sSplit);
    }

    private static string ReverseString(string word)
    {
        var wordLength = word.Length;
        var wordArray = word.ToCharArray();
        var mid = wordLength % 2 == 0
            ? wordLength / 2
            : (wordLength - 1) / 2;

        var j = wordLength - 1;
        for (var i = 0; i < mid; i++)
        {
            var temp = wordArray[i];
            wordArray[i] = wordArray[j];
            wordArray[j] = temp;
            j--;
        }

        return new string(wordArray);
    }
}