
/**
只要判断当前节点是左节点并且没有子节点，累加
*/
//左叶子之和
public class Solution404 {
    public int SumOfLeftLeaves(TreeNode root) {
        Sum(root, false);
        return result;
    }

    int result = 0;
    public bool Sum(TreeNode root, bool isLeft) {
        if (root == null) return true;
        bool b = Sum(root.left, true);
        bool d = Sum(root.right, false);
        if (b && d && isLeft) {
            result += root.val;
        }
        return false;
    }
}