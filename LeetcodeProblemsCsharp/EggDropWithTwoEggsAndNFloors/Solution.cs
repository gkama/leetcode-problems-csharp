// https://leetcode.com/problems/egg-drop-with-2-eggs-and-n-floors/
public static class Solution
{
    /*
     * Alg
     *      can we do a binary search on it?
     *      if n = 100
     *      step 1. drop at floor 50
     *      step 2. if it breaks then < 50
     *              if it doesn't break then > 50
     *      step 3. case one, drop at 75 (100 - 50 / 2)
     *      step 4. if it breaks 
     *      ...
     *      when to exit?
     */
    public static int TwoEggDrop(int n)
    {
        if (n <= 2)
        {
            return n;
        }

        var totalDrops = 1;

        int TwoEggDropInternal(int n)
        {
            if (n - totalDrops <= 0)
            {
                return totalDrops;
            }

            n -= totalDrops;
            totalDrops++;

            return TwoEggDropInternal(n);
        }

        return TwoEggDropInternal(n);
    }
}