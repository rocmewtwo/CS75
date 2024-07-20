// 141. Linked List Cycle
// https://leetcode.com/problems/linked-list-cycle/

public class _141_Linked_List_Cycle {
    public bool HasCycle(ListNode head) {
        ListNode? slow = head;
        ListNode? fast = head;

        while (fast != null && fast.next != null) {
            if (slow != null)
            {
                slow = slow.next;
            }
            fast = fast.next.next;

            if (slow == fast) {
                return true;
            }
        }

        return false;
    }
}