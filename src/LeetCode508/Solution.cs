using System.Collections.Generic;
using System.Linq;

namespace LeetCode508
{
    public class Solution
    {
        public int[] FindFrequentTreeSum(TreeNode root)
        {
            var sum = new Dictionary<TreeNode, int>();
            PostOrder(root, sum);
            var group = sum.Values.GroupBy(temp => temp).ToList();
            var maxCount = group.Select(temp => temp.Count()).Max();
            return group.Where(temp => temp.Count() == maxCount).Select(temp => temp.Key).ToArray();
        }

        private void PostOrder(TreeNode node, Dictionary<TreeNode, int> sum)
        {
            if (node is null)
            {
                return;
            }

            PostOrder(node.left, sum);
            PostOrder(node.right, sum);
            var val = node.val;
            if (node.left != null && sum.ContainsKey(node.left))
            {
                val += sum[node.left];
            }
            if (node.right != null && sum.ContainsKey(node.right))
            {
                val += sum[node.right];
            }
            sum[node] = val;
        }
    }
}
