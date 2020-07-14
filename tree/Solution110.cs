/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }

先序遍历
获取当前节点两个子树的差值


 */
 //平衡二叉树
public class Solution110 {
    public bool IsBalanced(TreeNode root) {
        if (root == null) return true;
        int minus = Depth(root.left) - Depth(root.right);
        if (minus < 0)
            minus = -minus;
        return minus < 2 && IsBalanced(root.left) && IsBalanced(root.right);
    }

    public int Depth(TreeNode node) {
        if (node == null) return 0;
        int leftDepth = Depth(node.left) + 1;
        int rightDepth = Depth(node.right) + 1;
        if (leftDepth > rightDepth) return leftDepth;
        else return rightDepth;
    }
}