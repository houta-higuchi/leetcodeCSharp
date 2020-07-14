/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
 //二叉树相邻节点的最小差值
public class Solution783{
    
    int result = 101;


    public int MinDiffInBST(TreeNode root) {
        dfs(root);
        return result;
    }


    public void dfs(TreeNode node) {
        if (node == null) return;
        if (node.left != null) {
            int n = node.left.val - node.val;
            if (n < 0) n = -n;
            if (n < result)
                result = n;
            dfs(node.left);
        }
        if (node.right != null) {
            int n = node.right.val - node.val;
            if (n < 0) n = -n;
            if (n < result)
                result = n;
            dfs(node.right);
        }
    }

}