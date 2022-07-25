using FluentAssertions;
using Xunit;

namespace LeetCode919
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var root = new TreeNode(1)
            {
                left = new TreeNode(2)
            };
            var obj = new CBTInserter(root);
            obj.Insert(3).Should().Be(1);
            obj.Insert(4).Should().Be(2);
            var result = obj.Get_root();
            result.val.Should().Be(1);
            result.left.val.Should().Be(2);
            result.right.val.Should().Be(3);
            result.left.left.val.Should().Be(4);
        }
    }
}
