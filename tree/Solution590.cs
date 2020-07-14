//N叉树的后序遍历
using System.Collections.Generic;

public class Solution590 {
    IList<int> result = new List<int>();

    public IList<int> Postorder(Node root) {
        if (root == null) return result;
        if (root.children == null || root.children.Count == 0) {
            result.Add(root.val);
        }
        else {
            foreach(Node item in root.children){
                Postorder(item);
            }
            result.Add(root.val);
        }
        return result;
    }
}