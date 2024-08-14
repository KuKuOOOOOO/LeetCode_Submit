/*
 * @lc app=leetcode id=141 lang=csharp
 *
 * [141] Linked List Cycle
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution
{
    public bool HasCycle(ListNode head)
    {
        if (head == null)
            return false;
        ListNode fast = head;
        ListNode slow = head;
        // Tortoise and Hare algorithm
        while (fast?.next != null && fast?.next?.next != null)
        {
            fast = fast.next.next;
            slow = slow.next;
            if (fast == slow)
                return true;
        }
        return false;
    }
}
// @lc code=end

