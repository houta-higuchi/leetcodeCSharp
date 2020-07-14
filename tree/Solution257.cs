
//深度优先遍历，把当前的值加入字符串。加入当前节点为叶子，把字符串加入结果

//二叉树的所有路径
using System.Collections.Generic;

public class Solution257 {
    IList<string> result = new List<string>();
    public IList<string> BinaryTreePaths(TreeNode root) {
        dfs(root, "");
        return result;
    }

    public void dfs(TreeNode node, string current){
        if (node == null) return;
        current = current + "->" + node.val;
        if (node.left == null && node.right == null) {
            result.Add(current.Substring(2));
            return;
        }
        dfs(node.left, current);
        dfs(node.right, current);
    }
}