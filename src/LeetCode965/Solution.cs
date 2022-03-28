namespace LeetCode965
{
    public class Solution
    {
        public bool IsUnivalTree(TreeNode root)
        {
            int val = root.val;
            return PreOrder(root.left, val) && PreOrder(root.right, val);
        }

        private bool PreOrder(TreeNode node, int val)
        {
            if (node == null)
            {
                return true;
            }

            if (node.val != val)
            {
                return false;
            }

            return PreOrder(node.left, val) && PreOrder(node.right, val);
        }
    }
}
