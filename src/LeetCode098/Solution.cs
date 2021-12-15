namespace LeetCode098
{
    public class Solution
    {
        public bool IsValidBST(TreeNode root)
        {
            return IsBST(root.left, long.MinValue, root.val) && IsBST(root.right, root.val, long.MaxValue);
        }

        private bool IsBST(TreeNode node, long min, long max)
        {
            if (node == null)
            {
                return true;
            }

            var val = node.val;
            if (val <= min || val >= max)
            {
                return false;
            }

            return IsBST(node.left, min, val) && IsBST(node.right, val, max);
        }
    }
}
