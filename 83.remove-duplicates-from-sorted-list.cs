/*
 * @lc app=leetcode id=83 lang=csharp
 *
 * [83] Remove Duplicates from Sorted List
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        ListNode Current = head;
        while(Current != null && Current.next != null)
        {
            if(Current.val == Current.next.val)
                Current.next = Current.next.next;
            else
                Current = Current.next;
        }
        return head;
    }
}
// @lc code=end

