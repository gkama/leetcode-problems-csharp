// https://leetcode.com/problems/remove-duplicates-from-sorted-list/
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
    /*
    Alg
        keep track of visited nodes
        create a new ListNode
        iterate through the head
        if the visited node is not in the list, add it
        if it is, then skip it
        return the new ListNode.next
    */
    public static ListNode DeleteDuplicates(ListNode head)
    {
        if (head == null) return head;

        var visitedNodesVal = new HashSet<int>();
        var dummy = new ListNode();
        var tail = dummy;

        while (head != null)
        {
            if (!visitedNodesVal.Contains(head.val))
            {
                visitedNodesVal.Add(head.val);
                tail.next = head;
                tail = tail.next;
            }

            head = head.next;
        }

        tail.next = null;

        return dummy.next;
    }
}