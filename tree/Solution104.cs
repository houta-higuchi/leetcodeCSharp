/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }


 dfs  
 */

 //二叉树的深度
public class Solution104 {
    public int MaxDepth(TreeNode root) {
        if (root == null) return 0;
        int leftDepth = MaxDepth(root.left) + 1;
        int rightDepth = MaxDepth(root.right) + 1;
        return leftDepth > rightDepth ? leftDepth:rightDepth;
    }
}