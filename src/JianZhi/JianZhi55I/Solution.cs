using System;

namespace JianZhi55I
{
    public class Solution
    {
        /// <summary>
        /// 时间复杂度 O(n)，n为树的节点个数
        /// 空间复杂度 O(n)，用于递归的栈
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            return Math.Max(MaxDepth(root.left), MaxDepth(root.right)) + 1;
        }
    }
}
