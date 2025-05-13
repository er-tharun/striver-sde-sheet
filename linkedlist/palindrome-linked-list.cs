//https://leetcode.com/problems/palindrome-linked-list/

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
    public bool IsPalindrome(ListNode head)
    {
        var list = new List<int>();
        while (head != null)
        {
            list.Add(head.val);
            head = head.next;
        }
        int mid = (list.Count - 1) / 2;
        int low = 0;
        int high = list.Count - 1;
        while (low <= mid)
        {
            if (list[low] == list[high])
            {
                low++;
                high--;
            }
            else
                return false;
        }
        return true;
    }
}