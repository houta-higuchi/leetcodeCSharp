/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

/**
先写出获取当前节点的高度函数
递归计算当前节点的左子节点和右子节点的高度
*/

public class 检查平衡性 {
    public bool IsBalanced(TreeNode root) {
        if (root == null) return true;
        int left = depth(root.left);
        int right = depth(root.right);
        int minus = left - right;
        if (minus < 0) minus = -minus;
        return minus <= 1 && IsBalanced(root.left) && IsBalanced(root.right);
    }

    public int depth(TreeNode node) {
        if (node == null) 
            return 0;
        int a = depth(node.left);
        int b = depth(node.right);
        if (a > b)
            return a + 1;
        else 
            return b + 1;
    }
    
}