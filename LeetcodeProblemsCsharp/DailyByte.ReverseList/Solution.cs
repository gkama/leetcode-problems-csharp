/*
 * This question is asked by Facebook. Given a linked list, containing unique values, reverse it, and return the result.
 * 
 * Ex: Given the following linked lists...
 * 1->2->3->null, return a reference to the node that contains 3 which points to a list that looks like the following: 3->2->1->null
 * 7->15->9->2->null, return a reference to the node that contains 2 which points to a list that looks like the following: 2->9->15->7->null
 * 1->null, return a reference to the node that contains 1 which points to a list that looks like the following: 1->null
 */
public static class Solution
{
    public class LinkedNode
    {
        public int Value { get; set; }
        public LinkedNode? Next { get; set; }

        public LinkedNode(int value = 0, LinkedNode? next = null)
        {
            Value = value;
            Next = next;
        }
    }

    public static LinkedNode? ReverseList(LinkedNode head)
    {
        if (head == null) return null;

        // DS to store the linked list's values
        var visitedNodes = new List<int>();

        while (head != null)
        {
            visitedNodes.Add(head.Value);
            head = head.Next;
        }

        // Convert to array and build backwards
        var visitedNodesArray = visitedNodes.ToArray();
        var visitedNodesArrayLength = visitedNodesArray.Length;
        var dummy = new LinkedNode();
        var result = dummy;

        for (var i = visitedNodesArrayLength - 1; i >= 0; i--)
        {
            dummy.Next = new LinkedNode(visitedNodesArray[i]);
            dummy = dummy.Next;
        }

        return result.Next;
    }

    public static void Examples()
    {
        var exs = new List<LinkedNode>
        {
            new LinkedNode { Value = 1, Next = new LinkedNode { Value = 2, Next = new LinkedNode { Value = 3 } } },
            new LinkedNode { Value = 7, Next = new LinkedNode { Value = 15, Next = new LinkedNode { Value = 9, Next = new LinkedNode { Value = 2 } } } },
            new LinkedNode { Value = 1, Next = new LinkedNode { Value = 9, Next = new LinkedNode { Value = 3, Next = new LinkedNode { Value = 7, Next = new LinkedNode { Value = 7 } } } } },
            new LinkedNode { Value = 1 }
        };

        foreach (var ex in exs)
        {
            Console.WriteLine($"{Print(ex)} -> {Print(ReverseList(ex))}");
        }
    }

    public static string Print(LinkedNode? head)
    {
        if (head == null) return "";

        var result = new System.Text.StringBuilder();

        while (head != null)
        {
            result.Append($"{head.Value}{(head.Next != null ? "->" : "")}");

            head = head.Next;
        }

        return result.ToString();
    }
}
