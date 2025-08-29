namespace LeetCode.Challenges._0104_maximum_depth_of_binary_tree;

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class _0104_maximum_depth_of_binary_tree
{
    public int MaxDepth(TreeNode root)
    {
        int max = Check(root, 0, 0);

        return max;
    }

    private int Check(TreeNode node, int level, int maxLevel)
    {
        if (node == null)
        {
            return Math.Max(level, maxLevel);
        }

        maxLevel = Check(node.left, level + 1, maxLevel);
        maxLevel = Check(node.right, level + 1, maxLevel);

        return maxLevel;
    }
}
