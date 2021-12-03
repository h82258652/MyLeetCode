using System.Collections.Generic;

namespace LeetCode257
{
    public class Solution
    {
        public IList<string> BinaryTreePaths(TreeNode root)
        {
            if (root == null)
            {
                return new List<string>();
            }

            if (root.left == null && root.right == null)
            {
                return new List<string> { root.val.ToString() };
            }

            var result = new List<string>();
            foreach (var leftPath in BinaryTreePaths(root.left))
            {
                result.Add(root.val + "->" + leftPath);
            }

            foreach (var rightPath in BinaryTreePaths(root.right))
            {
                result.Add(root.val + "->" + rightPath);
            }

            return result;
        }
    }
}
