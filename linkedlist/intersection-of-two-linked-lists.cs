//https://leetcode.com/problems/intersection-of-two-linked-lists/

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution
{
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        var list = new List<ListNode>();

        while (headA != null)
        {
            list.Add(headA);
            headA = headA.next;
        }
        while (headB != null)
        {
            if (list.Contains(headB))
                return headB;
            headB = headB.next;
        }
        return null;
    }
}