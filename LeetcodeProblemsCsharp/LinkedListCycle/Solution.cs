// https://leetcode.com/problems/linked-list-cycle/
public static class Solution
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }

    /*
    Alg
        keep track of all visited nodes and their pos
        if the next appears in the DS of stored nodes
            then return true
        else return false
    */
    public static bool HasCycle(ListNode head)
    {
        /*
        Q's
            will there be repetitive values in the linked list?
        */
        if (head == null || head.next == null) return false;

        var visitedNodes = new List<ListNode>();
        var queue = new Queue<ListNode>();

        queue.Enqueue(head);

        while (queue.Count() > 0)
        {
            var next = queue.Dequeue();

            if (visitedNodes.Contains(next)) return true;

            visitedNodes.Add(next);

            if (next.next == null) return false;
            queue.Enqueue(next.next);
        }

        return false;
    }
}