/*
 * This question is asked by Apple. Given a potentially cyclical linked list where each value is unique, return the node at which the cycle starts. If the list does not contain a cycle, return null.
 * 
 * Ex: Given the following linked lists...
 * 1->2->3, return null
 * 1->2->3->4->5->2 (5 points back to 2), return a reference to the node containing 2
 * 1->9->3->7->7 (7 points to itself), return a reference to the node containing 7
 */
public static class Solution
{
    public class LinkedNode
    {
        public int Value { get; set; }
        public LinkedNode Next { get; set; }

        public LinkedNode(int value = 0, LinkedNode next = null)
        {
            Value = value;
            Next = next;
        }
    }

    public static LinkedNode ReturnStartOfACycle(LinkedNode head)
    {
        if (head == null) return null;

        // Use a DS to keep track of visited nodes
        var visitedNodes = new Dictionary<int, LinkedNode>();

        while (head != null)
        {
            if (visitedNodes.ContainsKey(head.Value)) return visitedNodes[head.Value];

            visitedNodes.Add(head.Value, head);

            head = head.Next;
        }

        return null;
    }

    public static void Examples()
    {
        var exs = new List<LinkedNode>
        {
            new LinkedNode { Value = 1, Next = new LinkedNode { Value = 2, Next = new LinkedNode { Value = 3 } } },
            new LinkedNode { Value = 1, Next = new LinkedNode { Value = 2, Next = new LinkedNode { Value = 3, Next = new LinkedNode { Value = 4, Next = new LinkedNode { Value = 5, Next = new LinkedNode { Value = 2 } } } } } },
            new LinkedNode { Value = 1, Next = new LinkedNode { Value = 9, Next = new LinkedNode { Value = 3, Next = new LinkedNode { Value = 7, Next = new LinkedNode { Value = 7 } } } } },
            new LinkedNode { Value = 1, Next = new LinkedNode { Value = 9, Next = new LinkedNode { Value = 1 } } }
        };

        foreach (var ex in exs)
        {
            Console.WriteLine($"{Print(ex)} -> {Print(ReturnStartOfACycle(ex))}");
        }
    }

    public static string Print(LinkedNode head)
    {
        var result = new System.Text.StringBuilder();

        while (head != null)
        {
            result.Append($"{head.Value}{(head.Next != null ? "->" : "")}");

            head = head.Next;
        }

        return result.ToString();
    }
}
