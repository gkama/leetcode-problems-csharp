// https://leetcode.com/problems/reverse-linked-list/submissions/
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
        Option 1
        create a stack
        iterate through the head (head.next)
        push to stack
        iterate through stack
        create new ListNode
        return the new ListNode
        
    */
    public static ListNode ReverseList(ListNode head)
    {
        if (head == null) return head;

        var stack = new Stack<ListNode>();

        Console.WriteLine("creating stack");
        while (head != null)
        {
            stack.Push(head);

            head = head.next;
        }

        Console.WriteLine("populating reversed head");
        var dummy = new ListNode();
        var reversedHead = dummy;

        while (stack.Count() > 0)
        {
            var current = stack.Pop();
            Console.WriteLine(current.val);

            reversedHead.next = current;
            reversedHead = reversedHead.next;
        }

        reversedHead.next = null;

        return dummy.next;
    }
}