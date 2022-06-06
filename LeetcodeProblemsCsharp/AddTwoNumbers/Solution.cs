// https://leetcode.com/problems/add-two-numbers
public class ListNode
{
    public int val;
    public ListNode? next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public static class Solution
{
    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var start = new ListNode();
        var res = Add(start, l1, l2, 0);

        return res;

        ListNode Add(ListNode res, ListNode? ll1, ListNode? ll2, int carryover)
        {
            var ll1val = ll1 is null ? 0 : ll1.val;
            var ll2val = ll2 is null ? 0 : ll2.val;

            var addRes = ll1val + ll2val + carryover;

            if (addRes == 10)
            {
                addRes = 0;
                carryover = 1;
            }
            else if (addRes > 10)
            {
                carryover = 1;
                addRes = addRes - 10;
            }
            else
            {
                carryover = 0;
            }

            res.val = addRes;

            if (ll1?.next == null && ll2?.next == null && carryover == 0)
            {
                res.next = null;
            }
            else if (ll1?.next == null && ll2?.next == null && carryover == 1)
            {
                res.next = Add(new ListNode { }, null, null, carryover);
            }
            else
            {
                res.next = Add(new ListNode { }, ll1?.next, ll2?.next, carryover);
            }

            return res;
        }
    }
}

