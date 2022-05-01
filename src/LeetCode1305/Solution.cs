using System;
using System.Collections.Generic;

namespace LeetCode1305
{
    public class Solution
    {
        public IList<int> GetAllElements(TreeNode root1, TreeNode root2)
        {
            var list1 = new List<int>();
            var list2 = new List<int>();
            Inorder(root1, list1);
            Inorder(root2, list2);
            return Merge(list1, list2);
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

        private List<int> Merge(List<int> list1, List<int> list2)
        {
            var list = new List<int>();
            var i1 = 0;
            var i2 = 0;
            while (i1 < list1.Count || i2 < list2.Count)
            {
                if (i1 == list1.Count)
                {
                    list.Add(list2[i2]);
                    i2++;
                }
                else if (i2 == list2.Count)
                {
                    list.Add(list1[i1]);
                    i1++;
                }
                else
                {
                    if (list1[i1] < list2[i2])
                    {
                        list.Add(list1[i1]);
                        i1++;
                    }
                    else
                    {
                        list.Add(list2[i2]);
                        i2++;
                    }
                }
            }

            return list;
        }
    }
}
