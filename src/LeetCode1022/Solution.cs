namespace LeetCode1022
{
    public class Solution
    {
        public int SumRootToLeaf(TreeNode root)
        {
            var sum = 0;
            PreOrder(root, 0, ref sum);
            return sum;
        }

        private void PreOrder(TreeNode node, int current, ref int sum)
        {
            if (node == null)
            {
                return;
            }

            if (node.left == null && node.right == null)
            {
                sum += (current << 1) + node.val;
            }
            else
            {
                var pathValue = (current << 1) + node.val;
                PreOrder(node.left, pathValue, ref sum);
                PreOrder(node.right, pathValue, ref sum);
            }
        }
    }
}
