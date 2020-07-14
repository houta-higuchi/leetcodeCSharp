/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }

冲右到左中序遍历
记录共享变量


 */

 //把二叉搜索树转换为累加树
public class Solution538 {
    int shareNum = 0;
    public TreeNode ConvertBST(TreeNode root) {
        if (root == null) return root;
        ConvertBST(root.right);
        root.val = root.val + shareNum;
        shareNum = root.val;
        ConvertBST(root.left);
        return root;
    }

}