using System;

namespace LeetCode111
{
    public class Solution
    {
        public int MinDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            if (root.left == null && root.right == null)
            {
                return 1;
            }

            int minDepth = int.MaxValue;
            if (root.left != null)
            {
                minDepth = Math.Min(minDepth, MinDepth(root.left) + 1);
            }

            if (root.right != null)
            {
                minDepth = Math.Min(minDepth, MinDepth(root.right) + 1);
            }

            return minDepth;
        }
    }
}
