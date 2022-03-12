using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace LeetCode590
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var root = new Node(1, new List<Node>
            {
                new Node(3, new List<Node>
                {
                    new Node(5),
                    new Node(6)
                }),
                new Node(2),
                new Node(4)
            });
            var result = solution.Postorder(root);
            result.Should().Equal(5, 6, 3, 2, 4, 1);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var root = new Node(1, new List<Node>
            {
                new Node(2),
                new Node(3, new List<Node>
                {
                    new Node(6),
                    new Node(7, new List<Node>
                    {
                        new Node(11, new List<Node>
                        {
                            new Node(14)
                        })
                    })
                }),
                new Node(4, new List<Node>
                {
                    new Node(8, new List<Node>
                    {
                        new Node(12)
                    })
                }),
                new Node(5, new List<Node>
                {
                    new Node(9, new List<Node>
                    {
                        new Node(13)
                    }),
                    new Node(10)
                })
            });
            var result = solution.Postorder(root);
            result.Should().Equal(2, 6, 14, 11, 7, 3, 12, 8, 4, 13, 9, 10, 5, 1);
        }
    }
}
