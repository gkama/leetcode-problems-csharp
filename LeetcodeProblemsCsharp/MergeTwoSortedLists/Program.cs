var exs = new List<ListNode[]>
{
    new ListNode [] { 
        new ListNode { val = 1, next = new ListNode { val = 2, next = new ListNode { val = 4, next = null } } },
        new ListNode { val = 1, next = new ListNode { val = 3, next = new ListNode { val = 4, next = null } } }
    },
    new ListNode [] {
        new ListNode { },
        new ListNode { }
    },
    new ListNode [] {
        new ListNode { },
        new ListNode { }
    }
};


foreach (var ex in exs)
{
    var res = Solution.MergeTwoLists(ex[0], ex[1]);

    Console.Write($"[");
    while (res != null)
    {
        Console.Write($"{res.val}");
        res = res.next;
    }
    Console.Write($"]");
}