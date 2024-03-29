﻿/*
 * This question is asked by Amazon. Given a non-empty linked list, 
 * return the middle node of the list. If the linked list contains an even number of elements, return the node closer to the end.
 * Ex: Given the following linked lists...
 * 
 * 1->2->3->null, return 2
 * 1->2->3->4->null, return 3
 * 1->null, return 1
 */
public static class Solution
{
    public class LinkedNode
    {
        public int Value { get; set; }
        public LinkedNode? Next { get; set; }
    }

    public static int FindMiddleElement(LinkedNode head)
    {
        if (head == null) return -1;

        // Find the size and add values to a list
        var size = 0;
        var valueList = new List<int>();

        while (head != null)
        {
            size += 1;
            valueList.Add(head.Value);
            head = head.Next;
        }

        // Calculate middle
        var sizeMiddle = size / 2;

        // Return
        return valueList.ToArray()[sizeMiddle];
    }

    public static void Examples()
    {
        var exs = new List<LinkedNode>
        {
            new LinkedNode { Value = 1, Next = new LinkedNode { Value = 2, Next = new LinkedNode { Value = 3 } } },
            new LinkedNode { Value = 1, Next = new LinkedNode { Value = 2, Next = new LinkedNode { Value = 3, Next = new LinkedNode { Value = 4 } } } },
            new LinkedNode { Value = 1 }
        };

        foreach (var ex in exs)
        {
            Console.WriteLine(FindMiddleElement(ex));
        }
    }
}
