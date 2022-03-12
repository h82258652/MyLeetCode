using System.Collections.Generic;

namespace LeetCode589
{
    public class Solution
    {
        public IList<int> Preorder(Node root)
        {
            var list = new List<int>();
            InternalPreorder(root, list);
            return list;
        }

        private void InternalPreorder(Node root, IList<int> list)
        {
            if (root == null)
            {
                return;
            }

            list.Add(root.val);
            if (root.children != null)
            {
                foreach (var child in root.children)
                {
                    InternalPreorder(child, list);
                }
            }
        }
    }
}
