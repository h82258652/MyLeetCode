namespace LeetCode002
{
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var root = Merge(l1, l2);
            var node = root;
            var plus = 0;
            while (node != null)
            {
                node.val += plus;
                plus = 0;
                if (node.val >= 10)
                {
                    node.val -= 10;
                    plus = 1;
                }

                if (node.next == null && plus == 1)// 最后一个节点且有进位
                {
                    node.next = new ListNode(1);
                    break;
                }

                node = node.next;
            }

            return root;
        }

        private ListNode Merge(ListNode l1, ListNode l2)
        {
            if (l1 == null && l2 == null)
            {
                return null;
            }

            if (l1 == null)
            {
                return new ListNode(l2.val, l2.next);
            }

            if (l2 == null)
            {
                return new ListNode(l1.val, l1.next);
            }

            return new ListNode(l1.val + l2.val, Merge(l1.next, l2.next));
        }
    }
}
