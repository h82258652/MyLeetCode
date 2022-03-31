using System;

namespace LeetCode654
{
    public class Solution
    {
        public TreeNode ConstructMaximumBinaryTree(int[] nums)
        {
            return InternalConstructMaximumBinaryTree(nums);
        }

        private TreeNode InternalConstructMaximumBinaryTree(Span<int> nums)
        {
            var max = int.MinValue;
            var maxIndex = -1;
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                    maxIndex = i;
                }
            }

            var root = new TreeNode(max);

            if (maxIndex > 0)
            {
                var left = InternalConstructMaximumBinaryTree(nums[..maxIndex]);
                root.left = left;
            }

            if (maxIndex < nums.Length - 1)
            {
                var right = InternalConstructMaximumBinaryTree(nums[(maxIndex + 1)..]);
                root.right = right;
            }

            return root;
        }
    }
}
