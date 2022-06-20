// https://leetcode.com/problems/middle-of-the-linked-list/
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
        since there is no way to know the size of the linked list in its current form
        we need to iterate though it and add it to the list
        return the element in the list ad the mid location
    */
    public static ListNode MiddleNode(ListNode head)
    {
        if (head == null) return head;

        var list = new List<ListNode>();

        while (head != null)
        {
            list.Add(head);
            head = head.next;
        }

        var size = list.Count();
        var mid = size / 2;

        return list.ToArray()[mid];
    }
}