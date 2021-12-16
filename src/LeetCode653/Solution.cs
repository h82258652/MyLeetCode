using System.Collections.Generic;

namespace LeetCode653
{
    public class Solution
    {
        public bool FindTarget(TreeNode root, int k)
        {
            if (root == null)
            {
                return false;
            }

            var list = new List<int>();
            Inorder(root, list);

            var left = 0;
            var right = list.Count - 1;
            while (left < right)
            {
                var leftVal = list[left];
                var rightVal = list[right];
                var sum = leftVal + rightVal;
                if (sum == k)
                {
                    return true;
                }

                if (sum < k)
                {
                    left++;
                }

                if (sum > k)
                {
                    right--;
                }
            }

            return false;
        }

        private void Inorder(TreeNode node, List<int> list)
        {
            if (node == null)
            {
                return;
            }

            Inorder(node.left, list);
            list.Add(node.val);
            Inorder(node.right, list);
        }
    }
}
