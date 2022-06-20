// https://leetcode.com/problems/binary-tree-level-order-traversal/
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
    public static IList<IList<int>> LevelOrder(TreeNode root)
    {
        var levelOrderTraversal = new List<IList<int>>();

        if (root == null)
        {
            return levelOrderTraversal;
        }

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count() > 0)
        {
            var size = queue.Count();
            var levelOrder = new List<int>();

            for (var i = 0; i < size; i++)
            {
                var next = queue.Dequeue();
                levelOrder.Add(next.val);

                if (next.left != null) queue.Enqueue(next.left);
                if (next.right != null) queue.Enqueue(next.right);
            }

            levelOrderTraversal.Add(levelOrder);
        }

        return levelOrderTraversal;
    }
}