using System.Collections.Generic;

namespace LeetCode1609
{
    public class Solution
    {
        public bool IsEvenOddTree(TreeNode root)
        {
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            var isOdd = true;
            var previousValue = int.MinValue;
            while (queue.Count > 0)
            {
                var count = queue.Count;
                for (var i = 0; i < count; i++)
                {
                    var node = queue.Dequeue();

                    var val = node.val;
                    if (isOdd)
                    {
                        if (val <= previousValue || (val & 1) == 0)
                        {
                            return false;
                        }

                        previousValue = val;
                    }
                    else
                    {
                        if (val >= previousValue || (val & 1) == 1)
                        {
                            return false;
                        }

                        previousValue = val;
                    }

                    var left = node.left;
                    if (left != null)
                    {
                        queue.Enqueue(left);
                    }

                    var right = node.right;
                    if (right != null)
                    {
                        queue.Enqueue(right);
                    }
                }

                if (isOdd)
                {
                    isOdd = false;
                    previousValue = int.MaxValue;
                }
                else
                {
                    isOdd = true;
                    previousValue = int.MinValue;
                }
            }

            return true;
        }
    }
}
