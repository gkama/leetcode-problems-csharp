// https://leetcode.com/problems/remove-nth-node-from-end-of-list/.
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
        we need to know the size of the linked list
        then in order to remove it
            we set the previous node to the next node
    */
    public static ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        if (head == null) return head;

        // Calculate the size of the LinkedList
        var dummySize = head;
        var size = 0;
        while (dummySize != null)
        {
            size += 1;
            dummySize = dummySize.next;
        }

        return RemoveNthFromEndInternal(head, size, n);
    }

    private static ListNode RemoveNthFromEndInternal(ListNode head, int size, int n)
    {
        var currentNode = 0;
        var dummy = new ListNode();
        var tail = dummy;

        Console.WriteLine(size - n);

        while (head != null)
        {
            if (currentNode != (size - n))
            {
                tail.next = head;
                tail = tail.next;
            }
            Console.WriteLine(tail.val);

            currentNode += 1;
            head = head.next;
        }

        tail.next = null;

        return dummy.next;
    }
}