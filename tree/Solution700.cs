/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
 //二叉搜索树中的搜索
public class Solution700 {
    public TreeNode SearchBST(TreeNode root, int val) {
        if(root == null || root.val == val ) return root;
        if (root.val > val) return SearchBST(root.left, val);
        else return SearchBST(root.right, val);
    }
}