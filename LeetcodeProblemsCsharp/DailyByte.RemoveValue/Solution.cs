/*
 * This question is asked by Google. Given a linked list and a value, remove all nodes containing the provided value, and return the resulting list.
 * 1->2->3->null, value = 3, return 1->2->null
 * 8->1->1->4->12->null, value = 1, return 8->4->12->null
 * 7->12->2->9->null, value = 7, return 12->2->9->null
 */
public static class Solution
{
    public class LinkedNode
    {
        public int Value { get; set; }
        public LinkedNode? Next { get; set; }
    }

    public static LinkedNode? RemoveValue(LinkedNode? head, int value)
    {
        if (head == null) return head;

        var dummy = new LinkedNode();
        var tail = dummy;

        while (head != null)
        {
            if (head.Value != value)
            {
                tail.Next = head;
                tail = tail.Next; 
            }

            head = head.Next;
        }

        if (tail.Next != null) tail.Next = null;

        return dummy.Next;
    }

    public static void Examples()
    {
        var head1 = new LinkedNode { Value = 1, Next = new LinkedNode { Value = 2, Next = new LinkedNode { Value = 3 } } };
        var head2 = new LinkedNode { Value = 8, Next = new LinkedNode { Value = 1, Next = new LinkedNode { Value = 1, Next = new LinkedNode { Value = 4, Next = new LinkedNode { Value = 12 } } } } };
        var head3 = new LinkedNode { Value = 7, Next = new LinkedNode { Value = 12, Next = new LinkedNode { Value = 2, Next = new LinkedNode { Value = 9 } } } };

        var ex1 = RemoveValue(head1, 3);
        var ex2 = RemoveValue(head2, 1);
        var ex3 = RemoveValue(head3, 7);

        // Print
        Print(ex1);
        Console.WriteLine();
        Print(ex2);
        Console.WriteLine();
        Print(ex3);
    }

    private static void Print(LinkedNode head)
    {
        while (head != null)
        {
            Console.Write($"{head.Value}{(head.Next == null ? "" : "->")}");

            head = head.Next;
        }
    }
}
