using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode388
{
    public class Solution
    {
        public int GetLongestLength(Node node)
        {
            if (node == null)
            {
                return 0;
            }

            if (node.IsFile)
            {
                return node.Length;
            }

            var length = 0;
            foreach (var child in node.Children)
            {
                var childLongestLength = GetLongestLength(child);
                if (childLongestLength <= 0)
                {
                    continue;
                }

                length = node.Length == 0 ?
                    Math.Max(length, childLongestLength) :
                    Math.Max(length, node.Length + 1 + childLongestLength);
            }

            return length;
        }

        public int LengthLongestPath(string input)
        {
            if (input.Length <= 0)
            {
                return 0;
            }

            var root = new Node();
            var lines = input.Split('\n');
            foreach (var line in lines)
            {
                var tabLength = GetTabLength(line);

                var newNode = new Node
                {
                    IsFile = line.Contains('.'),
                    Length = line.Length - tabLength
                };

                var node = root;
                while (tabLength > 0)
                {
                    node = node.Children.Last(temp => !temp.IsFile);
                    tabLength--;
                }

                node.Children.Add(newNode);
            }

            return GetLongestLength(root);
        }

        private static int GetTabLength(string line)
        {
            var tabLength = 0;
            for (var i = 0; i < line.Length; i++)
            {
                var c = line[i];
                if (c != '\t')
                {
                    break;
                }

                tabLength++;
            }

            return tabLength;
        }

        public class Node
        {
            public List<Node> Children { get; set; } = new List<Node>();

            public bool IsFile { get; set; }

            public int Length { get; set; }
        }
    }
}
