using System.Collections.Generic;

namespace LeetCode919
{
    public class CBTInserter
    {
        private readonly List<TreeNode> _nodes;
        private readonly TreeNode _root;

        public CBTInserter(TreeNode root)
        {
            _root = root;
            _nodes = new List<TreeNode>();
            _nodes.Add(null);

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                _nodes.Add(node);

                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }

                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }
            }
        }

        public int Insert(int val)
        {
            var newNodeIndex = _nodes.Count;
            var newNode = new TreeNode(val);
            _nodes.Add(newNode);

            var parentNodeIndex = newNodeIndex / 2;
            var parentNode = _nodes[parentNodeIndex];
            if (newNodeIndex % 2 == 0)
            {
                parentNode.left = newNode;
                return parentNode.val;
            }
            else
            {
                parentNode.right = newNode;
                return parentNode.val;
            }
        }

        public TreeNode Get_root()
        {
            return _root;
        }
    }
}
