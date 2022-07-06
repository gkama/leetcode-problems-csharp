/*
 * This question is asked by Apple. Given two sorted linked lists, merge them together in ascending order and return a reference to the merged list
 * Ex: Given the following lists...
 * list1 = 1->2->3, list2 = 4->5->6->null, return 1->2->3->4->5->6->null
 * list1 = 1->3->5, list2 = 2->4->6->null, return 1->2->3->4->5->6->null
 * list1 = 4->4->7, list2 = 1->5->6->null, return 1->4->4->5->6->7->null
 */
public class LinkedNode
{
    public int Value { get; set; }
    public LinkedNode? Next { get; set; }
}

public static class Solution
{
    public static LinkedNode MergeLinkedLists(LinkedNode head1, LinkedNode head2)
    {
        if (head1 == null) return head2;
        if (head2 == null) return head1;

        // Create dummy LinkedNode
        var dummy = new LinkedNode();
        var tail = dummy;

        // Keep 2 indexes of head1 and head2
        while (head1 != null && head2 != null)
        {
            if (head1.Value < head2.Value)
            {
                tail.Next = head1;
                head1 = head1.Next;
            }
            else
            {
                tail.Next = head2;
                head2 = head2.Next;

            }

            tail = tail.Next;
        }

        if (head1 != null) tail.Next = head1;
        if (head2 != null) tail.Next = head2;

        return dummy.Next;
    }

    public static void Examples()
    {
        var head1 = new LinkedNode { Value = 1, Next = new LinkedNode { Value = 2, Next = new LinkedNode { Value = 3, Next = null } } };
        var head2 = new LinkedNode { Value = 4, Next = new LinkedNode { Value = 5, Next = new LinkedNode { Value = 6, Next = null } } };
        var res = MergeLinkedLists(head1, head2);

        while (res != null)
        {
            Console.Write($"{res.Value}{(res.Next != null ? "->" : "")}");
            res = res.Next;
        }
    }
}
