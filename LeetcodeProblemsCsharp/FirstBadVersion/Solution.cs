public static class Solution
{
    /* Accepted answer
     * public int FirstBadVersion(int n) {
        for (var i = n; i >= 0; i--)
        {
            if (IsBadVersion(i)) continue;
            else return i + 1;
        }
        
        return 0;
    }
     */

    /*
     * if (n == 1)
        {
            if (IsBadVersion(n)) return n;
            else return -1;
        }
        
        var mid = (1 + n) / 2;
        Console.WriteLine(mid);
        var isBad = IsBadVersion(mid);
        Console.WriteLine(isBad);
        
        if (isBad)
        {
            for (var i = mid; i >= 0; i--)
            {
                if (IsBadVersion(i) == false) return i + 1;
            }
        }
        else
        {
            for (var i = mid; i <= n; i++)
            {
                if (IsBadVersion(i)) return i;
            }
        }
        
        return -1;
     */
}
