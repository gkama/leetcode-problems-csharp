
// https://leetcode.com/problems/remove-linked-list-elements/ 
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
        create a new ListNode head (call it tail)
        check if the first element (head.val) needs to be remove
        iterate using a queue
        keep track of previous element
            because if we remove the current
            the previous needs to point to the next
    */
    public static ListNode RemoveElements(ListNode head, int val)
    {
        if (head == null) return head;

        var dummy = new ListNode();
        var tail = dummy;
        var queue = new Queue<ListNode>();

        queue.Enqueue(head);

        while (queue.Count() > 0)
        {
            var next = queue.Dequeue();

            if (next.val != val)
            {
                tail.next = next;
                tail = tail.next;
            }

            if (next.next != null)
            {
                queue.Enqueue(next.next);
            }
            else
            {
                tail.next = null;
            }
        }

        return dummy.next;
    }
}