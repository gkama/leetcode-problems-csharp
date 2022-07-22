// https://leetcode.com/problems/intersection-of-two-linked-lists/

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
    public ListNode() { }
}

public static class Solution
{
    public static ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        return (GetIntersectionV2(headA, headB));
    }

    public static ListNode GetIntersectionV2(ListNode headA, ListNode headB)
    {
        HashSet<ListNode> set = new HashSet<ListNode>();

        while (headA != null || headB != null)
        {
            if (headA != null)
            {
                if (!set.Add(headA))
                {
                    return headA;
                }

                headA = headA.next;

            }
            if (headB != null)
            {
                if (!set.Add(headB))
                {
                    return headB;
                }

                headB = headB.next;
            }
        }

        return null;
    }

    public static ListNode GetIntersectionNodeV1(ListNode headA, ListNode headB)
    {
        if (headA == null && headB == null) return null;
        if (headA == null && headB != null) return null;
        if (headA != null && headB == null) return null;

        var listA = new List<int>();
        var listB = new List<int>();

        while (headA != null)
        {
            listA.Add(headA.val);
            headA = headA.next;
        }

        while (headB != null)
        {
            listB.Add(headB.val);
            headB = headB.next;
        }

        var commonValues = new List<int>();
        var indexEndA = listA.Count() - 1;
        var indexEndB = listB.Count() - 1;
        var smaller = Math.Min(indexEndA, indexEndB);
        var bigger = Math.Max(indexEndA, indexEndB);
        var arrayA = listA.ToArray();
        var arrayB = listB.ToArray();

        while (smaller <= bigger)
        {
            if (arrayA[indexEndA] != arrayB[indexEndB]) break;

            commonValues.Add(arrayA[indexEndA]);

            indexEndB--;
            smaller--;
            indexEndA--;
            bigger--;
        }

        var dummy = new ListNode();
        var latestIntersect = dummy;

        foreach (var cv in commonValues)
        {
            dummy.next = new ListNode(cv);
            dummy = dummy.next;
        }

        return dummy.val == 0 ? null : dummy;
    }
}