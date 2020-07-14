
/**
1.前序遍历二叉树
2.以当前节点开始，dfs算出有多少种情况
*/

//路径总和 III
public class Solution437 {
    public int PathSum(TreeNode root, int sum) {
        if (root == null) return result;
        dfs(root, sum);
        PathSum(root.left, sum);
        PathSum(root.right, sum);
        return result;
    }

    int result = 0;
    public void dfs(TreeNode node, int sum) {
        if (node == null) return;
        sum -= node.val;
        if (sum == 0) {
            result++;
        }
        dfs(node.left, sum);
        dfs(node.right, sum);
    }
}