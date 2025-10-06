namespace LeetCode.Challenges._0110_balanced_binary_tree;

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

public class _0110_balanced_binary_tree
{
    public bool IsBalanced(TreeNode root)
    {
        int returnValue = _Dfs(root);
        return returnValue != -1;
    }

    private int _Dfs(TreeNode node)
    {
        if (node == null)
        {
            return 0;
        }

        int leftHeight = _Dfs(node.left);
        if (leftHeight == -1)
        {
            return -1;
        }

        int rightHeight = _Dfs(node.right);
        if (rightHeight == -1)
        {
            return -1;
        }

        int diff = Math.Abs(leftHeight - rightHeight);
        if (diff < 2)
        {
            return Math.Max(leftHeight, rightHeight) + 1;
        }
        else
        {
            return -1;
        }
    }
}