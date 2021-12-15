using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace LeetCode094
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var root = new TreeNode(1, right: new TreeNode(2, new TreeNode(3)));
            var expected = new List<int> { 1, 3, 2 };

            var solution = new Solution();
            var result = solution.InorderTraversal(root);
            result.Should().Equal(expected);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.InorderTraversal(null);
            result.Should().Equal(new List<int>());
        }

        [Fact]
        public void Test3()
        {
            var root = new TreeNode(1);
            var expected = new List<int> { 1 };

            var solution = new Solution();
            var result = solution.InorderTraversal(root);
            result.Should().Equal(expected);
        }

        [Fact]
        public void Test4()
        {
            var root = new TreeNode(1, new TreeNode(2));
            var expected = new List<int> { 2, 1 };

            var solution = new Solution();
            var result = solution.InorderTraversal(root);
            result.Should().Equal(expected);
        }

        [Fact]
        public void Test5()
        {
            var root = new TreeNode(1, right: new TreeNode(2));
            var expected = new List<int> { 1, 2 };

            var solution = new Solution();
            var result = solution.InorderTraversal(root);
            result.Should().Equal(expected);
        }
    }
}
