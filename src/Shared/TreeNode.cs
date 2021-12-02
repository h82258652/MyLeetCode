using System.Collections.Generic;

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }

    public static TreeNode Create(int?[] array)
    {
        if (array.Length <= 0 || !array[0].HasValue)
        {
            return null;
        }

        var indexToNodeMap = new Dictionary<int, TreeNode>();
        var root = new TreeNode(array[0].Value);
        indexToNodeMap[1] = root;

        for (var i = 1; i < array.Length; i++)
        {
            var val = array[i];
            if (val.HasValue)
            {
                var node = new TreeNode(val.Value);
                var parentIndex = (i + 1) / 2;
                TreeNode parent;
                while (true)
                {
                    if (indexToNodeMap.TryGetValue(parentIndex, out parent))
                    {
                        break;
                    }

                    parentIndex++;
                }

                if ((i + 1) % 2 == 0)
                {
                    // 左节点
                    parent.left = node;
                }
                else
                {
                    // 右节点
                    parent.right = node;
                }

                indexToNodeMap[i + 1] = node;
            }
        }

        return root;
    }
}
