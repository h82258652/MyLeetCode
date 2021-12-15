namespace LeetCode226
{
    public class Solution
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }

            var left = root.left;
            var right = root.right;
            root.right = left;
            root.left = right;

            InvertTree(left);
            InvertTree(right);

            return root;
        }
    }
}
