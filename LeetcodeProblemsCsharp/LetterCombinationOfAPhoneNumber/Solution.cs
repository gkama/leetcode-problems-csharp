// https://leetcode.com/problems/letter-combinations-of-a-phone-number/
public class Solution
{
    public IList<string> LetterCombinations(string digits)
    {
        var result = new HashSet<string>();

        if (digits == null || digits.Length == 0) return result.ToList();

        var digitsArray = digits.ToCharArray();
        var digitLetters = new string[digitsArray.Length];

        // Get the letters for each digit
        for (var i = 0; i < digitsArray.Length; i++)
        {
            digitLetters[i] = NumberToLetter(int.Parse(digitsArray[i].ToString()));
        }

        var digitLettersLength = digitLetters.Length;


        if (digitLettersLength == 1)
        {
            for (var i = 0; i < digitLetters[0].Length; i++)
            {
                result.Add(digitLetters[0][i].ToString());
            }
        }
        else if (digitLettersLength == 2)
        {
            for (var i = 0; i < digitLetters[0].Length; i++)
            {
                for (var j = 0; j < digitLetters[1].Length; j++)
                {
                    result.Add(digitLetters[0][i].ToString() + digitLetters[1][j].ToString());
                }
            }
        }
        else if (digitLettersLength == 3)
        {
            for (var i = 0; i < digitLetters[0].Length; i++)
            {
                for (var j = 0; j < digitLetters[1].Length; j++)
                {
                    for (var k = 0; k < digitLetters[2].Length; k++)
                    {
                        result.Add(
                            digitLetters[0][i].ToString()
                            + digitLetters[1][j].ToString()
                            + digitLetters[2][k].ToString());
                    }
                }
            }
        }
        else if (digitLettersLength == 4)
        {
            for (var i = 0; i < digitLetters[0].Length; i++)
            {
                for (var j = 0; j < digitLetters[1].Length; j++)
                {
                    for (var k = 0; k < digitLetters[2].Length; k++)
                    {
                        for (var l = 0; l < digitLetters[3].Length; l++)
                        {
                            result.Add(
                                digitLetters[0][i].ToString()
                                + digitLetters[1][j].ToString()
                                + digitLetters[2][k].ToString()
                                + digitLetters[3][l].ToString());
                        }
                    }
                }
            }
        }


        return result.ToList();
    }

    private string NumberToLetter(int n)
    {
        switch (n)
        {
            case 2: return "abc";
            case 3: return "def";
            case 4: return "ghi";
            case 5: return "jkl";
            case 6: return "mno";
            case 7: return "pqrs";
            case 8: return "tuv";
            case 9: return "wxyz";
            default: throw new NotImplementedException();
        }
    }
}