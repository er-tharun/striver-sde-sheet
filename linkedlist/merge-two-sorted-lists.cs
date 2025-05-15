//https://leetcode.com/problems/merge-two-sorted-lists/

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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode head = null;
        ListNode temp = null;
        while (list1 != null && list2 != null)
        {
            if (list1.val <= list2.val)
            {
                ListNode newNode = new ListNode(list1.val, null);
                if (head == null)
                {
                    head = temp = newNode;
                }
                else
                {
                    temp.next = newNode;
                    temp = temp.next;
                }
                list1 = list1.next;
            }
            else
            {
                ListNode newNode = new ListNode(list2.val, null);
                if (head == null)
                {
                    head = temp = newNode;
                }
                else
                {
                    temp.next = newNode;
                    temp = temp.next;
                }
                list2 = list2.next;
            }
        }
        while (list1 != null)
        {
            ListNode newNode = new ListNode(list1.val, null);
            if (head == null)
            {
                head = temp = newNode;
            }
            else
            {
                temp.next = newNode;
                temp = temp.next;
            }
            list1 = list1.next;
        }
        while (list2 != null)
        {
            ListNode newNode = new ListNode(list2.val, null);
            if (head == null)
            {
                head = temp = newNode;
            }
            else
            {
                temp.next = newNode;
                temp = temp.next;
            }
            list2 = list2.next;
        }
        return head;
    }
}