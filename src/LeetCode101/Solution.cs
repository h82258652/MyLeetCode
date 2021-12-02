namespace LeetCode101
{
    public class Solution
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            var left = root.left;
            var right = root.right;
            Reverse(right);

            return IsSame(left, right);
        }

        private bool IsSame(TreeNode node1, TreeNode node2)
        {
            if (node1 == null && node2 == null)
            {
                return true;
            }

            if (node1 == null || node2 == null)
            {
                return false;
            }

            if (node1.val != node2.val)
            {
                return false;
            }

            return IsSame(node1.left, node2.left) && IsSame(node1.right, node2.right);
        }

        private void Reverse(TreeNode node)
        {
            if (node == null)
            {
                return;
            }

            (node.left, node.right) = (node.right, node.left);
            Reverse(node.left);
            Reverse(node.right);
        }
    }
}
