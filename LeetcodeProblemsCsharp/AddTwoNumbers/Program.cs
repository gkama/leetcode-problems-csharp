var l1 = new ListNode { val = 2, next = new ListNode { val = 4, next = new ListNode { val = 3, next = null } } };
var l2 = new ListNode { val = 5, next = new ListNode { val = 6, next = new ListNode { val = 4, next = null } } };
var res = Solution.AddTwoNumbers(l1, l2);
PrintListNode(res);
Console.WriteLine("---");

var l3 = new ListNode { val = 0, next = null };
var l4 = new ListNode { val = 0, next = null };
var res2 = Solution.AddTwoNumbers(l3, l4);
PrintListNode(res2);
Console.WriteLine("---");

var l5 = new ListNode { val = 9, next = new ListNode { val = 9, next = new ListNode { val = 9, next = new ListNode { val = 9, next = new ListNode { val = 9, next = null } } } } };
var l6 = new ListNode { val = 9, next = new ListNode { val = 9, next = new ListNode { val = 9, next = null } } };
var res3 = Solution.AddTwoNumbers(l5, l6);
PrintListNode(res3);
Console.WriteLine("---");

void PrintListNode(ListNode node)
{
    Console.Write(node.val);

    if (node.next is not null)
    {
        PrintListNode(node.next);
    }
}