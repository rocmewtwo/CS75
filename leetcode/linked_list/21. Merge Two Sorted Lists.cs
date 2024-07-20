// 21. Merge Two Sorted Lists
// https://leetcode.com/problems/merge-two-sorted-lists

public class _21_Merge_Two_Sorted_Lists
{
    public ListNode? MergeTwoLists(ListNode? list1, ListNode? list2)
    {
        var head = new ListNode(0);
        var current = head;

        // Compare the first node of each list
        while (list1 != null && list2 != null)
        {
            if (list1.val < list2.val)
            {
                current.next = list1;
                list1 = list1.next;
            }
            else
            {
                current.next = list2;
                list2 = list2.next;
            }
            current = current.next;
        }

        // If there are remaining nodes in list1 or list2
        while (list1 != null)
        {
            current.next = list1;
            list1 = list1.next;
            current = current.next;
        }
        while (list2 != null)
        {
            current.next = list2;
            list2 = list2.next;
            current = current.next;
        }
        return head.next;
    }
}