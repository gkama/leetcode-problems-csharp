// https://leetcode.com/problems/merge-two-sorted-lists/
public class Solution
{
    public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        /*
         * Given
         *      heads of 2 sorted lists
         *      both lists are sorted in non-decreasing order
         *      note:
         *          what is they're not the same size
         *  
         *  Do and return
         *      merge in a one sorted list
         *      the list should be made by splicing together the nodes of the first two lists
         *      return the head of the merged list
         *   
         *  Alg
         *      start by creating a new ListNode which is the new sorted list
         *      start with one as the base, since it's already sorted
         *      iterate through the second list and check where the values fit
         */
        if (list1 == null) return list2;
        else if (list2 == null) return list1;

        var dummy = new ListNode();
        var tail = dummy;

        while (list1 != null && list2 != null)
        {
            if (list1.val < list2.val)
            {
                tail.next = list1;
                list1 = list1.next;
            }
            else
            {
                tail.next = list2;
                list2 = list2.next;

            }

            tail = tail.next;
        }

        if (list1 != null) tail.next = list1;
        if (list2 != null) tail.next = list2;

        return dummy.next;
    }
}

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}
