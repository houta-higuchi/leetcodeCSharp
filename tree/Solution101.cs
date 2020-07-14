//对称的二叉树



public class Solution101 {
    public bool IsSymmetric(TreeNode root) {
        return root == null?true:recur(root.left, root.right);
    }


    public bool recur(TreeNode left, TreeNode right){
        if (left == null && right == null) return true;
        if (left == null || right == null || left.val != right.val) return false;
        return recur(left.left, right.right) && recur(left.right, right.left);
    }
}