namespace LeetCode021
{
    public class Solution
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode result = null;
            ListNode node = null;

            while (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {
                    if (result == null)
                    {
                        result = new ListNode(list1.val);
                        node = result;
                    }
                    else
                    {
                        node.next = new ListNode(list1.val);
                        node = node.next;
                    }

                    list1 = list1.next;
                }
                else
                {
                    if (result == null)
                    {
                        result = new ListNode(list2.val);
                        node = result;
                    }
                    else
                    {
                        node.next = new ListNode(list2.val);
                        node = node.next;
                    }

                    list2 = list2.next;
                }
            }

            while (list1 != null)
            {
                if (node == null)
                {
                    node = new ListNode(list1.val);
                    result = node;
                }
                else
                {
                    node.next = new ListNode(list1.val);
                    node = node.next;
                }

                list1 = list1.next;
            }

            while (list2 != null)
            {
                if (node == null)
                {
                    node = new ListNode(list2.val);
                    result = node;
                }
                else
                {
                    node.next = new ListNode(list2.val);
                    node = node.next;
                }

                list2 = list2.next;
            }

            return result;
        }
    }
}
