// https://leetcode.com/problems/two-sum-iv-input-is-a-bst/
public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public static class Solution
{
    public static bool FindTarget(TreeNode root, int k)
    {
        return DFS(root, k, new HashSet<int>());
    }

    private static bool DFS(TreeNode root, int k, HashSet<int> recorded)
    {
        if (root == null)
        {
            return false;
        }

        if (recorded.Contains(root.val))
        {
            return true;
        }

        recorded.Add(k - root.val);

        return DFS(root.left, k, recorded)
            || DFS(root.right, k, recorded);
    }

    #region My attempted solution
    public static bool FindTargetVerySlow(TreeNode root, int k)
    {
        if (root == null) return false;

        if (k > 0 && root.val > k)
        {
            root = root.left;
        }

        var values = GetAllValues(root);

        return SumOfKExists(values.ToArray(), k);
    }

    private static List<int> GetAllValues(TreeNode root)
    {
        var list = new List<int>();
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count() > 0)
        {
            var next = queue.Dequeue();

            list.Add(next.val);

            if (next.left != null) queue.Enqueue(next.left);
            if (next.right != null) queue.Enqueue(next.right);
        }

        return list;
    }

    private static bool SumOfKExists(int[] nums, int k)
    {
        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = i + 1; j < nums.Length; j++)
            {
                var val = nums[i] + nums[j];
                Console.WriteLine(val);
                if (val == k)
                {
                    return true;
                }
            }
        }

        return false;
    }
    #endregion
}