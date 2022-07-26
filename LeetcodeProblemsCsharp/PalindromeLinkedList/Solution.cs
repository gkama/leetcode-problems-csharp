// https://leetcode.com/problems/palindrome-linked-list/
public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}

public static class Solution
{
    public static bool IsPalindrome(ListNode head)
    {
        if (head == null) return true;

        var list = new List<int>();

        while (head != null)
        {
            list.Add(head.val);
            head = head.next;
        }

        var array = list.ToArray();
        var n = array.Length;

        if (n == 1)
        {
            return true;
        }
        else
        {
            var halfN = n / 2;
            var j = n - 1;
            for (var i = 0; i < halfN; i++)
            {
                if (array[i] != array[j]) return false;
                j--;
            }
        }

        return true;
    }
}