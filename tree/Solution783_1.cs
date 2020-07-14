/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }

先序遍历所有节点
以当前节点开始，深度遍历计算查值


 */

 //二叉搜索树节点最小距离
public class Solution783_1 {
    
    int result = 101;


    public int MinDiffInBST(TreeNode root) {
        if (root == null) return result;
        dfs(root.left, root.val);
        dfs(root.right, root.val);
        MinDiffInBST(root.left);
        MinDiffInBST(root.right);
        return result;
    }


    public void dfs(TreeNode node, int val) {
        if (node == null)
            return;
        int b = node.val - val;
        if (b < 0)
            b = -b;
        if (b < result)
            result = b;
        dfs(node.left, val);
        dfs(node.right, val);
    }

}