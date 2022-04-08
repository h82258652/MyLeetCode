using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace LeetCode429
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var root = new Node(1)
            {
                children = new List<Node>
                {
                    new Node(3)
                    {
                        children = new List<Node>
                        {
                            new Node(5),
                            new Node(6)
                        }
                    },
                    new Node(2),
                    new Node(4)
                }
            };
            var result = solution.LevelOrder(root);
            result.Should().BeEquivalentTo(new List<IList<int>>
            {
                new List<int> { 1 },
                new List<int> { 3, 2, 4 },
                new List<int> { 5, 6 }
            }, options => options.WithStrictOrdering());
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var root = new Node(1)
            {
                children = new List<Node>
                {
                    new Node(2),
                    new Node(3)
                    {
                        children = new List<Node>
                        {
                            new Node(6),
                            new Node(7)
                            {
                                children = new List<Node>
                                {
                                    new Node(11)
                                    {
                                        children = new List<Node>
                                        {
                                            new Node(14)
                                        }
                                    }
                                }
                            }
                        }
                    },
                    new Node(4)
                    {
                        children = new List<Node>
                        {
                            new Node(8)
                            {
                                children = new List<Node>
                                {
                                    new Node(12)
                                }
                            }
                        }
                    },
                    new Node(5)
                    {
                        children = new List<Node>
                        {
                            new Node(9)
                            {
                                children = new List<Node>
                                {
                                    new Node(13)
                                }
                            },
                            new Node(10)
                        }
                    }
                }
            };
            var result = solution.LevelOrder(root);
            result.Should().BeEquivalentTo(new List<IList<int>>
            {
                new List<int> { 1 },
                new List<int> { 2, 3, 4, 5 },
                new List<int> { 6, 7, 8, 9, 10 },
                new List<int> { 11, 12, 13 },
                new List<int> { 14 }
            }, options => options.WithStrictOrdering());
        }
    }
}
