//https://leetcode.com/problems/reverse-nodes-in-k-group/

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
    public ListNode ReverseKGroup(ListNode head, int k)
    {
        if (head == null) return null;
        int count = 0;
        ListNode temp = head;
        ListNode dummy = new ListNode(0);
        dummy.next = head;
        while (temp != null)
        {
            count++;
            temp = temp.next;
        }
        ListNode prev = dummy, curr = dummy, next = dummy;

        while (count >= k)
        {
            curr = prev.next;
            next = curr.next;
            for (int i = 1; i < k; i++)
            {
                curr.next = next.next;
                next.next = prev.next;
                prev.next = next;
                next = curr.next;
            }
            prev = curr;
            count -= k;
        }
        return dummy.next;
    }
}