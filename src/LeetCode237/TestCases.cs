using FluentAssertions;
using Xunit;

namespace LeetCode237
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var node4 = new ListNode(4);
            var node5 = new ListNode(5);
            var node1 = new ListNode(1);
            var node9 = new ListNode(9);
            node4.next = node5;
            node5.next = node1;
            node1.next = node9;
            var solution = new Solution();
            solution.DeleteNode(node5);
            node4.ToArray().Should().Equal(4, 1, 9);
        }

        [Fact]
        public void Test2()
        {
            var node4 = new ListNode(4);
            var node5 = new ListNode(5);
            var node1 = new ListNode(1);
            var node9 = new ListNode(9);
            node4.next = node5;
            node5.next = node1;
            node1.next = node9;
            var solution = new Solution();
            solution.DeleteNode(node1);
            node4.ToArray().Should().Equal(4, 5, 9);
        }

        [Fact]
        public void Test3()
        {
            var node1 = new ListNode(1);
            var node2 = new ListNode(2);
            var node3 = new ListNode(3);
            var node4 = new ListNode(4);
            node1.next = node2;
            node2.next = node3;
            node3.next = node4;
            var solution = new Solution();
            solution.DeleteNode(node3);
            node1.ToArray().Should().Equal(1, 2, 4);
        }

        [Fact]
        public void Test4()
        {
            var node0 = new ListNode(0);
            var node1 = new ListNode(1);
            node0.next = node1;
            var solution = new Solution();
            solution.DeleteNode(node0);
            node0.ToArray().Should().Equal(1);
        }

        [Fact]
        public void Test5()
        {
            var nodeMinus3 = new ListNode(-3);
            var node5 = new ListNode(5);
            var nodeMinus99 = new ListNode(-99);
            nodeMinus3.next = node5;
            node5.next = nodeMinus99;
            var solution = new Solution();
            solution.DeleteNode(nodeMinus3);
            nodeMinus3.ToArray().Should().Equal(5, -99);
        }
    }
}
