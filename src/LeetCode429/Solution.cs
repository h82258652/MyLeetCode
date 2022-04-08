using System.Collections.Generic;

namespace LeetCode429
{
    public class Solution
    {
        public IList<IList<int>> LevelOrder(Node root)
        {
            var result = new List<IList<int>>();

            if (root == null)
            {
                return result;
            }

            var nodes = new Queue<Node>();
            nodes.Enqueue(root);
            while (nodes.Count > 0)
            {
                var count = nodes.Count;
                var level = new List<int>();
                for (var i = 0; i < count; i++)
                {
                    var node = nodes.Dequeue();
                    if (node.children != null)
                    {
                        foreach (var child in node.children)
                        {
                            nodes.Enqueue(child);
                        }
                    }

                    level.Add(node.val);
                }

                result.Add(level);
            }

            return result;
        }
    }
}
