using FluentAssertions;
using Xunit;

namespace LeetCode1609
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var root = new TreeNode(1)
            {
                left = new TreeNode(10)
                {
                    left = new TreeNode(3)
                    {
                        left = new TreeNode(12),
                        right = new TreeNode(8)
                    }
                },
                right = new TreeNode(4)
                {
                    left = new TreeNode(7)
                    {
                        left = new TreeNode(6)
                    },
                    right = new TreeNode(9)
                    {
                        right = new TreeNode(2)
                    }
                }
            };
            var result = solution.IsEvenOddTree(root);
            result.Should().BeTrue();
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var root = new TreeNode(5)
            {
                left = new TreeNode(4)
                {
                    left = new TreeNode(3),
                    right = new TreeNode(3)
                },
                right = new TreeNode(2)
                {
                    left = new TreeNode(7)
                }
            };
            var result = solution.IsEvenOddTree(root);
            result.Should().BeFalse();
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var root = new TreeNode(5)
            {
                left = new TreeNode(9)
                {
                    left = new TreeNode(3),
                    right = new TreeNode(5)
                },
                right = new TreeNode(1)
                {
                    left = new TreeNode(7)
                }
            };
            var result = solution.IsEvenOddTree(root);
            result.Should().BeFalse();
        }

        [Fact]
        public void Test4()
        {
            var solution = new Solution();
            var root = new TreeNode(1);
            var result = solution.IsEvenOddTree(root);
            result.Should().BeTrue();
        }

        [Fact]
        public void Test5()
        {
            var solution = new Solution();
            var root = new TreeNode(11)
            {
                left = new TreeNode(8)
                {
                    left = new TreeNode(1)
                    {
                        left = new TreeNode(30)
                        {
                            left = new TreeNode(17)
                        },
                        right = new TreeNode(20)
                    },
                    right = new TreeNode(3)
                    {
                        left = new TreeNode(18),
                        right = new TreeNode(16)
                    }
                },
                right = new TreeNode(6)
                {
                    left = new TreeNode(9)
                    {
                        left = new TreeNode(12),
                        right = new TreeNode(10)
                    },
                    right = new TreeNode(11)
                    {
                        left = new TreeNode(4),
                        right = new TreeNode(2)
                    }
                }
            };
            var result = solution.IsEvenOddTree(root);
            result.Should().BeTrue();
        }
    }
}
