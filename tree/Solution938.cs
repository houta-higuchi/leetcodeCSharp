/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }

中序遍历，当前节点符合则累加


 */

 //二叉搜索树的范围和
public class Solution938 {
    public int RangeSumBST(TreeNode root, int L, int R) {
        if (root == null) return 0;
        int result = 0;
        if (root.val >= L && root.val <= R) {
            result = root.val;
        }
        return result + RangeSumBST(root.left, L, R) + RangeSumBST(root.right, L, R);
    }
}