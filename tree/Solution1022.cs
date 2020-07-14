

//从根到叶的二进制数之和
using System.Collections.Generic;
/**
先序遍历，记录每次的路径
到达节点后计算数值，累加
*/
public class Solution1022 {
    
    public int SumRootToLeaf(TreeNode root) {
        IList<int> list = new List<int>();
        dfs(root, list);
        return result;
    }

    int result = 0;
    public void dfs(TreeNode node, IList<int> list) {
        if (node == null) return;
        list.Add(node.val);
        if (node.left == null && node.right == null) {
            //计算
            result += listToNum(list, 0);
        }
        dfs(node.left, list);
        dfs(node.right, list);
        list.RemoveAt(list.Count-1);
    }


    public int listToNum(IList<int> list, int c) {
        if (c == list.Count) return 0;
        int num = 1;
        for(int i = 0; i < list.Count - c - 1; i++) {
            num *= 2;
        }
        num *= list[c];
        return listToNum(list, c+1) + num;
    }



}