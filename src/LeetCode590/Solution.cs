using System.Collections.Generic;

namespace LeetCode590
{
    public class Solution
    {
        public IList<int> Postorder(Node root)
        {
            List<int> result = new List<int>();
            InternalPostorder(root, result);
            return result;
        }

        private void InternalPostorder(Node node, IList<int> list)
        {
            if (node == null)
            {
                return;
            }

            if (node.children != null)
            {
                foreach (var child in node.children)
                {
                    InternalPostorder(child, list);
                }
            }

            list.Add(node.val);
        }
    }
}
