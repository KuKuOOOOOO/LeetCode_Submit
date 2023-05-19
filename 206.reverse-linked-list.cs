/*
 * @lc app=leetcode id=206 lang=csharp
 *
 * [206] Reverse Linked List
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
public class Solution {
    public ListNode ReverseList(ListNode head) 
    {
        ListNode PreList = null;
        ListNode CurrentList = head;

        while(CurrentList != null)
        {
            ListNode NextTemp = CurrentList.next;
            CurrentList.next = PreList;
            PreList = CurrentList;
            CurrentList = NextTemp;
        }
        return PreList;
        
    }
}
// @lc code=end

