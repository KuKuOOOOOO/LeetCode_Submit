/*
 * @lc app=leetcode id=2 lang=csharp
 *
 * [2] Add Two Numbers
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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        int sumValue = 0;
        int carryValue = 0;
        ListNode ansNode = new ListNode(-1);
        ListNode node = ansNode;
        while (l1 != null || l2 != null)
        {
            sumValue = carryValue;
            if (l1 != null)
            {
                sumValue += l1.val;
                l1 = l1.next;
            }
            if (l2 != null)
            {
                sumValue += l2.val;
                l2 = l2.next;
            }
            carryValue = (sumValue / 10);
            if (carryValue > 0)
            {
                sumValue = (sumValue % 10);
                if (l1 == null && l2 == null)
                {
                    l1 = new ListNode(0);
                }
            }
            if (ansNode.val == -1)
            {
                ansNode.val = sumValue;
            }
            else
            {
                node.next = new ListNode(sumValue);
                node = node.next;
            }
        }
        return ansNode;
    }
}
// @lc code=end
