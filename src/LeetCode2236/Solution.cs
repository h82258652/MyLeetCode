﻿namespace LeetCode2236
{
    public class Solution
    {
        public bool CheckTree(TreeNode root)
        {
            return root.val == root.left.val + root.right.val;
        }
    }
}
