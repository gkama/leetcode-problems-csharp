using System.Text;

/*
 * This question is asked by Microsoft. Given a linked list, containing unique numbers, return whether or not it has a cycle.
 * Note: a cycle is a circular arrangement (i.e. one node points back to a previous node)
 * 
 * Ex: Given the following linked lists...
 * 1->2->3->1 -> true (3 points back to 1)
 * 1->2->3 -> false
 * 1->1 true (1 points to itself)
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

    public static bool ContainsCycle(LinkedNode head)
    {
        if (head == null) return false;

        // Create a DS to store all the values we have visited
        // since it's all unique value, if we see it again, then it's a cycle
        var visitedLinkedNodesValues = new List<int>();

        while (head != null)
        {
            if (visitedLinkedNodesValues.Contains(head.Value)) return true;

            visitedLinkedNodesValues.Add(head.Value);
            head = head.Next;
        }

        return false;
    }

    public static void Examples()
    {
        var exs = new List<LinkedNode>
        {
            new LinkedNode { Value = 1, Next = new LinkedNode { Value = 2, Next = new LinkedNode { Value = 3, Next = new LinkedNode { Value = 1, Next = null } } } },
            new LinkedNode { Value = 1, Next = new LinkedNode { Value = 2, Next = new LinkedNode { Value = 3, Next = null } } },
            new LinkedNode { Value = 1, Next = new LinkedNode { Value = 1, Next = null } },
            new LinkedNode { Value = 1, Next = new LinkedNode { Value = 2, Next = new LinkedNode { Value = 3, Next = new LinkedNode { Value = 4, Next = null } } } }
        };

        foreach (var ex in exs)
        {
            Console.WriteLine($"{Print(ex)} -> {ContainsCycle(ex)}");
        }
    }

    public static string Print(LinkedNode head)
    {
        var result = new StringBuilder();

        while (head != null)
        {
            result.Append($"{head.Value}{(head.Next != null ? "->" : "")}");

            head = head.Next;
        }

        return result.ToString();
    }
}
